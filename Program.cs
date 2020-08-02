using System;
using System.Collections.Generic;

namespace capstonetasklist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaskClass> tasks = new List<TaskClass>()
            { 
                new TaskClass("Simon", "this capstone", "Monday", false),
                new TaskClass("Nick", "cut Simon's hair", "soon", false)
            };


            while (true)
            {
                Console.WriteLine("Welcome to TaskApp 3000");
               
                Console.WriteLine("Please select what you'd like to do: ");
                Console.WriteLine("1) Print all tasks");
                Console.WriteLine("2) Add in a new task");
                Console.WriteLine("3) Delete a task");
                Console.WriteLine("4) Mark a task complete");
                Console.WriteLine("5) Exit");

                string input = Console.ReadLine();

                try
                {
                    int pick = int.Parse(input);
                    if (1 <= pick && pick <= 5)
                    {
                        if (pick == 1)
                        {
                            PrintList(tasks);
                            Console.WriteLine();
                        }
                        else if (pick == 2)
                        {
                            AddTask(tasks);
                            Console.WriteLine();
                        }
                        else if (pick == 3)
                        {
                            DeleteTask(tasks);
                            Console.WriteLine();
                        }
                        else if (pick == 4)
                        {
                            MarkComplete(tasks);
                            Console.WriteLine();
                        }
                        else if (pick == 5)
                        {
                            Console.WriteLine("Thanks for using the program");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input number: " + pick + " was not in between 1 and 5");
                        Console.WriteLine("Please press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The input " + input + " was not a number");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }

        public static void PrintList(List<TaskClass> tasks)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.Write($"{i +1}: ");
                tasks[i].PrintTask();
            }
        }

        public static void AddTask(List<TaskClass> tasks)
        {
            Console.WriteLine("Who is assigned this task?");
            string taskAssign = Console.ReadLine();

            Console.WriteLine("Please describe the task:");
            string taskDesc = Console.ReadLine();

            Console.WriteLine("When is it due?");
            string taskDue = Console.ReadLine();

            TaskClass addedTask = new TaskClass(taskAssign, taskDesc, taskDue, false);
            
            tasks.Add(addedTask);
            

            Console.WriteLine("Cool, you added this task:");
            addedTask.PrintTask();
            
        }

        public static void MarkComplete(List<TaskClass> tasks)
        {
            Console.WriteLine("Whick task would you like to mark complete? Select a number from the list below:");
            PrintList(tasks);
            string completeTask = Console.ReadLine();
            bool success = int.TryParse(completeTask, out int selection);
            selection -= 1;

            if (success)
            {
                if (selection >= 0 && selection <= tasks.Count)
                {
                    tasks[selection].Complete = true;
                    tasks[selection].PrintTask();
                }
                else
                {
                    Console.WriteLine("No task with that number");
                }
            }
            else
            {
                Console.WriteLine("That wasn't a number");
            }
        }

        public static void DeleteTask(List<TaskClass> tasks)
        {
            Console.WriteLine("Whick task would you like to delete? Select a number from the list below:");
            PrintList(tasks);
            string completeTask = Console.ReadLine();
            bool success = int.TryParse(completeTask, out int selection);
            selection -= 1;

            if (success)
            {
                if (selection >= 0 && selection <= tasks.Count)
                {
                    tasks.Remove(tasks[selection]);
                    Console.WriteLine("Cool! Here's what's left to do:");
                    PrintList(tasks);
                }
                else
                {
                    Console.WriteLine("No task with that number");
                }
            }
            else
            {
                Console.WriteLine("That wasn't a number");
            }
        }
    }
    }

