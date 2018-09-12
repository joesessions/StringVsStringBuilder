using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When you hit enter, I will build a 10,000-character string, one character at a time, then delete it, one character at a time.");
            Console.WriteLine();
            Console.WriteLine("Then, I will build a 10,000-character StringBuilder one character at a time, then delete it one character at a time.");
            Console.WriteLine();
            Console.WriteLine("Then, I'll give you the elaped time for each.");
            Console.WriteLine();
            Console.WriteLine("Ready? Press enter."); Console.ReadLine();

            Console.WriteLine("Please wait (about 10 seconds)");

            DateTime start = DateTime.Now;
            LetterGenerator();
            DateTime mid = DateTime.Now;
            StringBuilderGenerator();
            DateTime end = DateTime.Now;

            Console.WriteLine("Time using string: " + (mid-start));
            Console.WriteLine("Time using StringBuilder: " + (end-mid));
            Console.ReadLine();

        }



        public static void LetterGenerator()
        {
            string letterOutput = "";
            Random _random = new Random();

            for (int i = 1; i <= 100000; i++)
            {
                int num = _random.Next(0, 26); // Zero to 25
                char let = (char)('a' + num);

                letterOutput += let;

            }

            for (int i = 1; i <= 100000; i++)
            {

                letterOutput.TrimEnd(letterOutput[letterOutput.Length - 1]);

            }
        }

        public static void StringBuilderGenerator()
        {
            StringBuilder letterOutput = new StringBuilder();
            Random _random = new Random();

            for (int i = 1; i <= 100000; i++)
            {
                int num = _random.Next(0, 26); // Zero to 25
                string let = Convert.ToString('a' + num);

                letterOutput.Append(let);

            }

            for (int i = 1; i <= 100000; i++)
            {

                letterOutput.Remove(letterOutput[letterOutput.Length - 1], 1);

            }
        }

    }
}
