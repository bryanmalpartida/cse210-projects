namespace EternalQuest
{
    
    class ChecklistGoal : Goal
    {
        public int TargetCount { get; set; }
        public int BonusPoints { get; set; }
        public int CurrentCount { get; set; }

        public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
            : base(name, points)
        {
            TargetCount = targetCount;
            BonusPoints = bonusPoints;
            CurrentCount = 0;
        }

        public override int RecordEvent()
        {
            if (CurrentCount < TargetCount)
            {
                CurrentCount++;
                if (CurrentCount == TargetCount)
                {
                    Completed = true;
                    return Points + BonusPoints;
                }
                return Points;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Completed {CurrentCount}/{TargetCount} times)";
        }
    }
}