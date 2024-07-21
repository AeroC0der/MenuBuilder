using System;

namespace Ex04.Menus.Events;

public delegate void MenuItemActionDelegate();

public class MenuItem
{
    public string Text { get; set; }
    public List<MenuItem> SubMenuItems { get; set; }

    public event MenuItemActionDelegate? ActionExecuted;

    // Constructor for submenu items (no action)
    public MenuItem(string i_Text)
    {
        Text = i_Text;
        SubMenuItems = new List<MenuItem>();
    }

    // Constructor for action items
    public MenuItem(string i_Text, MenuItemActionDelegate i_Action)
    {
        Text = i_Text;
        SubMenuItems = new List<MenuItem>();
        ActionExecuted += i_Action;  // Subscribe the action to the event
    }

    protected virtual void OnActionExecuted()
    {
        ActionExecuted?.Invoke();
    }

    public void Execute()
    {
        if (SubMenuItems.Count > 0) // If it has sub-menu items, show sub-menu
        {
            ShowSubMenu();
        }
        else if (ActionExecuted != null) // If it has an action, execute the action
        {
            OnActionExecuted();
            Console.Write(Environment.NewLine);
        }
    }

    private void ShowSubMenu()
    {
        MenuDisplay menuDisplay = new MenuDisplay();

        menuDisplay.ShowMenu(Text, SubMenuItems, true); // Because a MenuItem, needs a subMenu flag.
    }
}
