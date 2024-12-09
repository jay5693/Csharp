using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Thread1
{
    class Program
    {
        static bool MyFlag = false;

        static void Main(string[] args)
        {
            //Sample1_UsingThread();
            //Sample_ThreadArguments();
            //Sample_ThreadArguments2();
            //Sample_BackGround();
            //Sample_ThreadBlock_1();
            //Sample_ThreadPolling();
            //Sample_ThreadAbort();
            Sample_Lock();
            Console.ReadKey();
        }
        

        #region 예시 1 - 스레드 사용하기 
        private static void Sample1_UsingThread()
        {
            Thread thread = new Thread(Func);
            thread.Start();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " by 메인스레드");
                Thread.Sleep(100);
            }
            Console.WriteLine("Stop - Main Thread");
        }

        private static void Func()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + " by 서브스레드");
                Thread.Sleep(100);
            }
        }
        #endregion -예시1

        #region  예시 2 - 스레드에 매개변수 전달
        private static void Sample_ThreadArguments()
        {
            Thread thread = new Thread(Func2);

            thread.Start(7);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " by 메인스레드");
                Thread.Sleep(100);
            }
            Console.WriteLine("Stop - Main Thread");
        }

        private static void Func2(object obj)
        {
            int num = (int)obj;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1 + " by 서브스레드");
                Thread.Sleep(100);
            }
        }


        #endregion-예시2
        
        #region 예시 3 - 스레드에 2개 이상의 매개변수 전달
        private static void Sample_ThreadArguments2()
        {
            Thread thread = new Thread(Func3);
            ThreadParam tp = new ThreadParam(2, 6);
            thread.Start(tp);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " by 메인스레드");
                Thread.Sleep(100);
            }
            Console.WriteLine("Stop - Main Thread");
        }

        private static void Func3(object obj)
        {
            ThreadParam threadParam = obj as ThreadParam;
            int num = threadParam.param1 + threadParam.param2;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + 1 + " by 서브스레드");
                Thread.Sleep(100);
            }
        }

        #endregion

        #region 예시 4 - 백그라운드 스레드
        private static void Sample_BackGround()
        {
            Thread thread = new Thread(Func);
            thread.IsBackground = true;
            thread.Start();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " by 메인스레드");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Stop - Main Thread");
        }


        #endregion

        #region 예시 5 - 스레드 기다리기-1(블락 시키기)

        private static void Sample_ThreadBlock_1()
        {
            Thread thread = new Thread(Func);
            thread.Start();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " by 메인스레드");
                Thread.Sleep(100);
            }
            thread.Join();
            Console.WriteLine("Stop - Main Thread");
        }

        #endregion

        #region 예시 6 - 폴링(Polling)
        /*
         * 폴링(Polling): 스레드에 플래그를 놓아 값이 준비된다면 플래그를 메인 프로그램에 전달해 주는 것. 메인 프로그램은 주기적으로 
         *                값이 준비 되었는지 물어보는 작업이 필요하다. 
         * 가장 보편적인 스레드 사용법
         * 1. 서브 스레드 생성
         * 2. 서브 스레드에서 돌아갈 메소드 무한 루프화시키고 해당 조건이 만족되었는지 0.1초 간격으로 체크
         * 3. 서브스레드 flag가 true가 되면 "폴링 성공" 출력
         * 4. 메인스레드는 서브스레드를 시작해주고 3까지 출력해준 후 flag를 true로 설정
         * 5. 서브스레드는 종료 조건이 없으므로 메인스레드가 끝나도 프로그램은 종료되지 않고 폴링성공을 계속 출력
         */

        private static void Sample_ThreadPolling()
        {
            Thread thread = new Thread(FuncPolling);
            thread.Start();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " by 메인스레드");
                Thread.Sleep(100);
            }
            MyFlag = true;
            Console.WriteLine("메인스레드 종료");
        }

        private static void FuncPolling()
        {
            while (true)
            {
                if (MyFlag)
                    Console.WriteLine("폴링 성공");
                Thread.Sleep(100);
            }
        }

        #endregion

        #region 예시 7 -스레드 강제종료(abort)

        private static void Sample_ThreadAbort()
        {
            Thread thread = new Thread(FuncPolling);
            thread.Start();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + " by 메인스레드");
                Thread.Sleep(100);
                thread.Abort();
                MyFlag = true;
                Console.WriteLine("메인스레드 종료");
            }
        }

        #endregion

        #region  예시 8 : Lock 
        /*
            스레드 두개를 생성해주고
            두개의 스레드는 하나의 멤버변수 num에 접근해 숫자를 하나 증가해주고 0.005초 후 출력을 해주는 예제
            --> 공유자원에 대한 스레드 동기화가 되지 않아서 생긴 오류
        */
        private static void Sample_Lock()
        {
            Data myData = new Data();
            Thread myThread1 = new Thread(MyFunc);
            Thread myThread2 = new Thread(MyFunc);

            myThread1.Start(myData);
            myThread2.Start(myData);

            myThread1.Join();
            myThread2.Join();
        }

        private static void MyFunc(object obj)
        {
            Data targetData = obj as Data;

            for (int i = 0; i < 10; i++)
            {
                targetData.Increase();
                Console.WriteLine(targetData.num);
            }
        }

        #endregion
    }

    class Data
    {
        /*
       public int num = 0;

       public void Increase()
       {
           this.num++;
           Thread.Sleep(5);
       }
       */
        //스레드에 안전하다
        private object obj = new object();
        public int num = 0;

        public void Increase()
        {
            lock (obj)
            {
                this.num++;
                Thread.Sleep(5);
            }
        }
    }
}
