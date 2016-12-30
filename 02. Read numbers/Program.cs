using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Read_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start = 1");
            Console.WriteLine("End = 100");
            ReadNumber(1, 100);
            Console.ReadLine();
        }
        public static void ReadNumber(int start, int end)
        {
            int number;
            try
            {
                int count = 1;
                for (int i = start; i < end; i++)
                {
                    Console.Write($"Enter number \"{count}\" ({start} < number < {end}): ");
                    number = int.Parse(Console.ReadLine());
                    if (number <= start || number >= end)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    count++;
                    if(count == 11)
                    {
                        Console.WriteLine("The end!");
                        break;
                    }
                    start = number;
                }              
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number was not in given range!");
            }
        }
    }
}
