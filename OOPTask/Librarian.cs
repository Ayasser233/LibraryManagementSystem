using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    internal class Librarian
    {
        private int _EmpId;
        private string _EmpName;
        public int EmpId
        {
            get { return _EmpId; }
            set { _EmpId = value; }
        }

        public string EmpName
        {
            get { return _EmpName; }
            set { _EmpName = value; }
        }


        public void AddBook(List<Book> Books, Book newbook)
        {
            Books.Add(newbook);
            Console.WriteLine("Book Added");
        }
        public void RemoveBook(List<Book> Books, Book book)
        {
            Books.Remove(book);
            Console.WriteLine("Book Removed");
        }
        public void DisplayAllBooks(List<Book> Books)
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Number of Copies: {book.NumberOfCopies}");
            }
        }
        public void RegisterMember(List<Member> Members, Member newmember)
        {
            Members.Add(newmember);
            Console.WriteLine("Member Registered");
        }
        public void DisplayAllMembers(List<Member> Members)
        {
            foreach (var member in Members)
            {
                Console.WriteLine($"Member Id: {member.MemberId}, Member Name: {member.MemberName}");
            }
        }
    }
}
