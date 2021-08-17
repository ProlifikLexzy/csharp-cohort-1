using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Text;

namespace Program
{
    public class Tester
    {
        public static void Main(string[] args)
        {
            UsingMemoryStream();
            Console.WriteLine("End of Main Method.");
            Console.ReadLine();
        }

        private static void UsingMemoryStream()
        {
            var memStream = new MemoryStream(100);

            byte[] javaBytes = Encoding.ASCII.GetBytes("Java");
            var csharpBytes = Encoding.ASCII.GetBytes("CSharp");
            var v = "Java vs rp";
            memStream.Write(javaBytes, 0, javaBytes.Length);
            memStream.Write(csharpBytes, 0, csharpBytes.Length);

            memStream.Seek(-6, SeekOrigin.Current);

            var vsBytes = Encoding.ASCII.GetBytes(" vs ");

            memStream.Write(vsBytes, 0, vsBytes.Length);

            var allBytes = memStream.GetBuffer();

            var message = Encoding.ASCII.GetString(allBytes);

            Console.WriteLine(message);
        }

        public static void WriteStream()
        {
            string path = @"c:\base-test\testfile.txt";

            
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (Stream stream = File.Create(path))
            {
                using (var streamWriter = new StreamWriter(stream))
                {
                    string message = "XOXOXO";
                    streamWriter.Write(message);
                }
            }
        }

        private static void ReadToStream()
        {
            string path = @"c:\base-test\testfile.txt";

            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                using (var streamReader = new StreamReader(stream))
                {
                    var message = streamReader.ReadToEnd();
                    Console.WriteLine(message);
                }
            }
        }

        private static void ReadFromFile()
        {
            string path = @"c:\base-test\testfile.txt";
            var ascii = new ASCIIEncoding();

            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                var bytes = new byte[1000];

                while (stream.Read(bytes, 0, bytes.Length) > 0)
                {
                }

                var message = ascii.GetString(bytes);
                Console.WriteLine(message);
            }
        }

        private static void WriteToFile()
        {
            string message = "Learning C#";
            var bytes = GetStringBytes(message);
            string directory = @"c:\base-test\";
            string path = @"testfile.txt";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string combinePath = directory + path;
            using (FileStream stream = new FileStream(combinePath, FileMode.Append))
            {
                try
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.WriteByte((byte)'!');
                    stream.Close();
                }
                catch (Exception ex)
                {

                }
                finally
                {

                }
            }
        }

        public static byte[] GetStringBytes(string message)
        {
            var bytes = Encoding.ASCII.GetBytes(message);
            //char[] letters = message.ToCharArray();
            //byte[] bytes = new byte[letters.Length];

            //for (int i = 0; i < letters.Length; i++)
            //{
            //    bytes[i] = (byte)letters[i];
            //}

            return bytes;
        }


        private static void RunMethod()
        {
            Thread.Sleep(5000);
        }
    }
}



