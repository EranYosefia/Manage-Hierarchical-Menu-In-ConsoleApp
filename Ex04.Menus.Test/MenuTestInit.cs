using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus;

namespace Ex04.Menus.Test
{
    public class MenuTestInit
    {
        public void Run()
        {
            runInterfaceMenu();
            runDelegateMenu();
        }

        private void runInterfaceMenu()
        {
            Interfaces.MainMenu mainMenu = initInterfaceMenu();
            mainMenu.Show();
        }

        private Interfaces.MainMenu initInterfaceMenu()
        {
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Main menu : Interface");

            Interfaces.SubMenu dateAndTime = new Interfaces.SubMenu("Show Date/Time");
            Interfaces.MenuItem time = new Interfaces.Operation("Show Time", new TestMenuOperations.ShowTime());
            dateAndTime.Add(time);
            Interfaces.MenuItem date = new Interfaces.Operation("Show Date", new TestMenuOperations.ShowDate());
            dateAndTime.Add(date);
            mainMenu.Add(dateAndTime);

            Interfaces.SubMenu versionandSpaces = new Interfaces.SubMenu("Version and Spaces");
            Interfaces.MenuItem countSpaces = new Interfaces.Operation("Count Spaces", new TestMenuOperations.CountSpaces());
            versionandSpaces.Add(countSpaces);
            Interfaces.MenuItem version = new Interfaces.Operation("Show Version", new TestMenuOperations.ShowVersion());
            versionandSpaces.Add(version);
            mainMenu.Add(versionandSpaces);

            return mainMenu;
        }
        
        private void runDelegateMenu()
        {
            Delegates.MainMenu mainMenu = initDelegateMenu();
            mainMenu.Show();
        }

        private Delegates.MainMenu initDelegateMenu()
        {
            Delegates.MainMenu mainMenu = new Delegates.MainMenu("Main menu : Delegete");

            Delegates.SubMenu dateAndTime = new Delegates.SubMenu("Show Date/Time");
            Delegates.MenuItem time = new Delegates.Operation("Show Time", new TestMenuOperations.ShowTime().Active);
            dateAndTime.Add(time);
            Delegates.MenuItem date = new Delegates.Operation("Show Date", new TestMenuOperations.ShowDate().Active);
            dateAndTime.Add(date);
            mainMenu.Add(dateAndTime);

            Delegates.SubMenu versionandSpaces = new Delegates.SubMenu("Version and Spaces");
            Delegates.MenuItem countSpaces = new Delegates.Operation("Count Spaces", new TestMenuOperations.CountSpaces().Active);
            versionandSpaces.Add(countSpaces);
            Delegates.MenuItem version = new Delegates.Operation("Show Version", new TestMenuOperations.ShowVersion().Active);
            versionandSpaces.Add(version);
            mainMenu.Add(versionandSpaces);

            return mainMenu;
        }
    }
}
