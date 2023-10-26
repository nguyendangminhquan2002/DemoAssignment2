using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAssignment
{
    internal class Returnbook : Book
    {
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public DateTime ReturnDate { get; set; }

        public Returnbook()
        {

        }
        public Returnbook(string bookOfName, string userName, string userAddress, DateTime returnDate)
            : base(bookOfName)
        {
            UserName = userName;
            UserAddress = userAddress;
            ReturnDate = returnDate;
        }
    }
}
