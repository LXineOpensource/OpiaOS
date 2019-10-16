using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace stack
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" Booted successfully. Type 'help' for avalible commands ");
            Console.ResetColor();
            Console.WriteLine("Stack os");
            Console.WriteLine("Sam lee © 2019");
            Console.WriteLine("Cosmos project © 2019");
            Console.WriteLine("");
            Console.WriteLine("WELCOME TO STACK OS");
            Console.WriteLine("");

        }

        protected override void Run()
        {
            Console.WriteLine("C:/>>");
            string input = "";

            input = Console.ReadLine();

            HandleThisCommand(input);



            //Console.Write("Input: ");
            //var input = Console.ReadLine();
            //Console.Write("Text typed: ");
            //Console.WriteLine(input);
        }

        private void HandleThisCommand(string input)
        {

            if (input == "help")
            {
                Console.WriteLine("help - All Avalible commands");
                Console.WriteLine("dir - List of Directories");
                Console.WriteLine("osver - Info about os");
                Console.WriteLine("license - Open source info");
            }

            else if (input == "osver")
            {
                Console.WriteLine("Stack os 0.1 © Sam Lee");
                Console.WriteLine("WHAT'S NEW - Commands");
            }

            else if (input == "dir")
            {
                Console.WriteLine("No directories exists...");
            }
            else if (input == "license")
            {
                Console.WriteLine(" INSTALLATION AND USE RIGHTS.  General.You may use any number of copies of the software to develop and test your applications, including deployment within your internal corporate network.");
            }
            else
            {
                Console.WriteLine("Bad command");
            }
        }
    }
}
