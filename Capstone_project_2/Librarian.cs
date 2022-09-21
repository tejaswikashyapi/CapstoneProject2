using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Capstone_project_2
{
     class Librarian: Book
    {
        //public int Userid { get; set; }
        

        private string _passwd = "lib123";
            
        public string Passwd { get { return _passwd; } }
        public void Addbooks()
        {
            Book book = new Book();
            
            var bookId = BookList.Count > 0 ? BookList.Max(b => b.Bookid) : 0;
            Console.WriteLine("Book Id:{0}", book.Bookid = bookId + 1);
            //Console.WriteLine("Book Id:{0}", book.bookId = BookList.Count + 1);
            Console.Write("Book Name:");
            book.Bookname = Console.ReadLine();
            Console.Write("Number of Books:");
            book.x=book.Bookcount = int.Parse(Console.ReadLine());
            BookList.Add(book);
           
        }

        

        public void RemoveBook(Borrower lib2)
        {
            Borrower book = lib2;
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());

            if (BookList.Exists(x => x.Bookid == Del))
            {
                BookList.Remove(BookList[Del-1]);
                Console.WriteLine("Book id - {0} has been deleted", Del);
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }

            BookList.Add(book);

        }

        public void ViewBooklibrarian()
        {
            
            //Book bookview =bookobj;
            Console.WriteLine();
            Console.WriteLine("ID    NAME          COUNT ");
            foreach (Book bookview in BookList)
            {
                Console.WriteLine($"{bookview.Bookid}     "+ $"{bookview.Bookname}            "+ $"{bookview.Bookcount}");
            }
        }

        public void SortBook()
        {
            Console.WriteLine("Sort Booklist according to Book Name");
            var orderByResult = from s in BookList
                                orderby s.Bookname
                                select s;
            Console.WriteLine("ID    NAME          COUNT ");
            foreach (Book bookview in orderByResult)
            {
                Console.WriteLine($"{bookview.Bookid}     " + $"{bookview.Bookname}            " + $"{bookview.Bookcount}");
            }

        }


    }
}
