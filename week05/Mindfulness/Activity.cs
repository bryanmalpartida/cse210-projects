using System;
using System.Threading;

namespace MindfulnessProgram
{
    abstract class Activity
    {
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Duration { get; set; }

        public Activity(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Start()
        {
            Console.WriteLine($"Welcome to the {Name} Activity!");
            Console.WriteLine(Description);
            Console.Write("Enter the duration of the activity in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }

        public void End()
        {
            Console.WriteLine("Good job!");
            Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
}