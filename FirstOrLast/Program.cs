using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja ees-ja perekonnanime
            //programm kontrollib nimede pikkust (tähtede arvu)
            //programm kuvab kumb on nendest pikem, kas ees või perekonnanimi

            Console.WriteLine("Sisesta eesnimi");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;

            Console.WriteLine($"Sinu eesnimies on {firstName.Length} tähte.");
            Console.WriteLine($"Sinu perekonnanimes on {lastName.Length}.");


            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikem, seal on rohkem tähti.");
            }
            else if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Sinu perekonnanimi on pikem kui eesnimi, seal on rohkem tähti.");
            }
            else
            {
                Console.WriteLine("Sinu ees- ja perekonnanmes on ühepalju tähti.");
            }

        }
    }
}
