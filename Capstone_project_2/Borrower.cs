using Capstone_project_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone_project_2
{
    class Borrower:Librarian
    {
        public int Userid;
        public string Username { get; set; }
        public string Useraddress;
        public int BorrowBookId;
        public DateTime BorrowDate;
        public int BorrowCount;
        private List<Borrower> BorrowList = new List<Borrower>();


        /// <summary>
        /// Method for Searching books
        /// </summary>
       public void SearchBook()
        {
            //Librarian book = new Librarian();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (BookList.Exists(x => x.Bookid == find))
            {
                foreach (var searchId in BookList.Where(searchId => searchId.Bookid == find))
                {
                    Console.WriteLine("Book id :{0}\n" +
                                        "Book name :{1}\n" +
                                        "Book Count :{2}", searchId.Bookid, searchId.Bookname, searchId.Bookcount);
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
            }
        }
        public void BorrowBook(Borrower borrower) {
            Borrower borrow = borrower;
         
            Console.WriteLine("User id : {0}", (borrow.Userid = BorrowList.Count + 1));
            Console.Write("Name :");

            borrow.Username = Console.ReadLine();

            Console.Write("Book id :");
            borrow.BorrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books : ");
            borrow.BorrowCount = int.Parse(Console.ReadLine());
            Console.Write("Address :");
            borrow.Useraddress = Console.ReadLine();
            borrow.BorrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.BorrowDate.ToShortDateString(), borrow.BorrowDate.ToShortTimeString());

            if (BookList.Exists(x => x.Bookid == borrow.BorrowBookId))
            {
                foreach (var searchId in BookList.Where(searchId=> searchId.Bookcount >= searchId.Bookcount - borrow.BorrowCount && searchId.Bookcount - borrow.BorrowCount >= 0 ))
                {
                    
                    if (searchId.Bookid == borrow.BorrowBookId)
                    {
                        searchId.Bookcount -= borrow.BorrowCount;
                        Console.WriteLine("Book Issued!!");
                        break;
                    }
                    
                    else
                    {
                        Console.WriteLine("Only {0} books are found", searchId.Bookcount);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.BorrowBookId);
            }
            BorrowList.Add(borrow);
        }
        public Borrower ReturnBook(Borrower borrower)
        {
            Borrower book = borrower;
            Console.WriteLine("Enter following details :");

            Console.Write("Book id : ");
            int returnId = int.Parse(Console.ReadLine());

            Console.Write("Number of Books:");
            int returnCount = int.Parse(Console.ReadLine());

            if (BookList.Exists(y => y.Bookid == returnId))
            {
                foreach (Book addReturnBookCount in BookList.Where(addReturnBookCount=>addReturnBookCount.x >= returnCount + addReturnBookCount.Bookcount))
                {
                    
                        if (addReturnBookCount.Bookid == returnId)
                        {
                            addReturnBookCount.Bookcount += returnCount;
                            Console.WriteLine("Book Returned");
                            break;
                        }
                    
                    else
                    {
                        Console.WriteLine("Count exceeds the actual count or book not borrowed");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", returnId);
            }
            return book;
        }

        public void ViewBooks()
        {
            //Book bookview =bookobj;
            Console.WriteLine();
            Console.WriteLine("ID    NAME          COUNT ");
            foreach (Book bookview in BookList)
            {
                Console.WriteLine($"{bookview.Bookid}     " + $"{bookview.Bookname}            " + $"{bookview.Bookcount}");
            }
        }

    }
}

