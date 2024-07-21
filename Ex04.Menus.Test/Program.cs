using Ex04.Menus.Interfaces;
using Ex04.Menus.Events;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Program program = new Program();

            Interfaces.MainMenu interfaceMainMenu = program.buildInterfacesMenu();
            interfaceMainMenu.Show();

            Events.MainMenu eventMainMenu = program.buildEventsMenu();
            eventMainMenu.Show();
        }

        private Interfaces.MainMenu buildInterfacesMenu()
        {
            Interfaces.MainMenu interfaceMainMenu = new Interfaces.MainMenu("Interfaces Main Menu");

            IMenuItem versionAndCapitalsUsingInterfaces = new Interfaces.MainMenu("Version and Capitals", interfaceMainMenu);
            IMenuItem showDateTimeUsingInterfaces = new Interfaces.MainMenu("Show Date/Time", interfaceMainMenu);

            IMenuItem showVersionUsingInterfaces = new Interfaces.MenuItem("Show Version", new PrintVersionAction());
            IMenuItem countCapitalsUsingInterfaces = new Interfaces.MenuItem("Count Capitals", new CountCapitalsAction());

            versionAndCapitalsUsingInterfaces.SubMenuItems?.Add(showVersionUsingInterfaces);
            versionAndCapitalsUsingInterfaces.SubMenuItems?.Add(countCapitalsUsingInterfaces);

            IMenuItem showTimeUsingInterfaces = new Interfaces.MenuItem("Show Time", new PrintCurrentTimeAction());
            IMenuItem showDateUsingInterfaces = new Interfaces.MenuItem("Show Date", new PrintCurrentDateAction());

            showDateTimeUsingInterfaces.SubMenuItems?.Add(showTimeUsingInterfaces);
            showDateTimeUsingInterfaces.SubMenuItems?.Add(showDateUsingInterfaces);

            interfaceMainMenu.AddMenuItem(versionAndCapitalsUsingInterfaces);
            interfaceMainMenu.AddMenuItem(showDateTimeUsingInterfaces);

            return interfaceMainMenu;
        }

        private Events.MainMenu buildEventsMenu()
        {
            EventsMenuMethods menuMethods = new EventsMenuMethods();

            Events.MainMenu eventMainMenu = new Events.MainMenu("Delegates Main Menu");

            Events.MenuItem versionAndCapitalsUsingEvents = new Events.MenuItem("Version and Capitals");
            Events.MenuItem showDateTimeUsingEvents = new Events.MenuItem("Show Date/Time");

            Events.MenuItem showVersionUsingEvents = new Events.MenuItem("Show Version", menuMethods.PrintVersion);
            Events.MenuItem countCapitalsUsingEvents = new Events.MenuItem("Count Capitals", menuMethods.CountCapitals);

            Events.MenuItem showTimeUsingEvents = new Events.MenuItem("Show Time", menuMethods.PrintCurrentTime);
            Events.MenuItem showDateUsingEvents = new Events.MenuItem("Show Date", menuMethods.PrintCurrentDate);

            versionAndCapitalsUsingEvents.SubMenuItems?.Add(showVersionUsingEvents);
            versionAndCapitalsUsingEvents.SubMenuItems?.Add(countCapitalsUsingEvents);

            showDateTimeUsingEvents.SubMenuItems?.Add(showTimeUsingEvents);
            showDateTimeUsingEvents.SubMenuItems?.Add(showDateUsingEvents);

            eventMainMenu.AddMenuItem(versionAndCapitalsUsingEvents);
            eventMainMenu.AddMenuItem(showDateTimeUsingEvents);

            return eventMainMenu;
        }
    }
}
