using System.Text;

namespace Ultima.Reader.UOP;

public static class UopHashResolver
{
    public static long Hash(string name)
    {
        ulong hash = 0;

        foreach (char c in name.ToLowerInvariant())
        {
            hash = (hash * 0x1003F) + c;
        }

        return unchecked((long)hash);
    }
}
