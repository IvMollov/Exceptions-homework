using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();
            Console.ReadLine();
        }

        public static void Print()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", Sqrt(number)); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
            
        }
        public static double Sqrt(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(number);
        }
    }
}
