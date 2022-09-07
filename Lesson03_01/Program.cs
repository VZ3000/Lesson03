using System;

namespace Lesson03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            byte a = 255;
            a++;
            Console.WriteLine(a);
            sbyte b = 126;
            b++;
            Console.WriteLine(b);
            b++;
            Console.Write(b);

            var c = 5;
            var d = 5.0;
            var e = 5.0m;
            

            double x = 1234.7;
            int a; 
            a = (int)x;

            Console.WriteLine(x);
            Console.WriteLine(a);
            

            int a = 12;
            double d = 765.12f;
            float f = 56.123F;
            Console.WriteLine("f ToString(f): " + Convert.ToString(f));
            Console.WriteLine("d ToInt32(d): " + Convert.ToInt32(d));
            Console.WriteLine("f ToUInt32: " + Convert.ToUInt32(f));
            Console.WriteLine("a ToDouble: " + Convert.ToDouble(a));
            */
            Console.WriteLine("Įveskite pirmąjį simbolį");
            char a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Įveskite antrąjį simbolį");
            char b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Įveskite trečiajį simbolį");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Atvirkštine tvarka suvesti simboliai");
            Console.WriteLine($"{c} {b} {a}");




        }
    }
}
