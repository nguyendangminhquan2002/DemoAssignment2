using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment
{
    internal class Book
    {
        public string BookOfID { get; set; }
        public string BookOfName { get; set; }
        public string BookOfAuthor { get; set; }
        public int BookOfPublicationDate { get; set; }
        public int BookOfPrice { get; set; }
        public string BookOfCategory { get; set; }
        public int BookOfQuantity { get; set; }
        public bool IsBorrowed { get; set; } // Trạng thái sách đã mượn

        public Book()
        {
            IsBorrowed = false; // Mặc định, sách chưa được mượn
        }

        public Book(string bookOfID, string bookOfName, string bookOfAuthor, string bookOfCategory, int bookOfQuantity, int bookOfPublicationDate, int bookOfPrice)
        {
            BookOfID = bookOfID;
            BookOfName = bookOfName;
            BookOfAuthor = bookOfAuthor;
            BookOfCategory = bookOfCategory;
            BookOfQuantity = bookOfQuantity;
            BookOfPublicationDate = bookOfPublicationDate;
            BookOfPrice = bookOfPrice;
            IsBorrowed = false; // Mặc định, sách chưa được mượn
        }


        public Book(string bookOfName)
        {
            BookOfName = bookOfName;
        }

        public override string ToString()
        {
            return "ID: " + BookOfID + " Name: " + BookOfName + " Author: " + BookOfAuthor + " Category: " + BookOfCategory + " Quantity: " + BookOfQuantity + " Publication Date: " + BookOfPublicationDate + " Price: " + BookOfPrice + " iAvailable: " + IsBorrowed;
        }
    }
}