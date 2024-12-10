using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFilePath = "source.bin";
            string destinationFilePath = "destination.bin";

            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine($"{sourceFilePath} 파일이 존재하지 않습니다. 새로 생성합니다.");

                // 파일 생성 및 초기 데이터 작성
                using (FileStream fs = new FileStream(sourceFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] initialData = Encoding.UTF8.GetBytes("이것은 테스트 파일입니다.");
                    fs.Write(initialData, 0, initialData.Length);
                }
                Console.WriteLine($"{sourceFilePath} 파일이 생성되었습니다.");
            }

            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while((bytesRead=sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
            Console.WriteLine("파일이 복사되었습니다.");
            Console.ReadKey();
        }
    }
}
