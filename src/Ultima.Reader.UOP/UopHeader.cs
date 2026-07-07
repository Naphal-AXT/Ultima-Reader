namespace Ultima.Reader.UOP;

public struct UopHeader
{
    public uint Magic;
    public long Version;
    public long Signature;
    public long FirstBlock;
    public int BlockCapacity;
    public int Format;
}
