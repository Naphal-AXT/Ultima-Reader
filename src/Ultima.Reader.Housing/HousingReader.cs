using System.Collections.Generic;
using System.IO;
using Ultima.Reader.Core.Binary;

namespace Ultima.Reader.Housing;

public sealed class HousingReader
{
    public IReadOnlyList<HousingEntry> Read(string file)
    {
        var result = new List<HousingEntry>();

        using var stream = File.OpenRead(file);
        using var reader = new BinaryReaderEx(stream);

        // Initial parser scaffold.
        // The exact housing.bin layout will be filled after binary analysis.

        return result;
    }
}
