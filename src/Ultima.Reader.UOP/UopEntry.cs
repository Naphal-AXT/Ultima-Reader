namespace Ultima.Reader.UOP;

public sealed class UopEntry
{
    public long DataOffset { get; set; }
    public int CompressedSize { get; set; }
    public int DecompressedSize { get; set; }
    public long FileHash { get; set; }
    public short Compression { get; set; }
    public string? Name { get; set; }
}
