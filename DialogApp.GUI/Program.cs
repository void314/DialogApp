using System;
using System.Collections.Generic;
using DialogApp.BLL; // Нужен доступ к слою BLL

namespace DialogApp.GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Приложение Диалогового Помощника ---");

            TableManager manager = new TableManager();

            List<string> availableTables = manager.GetAllAvailableTables();

            Console.WriteLine("\nДоступные столики:");
            foreach (var table in availableTables)
            {
                Console.WriteLine($"- {table}");
            }
            Console.ReadLine();
        }
    }
}