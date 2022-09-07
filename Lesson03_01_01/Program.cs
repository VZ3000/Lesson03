using System;

namespace Lesson03_01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įveskite grupės narių skaičių");
            string membersCount = Console.ReadLine();
            int membersCount;

            bool isConversionSuccessful = int.TryParse(membersCountInput, out membersCount);
            if (isConversionSuccessful == false)
            {
                Console.WriteLine("Nepavyko konversija, programa užbaigiama");
                Environment.Exit(0);

                else
                    if(membersCount) == 1)
            }
        }
    }
}
