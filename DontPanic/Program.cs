using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik o-tähed lauses "Dont panic" nulliga -0
            //programm asendab kõik a- tähed samas lauses 4-ga

            string DontP = "Dont panic!";


            DontP = DontP.Replace('o', '0');
            DontP = DontP.Replace('a', '4');
            Console.WriteLine(DontP);


        }
    }
}
