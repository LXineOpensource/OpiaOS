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
            Console.WriteLine("Sam lee (c) 2019");
            Console.WriteLine("Cosmos project (c) 2019");
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
                Console.WriteLine("printcolor - Prints 3 colors");
                Console.WriteLine("license - Open source info");
                Console.WriteLine("cls - Clears Terminal texts");
            }

            else if (input == "osver")
            {
                Console.WriteLine("Stack os 0.2 (c) Sam Lee");
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
            else if (input == "printcolor")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("RED");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Green");
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Blue");
                Console.ResetColor();
              
                

            }

            else if (input == "secrete")
            {
                Console.WriteLine("Thanks for downloading the stackOS. This message is here to show my apreciation.");
            }

            else if (input == "cls")
            {
                Console.Clear();
            }

            else
            {
                Console.WriteLine("Bad command");
            }
        }
    }
}
