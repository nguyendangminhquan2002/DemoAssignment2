using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment
{
    internal class Menu : IMenu
    {
        public int EnterUserChoice()
        {
            int choice;
            Console.WriteLine("Press 1: Creating the library");
            Console.WriteLine("Press 2: Display the library");
            Console.WriteLine("Press 3: Adding new book");
            Console.WriteLine("Press 4: Searching Book");
            Console.WriteLine("Press 5: Borrowing Book");
            Console.WriteLine("Press 6: Displaying Borrow Book");
            Console.WriteLine("Press 7: Returning Book");
            Console.WriteLine("Press 8: Exit the program");
            Console.WriteLine("===========================");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}