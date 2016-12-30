using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_defined_exception
{
    class Program
    {
        static string[] namesOfEmployees = new string[] { "Pesho", "Gosho", "Arnold", "Donald", "Marin", "John", "Ivan", "Yordan", "George" };

        static void Main(string[] args)
        {
            bool isFound = false;
            Console.Write("Enter the name of the employee: ");
            string name = Console.ReadLine();
            try
            {
                for (int i = 0; i < namesOfEmployees.Length; i++)
                {
                    if(name == namesOfEmployees[i])
                    {
                        isFound = true;
                    }
                }
                if(isFound)
                {
                    Console.WriteLine($"{name} is in current database.");
                    Console.ReadLine();
                }
                else
                {
                    throw new EmployeeNotFoundException($"Employee {name} is not in current datebase.");
                }
            }
            catch(EmployeeNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.ReadLine();
            }
        }
    }
    class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException()
        {

        }

        public EmployeeNotFoundException(string message) : base(message)
        {

        }
    }


}
