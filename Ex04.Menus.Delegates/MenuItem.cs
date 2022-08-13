using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private static readonly int sr_PreInitKey = -1;
        private readonly string r_Title;
        private int m_SelectedKey;

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
            m_SelectedKey = sr_PreInitKey;
        }

        internal abstract void OnSelect();

        public string Title
        {
            get { return r_Title; }
        }

        public int SelectedKey
        {
            get { return m_SelectedKey; }
            set { m_SelectedKey = value; }
        }

        public abstract override string ToString();
    }
}
