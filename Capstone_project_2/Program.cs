using System;
using System.Collections.Generic;
using System.Net;

namespace Capstone_project_2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Program p = new Program();
            Borrower library = new Borrower();
            int ch = 0;


            do
            {
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("|--------155094 LIBRARY MANAGEMENT SYSTEM-----|");
                Console.WriteLine("| Login into any of the following accounts    |");
                Console.WriteLine("| 1.Librarian                                 |");
                Console.WriteLine("| 2.Book Borrower(Member of Library)          |");
                Console.WriteLine("| 3.Exit                                      |");
                Console.WriteLine("Enter Choice:");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        string wh="";
                        string whl="";
                        do
                        {
                            Console.WriteLine("----------Welcome to Librarian menu-------");
                            Console.WriteLine("Please Enter Password");
                            string Password = Console.ReadLine();

                            if (Password.Equals(library.Passwd))
                            {
                                Console.WriteLine("Successfully Authorized!!");
                                Console.WriteLine("What would you Like to do today?");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("| 1. Add Books                           |");
                                Console.WriteLine("| 2. View Books                          |");
                                Console.WriteLine("| 3. Remove Books                        |");
                                Console.WriteLine("| 4. Sort Books                          |");
                                Console.WriteLine("| 5. Return to Main Menu                 |");
                                Console.WriteLine("| Enter Choice                           |");
                                Console.WriteLine("|----------------------------------------|");
                                Console.WriteLine();
                                int librarianchoice = int.Parse(Console.ReadLine());

                                switch (librarianchoice)
                                {
                                    case 1:
                                        library.Addbooks();
                                        break;
                                    case 2:
                                        library.ViewBooklibrarian();
                                        break;
                                    case 3:
                                        library.RemoveBook(library);
                                        break;
                                    case 4:
                                        library.SortBook();
                                        break;
                                    case 5:
                                        wh = "5";
                                        break;


                                    default:
                                        Console.WriteLine("Invalid Choice");
                                        break;
                                }
                                Console.WriteLine("Continue(any key to continue , 5 to return to main menu): ");

                                wh = Console.ReadLine();



                            }
                            else
                            {
                                Console.WriteLine("Not Authorized!!");
                                break;
                            }
                        } while (wh != "5");

                        break;
                    case 2:
                        
                        do
                        {
                            Console.WriteLine("----------Welcome to Borrower(Member) menu-------");
                            Console.WriteLine("What would you Like to do today?");
                            Console.WriteLine("------------------------------------------");
                            Console.WriteLine("| 1. Search Books                        |");
                            Console.WriteLine("| 2. View Books                          |");
                            Console.WriteLine("| 3. Borrow Book                         |");
                            Console.WriteLine("| 4. Return Book                         |");
                            Console.WriteLine("| 5. Return to Main Menu                 |");
                            Console.WriteLine("| Enter Choice                           |");
                            Console.WriteLine("|----------------------------------------|");
                            Console.WriteLine();
                            int librarianchoice = int.Parse(Console.ReadLine());

                            switch (librarianchoice)
                            {
                                case 1:
                                    library.SearchBook();
                                    break;
                                case 2:
                                    library.ViewBooks();
                                    break;
                                case 3:
                                    library.BorrowBook(library);
                                    break;
                                case 4:
                                    library.ReturnBook(library);
                                    break;
                                case 5:
                                    whl = "5";
                                    break;


                                default:
                                    Console.WriteLine("Invalid Choice");
                                    break;
                            }
                            Console.WriteLine("Continue(any key to continue , 5 to return to main menu): ");
                            whl = Console.ReadLine();



                        } while (whl != "5");



                        break;


                }
            } while (ch != 3);
        }
    }
}
