using System;
using System.Net.Mail;

namespace lab_1_console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string line;
            while((line = Console.ReadLine())!= null)
            {
                line = line.Replace(",", " у:");
                line = "x:" + line;

                //
                Console.WriteLine(line);
            }
        }
    }
}
