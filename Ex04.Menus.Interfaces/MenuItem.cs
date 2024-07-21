using System;
using System.Text;

namespace Ex04.Menus.Interfaces;

public class MenuItem : IMenuItem
{
    public string Text { get; set; }
    public List<IMenuItem>? SubMenuItems { get; set; }
    private IMenuAction? MenuItemAction { get; set; }

    public MenuItem(string i_Text, IMenuAction? i_MenuItemAction = null)
    {
        Text = i_Text;
        SubMenuItems = new List<IMenuItem>();
        MenuItemAction = i_MenuItemAction;
    }

    public virtual void Execute()
    {
        if (SubMenuItems == null || SubMenuItems.Count == 0)
        {
            MenuItemAction?.InvokeItem();
            Console.Write(Environment.NewLine);
        }
    }
}
