using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment
{
    class BorrowBook : Book
    {

        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public DateTime BorrowDate { get; set; }

        public BorrowBook()
        {

        }
        public BorrowBook(string bookOfName, string userName, string userAddress, DateTime borrowDate)
            : base(bookOfName)
        {
            UserName = userName;
            UserAddress = userAddress;
            BorrowDate = borrowDate;
        }
    }
}