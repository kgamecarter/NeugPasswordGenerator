﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeugPasswordGenerator
{
    public static class Hex
    {
        public static string ToHex(ReadOnlySpan<byte> data)
        {
            var sb = new StringBuilder(data.Length * 2);
            foreach (var b in data)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}
