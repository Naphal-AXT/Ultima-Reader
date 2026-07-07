using System.Collections.Generic;

namespace Ultima.Reader.UOP;

public sealed class UopBlock
{
    public long Offset { get; set; }
    public int FileCount { get; set; }
    public long NextBlock { get; set; }
    public List<UopEntry> Entries { get; } = new();
}
