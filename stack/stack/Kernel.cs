using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Drawing;




namespace stack
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" Booted successfully. Type 'help' for avalible commands ");
            Console.ResetColor();
            Console.WriteLine("Stack OS");
            Console.WriteLine("Sam Lee (c) 2020");
            Console.WriteLine("Cosmos project (c) 2020");
            Console.WriteLine("");
            Console.WriteLine("WELCOME TO STACK OS");
            Console.WriteLine("");

        }

        protected override void Run()
        {
            Console.Write("C:/>>");
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
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("help - All Avalible commands");
                Console.WriteLine("dir - List of Directories");
                Console.WriteLine("osver - Info about the OS");
                Console.WriteLine("printcolor - Prints 3 colors");
                Console.WriteLine("license - Open source info");
                Console.WriteLine("cls - Clears all terminal texts");
                Console.WriteLine("soundtest - Plays sound based of a beeper");
                Console.ResetColor();
            }

            else if (input == "osver")
            {
                Console.WriteLine("Stack OS 0.2 (c) Sam Lee");
                Console.WriteLine("WHAT'S NEW - Commands");
            }

            else if (input == "dir")
            {
                Console.WriteLine("No directories exists...");
            }
            else if (input == "license")
            {
                Console.WriteLine(" INSTALLATION AND USE RIGHTS. You may use any number of copies of the software to develop and test your applications, including deployment within your internal corporate network.");
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
            else if (input == "soundtest")
            {
                Console.Beep(500, 100);
                Console.Beep(400, 100);
                Console.Beep(500, 100);
                Console.Beep(400, 100);
                Console.Beep(700, 700);
                Console.Beep(550, 500);
            }
            else if(input == "cd")
            {
                Console.WriteLine("There is no directories");

            }
            else if (input == "time")
            {
                DateTime now = DateTime.Now;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(now);
                Console.ReadLine();
                Console.ResetColor();
            }
            else if (input == "printimage1")
            {
                
            }

            else
            {
                Console.WriteLine("Bad command");
            }
        }
    }
}
