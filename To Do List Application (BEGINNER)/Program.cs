using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> tasks = new List<string>();
        int choice;

        do
        {
            Console.WriteLine("\nWelcome to the To-Do List application!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Delete task");
            Console.WriteLine("4. Exit");
            Console.Write("Your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter task description: ");
                    string taskDescription = Console.ReadLine();
                    tasks.Add(taskDescription);
                    Console.WriteLine("Task added!");
                    break;

                case 2:
                    Console.WriteLine("\nTasks:");
                    if (tasks.Count == 0)
                    {
                        Console.WriteLine("No tasks to display.");
                    }
                    else
                    {
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i]}");
                        }
                    }
                    break;

                case 3:
                    Console.Write("Enter task number to delete: ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    if (taskNumber >= 1 && taskNumber <= tasks.Count)
                    {
                        tasks.RemoveAt(taskNumber - 1);
                        Console.WriteLine("Task deleted!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 4);
    }
}
