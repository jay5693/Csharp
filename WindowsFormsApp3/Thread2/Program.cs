using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace Thread2
{
    class Program
    {
        delegate void MyDelegate();
        delegate int MyDelegate2(int n);
        delegate int MyDelegate3(int n);

        static void Main(string[] args)
        {
            //Sample_BeginInvoke();
            //Sample_BeginInvoke2();
            Sample_CallBack();
        }

        static void Sample_BeginInvoke()
        {
            MyDelegate a = Func;
            a.BeginInvoke(null, null);
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("메인스레드는 이걸 세번 출력해주고 프로그램이 종료");
                Thread.Sleep(1000);
            }
        }

        //BeginInvoke로 생성된 스레드는 백그라운드스레드로 실행됨 <-> 포어그라운드 스레드
        //또한 스레드풀에서 실행되기 때문에 역시 True <-> 사용자 정의 스레드
        private static void Func()
        {
            Console.WriteLine(Thread.CurrentThread.IsBackground);
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1);
                Thread.Sleep(1000);
            }
        }

        static void Sample_BeginInvoke2()
        {
            MyDelegate2 a = Func2;
            int cnt = 10;
            Console.WriteLine("1부터 {0}까지 더하고 다 더하면 결과 출력", cnt);

            IAsyncResult ar = a.BeginInvoke(cnt, null, null);
            Console.WriteLine("더할때까지 기다리고 있겠습니다.");
            int result = a.EndInvoke(ar);
            Console.WriteLine("1부터 {0}까지의 합은 {1}이군요.", cnt, result);
        }

        private static int Func2(int n)
        {
            int sum = 0;
            for(int i=0; i<=n; i++)
            {
                sum += i;
                Thread.Sleep(100);
            }
            Console.WriteLine(sum);
            return sum;
        }

        static void Sample_CallBack()
        {
            MyDelegate3 a = Func3;
            int cnt = 10;
            Console.WriteLine("1부터 {0}까지 더하고 다 더하면 결과를 말해주세요", cnt);

            IAsyncResult ar = a.BeginInvoke(cnt, new AsyncCallback(myCallback), cnt);
            Console.WriteLine("더할때까지 기다리고 있겠습니다.");
            ar.AsyncWaitHandle.WaitOne();
            Console.WriteLine("다 더했다면 결과를 알려주세요");
            Thread.Sleep(1000);
        }

        private static void myCallback(IAsyncResult ar)
        {
            MyDelegate3 temp = ((AsyncResult)ar).AsyncDelegate as MyDelegate3;
            int result = temp.EndInvoke(ar);
            Console.WriteLine("1부터 {0}까지의 합은 {1}입니다.", ar.AsyncState, result);
        }

        private static int Func3(int n)
        {
            int sum = 0;
            for(int i=1; i<=n; i++)
            {
                sum += i;
                Thread.Sleep(100);
            }
            Console.WriteLine(sum);
            return sum;
        }
        ////////////
    }
}
