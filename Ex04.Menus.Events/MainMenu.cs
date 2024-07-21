using System;

namespace Ex04.Menus.Events
{
	public class MainMenu
	{
        private string Text { get; set; }
        private List<MenuItem> SubMenuItems { get; set; }

        public MainMenu(string i_Text)
        {
            Text = i_Text;
            SubMenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            SubMenuItems?.Add(i_MenuItem);
            i_MenuItem.ActionExecuted += MenuItem_ActionExecuted; // Subscribe to the MenuItem's event
        }

        private void MenuItem_ActionExecuted()
        {
            Console.WriteLine("Action executed, update display or perform other actions in response.");
        }

        public void Show()
        {
            MenuDisplay menuDisplay = new MenuDisplay();

            menuDisplay.ShowMenu(Text, SubMenuItems);
        }
    }
}
