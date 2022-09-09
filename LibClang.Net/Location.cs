namespace LibClang.Net;

public readonly record struct Location(Clang.CXSourceLocation Handle)
{
    public static implicit operator Clang.CXSourceLocation(Location location)
    {
        return location.Handle;
    }
    
    public static implicit operator Location(Clang.CXSourceLocation location)
    {
        return new Location(location);
    }
}
