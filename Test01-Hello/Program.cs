using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test01_Hello
{
    static class myLib
    {
        public static string GetToken(string str, int n, char ch)  // (str):" 1 2 3" "1,2,3", (n)번째, (ch)',' ' ' 
        {
            return str.Split(ch)[n];
        }
    }
    class Point
    {
        int x, y;
        public Point(int x = 0, int y = 0)
        { 
            this.x = x;
            this.y = y;
        }
        public double Dist(Point p1)
        {
            int d1 = p1.x - x;
            int d2 = p1.y - y;
            return Sqrt(d1 * d1 + d2 * d2);
        }
        public static double operator - (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Sqrt(d1 * d1 + d2 * d2);
        }
        public static double operator * (Point p1, Point p2)
        {
            int d1 = p1.x - p2.x;
            int d2 = p1.y - p2.y;
            return Abs(d1 * d2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program pgm = new Program();
            //int  i = pgm.function();
            Test01 Sub = new Test01();
            Sub.MainFunc();
        }
        //int function() 
        //{
        //    while(true)
        //    {

        //    }
        //    return 1; 
        //}

    }
    class Test01  // main class
    {
        public void Func1()
        {
            Point p  = new Point(10, 20);
            Point p1 = new Point(30, 40);
            WriteLine($"두 점 P1(10,20)과 P2(30,40)의 거리는 [{p-p1}] 사각형의 면적은[{p*p1}]입니다.");
            string s1 = "Good";
            string s2 = "morning";
            string s3 = s1 + s2;
        }
        public void MainFunc()
        {
            //Func1(); return;  // Point Test
            int i = 10,j = 20;
            double d = 1.5, e = 3.1;
            object o = i + 1;
            var v = i * 10;
            Console.WriteLine("Hello World({0},{1},{4},{5})\nMain Function({2},{3})",i,j,d,e,o,v);  // printf 함수와 동일
            o = d + 0.5;
            v = j * 10;
            Console.WriteLine("Hello World({0},{1})\nMain Function({2},{3},{4})",i,j,d,e,o);  // printf 함수와 동일
            Console.WriteLine("i:{0}, j:{1}, d:{2}, e:{3}, o:{4})",i,j,d,e,o);  // printf 함수와 동일
            Console.WriteLine($"i:{sizeof(int)}, d:{sizeof(double)})");  // printf 함수와 동일

            int[] arr = new int[i];
            for (int i1 = 0; i1 < 10; i1++) arr[i1] = i1;
            
            //myLib my = new myLib();
            //while(true)
            {
                try
                {
                    Console.WriteLine("두개의 정수를 입력하세요 ");
                    string str = Console.ReadLine();   //  str   = "10 20"
                    //i = int.Parse(str.Split(' ')[0]);
                    i = int.Parse(myLib.GetToken(str, 0, ' '));
                    j = int.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"입력한 정수는 ({i},{j})입니다.");  // printf 함수와 동일

                    Console.WriteLine("두개의 실수를 입력하세요 ");
                    str = Console.ReadLine();   //  str   = "10.5 20.1"
                    d = double.Parse(str.Split(' ')[0]);
                    e = double.Parse(str.Split(' ')[1]);
                    Console.WriteLine($"입력한 실수는 ({d},{e})입니다.");  // printf 함수와 동일
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.Message);
                }
            }
        }
    }
}
