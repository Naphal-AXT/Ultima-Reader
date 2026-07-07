using Ultima.Reader.Core.Binary;

namespace Ultima.Reader.UOP;

public sealed class UopBlockReader
{
    public UopBlock Read(BinaryReaderEx reader, long offset)
    {
        reader.Position = offset;

        var block = new UopBlock
        {
            Offset = offset,
            FileCount = reader.ReadInt32()
        };

        for (int i = 0; i < 0x100; i++)
        {
            if (i >= block.FileCount)
                break;

            block.Entries.Add(new UopEntry
            {
                DataOffset = reader.ReadInt64(),
                CompressedSize = reader.ReadInt32(),
                DecompressedSize = reader.ReadInt32(),
                FileHash = reader.ReadInt64(),
                Compression = reader.ReadInt16()
            });
        }

        block.NextBlock = reader.ReadInt64();
        return block;
    }
}
