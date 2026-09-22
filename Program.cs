using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arithematic operator
            /*  Console.WriteLine("arithematic operator");
              int a = 100;
              int b = 200;
              int c = a + b;
              int d = a - b;
              int f = a * b;
              int g = a / b;
              int h = a % b;
              Console.WriteLine(c);
              Console.WriteLine(d);
              Console.WriteLine(f);
              Console.WriteLine(g);
              Console.WriteLine(h);*/

            //assignment operator
            Console.WriteLine("assignment operator");
            int y = 55;
            y += 55;
            y -= 55;
            y &= 55;
            y |= 55;
            y ^= 55;

            Console.WriteLine(y);

            //assignment operator
            Console.WriteLine("assignment operator");
            int k = 55;
            int o = 55;
            Console.WriteLine(k == o);
            Console.WriteLine(k != o);
            Console.WriteLine(k > o);
            Console.WriteLine(k < o);
            Console.WriteLine(k >= o);
            Console.WriteLine(k <= o);

            //logical operator
            Console.WriteLine("logical operator");
            bool p = true;
            bool q = false;
            Console.WriteLine(p && q);
            Console.WriteLine(p || q);
            Console.WriteLine(!p);

            //typecasting
            Console.WriteLine("Typecasting");
            int x = 100;
            string str = x.ToString();
            Console.WriteLine(str);

            string a = "200";
            int b = Convert.ToInt32(a);


            //looping condition
            Console.WriteLine("looping");
            int n = 50;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);

            }

            // star pattern
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }





        }
    }
}