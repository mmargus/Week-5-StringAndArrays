using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsin kasutaja eesnime
            //programm kuvab sisestatud nime pikkust

            Console.WriteLine("Sisesta eesnimi");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimi on {firstName.Length} tähte.");

        }
    }
}
