using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeugPasswordGenerator
{
    public static class Hex
    {
        public static string ToHex(byte[] data)
        {
            return data
                .Select(b => b.ToString("X2"))
                .Aggregate(new StringBuilder(), (sb, v) => sb.Append(v))
                .ToString();
        }
    }
}
