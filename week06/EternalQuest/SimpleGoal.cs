namespace EternalQuest
{
    
    class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override int RecordEvent()
        {
            if (!Completed)
            {
                Completed = true;
                return Points;
            }
            return 0;
        }
    }
}