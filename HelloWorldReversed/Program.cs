using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvablause "Hello world!" tagurpidi

            string message = "Hello World!";

            for (int i = message.Length - 1; i >= 0; i--)
            {Console.Write(message[i]);
            }

        }
    }
}
