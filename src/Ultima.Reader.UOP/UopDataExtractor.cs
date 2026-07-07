using System.IO;
using Ultima.Reader.Core.Binary;

namespace Ultima.Reader.UOP;

public sealed class UopDataExtractor
{
    private readonly string _file;

    public UopDataExtractor(string file)
    {
        _file = file;
    }

    public byte[] Extract(UopEntry entry)
    {
        using var stream = File.OpenRead(_file);
        using var reader = new BinaryReaderEx(stream);

        reader.Position = entry.DataOffset;
        var data = reader.ReadBytes(entry.CompressedSize);

        return Compression.Decompress(data, entry.DecompressedSize, entry.Compression);
    }

    public void ExtractToFile(UopEntry entry, string output)
    {
        File.WriteAllBytes(output, Extract(entry));
    }
}
