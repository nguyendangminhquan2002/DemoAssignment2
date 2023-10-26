using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            ListBook bookList = new ListBook();
            IMenu menu;
            int option;

            bool correctPassword = false;
            while (!correctPassword)
            {
                Console.WriteLine("\n Enter your password: ");
                string password = Console.ReadLine();

                if (password == "nokia1")
                {
                    correctPassword = true;
                }
                else
                {
                    Console.WriteLine("Invalid password\nRetry\n ");
                }
            }

            while (true)
            {
                menu = new Menu();                
                option = menu.EnterUserChoice();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("We are creating the new library");
                        library.NameOfLibary = "NDMQuan Library";
                        bookList.BookLibrary();
                        library.BookListOfLibrary = bookList;
                        Console.WriteLine("Created");
                        break;
                    case 2:
                        Console.WriteLine("The current information of the library");
                        library.displayLibraryInformation();

                        break;
                    case 3: // create new book
                        bookList.BookAdd();
                        Console.WriteLine("===========================");
                        break;
                    case 4:
                        Console.WriteLine("Enter choice: ");
                        Console.WriteLine("1. Search Book's ID");
                        Console.WriteLine("2. Search Book's Category");
                        Console.WriteLine("3. Search Author");
                        Console.Write("Enter choice: ");
                        int find = int.Parse(Console.ReadLine());
                        if (find == 1)
                        {
                            Console.Write("Enter ID: ");
                            string tmpID = Console.ReadLine();
                            if (tmpID != null)
                            {
                                bookList.SearchIDBook(tmpID);
                                Console.WriteLine("===========================");
                            }
                            else
                            {
                                Console.WriteLine("Error/ Please try again!");
                            }
                            break;
                        }
                        else if (find == 2)
                        {
                            Console.Write("Enter Category: ");
                            string tmpCategory = Console.ReadLine();
                            List<Book> listCategory = bookList.CategorySearch(tmpCategory);
                            if (listCategory.Count > 0)
                            {
                                foreach (var item in listCategory)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("===========================");
                            }
                            else
                            {
                                Console.WriteLine("Error/ Please try again!");
                            }
                            break;
                        }
                        else if (find == 3)
                        {
                            Console.Write("Enter Author: ");
                            string tmpAuthor = Console.ReadLine();
                            List<Book> listAuthor = bookList.AuthorSearch(tmpAuthor);
                            if (listAuthor.Count > 0)
                            {
                                foreach (var item in listAuthor)
                                {
                                    Console.WriteLine(item.ToString());
                                }
                                Console.WriteLine("===========================");
                            }
                            else
                            {
                                Console.WriteLine("Error/ Please try again!");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error/ Please try again!");
                        }
                        break;
                    case 5:
                        bookList.BorrowBook();
                        Console.WriteLine("================");
                        break;
                    case 6:
                        bookList.ViewBorrowedBooks();
                        Console.WriteLine("================");
                        break;
                    case 7:
                        bookList.ReturnBook();
                        Console.WriteLine("================");
                        break;
                    case 8:
                        Console.WriteLine("End");
                        return;
                    default:
                        Console.WriteLine("Error/ Please try again!");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}