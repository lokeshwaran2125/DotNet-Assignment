using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DivideByZeroException: " + ex.Message);
            }



            try
            {
                int[] numbers = { 10, 20, 30, 40, 60 };

                Console.WriteLine(numbers[6]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }



            try
            {
                string name = null;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException: " + ex.Message);
            }



            try
            {
                object value = "Ravi";

                int number = (int)value;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("InvalidCastException: " + ex.Message);
            }



            try
            {
                string data = File.ReadAllText("newfile.txt");

                Console.WriteLine(data);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException: " + ex.Message);
            }



            try
            {
                string[] names = new string[2];

                object[] objects = names;

                objects[0] = 1000;
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("ArrayTypeMismatchException: " + ex.Message);
            }


            Console.WriteLine("\nProgram completed.");
        }
    }
}
