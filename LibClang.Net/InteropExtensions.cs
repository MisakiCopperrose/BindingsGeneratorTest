using System.Runtime.InteropServices;

namespace LibClang.Net;

public static class InteropExtensions
{
    public static string GetString(this Clang.CXString cxString)
    {
        var unmanagedString = Clang.clang_getCString(cxString);
        var managedString = Marshal.PtrToStringAnsi(unmanagedString._pointer);

        Clang.clang_disposeString(cxString);
        
        return managedString ?? string.Empty;
    }
}