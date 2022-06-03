using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThread_063
{
    class Program
    {
       

        public void TampilThread1()
        {
            int a = 6;
            for (int i=0; i < a; i++)
            {
                Console.WriteLine("antrian ke , {0}",i);
                Thread.Sleep(100);
            }
        }
        public void TampilThread2()
        {
            int a = 11;
            for (int i = 6; i < a; i++)
            {
                Console.WriteLine("antrian ke , {0}",i);
                Thread.Sleep(100);
            }
        }
        public void TampilThread3()
        {
            int a = 16;
            for (int i = 11; i < a; i++)
            {
                Console.WriteLine("antrian ke , {0}",i);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Program th = new Program();

            Console.WriteLine("hitung 1-15");
            
            Console.WriteLine("Hitung 1-5");
            th.TampilThread1();
            Console.WriteLine("Hitung 6-10");
            th.TampilThread2();
            Console.WriteLine("Hitung 11-15");
            th.TampilThread3();

        }


    }
}
