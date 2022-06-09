using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeugPasswordGenerator
{
    public class Ascii85
    {
        private const int _asciiOffset = 33;
        private byte[] _encodedBlock = new byte[5];
        private byte[] _decodedBlock = new byte[4];
        private uint _tuple = 0;

        private uint[] pow85 = { 85 * 85 * 85 * 85, 85 * 85 * 85, 85 * 85, 85, 1 };
        
        /// <summary>
        /// Encodes binary data into a plaintext ASCII85 format string
        /// </summary>
        /// <param name="ba">binary data to encode</param>
        /// <returns>ASCII85 encoded string</returns>
        public string Encode(ReadOnlySpan<byte> ba)
        {
            StringBuilder sb = new StringBuilder((int)(ba.Length * (_encodedBlock.Length / _decodedBlock.Length)));
            
            int count = 0;
            _tuple = 0;
            foreach (byte b in ba)
            {
                if (count >= _decodedBlock.Length - 1)
                {
                    _tuple |= b;
                    if (_tuple == 0)
                    {
                        sb.Append('z');
                    }
                    else
                    {
                        EncodeBlock(sb);
                    }
                    _tuple = 0;
                    count = 0;
                }
                else
                {
                    _tuple |= (uint)(b << (24 - (count * 8)));
                    count++;
                }
            }

            // if we have some bytes left over at the end..
            if (count > 0)
            {
                EncodeBlock(count + 1, sb);
            }
            return sb.ToString();
        }

        private void EncodeBlock(StringBuilder sb)
        {
            EncodeBlock(_encodedBlock.Length, sb);
        }

        private void EncodeBlock(int count, StringBuilder sb)
        {
            for (int i = _encodedBlock.Length - 1; i >= 0; i--)
            {
                _encodedBlock[i] = (byte)((_tuple % 85) + _asciiOffset);
                _tuple /= 85;
            }

            for (int i = 0; i < count; i++)
            {
                char c = (char)_encodedBlock[i];
                sb.Append(c);
            }

        }
    }
}
