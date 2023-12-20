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
using System.Runtime.ExceptionServices;

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
        delegate void cbTest();
        void f1() { WriteLine("delegate Test 01"); }
        void f2() { WriteLine("delegate Test 02"); }
        void f3() { WriteLine("delegate Test 03"); }
        void Func_DelegateTest()
        {
            cbTest cb1;
            cb1 = new cbTest(f1); cb1();
            cb1 = new cbTest(f2); cb1();
            cb1 = new cbTest(f3); cb1();
        }
        public void Func_PointTest()
        {
            Point p  = new Point(10, 20);
            Point p1 = new Point(30, 40);
            WriteLine($"두 점 P1(10,20)과 P2(30,40)의 거리는 [{p-p1}] 사각형의 면적은[{p*p1}]입니다.");
            string s1 = "Good";
            string s2 = "morning";
            string s3 = s1 + s2;
        }
        public void Func_ReadWrite()
        {
            int i = 10, j = 20;
            double d = 1.5, e = 3.1;
            object o = i + 1;
            var v = i * 10;
            Console.WriteLine("Hello World({0},{1},{4},{5})\nMain Function({2},{3})", i, j, d, e, o, v);  // printf 함수와 동일
            o = d + 0.5;
            v = j * 10;
            Console.WriteLine("Hello World({0},{1})\nMain Function({2},{3},{4})", i, j, d, e, o);  // printf 함수와 동일
            Console.WriteLine("i:{0}, j:{1}, d:{2}, e:{3}, o:{4})", i, j, d, e, o);  // printf 함수와 동일
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
        int ArrSum1(int[] arr)  // int 배열요소의 합
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }
        T ArrSum<T>(T[] arr)  // int 배열요소의 합
        {
            T sum = (dynamic)0;
            foreach(T a in arr)
                sum += (dynamic)a;
            return sum;
        }
        void PrintArr<T>(T[] arr)
        {
            int i = 0;
            foreach (T a in arr)
            {
                Write($"[{i++}]{a}  ");
            }
        }
        void InitArr(out int[] arr, int n)
        {
            arr = new int[n];
            for(int i = 0;i<10;i++) arr[i] = i;
        }
        void CallArr(int[] arr)
        {
            arr[2] = 100;
            arr[4] = 200;
            for (int i = 0; i < 10; i++) 
                Write($"arr[{i}]:{arr[i]}  "); 
            WriteLine("");
        }
        public void Func_ArrayTest()
        {
            string s1 = "Good ";
            string s2 = "Morning";

            int[] arr;// = new int[10];
            int[] arr1 = { 0,1,2,3,4 }; //
            double[] drr = { 0.1,1.1,2.1,3.1,4.1 }; //
            Point[] parr = new Point[10];
            int[,] brr = { { 10, 11, 12, 13, 14 }, { 20, 21, 22, 23, 24 }};
            int[][] crr =
            {
                new int[] { 10,11,12,13,14, 0, 0,0,0,0 },
                new int[] { 20,21,22,23,24,25,26,0,0,0 }
            };
            InitArr(out arr, 10); for (int i = 0; i < 10; i++) Write($"arr[{i}]:{arr[i]}  "); WriteLine("");
            crr[0].CopyTo(arr,0); for (int i = 0; i < 10; i++) Write($"arr[{i}]:{arr[i]}  "); WriteLine("");
            arr.CopyTo(crr[0],0); for (int i = 0; i < 10; i++) Write($"arr[{i}]:{arr[i]}  "); WriteLine("");
            CallArr(arr);         for (int i = 0; i < 10; i++) Write($"arr[{i}]:{arr[i]}  "); WriteLine("");
            Array.Copy(crr[0], arr, 5);            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Write($"brr[{i},{j}]:{brr[i,j]}  ");
                }
                WriteLine("");
            }

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < crr[i].Length; j++)
                {
                    Write($"crr[{i}][{j}]:{crr[i][j]}  ");
                }
                WriteLine("");
            }

            WriteLine($"Sum of [arr] : {ArrSum(arr)}");
            WriteLine($"Sum of [drr] : {ArrSum(drr)}");
            //int[] arr2 = arr + arr1;
            arr.Append<int>(1);
            WriteLine(s1 + s2);
            WriteLine($"Length of [arr] : {arr.Length}");
        }
        public void MainFunc()  //  주 진입점(실행 함수)
        {
            //Func_PointTest(); return;  // Point Test
            //Func_ReadWrite(); return;
            //Func_ArrayTest(); return;
            Func_DelegateTest();
        }
    }
}
