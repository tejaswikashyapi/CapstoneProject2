using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone_project_2
{
    //Assume this Class acts as a Library
     class Book
    {
        
        public string Bookname;
        private int _Bookid;
        public int Bookid { get { return _Bookid; } set { _Bookid = value; } }
        private int _bookcount;
        public int x;
        public int Bookcount { get => _bookcount; set => _bookcount = value; }
        public List<Book> BookList = new List<Book>();
        
        public Book()
        {
            Console.WriteLine("-------------Welcome to 155094 Library------------");
        }
        public virtual void Bookdisplay() { }

    }
}
