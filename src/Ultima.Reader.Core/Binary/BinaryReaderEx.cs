using System;
using System.IO;
using System.Text;

namespace Ultima.Reader.Core.Binary;

public sealed class BinaryReaderEx : BinaryReader
{
    public BinaryReaderEx(Stream stream) : base(stream)
    {
    }

    public long Position
    {
        get => BaseStream.Position;
        set => BaseStream.Position = value;
    }

    public byte[] ReadBytesAt(long offset, int count)
    {
        var old = Position;
        Position = offset;
        var data = ReadBytes(count);
        Position = old;
        return data;
    }

    public string ReadAscii(int length)
    {
        return Encoding.ASCII.GetString(ReadBytes(length)).TrimEnd('\0');
    }
}
