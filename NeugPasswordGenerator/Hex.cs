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
                .Aggregate(new StringBuilder(data.Length * 2), (sb, v) => sb.Append(v.ToString("X2")))
                .ToString();
        }
    }
}
