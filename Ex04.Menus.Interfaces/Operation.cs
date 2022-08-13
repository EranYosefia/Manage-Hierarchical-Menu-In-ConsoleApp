using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class Operation : MenuItem
    {
        private IActionable m_Actionable;

        public Operation(string i_Title) : base(i_Title)
        {
            m_Actionable = null;
        }

        public Operation(string i_Title, IActionable i_Actionable) : base(i_Title)
        {
            m_Actionable = i_Actionable;
        }

        public IActionable Active
        {
            get { return m_Actionable; }
            set { m_Actionable = value; }
        }

        internal override void OnSelect()
        {
            if (m_Actionable != null)
            {
                m_Actionable.Active();
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
