using System;

namespace Lesson03_01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite egzamino pažymį");
            int mark;

            //string theInput = Console.ReadLine();

            bool checkMark = int.TryParse(Console.ReadLine(), out mark);
            
            
            
            
            
            
            if (convertNumber == false)
            {
                Console.WriteLine("Neįvestas skaičius");
                Environment.Exit(0);
            }
            else if (mark < 0 and > 4)
                    {
                Console.WriteLine("Nepatenkinamai");
            }

            else if (mark == 5)
            { Console.WriteLine("Silpnai");
            }
            else if (mark == 6) 
            Console.ReadLine();
        }
    }
}
