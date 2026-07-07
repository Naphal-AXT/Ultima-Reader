namespace Ultima.Reader.Housing;

public sealed class HousingEntry
{
    public int Id { get; set; }
    public int TileId { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public int Flags { get; set; }
    public int ClilocId { get; set; }
}
