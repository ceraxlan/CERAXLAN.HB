using CERAXLAN.HB.ConsoleApp.Commands;
using CERAXLAN.HB.ConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.IO;

namespace CERAXLAN.HB.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("-----CERAXLAN HB Case Tests---------");
            //Console.WriteLine("Enter the Endpoint Adress(Example: http://localhost:8080/)");
            //Helper.EndPointAddress = Console.ReadLine();
            Helper.EndPointAddress = "https://localhost:44343/";

            string scenarioNumber = string.Empty;
            while (true)
            {
                try
                {
                    string path = string.Empty;
                    List<BaseCommand> list;
                    switch (scenarioNumber)
                    {
                        case "1":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "ScenarioFiles\\Scenario1.txt");
                            list = CommonOperation.FileOperattion(path);
                            ExcecuteLine(list);
                            break;
                        case "2":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "ScenarioFiles\\Scenario2.txt");
                            list = CommonOperation.FileOperattion(path);
                            ExcecuteLine(list);
                            break;
                        case "3":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "ScenarioFiles\\Scenario3.txt");
                            list = CommonOperation.FileOperattion(path);
                            ExcecuteLine(list);
                            break;
                        case "4":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "ScenarioFiles\\Scenario4.txt");
                            list = CommonOperation.FileOperattion(path);
                            ExcecuteLine(list);
                            break;
                        case "5":
                            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "ScenarioFiles\\Scenario5.txt");
                            list = CommonOperation.FileOperattion(path);
                            ExcecuteLine(list);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("There are 5 scenarios in the system");
                Console.WriteLine("Please choose from 1 to 5 scenarios");
                scenarioNumber = Console.ReadLine();
            }


        }

        public static void ExcecuteLine(List<BaseCommand> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. command line invoked");
                list[i].Execute();

            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------");
            Console.WriteLine("Scenario is complete.Time reset");
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
