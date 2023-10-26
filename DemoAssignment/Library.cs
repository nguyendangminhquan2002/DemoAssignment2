using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment
{
    internal class Library
    {
        public string NameOfLibary { get; set; }
        public ListBook BookListOfLibrary { get; set; }
        public Library()
        {

        }
        public Library(string nameOfLibary, ListBook bookListOfLibrary)
        {
            NameOfLibary = nameOfLibary;
            BookListOfLibrary = bookListOfLibrary;
        }
        public void displayLibraryInformation()
        {
            Console.WriteLine($"The library Name {NameOfLibary}");
            Console.WriteLine("===========================");
            BookListOfLibrary.DisplayBookList();
            Console.WriteLine("\n===========================");
        }
    }
}