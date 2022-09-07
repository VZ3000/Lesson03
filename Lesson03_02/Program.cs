using System;

namespace Lesson03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite atstumą metrais");
            string metrai = Console.ReadLine();

            Console.WriteLine("Įveskite laiką sekundėmis");
            string sekundės = Console.ReadLine();

            double kilometrai = Convert.ToDouble(metrai)/1000;
            double greitis = kilometrai / Convert.ToInt32(sekundės)*3600;

            Console.WriteLine($"Gautas greitis yra {greitis} km/h");


        }
    }
}
