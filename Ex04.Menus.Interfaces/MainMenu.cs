namespace Ex04.Menus.Interfaces;

public class MainMenu : IMenu, IMenuItem
{
    public string Text { get; set; }
    public List<IMenuItem>? SubMenuItems { get; set; }
    public IMenu? OwnerMenu { get; set; }

    public MainMenu(string i_Text, IMenu? i_OwnerMenu = null)
    {
        Text = i_Text;
        SubMenuItems = new List<IMenuItem>();
        OwnerMenu = i_OwnerMenu;
    }

    public void AddMenuItem(IMenuItem i_MenuItem)
    {
        SubMenuItems?.Add(i_MenuItem);
    }

    public void RemoveMenuItem(IMenuItem i_MenuItem)
    {
        SubMenuItems?.Remove(i_MenuItem);
    }

    public void Show()
    {
        bool isQuit = false;

        while (!isQuit)
        {
            Console.WriteLine($"**{Text}**");
            Console.WriteLine("------------------------");

            for (int i = 0; i < SubMenuItems?.Count; i++)
            {
                Console.WriteLine($"{i + 1} -> {SubMenuItems[i].Text}");
            }
            Console.WriteLine("0 -> " + (OwnerMenu == null ? "Exit" : "Back"));
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter your request: 1 to {0} or press '0' to {1}.", SubMenuItems?.Count, OwnerMenu == null ? "exit" : "go back");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= SubMenuItems?.Count)
            {
                if (choice == 0)
                {
                    if (OwnerMenu == null) // We are at Main Menu
                    {
                        isQuit = true;
                    }
                    else // We are at sub Menu and choose to go back
                    {
                        return; // Exit the method, "going back" to the previous menu level
                    }
                }
                else if (choice > 0 && choice <= SubMenuItems.Count)
                {
                    SubMenuItems[choice - 1].Execute();
                }
            }
            else
            {
                Console.WriteLine("Invalid choice please enter a valid choice...");
                Console.Write(Environment.NewLine);
            }
        }
    }

    public virtual void Execute()
    {
        Show();
    }
}
