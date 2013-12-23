using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;

namespace SantaDecryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = Decompress(new byte[82]
              {
                (byte) 31,
                (byte) 139,
                (byte) 8,
                (byte) 8,
                (byte) 16,
                (byte) 171,
                (byte) 164,
                (byte) 82,
                (byte) 2,
                byte.MaxValue,
                (byte) 108,
                (byte) 111,
                (byte) 99,
                (byte) 97,
                (byte) 116,
                (byte) 105,
                (byte) 111,
                (byte) 110,
                (byte) 0,
                (byte) 11,
                (byte) 78,
                (byte) 204,
                (byte) 43,
                (byte) 73,
                (byte) 44,
                (byte) 86,
                (byte) 240,
                (byte) 201,
                (byte) 79,
                (byte) 78,
                (byte) 44,
                (byte) 201,
                (byte) 204,
                (byte) 207,
                (byte) 179,
                (byte) 82,
                (byte) 48,
                (byte) 54,
                (byte) 209,
                (byte) 51,
                (byte) 48,
                (byte) 50,
                (byte) 180,
                (byte) 244,
                (byte) 211,
                (byte) 81,
                (byte) 48,
                (byte) 52,
                (byte) 180,
                (byte) 208,
                (byte) 51,
                (byte) 177,
                (byte) 48,
                (byte) 52,
                (byte) 9,
                (byte) 87,
                (byte) 112,
                (byte) 203,
                (byte) 73,
                (byte) 76,
                (byte) 175,
                (byte) 118,
                (byte) 42,
                (byte) 45,
                (byte) 46,
                (byte) 73,
                (byte) 77,
                (byte) 137,
                (byte) 15,
                (byte) 6,
                (byte) 105,
                (byte) 168,
                (byte) 5,
                (byte) 0,
                (byte) 69,
                (byte) 105,
                (byte) 164,
                (byte) 22,
                (byte) 55,
                (byte) 0,
                (byte) 0,
                (byte) 0
              });
            Console.Write(Encoding.UTF8.GetString(bytes, 0, bytes.Length));
            Console.ReadLine();
        }

        private static byte[] Decompress(byte[] data)
        {
            using (GZipStream gzipStream = new GZipStream((Stream)new MemoryStream(data), CompressionMode.Decompress))
            {
                byte[] buffer = new byte[4096];
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    int count;
                    do
                    {
                        count = gzipStream.Read(buffer, 0, 4096);
                        if (count > 0)
                            memoryStream.Write(buffer, 0, count);
                    }
                    while (count > 0);
                    return memoryStream.ToArray();
                }
            }
        }
    }
}
