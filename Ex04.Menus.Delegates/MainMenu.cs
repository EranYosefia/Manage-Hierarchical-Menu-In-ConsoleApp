using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private static readonly string sr_ExitLabel = "Exit";
        private static readonly int sr_ExitKey = 0;
        private readonly SubMenu r_MainMenu;

        public MainMenu(string i_Title)
        {
            r_MainMenu = new SubMenu(i_Title);

            MenuItem exitOption = new Operation(sr_ExitLabel) { SelectedKey = sr_ExitKey };
            r_MainMenu.Add(exitOption);
        }

        public void Add(MenuItem i_MenuItemOption)
        {
            r_MainMenu.Add(i_MenuItemOption);
        }

        public void Show()
        {
            r_MainMenu.OnSelect();
        }
    }
}
