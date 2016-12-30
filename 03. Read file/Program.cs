using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
   

namespace _03.Read_file
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enters file name along with its full file path: ");
                string text = Console.ReadLine();
                string n = File.ReadAllText(text);
                Console.WriteLine(n);
            }
            catch (ArgumentException)
            {
                Console.WriteLine(
                    "Path is a zero-length string, contains only white space,\n or contains one or more invalid characters.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine(
                    "The specified path, file name, or both exceed the system-defined maximum length.");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid path.");
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("Path specified a file that is read-only \nor"
                    + " this operation is not supported on the current platform.path specified a directory or\n path specified a directory"
                    + "or\n The caller does not have the required permission.");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch(NotSupportedException)
            {
                Console.WriteLine("Path is in an invalid format.");
            }

        }
    }
}
