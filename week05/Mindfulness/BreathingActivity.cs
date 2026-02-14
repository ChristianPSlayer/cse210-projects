using System;

namespace Mindfulness
{
    class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.")
        {
        }

        public void Start()
        {
            DisplayStartingMessage();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowSpinner(4);
                Console.WriteLine("Breathe out...");
                ShowSpinner(4);
                Console.WriteLine();
            }
            DisplayEndingMessage();
        }
    }
}