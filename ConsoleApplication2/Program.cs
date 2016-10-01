﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Usercontrol = 1;
            Thread.Sleep(1000);
            Console.Write(" [Initiating first boot procedure]...\n\n");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" {Success}\n\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Write(" [Loading core operating functions]...\n\n");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" {Success}\n\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Write(" [Loading User space]...\n\n");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" [ERROR 451 - NO USERS FOUND] \n\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" {Ignoring}\n\n");
            Thread.Sleep(500);
            Console.Write(" {Continuing}\n\n");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.Write(" Welcome to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ChaOS V. 50.15.1 REV2\n");
            Console.ResetColor();
            Thread.Sleep(500);
            Console.Write(" Welcome ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("<UNKOWN>");
            Console.ResetColor();
            Console.Write("!\n\n");
            Thread.Sleep(1000);
            Console.Write(" Type help on the next line to see a list of commands:\n\n");
            string Command = Console.ReadLine();
            while (Usercontrol == 1)
            {
                if (Command == "help")
                {
                    Console.Write("\n All commands are to be entered in lower case\n");
                    Console.Write(" The 'Complete' list of commands is as follows:\n");
                    Thread.Sleep(1000);
                    Console.Write("  help     - Displays this menu\n");
                    Console.Write("  list     - Lists the contents of the current directory\n");
                    Console.Write("  listdir  - List the current directory\n");
                    Console.Write("  user     - List current user\n");
                    Console.Write("  read     - Displays the contents of any text file\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  init     - FUNCTION DESCRIPTION UNKNOWN(error 444)\n\n");
                    Console.ResetColor();
                    Command = "";
                    Command = Console.ReadLine();
                }
               
                else if (Command == "list")
                {
                    Console.Write("\n listing contents of: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("COS/base/users/UNKNOWN/home\n");
                    Console.ResetColor();
                    Console.Write("     config.txt      ");
                    Thread.Sleep(100);
                    Console.Write("     Documents       ");
                    Thread.Sleep(100);
                    Console.Write("     TotallyNotAMeme.PNG     \n");
                    Thread.Sleep(2000);
                    Console.Write("     RUN_INIT.txt    ");
                    Thread.Sleep(1000);
                    Console.Write("\n Existing to prompt...\n\n ");
                    Command = "";
                    Command = Console.ReadLine();
                }
                
                else if (Command == "listdir")
                {
                    Console.Write("\n Listing Current Working Directory...\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" COS/base/users/UNKNOWN/home\n\n");
                    Console.ResetColor();
                    Command = "";
                    Command = Console.ReadLine();
                }
                else if(Command == "")
                {
                    Command = "";
                    Command = Console.ReadLine();
                }
                else if(Command == "read")
                {
                    Console.Write(" Please select a .txt file to read (include file extention)");
                    string Input = "";
                    Input = Console.ReadLine();
                    if (Input == "config.txt")
                    {
                        Console.Write("  Users: ERROR 451\n");
                        Console.Write("  Permissions: NONE\n");
                        Console.Write("  AI_status: OFFLINE\n");
                        Console.Write("  Error_logging: False\n\n");
                        Console.Write(" Press Enter fo return to normal prompt\n");
                        Console.ReadLine();
                                            
                    }
                    else if (Input == "RUN_INIT.txt")
                    {
                        Console.Write("  Run the init command.....\n Please\n I beg you\n\n");
                        Console.Write(" Press Enter fo return to normal prompt\n");
                        Console.ReadLine();
                        
                    }
                    Command = "";
                    Command = Console.ReadLine();
                }
                else if (Command == "user")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO USER DETECTED ERROR 451, EXITING.\n\n");
                    Console.ResetColor();
                    Command = "";
                    Command = Console.ReadLine();
                }
                else if (Command == "init")
                {
                    Usercontrol = 0;
                    AI.initFunc();
                }else
                {
                    Console.Write("\n Please enter a valid command.\n\n");
                    Command = "";
                    Command = Console.ReadLine();
                }

            }
            
            
        }
    }
}