using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace asyncawait
{
    class Program
    {
        static void Main(string[] args)
        {
            //TaskTest(); // Task를 await하지 않았기 때문에 바로 출력
            //TaskTestAwait();
            TaskTest3();
            Console.ReadKey();
        }

        static void TaskTest()
        {
            Task.Delay(5000);
            Console.WriteLine("Task Test Done");
        }

        static async void TaskTestAwait()
        {
            await Task.Delay(5000);
            Console.WriteLine("Task Test Done");
        }

        public static async void TaskTest3()
        {
            try
            {
                string filePath = @"C:\TEMP\왁왁.txt";
                Task<string> task = ReadFileAsync(filePath);

                Console.WriteLine("메인 함수 종료");

                string content = await task;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("작업 종료");
            }
        }

        private static async Task<string> ReadFileAsync(string filePath)
        {
            using(StreamReader sr = new StreamReader(filePath))
            {
                string content = await sr.ReadToEndAsync();
                Console.WriteLine("Read File Done");
                return content;
            }
        }
    }
}
