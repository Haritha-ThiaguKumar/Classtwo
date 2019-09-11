using System;

namespace Classtwo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello world");
            Console.WriteLine("How many years experience do you have in professional programming");
            try
            {
                int yearsinsales = 0;
                yearsinsales = int.Parse(Console.ReadLine());
                switch (yearsinsales)
                {
                    case 0:
                        Console.WriteLine("Need lots of practice");
                        break;


                    case 1:
                        Console.WriteLine("Looks like you have experinece");

                        break;
                    case 2:
                        Console.WriteLine("Wow you have been doing this for a while");

                        break;
                    case 3:
                        Console.WriteLine("you are an expert");

                        break;
                    default:
                        Console.WriteLine("You have many years of sales experience. Keep up the good work!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Please enter your experience");
            }
        }
    }
}
