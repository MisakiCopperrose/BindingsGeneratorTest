using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LibClang.Net;

namespace BindingsGeneratorTest;

public static class Traverser
{
    public static void TraversChildren(this List<Cursor> children)
    {
        if (!children.Any())
        {
            return;
        }
        
        foreach (var cursor in children)
        {
            cursor.TraversCursor();
            cursor.Children.TraversChildren();
        }
    }
    
    public static unsafe void TraversCursor(this Cursor cursor)
    {
        var cursorChildrenHandle = GCHandle.Alloc(new List<Cursor>());
        var cursorHandle = GCHandle.Alloc(cursor);

        var pVisitor = (delegate* unmanaged[Cdecl]<Clang.CXCursor, Clang.CXCursor, nint*, Clang.CXChildVisitResult>)&Visitor;

        var clientData = stackalloc nint[2] {
            GCHandle.ToIntPtr(cursorChildrenHandle),
            GCHandle.ToIntPtr(cursorHandle)
        };

        Clang.clang_visitChildren(cursor, (nint)pVisitor, clientData);

        cursor.Children.AddRange((List<Cursor>)cursorChildrenHandle.Target!);
        
        cursorChildrenHandle.Free();
        cursorHandle.Free();
        
        cursor.Children.TraversChildren();
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static unsafe Clang.CXChildVisitResult Visitor(Clang.CXCursor cursor, Clang.CXCursor parent, nint* clientData)
    {
        var childCursor = (Cursor)cursor;
        var parentCursor = (Cursor)parent;
        
        var cursorChildren = (List<Cursor>)GCHandle.FromIntPtr(clientData[0]).Target!;
        var traversedCursor = (Cursor)GCHandle.FromIntPtr(clientData[1]).Target!;

        if (Clang.clang_Location_isFromMainFile(childCursor.Location) == 0)
        {
            return Clang.CXChildVisitResult.CXChildVisit_Continue;
        }
        
        cursorChildren.Add(childCursor);

        return Clang.CXChildVisitResult.CXChildVisit_Continue;
    }
}