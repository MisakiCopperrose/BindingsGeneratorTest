using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.Json;
using InteropExtensions.C;
using LibClang.Net;
using LibGit2Sharp;

namespace BindingsGeneratorTest;

public static class TestClang
{
    private static Cursor _cursor;
    
    public static unsafe void Run()
    {
        NativeLibrary.SetDllImportResolver(Assembly.GetAssembly(typeof(Clang))!, Resolver);

        var repositories = new[]
        {
            "bx",
            "bimg",
            "bgfx"
        };

        foreach (var repository in repositories)
        {
            GetGitRepositories(repository);
        }

        const string filepath = "bgfx/include/bgfx/c99/bgfx.h";
        var commandLineArgs = new[]
        {
            // "-H",
            // "-v",
            // "-fsyntax-only",
            "--language=c",
            "-I/Applications/Xcode.app/Contents/Developer/Platforms/MacOSX.platform/Developer/SDKs/MacOSX.sdk/usr/include",
            "-Ibx/include/compat/osx",
            "-Ibgfx/3rdparty",
            "-Ibimg/include",
            "-Ibx/include",
            "-Ibgfx/3rdparty/khronos",
            "-Ibgfx/include",
            "--target=aarch64-apple-darwin",
            "-MMD",
            "-MP",
            "-MP",
            "-Wall",
            "-Wextra",
            "-ffast-math",
            "-g",
            "-m32",
            "-Wno-error=unused-command-line-argument",
            "-Wno-unused-command-line-argument",
            "-Wfatal-errors",
            "-Wunused-value",
            "-Wundef",
            "--std=gnu99"
        };

        var firstCommand = CStrings.CStringArrayP(commandLineArgs);
        var index = Clang.clang_createIndex(0, 1);

        const Clang.CXTranslationUnit_Flags options = Clang.CXTranslationUnit_Flags.CXTranslationUnit_None;

        Clang.CXTranslationUnit translationUnit;

        var errorCode = Clang.clang_parseTranslationUnit2(
            index,
            filepath,
            firstCommand,
            commandLineArgs.Length,
            null,
            0,
            (uint)options,
            &translationUnit
        );

        if (errorCode == Clang.CXErrorCode.CXError_Failure)
        {
            throw new Exception();
        }

        _cursor = Clang.clang_getTranslationUnitCursor(translationUnit);

        _cursor.TraversCursor();

        var jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        
        var jsonString = JsonSerializer.Serialize(_cursor, jsonOptions);
        
        File.WriteAllText("AST.json", jsonString);

        var test = 1;
        
        Clang.clang_disposeTranslationUnit(translationUnit);
        Clang.clang_disposeIndex(index);
    }

    private static void GetGitRepositories(string name)
    {
        var folder = $"{name}/";

        if (!Directory.Exists(folder))
        {
            Console.WriteLine($"Cloning {name}...");
            Repository.Clone($"https://github.com/bkaradzic/{name}.git", folder);
        }
        else
        {
            var standardSignature = new Signature(new Identity("winand", "winand1990@live.nl"), DateTimeOffset.Now);
            Console.WriteLine($"Pulling {name}...");
            var repository = new Repository(folder);
            Commands.Pull(repository, standardSignature, new PullOptions());
        }
    }

    private static IntPtr Resolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
    {
        return CLibrary.Load("/Library/Developer/CommandLineTools/usr/lib/libclang.dylib");
    }
}