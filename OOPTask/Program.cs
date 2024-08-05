using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            List<Member> members = new List<Member>();
            Member member = new Member();
            
            Librarian librarian = new Librarian
            { 
                EmpId = 1,
                EmpName = "ahmed"
            };

            librarian.AddBook(books,new Book { Title = "C#", Author = "Ahmed", NumberOfCopies = 5 });
            librarian.AddBook(books, new Book { Title = "Java", Author = "Ali", NumberOfCopies = 3 });
            librarian.AddBook(books, new Book { Title = "Python", Author = "Nada", NumberOfCopies = 2 });

            librarian.DisplayAllBooks(books);

            librarian.RegisterMember(members,new Member { MemberId = 1, MemberName = "Mohamed" });
            librarian.RegisterMember(members,new Member { MemberId = 2, MemberName = "adham" });
            librarian.RegisterMember(members,new Member { MemberId = 3, MemberName = "salah" });

            librarian.DisplayAllMembers(members);

            Member adham = members.Find(m => m.MemberName == "adham");
            Book csharp = books.Find(b => b.Title == "C#");

            member.BorrowBook(adham,csharp);
            librarian.DisplayAllBooks(books);
            member.ReturnBook(adham,csharp);

            librarian.DisplayAllBooks(books);

           Console.ReadKey();

        }
    }
}
