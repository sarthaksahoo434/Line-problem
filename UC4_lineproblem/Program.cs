using System;

namespace UC4_lineproblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2 = 0;
            Console.Write("Input an integer value: +x1 +x2 +y1 +y2 ");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
  

            double lenght1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double lenght2 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            if (lenght1 == lenght2)
            {
                Console.WriteLine("lenght1 lenght2 are same");
            }
           else
            {
                Console.WriteLine("lenght1 lenght2 are differentt");
            }
        }
          

          
            

        }
    }

