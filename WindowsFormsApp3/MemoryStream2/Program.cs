using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MemoryStream2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputImagePath = "94dc5a2f83cd5.jpg";
            string outputImagePath = "output.jpg";

            //1.파일에서 이미지 읽기
            byte[] imageData = File.ReadAllBytes(inputImagePath);

            //2.MemoryStream에 이미지 데이터를 쓰기
            using(MemoryStream memoryStream = new MemoryStream(imageData))
            {
                //3.MemoryStream 데이터를 다시 파일로 저장
                File.WriteAllBytes(outputImagePath, memoryStream.ToArray());
            }
            Console.WriteLine("이미지가 MemoryStream을 통해 저장되었습니다.");
            Console.ReadKey();
        }
    }
}
