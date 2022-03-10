using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string again;
            Console.WriteLine("Program obliczający liczbę rozwiązań równania kwadratowego");
            do
            {
                Console.WriteLine("Podaj a");
                double zmiennaA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj b");
                double zmiennaB = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c");
                double zmiennaC = double.Parse(Console.ReadLine());
                int i = 0;

                double delta = zmiennaB * zmiennaB - 4 * zmiennaA * zmiennaC;
                if (delta == 0)
                {
                    i++;
                }
                i = (delta > 0) ? i += 2 : i;
                Console.WriteLine("Równanie {0}x^2+{1}x+{2} posiada {3} rozwiązań", zmiennaA, zmiennaB, zmiennaC, i);
                Console.WriteLine("Czy chcesz zakończyć program (t/n)");
                again = Console.ReadLine();
            } while (again != "t");

        }
    }
}
