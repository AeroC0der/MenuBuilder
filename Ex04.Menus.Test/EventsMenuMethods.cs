using System;

namespace Ex04.Menus.Events
{
	public class EventsMenuMethods
	{
        private const string k_AppVersion = "24.2.4.9504";

        public void PrintVersion()
		{
            Console.WriteLine($"App Version: {k_AppVersion}");
        }

		public void PrintCurrentTime()
		{
            Console.WriteLine($"The time is: {DateTime.Now.ToString("HH:mm:ss")}");
        }

		public void PrintCurrentDate()
		{
            Console.WriteLine($"The date is: {DateTime.Now.ToString("dd.MM.yyyy")}");
        }

		public void CountCapitals()
		{
            Console.WriteLine("Please enter your sentence:");
            string? inputSentence = Console.ReadLine();
            int countCapitals = 0;

            if (inputSentence != null)
            {
                foreach (char charInSentence in inputSentence)
                {
                    if (char.IsUpper(charInSentence))
                    {
                        countCapitals++;
                    }
                }
            }
            Console.WriteLine($"Number of capital letters: {countCapitals}");
        }
    }
}
