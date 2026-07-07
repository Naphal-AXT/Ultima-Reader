using System.IO;

namespace Ultima.Reader.UOP;

public static class Compression
{
    public static byte[] Decompress(byte[] data, int expectedSize, short method)
    {
        // UOP compression implementation placeholder.
        // Method 0: uncompressed data.
        // Method 1: will be implemented with zlib decompression.
        if (method == 0)
            return data;

        return data;
    }
}
