using System;

namespace Gæt_et_tal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int g = 0;

            int n = r.Next(1, 100);
            Console.WriteLine("try to guess a number from 1 to 100");

            
            int i = 0;

            while (g != n)
            {

                try
                {
                    g = Convert.ToInt32(Console.ReadLine());
                    if (g > n)
                    {
                        Console.WriteLine("Too High");
                    }
                    else
                    {
                        Console.WriteLine("Too Low");
                    }
                }

                catch
                {
                    Console.WriteLine("sorry mate, you must use a number");// adding this will make it so the program dont shutdown if you should miss click somethingother than a number.
                    i--;//this will make sure it dosen't count the miss click.
                }
                i++;// this count all the tries
            }

            Console.WriteLine($"nice it took you only {i} tries.");
            Console.ReadLine();

        }
    }
}
