using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace _04.Download_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://www.qygjxz.com/data/out/179/";
            string fileName = "4757532-picture.jpg";
            string webClient = uri + fileName;
            using (WebClient myWebClient = new WebClient())
            {
                try
                {
                    myWebClient.DownloadFile(webClient, fileName);
                    Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myWebClient);
                    Console.WriteLine("\nDownloaded file saved in the following file system folder:\n" + AppDomain.CurrentDomain.BaseDirectory);
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("The address parameter is null.");
                }
                catch (WebException)
                {
                    Console.WriteLine("Invalid address or\nfilename is null or Empty or"
                        + "\nthe file does not exist or\nan error occurred while downloading data.");
                }
                catch (NotSupportedException)
                {
                    Console.WriteLine("The method has been called simultaneously on multiple threads.");
                }
            }
            Console.ReadLine();
        }
    }
}
