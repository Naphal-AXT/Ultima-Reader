using System.IO;
using Ultima.Reader.Core.Binary;

namespace Ultima.Reader.UOP;

public sealed class UopReader
{
    private readonly string _file;

    public UopReader(string file)
    {
        _file = file;
    }

    public UopHeader ReadHeader()
    {
        using var stream = File.OpenRead(_file);
        using var reader = new BinaryReaderEx(stream);

        return new UopHeader
        {
            Magic = reader.ReadUInt32(),
            Version = reader.ReadInt64(),
            Signature = reader.ReadInt64(),
            FirstBlock = reader.ReadInt64(),
            BlockCapacity = reader.ReadInt32(),
            Format = reader.ReadInt32()
        };
    }
}
