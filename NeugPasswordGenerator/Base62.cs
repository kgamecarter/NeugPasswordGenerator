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
        public static string ToBase62(byte[] original)
        {
            var arr = Array.ConvertAll(original, t => (int)t);

            var converted = BaseConvert(arr, 256, 62);
            var builder = new StringBuilder();
            foreach (var t in converted)
                builder.Append(CharacterSet[t]);
            return builder.ToString();
        }

        private static int[] BaseConvert(int[] source, int sourceBase, int targetBase)
        {
            var result = new List<int>();
            var leadingZeroCount = source.TakeWhile(x => x == 0).Count();
            int count;
            while ((count = source.Length) > 0)
            {
                var quotient = new List<int>();
                var remainder = 0;
                for (var i = 0; i != count; i++)
                {
                    var accumulator = source[i] + remainder * sourceBase;
                    var digit = accumulator / targetBase;
                    remainder = accumulator % targetBase;
                    if (quotient.Count > 0 || digit > 0)
                    {
                        quotient.Add(digit);
                    }
                }

                result.Insert(0, remainder);
                source = quotient.ToArray();
            }
            result.InsertRange(0, Enumerable.Repeat(0, leadingZeroCount));
            return result.ToArray();
        }
    }
}
