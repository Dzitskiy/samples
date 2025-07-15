using System;
using System.Linq;
using ToDoList.Core.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        ToDoItemService service = new ToDoItemService();

        string command;
        do
        {
            Console.Clear();
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("1. View All Items");
            Console.WriteLine("2. Add New Item");
            Console.WriteLine("3. Update Item");
            Console.WriteLine("4. Delete Item");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    var items = service.GetAll();
                    foreach (var item in items)
                    {
                        Console.WriteLine($"{item.Id}: {item.Title} - {item.Description} (Completed: {item.IsCompleted})");
                    }
                    break;
                case "2":
                    // Logic to add a new item
                    break;
                case "3":
                    // Logic to update an item
                    break;
                case "4":
                    // Logic to delete an item
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
            if (command != "5")
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        } while (command != "5");
    }
}
