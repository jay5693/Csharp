using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoryStream1 
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello, MemoryStream";
            byte[] buffer = Encoding.UTF8.GetBytes(data);
            
            //1.MemoryStream에 데이터 쓰기
            using(MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Write(buffer, 0, buffer.Length);
                //2.스트림 포인터를 처음으로 이동
                memoryStream.Seek(0, SeekOrigin.Begin);
                
                //3.MemoryStream에서 데이터 읽기
                byte[] readbuffer = new byte[memoryStream.Length];
                memoryStream.Read(readbuffer, 0, readbuffer.Length);

                //4.바이트 배열을 문자열로 변환
                string result = Encoding.UTF8.GetString(readbuffer);
                Console.WriteLine($"MemoryStream내용:{result}");
                Console.ReadKey();
            }
        }
    }
}
