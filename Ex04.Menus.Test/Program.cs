using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            MenuTestInit menuTest = new MenuTestInit();
            menuTest.Run();
            Console.WriteLine("Bye bye");
            Console.ReadLine();
        }
    }
}
