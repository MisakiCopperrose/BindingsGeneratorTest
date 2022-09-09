using System.Text.Json.Serialization;

namespace LibClang.Net;

public readonly record struct Cursor([property: JsonIgnore] Clang.CXCursor Handle)
{
    [JsonInclude] public string Spelling => Clang.clang_getCursorSpelling(Handle).GetString();

    [JsonInclude] public Clang.CXCursorKind Kind => Clang.clang_getCursorKind(Handle);

    [JsonIgnore] public string KindSpelling => Clang.clang_getCursorKindSpelling(Kind).GetString();

    [JsonIgnore] public Cursor SemanticParent => Clang.clang_getCursorSemanticParent(Handle);

    [JsonIgnore] public Cursor LexicalParent => Clang.clang_getCursorLexicalParent(Handle);

    [JsonIgnore] public Location Location => Clang.clang_getCursorLocation(Handle);
    
    [JsonInclude] public List<Cursor> Children { get; } = new();

    [JsonIgnore] public static Cursor Null => Clang.clang_getNullCursor();

    public bool Equals(Cursor other)
    {
        return Clang.clang_equalCursors(Handle, other) != 0;
    }

    public override int GetHashCode()
    {
        return (int)Clang.clang_hashCursor(Handle);
    }

    public static implicit operator Clang.CXCursor(Cursor cursor)
    {
        return cursor.Handle;
    }

    public static implicit operator Cursor(Clang.CXCursor cursor)
    {
        return new Cursor(cursor);
    }
}