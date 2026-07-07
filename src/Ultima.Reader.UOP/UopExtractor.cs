using System;
using System.IO;
using Ultima.Reader.Core.Binary;

namespace Ultima.Reader.UOP;

public sealed class UopExtractor
{
    private readonly string _file;

    public UopExtractor(string file)
    {
        _file = file;
    }

    public UopEntry? FindByHash(long hash)
    {
        using var stream = File.OpenRead(_file);
        using var reader = new BinaryReaderEx(stream);

        var header = new UopReader(_file).ReadHeader();
        long blockOffset = header.FirstBlock;
        var blockReader = new UopBlockReader();

        while (blockOffset != 0)
        {
            var block = blockReader.Read(reader, blockOffset);

            foreach (var entry in block.Entries)
            {
                if (entry.FileHash == hash)
                    return entry;
            }

            blockOffset = block.NextBlock;
        }

        return null;
    }

    public UopEntry? Find(string filename)
    {
        return FindByHash(UopHashResolver.Hash(filename));
    }
}
