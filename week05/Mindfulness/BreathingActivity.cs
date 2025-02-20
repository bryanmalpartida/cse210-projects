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
             for (int i = 1; i <= 5; i++)
             {
            Console.WriteLine(new string('*', i));
            Thread.Sleep(500); 
            }
            Console.WriteLine("Breathe out...");
            for (int i = 5; i >= 1; i--)
            {
            Console.WriteLine(new string('*', i));
            Thread.Sleep(500); // 
            }
            remainingTime -= 5;
            }
            End();
        }
    }
}