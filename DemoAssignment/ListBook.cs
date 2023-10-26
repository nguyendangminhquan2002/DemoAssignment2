using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment
{
    internal class ListBook : Book
    {
        public List<Book> listOfBook = new List<Book>();
        public List<BorrowBook> listOfBorrowedBooks = new List<BorrowBook>();
        public ListBook()
        {

        }
        public void BookLibrary()
        {
            listOfBook.Add(new Book("Book1", "Future Diary", "Sakae Esuno", "Psychological thriller", 1, 2006, 1000));
            listOfBook.Add(new Book("Book2", "Naruto", "Masashi Kishimoto", "Adventure", 9, 1999, 1200));
            listOfBook.Add(new Book("Book3", "Hunter X Hunter", "Yoshihiro Togashi", "Adventure", 3, 1998, 2000));
            listOfBook.Add(new Book("Book4", "Nha Gia Kim", "Paulo Coelho", "Fantasy", 5, 1988, 6000));
            listOfBook.Add(new Book("Book5", "Nhung Nguoi Khon Kho", " Victor Hugo", "Novel", 2, 1862, 7000));
        }
        public void BookAdd()
        {
            try
            {
                Console.Write("Enter Book's Quantity: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    ListBook highmanager = new ListBook();
                    //ID
                    Console.Write("Book's ID: ");
                    highmanager.BookOfID = Console.ReadLine();
                    //Name
                    Console.Write("Book's Name: ");
                    highmanager.BookOfName = Console.ReadLine();
                    //Author
                    Console.Write("Book's Author: ");
                    highmanager.BookOfAuthor = Console.ReadLine();
                    Console.Write("Book's Category: ");
                    highmanager.BookOfCategory = Console.ReadLine();
                    Console.Write("Book's Quantity: ");
                    highmanager.BookOfQuantity = int.Parse(Console.ReadLine());
                    Console.Write("Book's Publication Date: ");
                    highmanager.BookOfPublicationDate = int.Parse(Console.ReadLine());
                    Console.Write("Book's Price: ");
                    highmanager.BookOfPrice = int.Parse(Console.ReadLine());

                    // Add the book to the list
                    listOfBook.Add(highmanager);
                    Console.WriteLine("Added!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                // You can choose to handle the error in different ways, e.g., continue the loop or exit the loop.
            }
        }
        public void BorrowBook()
        {
            try
            {
                Console.WriteLine("Enter the name of the book you want to borrow:");
                string tenSachMuon = Console.ReadLine();

                if (string.IsNullOrEmpty(tenSachMuon))
                {
                    throw new ArgumentNullException("Ten sach muon khong duoc rong.");
                }
                // Tìm sách trong danh sách listOfBook dựa trên tên sách được nhập
                Book sachMuon = listOfBook.Find(book => book.BookOfName.Equals(tenSachMuon, StringComparison.OrdinalIgnoreCase));

                if (sachMuon != null)
                {
                    // Kiểm tra trạng thái sách
                    if (!sachMuon.IsBorrowed)
                    {
                        // Sách tồn tại trong danh sách, cho phép mượn
                        Console.WriteLine("Books are borrowed: " + sachMuon.BookOfName);

                        Console.WriteLine("Enter the borrower's name:");
                        string tenNguoiMuon = Console.ReadLine();

                        Console.WriteLine("Enter the borrower's address:");
                        string diaChiNguoiMuon = Console.ReadLine();

                        DateTime ngayMuon = DateTime.Now;

                        // Cập nhật trạng thái sách đã mượn
                        sachMuon.IsBorrowed = true;

                        // Tạo đối tượng BorrowBook và thêm vào danh sách mượn sách
                        BorrowBook muonSach = new BorrowBook(sachMuon.BookOfName, tenNguoiMuon, diaChiNguoiMuon, ngayMuon);
                        listOfBorrowedBooks.Add(muonSach);

                        Console.WriteLine(" The book was borrowed by " + tenNguoiMuon + " on the day " + ngayMuon);
                    }
                }
                else
                {
                    // Sách không tồn tại trong danh sách
                    Console.WriteLine("Books do not exist in the library.\"");
                }
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
        public void ViewBorrowedBooks()
        {
            if (listOfBorrowedBooks.Count > 0)
            {
                Console.WriteLine("List of borrowed books:");
                foreach (var borrowedBook in listOfBorrowedBooks)
                {
                    Console.WriteLine("Book title: " + borrowedBook.BookOfName);
                    Console.WriteLine("Borrower: " + borrowedBook.UserName);
                    Console.WriteLine("Borrower address: " + borrowedBook.UserAddress);
                    Console.WriteLine("Borrowing date: " + borrowedBook.BorrowDate);
                    Console.WriteLine("------------------------------");
                }
            }
            else
            {
                Console.WriteLine("No books can be borrowed.");
            }
        }

        public void ReturnBook()
        {
            try
            {
                Console.WriteLine("Enter the title of the book you want to return:");
                string tenSachTra = Console.ReadLine();

                // Tìm sách đã mượn trong danh sách đã mượn
                BorrowBook sachDaMuon = listOfBorrowedBooks.Find(book => book.BookOfName.Equals(tenSachTra, StringComparison.OrdinalIgnoreCase));

                if (sachDaMuon != null)
                {
                    // Sách tồn tại trong danh sách đã mượn, cho phép trả
                    Console.WriteLine(" Books returned: " + sachDaMuon.BookOfName);

                    // Loại bỏ sách đã mượn khỏi danh sách đã mượn
                    listOfBorrowedBooks.Remove(sachDaMuon);

                    // Cập nhật trạng thái sách trong danh sách sách chính
                    Book sachGoc = listOfBook.Find(book => book.BookOfName.Equals(tenSachTra, StringComparison.OrdinalIgnoreCase));
                    if (sachGoc != null)
                    {
                        sachGoc.IsBorrowed = false;
                    }
                    Console.WriteLine(" Books have been returned. ");
                }
                else
                {
                    Console.WriteLine("The book does not exist in the borrowed list.");
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("ArgumentNullException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public void DisplayBookList()
        {
            foreach (var item in listOfBook)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void SearchIDBook(string IDs)
        {
            foreach (var item in listOfBook)
            {
                if (item.BookOfID.Contains(IDs))
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public List<Book> CategorySearch(string category)
        {
            List<Book> book = new List<Book>();
            foreach (var item in listOfBook)
            {
                if (item.BookOfCategory.Contains(category)) book.Add(item);
            }
            return book;
        }
        public List<Book> AuthorSearch(string author)
        {
            List<Book> book = new List<Book>();
            foreach (var item in listOfBook)
            {
                if (item.BookOfAuthor.Contains(author)) book.Add(item);
            }
            return book;
        }
    }
}