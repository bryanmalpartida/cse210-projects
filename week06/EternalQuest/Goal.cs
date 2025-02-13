using System;

namespace EternalQuest
{
    // Base class for all goals
    abstract class Goal
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public bool Completed { get; set; }

        protected Goal(string name, int points)
        {
            Name = name;
            Points = points;
            Completed = false;
        }

        public abstract int RecordEvent();

        public override string ToString()
        {
            return $"[{(Completed ? "X" : " ")}] {Name}";
        }
    }
}