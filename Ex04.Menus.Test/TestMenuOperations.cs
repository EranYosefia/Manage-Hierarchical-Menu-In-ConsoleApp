using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TestMenuOperations
    {
        public class ShowTime : IActionable
        {
            public void Active()
            {
                string timeOutput = DateTime.Now.TimeOfDay.ToString();
                Console.WriteLine(timeOutput);
                Console.WriteLine("Press any key to return");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public class ShowDate : IActionable
        {
            public void Active()
            {
                string dateOutput = DateTime.Now.Date.ToString();
                Console.WriteLine(dateOutput);
                Console.WriteLine("Press any key to return");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public class CountSpaces : IActionable
        {
            public void Active()
            {
                int countSpaces = 0;
                string userInput;

                Console.WriteLine("Enter a sentence: ");
                userInput = Console.ReadLine();

                countSpaces = userInput.Count(char.IsWhiteSpace);

                Console.WriteLine("Number of spaces is: {0}", countSpaces);
                Console.WriteLine("Press any key to return");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public class ShowVersion : IActionable
        {
            public void Active()
            {
                Console.WriteLine("Version: 22.2.4.8950");
                Console.WriteLine("Press any key to return");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
