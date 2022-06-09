using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeugPasswordGenerator
{
    public static class Base62
    {
        private const string CharacterSet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Encode a byte array with Base62
        /// </summary>
        /// <param name="original">Byte array</param>
        /// <param name="inverted">Use inverted character set</param>
        /// <returns>Base62 string</returns>
        public static string ToBase62(ReadOnlySpan<byte> original)
        {
            var converted = BaseConvert(original, 256, 62);
            var builder = new StringBuilder();
            foreach (var t in converted)
                builder.Append(CharacterSet[t]);
            return builder.ToString();
        }

        private static byte[] BaseConvert(ReadOnlySpan<byte> source, int sourceBase, int targetBase)
        {
            var result = new List<int>();
            int count;
            while ((count = source.Length) > 0)
            {
                var quotient = new List<byte>();
                int remainder = 0;
                for (var i = 0; i != count; i++)
                {
                    int accumulator = source[i] + remainder * sourceBase;
                    byte digit = (byte)((accumulator - (accumulator % targetBase)) / targetBase);
                    remainder = accumulator % targetBase;
                    if (quotient.Count > 0 || digit != 0)
                    {
                        quotient.Add(digit);
                    }
                }

                result.Insert(0, remainder);
                source = quotient.ToArray();
            }

            var output = new byte[result.Count];
            for (int i = 0; i < result.Count; i++)
                output[i] = (byte)result[i];

            return output;
        }
    }
}
