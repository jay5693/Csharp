using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.txt";
            string content = "Hello, FileStream";

            //1. FileStream 이용해서 파일쓰기
            using(FileStream fileStream = new FileStream(filePath,FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(content);
                fileStream.Write(buffer, 0, buffer.Length);
            }
            //2.FileStream을 이용하여 파일읽기
            using(FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);

                string result = Encoding.UTF8.GetString(buffer);
                Console.WriteLine($"FileStream 내용: {result}");
                Console.ReadKey();
            }
        }
    }
}
