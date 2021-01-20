using System;

namespace HW190121
{
    class Program
    {
        static void Main(string[] args)
        {


            double a = 16.80;
            double b = 12.40;
            double mul = Math.Sqrt(a * b);
            Console.WriteLine(mul);

            double x1 = -6.20, y1 = 5.20;
            double x2 = 2.10, y2 = 9.80;
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(result);



            int N;
            N = 10985;
            int Result = (N % (3600 * 60)) / 60;
            Console.WriteLine(Result);


            double A = 1.40;
            double B = -5.50;
            double C = 0.60;
            double resultAC = Math.Abs(C - A);
            double resultBC = Math.Abs(B - C);
            double sum = (resultAC + resultBC);
            Console.WriteLine(resultAC);
            Console.WriteLine(resultBC);
            Console.WriteLine(sum);

            int number = 41;
            int num1 = number / 10;
            int num2 = number % 10;
            Console.WriteLine(num2 * 10 + num1);

            int k = 202;
            int s = k % 7;
            Console.WriteLine(s);
            Console.ReadLine();


        }
    }
}
