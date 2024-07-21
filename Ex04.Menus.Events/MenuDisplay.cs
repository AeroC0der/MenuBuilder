using System;

namespace Ex04.Menus.Events
{
    public class MenuDisplay
    {
        public void ShowMenu(string i_Text, List<MenuItem> i_SubMenuItems, bool isSub = false)
        {
            bool isQuit = false;

            while (!isQuit)
            {
                //Console.Clear();
                Console.WriteLine($"**{i_Text}**");
                Console.WriteLine("------------------------");
                for (int i = 0; i < i_SubMenuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1} -> {i_SubMenuItems[i].Text}");
                }
                Console.WriteLine("0 -> " + (isSub ? "Back" : "Exit"));
                Console.WriteLine("------------------------");
                Console.WriteLine($"Enter your request: 1 to {i_SubMenuItems.Count} or press '0' to {(isSub ? "go back" : "exit")}.");

                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= i_SubMenuItems.Count)
                {
                    if (choice == 0)
                    {
                        isQuit = true;
                    }
                    else
                    {
                        i_SubMenuItems[choice - 1].Execute();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter a valid number.");
                }
            }
        }
    }
}
