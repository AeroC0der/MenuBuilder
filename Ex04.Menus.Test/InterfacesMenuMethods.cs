using System;

namespace Ex04.Menus.Interfaces;

public class PrintVersionAction : IMenuAction
{
    private const string k_AppVersion = "24.2.4.9504";

    public void InvokeItem()
    {
        Console.WriteLine($"App Version: {k_AppVersion}");
    }
}

public class PrintCurrentTimeAction : IMenuAction
{
    public void InvokeItem()
    {
        Console.WriteLine($"The time is: {DateTime.Now.ToString("HH:mm:ss")}");
    }
}

public class PrintCurrentDateAction : IMenuAction
{
    public void InvokeItem()
    {
        Console.WriteLine($"The date is: {DateTime.Now.ToString("dd.MM.yyyy")}");
    }
}

public class CountCapitalsAction : IMenuAction
{
    public void InvokeItem()
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
