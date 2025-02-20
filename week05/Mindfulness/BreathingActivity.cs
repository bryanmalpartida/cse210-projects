using System;

namespace MindfulnessProgram
{
    class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public override void Run()
        {
            Start();
            int remainingTime = Duration;
            while (remainingTime > 0)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(3);
                Console.WriteLine("Breathe out...");
                ShowCountdown(3);
                remainingTime -= 6;
            }
            End();
        }
    }
}