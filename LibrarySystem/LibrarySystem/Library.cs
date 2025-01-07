using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        private List<Book>books;
        private List<Book> borrowedBooks ;
        private List<Librian> librians;
        private List<LibraryUser> libraryUsers;

        public Library() {
            books = new List<Book>();
            borrowedBooks = new List<Book>();
            librians = new List<Librian>();
            libraryUsers = new List<LibraryUser>();
        }

        public void AddLibrian(Librian librian)
        {
            librians.Add(librian);
            Console.WriteLine("this user has been Added successfully");
        }
        public void AddlibraryUser(LibraryUser LibraryUser)
        {
            libraryUsers.Add(LibraryUser);
            Console.WriteLine("this user has been Added successfully");

        }
        public bool LibrianExist(String name)
        {
            for (int i = 0; i < librians.Count; i++)
            {
                if (librians[i].Name ==name)return true;
            }
            return false;
        }
        public bool RegularUserExist(string name)
        {
            for (int i = 0; i < libraryUsers.Count; i++)
            {
                if (libraryUsers[i].Name == name) return true;
            }
            return false;
        }
        public void AddBook(Book book)
        {
            if (!books.Contains(book))
            {
                books.Add(book);
                Console.WriteLine("this book has been Added successfully");
            }
            else Console.WriteLine("this book is alredy exist");
        }

        public void BorrowBook(Book book)
        {
            if (books.Contains(book))
            {
                if (borrowedBooks.Count > 0 )
                {
                    if (!borrowedBooks.Contains(book))
                    {
                        borrowedBooks.Add(book);
                        Console.WriteLine("You borrowed this book succefully");
                    }
                    else
                        Console.WriteLine("You can not Borrow this book");
                }
                else
                {
                    borrowedBooks.Add(book);
                    Console.WriteLine("You borrowed this book succefully");
                }
            }
            else
                Console.WriteLine("this book is not exist");
        }
        
        public void RemoveBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine("this book has been removed");
            }
            else
                Console.WriteLine("this book is not exist");
        }

        public void RemoveBorrowedBook(Book book)
        {
            if (borrowedBooks.Contains(book))
            {
                borrowedBooks.Remove(book);
                Console.WriteLine("this book hes been returned");
            }
            else
                Console.WriteLine("this book is not exist");
        }

        public void DisplayBooks()
        {
            foreach (Book book in books) 
                Console.WriteLine(book);
        }
    }
}
