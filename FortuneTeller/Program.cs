using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab, mis kasutajaga homme juhtub (random kasutan)

            string[] predictions = { "win million", "fall in love", "buy youtube premium", "join the darkside for cookies" };

            Random rnd = new Random();

            int userNumber = rnd.Next(0, predictions.Length);
            Console.WriteLine($"Tomorrow you {predictions[userNumber]}:)");


        }
    }
}
