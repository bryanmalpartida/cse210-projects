using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            EternalQuest quest = new EternalQuest();

            while (true)
            {
                Console.WriteLine("\nEternal Quest Program");
                Console.WriteLine("1. Add Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Show Goals");
                Console.WriteLine("4. Show Score");
                Console.WriteLine("5. Save Progress");
                Console.WriteLine("6. Load Progress");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter goal type (simple/eternal/checklist): ");
                    string goalType = Console.ReadLine().ToLower();
                    Console.Write("Enter goal name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (goalType == "simple")
                    {
                        quest.AddGoal(new SimpleGoal(name, points));
                    }
                    else if (goalType == "eternal")
                    {
                        quest.AddGoal(new EternalGoal(name, points));
                    }
                    else if (goalType == "checklist")
                    {
                        Console.Write("Enter target count: ");
                        int targetCount = int.Parse(Console.ReadLine());
                        Console.Write("Enter bonus points: ");
                        int bonusPoints = int.Parse(Console.ReadLine());
                        quest.AddGoal(new ChecklistGoal(name, points, targetCount, bonusPoints));
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal type.");
                    }
                }
                else if (choice == "2")
                {
                    quest.ShowGoals();
                    Console.Write("Enter goal number to record: ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    quest.RecordEvent(goalIndex);
                }
                else if (choice == "3")
                {
                    quest.ShowGoals();
                }
                else if (choice == "4")
                {
                    quest.ShowScore();
                }
                else if (choice == "5")
                {
                    Console.Write("Enter filename to save: ");
                    string filename = Console.ReadLine();
                    quest.SaveProgress(filename);
                }
                else if (choice == "6")
                {
                    Console.Write("Enter filename to load: ");
                    string filename = Console.ReadLine();
                    quest.LoadProgress(filename);
                }
                else if (choice == "7")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}