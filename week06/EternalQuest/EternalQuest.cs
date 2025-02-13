using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace EternalQuest
{
    
    class EternalQuest
    {
        public List<Goal> Goals { get; set; } = new List<Goal>();
        public int Score { get; set; } = 0;

        public void AddGoal(Goal goal)
        {
            Goals.Add(goal);
        }

        public void RecordEvent(int goalIndex)
        {
            if (goalIndex >= 0 && goalIndex < Goals.Count)
            {
                int points = Goals[goalIndex].RecordEvent();
                Score += points;
                Console.WriteLine($"Event recorded! You earned {points} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public void ShowGoals()
        {
            if (Goals.Count == 0)
            {
                Console.WriteLine("No goals found.");
            }
            else
            {
                for (int i = 0; i < Goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Goals[i]}");
                }
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"Your current score: {Score}");
            int level = Score / 1000;
            Console.WriteLine($"Your current level: {level}");
        }

        public void SaveProgress(string filename)
        {
            var data = new
            {
                Score,
                Goals = Goals.Select(g => new
                {
                    Type = g.GetType().Name,
                    g.Name,
                    g.Points,
                    g.Completed,
                    CurrentCount = g is ChecklistGoal ? ((ChecklistGoal)g).CurrentCount : (int?)null,
                    TargetCount = g is ChecklistGoal ? ((ChecklistGoal)g).TargetCount : (int?)null,
                    BonusPoints = g is ChecklistGoal ? ((ChecklistGoal)g).BonusPoints : (int?)null,
                }).ToList()
            };

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, json);
            Console.WriteLine("Progress saved successfully.");
        }

        public void LoadProgress(string filename)
        {
            string json = File.ReadAllText(filename);
            var data = JsonSerializer.Deserialize<JsonElement>(json);

            Score = data.GetProperty("Score").GetInt32();
            Goals.Clear();

            foreach (var goalData in data.GetProperty("Goals").EnumerateArray())
            {
                string type = goalData.GetProperty("Type").GetString();
                string name = goalData.GetProperty("Name").GetString();
                int points = goalData.GetProperty("Points").GetInt32();
                bool completed = goalData.GetProperty("Completed").GetBoolean();

                Goal goal = null;
                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(name, points);
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(name, points);
                        break;
                    case "ChecklistGoal":
                        int targetCount = goalData.GetProperty("TargetCount").GetInt32();
                        int bonusPoints = goalData.GetProperty("BonusPoints").GetInt32();
                        goal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                        ((ChecklistGoal)goal).CurrentCount = goalData.GetProperty("CurrentCount").GetInt32();
                        break;
                }
                if (goal != null)
                {
                    goal.Completed = completed;
                    Goals.Add(goal);
                }
            }
            Console.WriteLine("Progress loaded successfully.");
        }
    }
}