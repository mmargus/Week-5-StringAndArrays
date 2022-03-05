using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu h, o ja l tähte on lauses "Hello World!"

            string message = "Hello World!".ToLower();
            //Console.WriteLine(message);

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;
                int sum = 0;

          
            for (int i = 0; i < message.Length; i++)
            {if (message[i] == 'h')
                {hCounter++;                 }

            }
            for (int i = 0; i < message.Length; i++)
            {if (message[i] == 'o')
                {oCounter++;
                }

            }             for (int i = 0; i < message.Length; i++)
            {if (message[i] == 'l')
                {
                    lCounter++;                 }

            }

            if (hCounter != 1)
            {Console.WriteLine($"Lauses Hello World! on {hCounter} h tähte.");
            }
            else
            { Console.WriteLine($"Lauses Hello World! on {hCounter} h täht.");
            }
            if (oCounter != 1)
            {Console.WriteLine($"Lauses Hello World! on {oCounter} o tähte.");
            }
            else
            {Console.WriteLine($"Lauses Hello World! on {oCounter} o täht.");
            }
            if (lCounter != 1)
            {Console.WriteLine($"Lauses Hello World! on {lCounter} l tähte.");
            }
            else
            {Console.WriteLine($"Lauses Hello World! on {lCounter} l täht.");
            }
            sum = hCounter + lCounter + oCounter;
            Console.WriteLine($"Kokku on lauses otsitavaid tähti {sum}.");

        }
    }
}
