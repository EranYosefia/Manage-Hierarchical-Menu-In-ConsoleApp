using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private static readonly string sr_BackLabel = "Back";
        private static readonly int sr_BackKey = 0;
        private readonly List<MenuItem> r_MenuOptions;

        public SubMenu(string i_Title) : base(i_Title)
        {
            r_MenuOptions = new List<MenuItem>();

            MenuItem backOption = new Operation(sr_BackLabel) { SelectedKey = sr_BackKey };
            Add(backOption);
        }

        internal override void OnSelect()
        {
            if (r_MenuOptions.Count == 0)
            {
                Console.WriteLine("This Menu Option cant Do Anything");
            }
            else
            {
                showSubMenu();
            }
        }

        public void Add(MenuItem i_MenuItemOption)
        {
            // If add Exit or Back option.
            if (i_MenuItemOption.SelectedKey == sr_BackKey)
            {
                if (r_MenuOptions.Count == 0)
                {
                    r_MenuOptions.Add(i_MenuItemOption);
                }
                else
                {
                    r_MenuOptions[sr_BackKey] = i_MenuItemOption;
                }
            }
            else
            {
                i_MenuItemOption.SelectedKey = r_MenuOptions.Count;
                r_MenuOptions.Add(i_MenuItemOption);
            }
        }

        private void buildSubMenu(out string o_MenuContent)
        {
            o_MenuContent = string.Format("=========================={0}{1}{0}=========================={0}{2}==========================",  Environment.NewLine, Title, this.ToString());
        }

        private void showSubMenu()
        {
            int userSelection;
            string menuContent;
            buildSubMenu(out menuContent);

            do
            {
                Console.WriteLine(menuContent);
                userSelection = getInputFromUser();
                Console.Clear();

                if (userSelection != sr_BackKey)
                {
                    r_MenuOptions[userSelection].OnSelect();
                }
            }
            while (userSelection != sr_BackKey);
        }

        private int getInputFromUser()
        {
            bool isValidInput = false;
            int ParsedUserSelection = sr_BackKey;
            string UserSelection;

            while (isValidInput == false)
            {
                Console.WriteLine("Enter your choice: (select between {0} and {1})", 0, r_MenuOptions.Count - 1);
                UserSelection = Console.ReadLine();

                isValidInput = int.TryParse(UserSelection, out ParsedUserSelection)
                               && ParsedUserSelection >= 0 && ParsedUserSelection < r_MenuOptions.Count;

                if (isValidInput == false)
                {
                    Console.WriteLine("Wrong input, try again...");
                }
            }

            return ParsedUserSelection;
        }

        public override string ToString()
        {
            StringBuilder ListOfMenuOutput = new StringBuilder();

            foreach (MenuItem option in r_MenuOptions)
            {
                if (option.SelectedKey != sr_BackKey)
                {
                    if (option is Operation)
                    {
                        ListOfMenuOutput.Append(option.ToString());
                    }
                    else if (option is SubMenu)
                    {
                        ListOfMenuOutput.Append(string.Format("{0}) -> {1}", option.SelectedKey, option.Title));
                    }

                    ListOfMenuOutput.Append(Environment.NewLine);
                }
            }

            ListOfMenuOutput.Append(r_MenuOptions[sr_BackKey].ToString());
            ListOfMenuOutput.Append(Environment.NewLine);

            return ListOfMenuOutput.ToString();
        }
    }
}
