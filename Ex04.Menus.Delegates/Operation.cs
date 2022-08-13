using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void MenuOptionDelegate();

    public class Operation : MenuItem
    {
        public event Action MenuOptionActived;

        public Operation(string i_Title) : base(i_Title)
        {
            MenuOptionActived = null;
        }

        public Operation(string i_Title, Action i_ActionDelegate) : base(i_Title)
        {
            MenuOptionActived += i_ActionDelegate;
        }

        internal override void OnSelect()
        {
            if (MenuOptionActived != null)
            {
                MenuOptionActived.Invoke();
            }
            else
            {
                Console.WriteLine("No Such Of Option");
            }
        }

        public override string ToString()
        {
            string operationContent = string.Format("{0}) -> {1}", SelectedKey, Title);
            return operationContent;
        }
    }
}
