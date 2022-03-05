using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib ees-ja perekonnanime
            //programm kuvab mitu "a" tähte ees-ja perekonnanimes kokku on

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();
            Console.WriteLine(fullName);


            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)

            {
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }
            }
            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnies {firstName} on {aCounter} 'a' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu täisnimes {firstName} on {aCounter} 'a' täht.");
            }
         
    
                
                        
             
        }
    }
}
