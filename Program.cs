using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApplication48
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lines = File.ReadAllLines(@"C:\Users\Dmitry\Desktop\VS13-LOCAL.csv");

            //foreach (var line in lines)
            //{
            //    var values = line.Split(';');

            //    if (values[1] != values[3])
            //        Console.WriteLine(values[0]);
            //}

            long[] badIndex = new long[]
                                  {
                                      260000000,
                                      1060000000,
                                      1830000000,
                                      2620000000,
                                      2990000000
                                  };

            const string file = @"D:\DL\VS2013_RC_ULT_ENU.iso";

            foreach (var l in badIndex)
            {
                var bytes = File.ReadAllBytes(@"D:\DL\" + l);

                using (var fileStream = new FileStream(file, FileMode.Open, FileAccess.Write))
                {
                    fileStream.Seek(l, SeekOrigin.Begin);
                    fileStream.Write(bytes, 0, bytes.Length);
                }
            }

            //const string file = @"C:\Users\Administrator\Downloads\VS2013_RC_ULT_ENU.iso";

            //foreach (var l in badIndex)
            //{
            //    var buffer = new byte[10000000];

            //    using (var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
            //    {
            //        fileStream.Seek(l, SeekOrigin.Begin);
            //        fileStream.Read(buffer, 0, buffer.Length);
            //    }

            //    File.WriteAllBytes(@"C:\Users\Administrator\Downloads\" + l, buffer);
            //}

            return;
            //const string file = @"C:\Users\Administrator\Downloads\VS2013_RC_ULT_ENU.iso";

            //var fileInfo = new FileInfo(file);

            //long from = 0;

            //var stringBuilder = new StringBuilder();

            //while (true)
            //{
            //    if (from >= fileInfo.Length)
            //        break;

            //    long to = from + 10000000;

            //    if (to > fileInfo.Length)
            //        to = fileInfo.Length;

            //    var buffer = new byte[to - from];

            //    using(var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
            //    {
            //        fileStream.Seek(from, SeekOrigin.Begin);
            //        fileStream.Read(buffer, 0, buffer.Length);
            //    }

            //    var hash = SHA1.Create().ComputeHash(buffer);
            //    stringBuilder.AppendLine(from + "=" + BitConverter.ToString(hash).Replace("-", ""));

            //    from += 10000000;
            //}

            //var s = stringBuilder.ToString();

            //File.WriteAllText(@"C:\Users\Administrator\Downloads\res.txt", s);
        }
    }
}
