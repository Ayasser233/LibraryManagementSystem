using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    internal class Member
    {
        private int _MemberId;
        private string _MemberName;
        public int MemberId
        {
            get { return _MemberId; }
            set { _MemberId = value; }
        }
        public string MemberName
        {
            get { return _MemberName; }
            set { _MemberName = value; }
        }

        public void BorrowBook(Member member ,Book book)
        {
            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }
            if (book.NumberOfCopies > 0)
            {
                book.NumberOfCopies--;
                Console.WriteLine($"Book {book.Title} borrowed by {member.MemberName}");
               
            }
            else
            {
                Console.WriteLine("No copies available.");
            }
            
        }

        public void ReturnBook(Member member,Book book) 
        {
            book.NumberOfCopies++;
            Console.WriteLine($"Book {book.Title} returned by {member.MemberName}");
        }
    }
}
