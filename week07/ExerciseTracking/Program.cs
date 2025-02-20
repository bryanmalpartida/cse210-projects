using System;
using System.Collections.Generic;

namespace ExerciseTrackingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>
            {
                new RunningActivity(new DateTime(2023, 10, 1), 30, 3.0),
                new CyclingActivity(new DateTime(2023, 10, 2), 45, 15.0),
                new SwimmingActivity(new DateTime(2023, 10, 3), 60, 40)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}