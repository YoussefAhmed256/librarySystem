using System;

namespace LibrarySystem
{
    internal class Program
    {
        public delegate void LibraryAction(Library library);

        public static void HandleUser(Library library, string userType, LibraryAction newUserAction, LibraryAction oldUserAction)
        {
            char identifier = CheckIdentifier();
            if (identifier == 'N')
                newUserAction(library);
            else if (identifier == 'O')
                oldUserAction(library);
        }

        public static Book bookDetails()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book author: ");
            string author = Console.ReadLine();
            Console.Write("Enter book year: ");
            int year=0;
            while (year==0)
            {
                Console.Write("enter valid year: ");
                string num=Console.ReadLine();
                int.TryParse(num,out year);
            }
            return new Book(year, title, author);
        }

        public static char CheckIdentifier()
        {
            char userIdentifier;
            Console.WriteLine("Are You New Or Old User");
            do
            {
                Console.WriteLine("Please enter N or O");
                userIdentifier = Console.ReadLine().ToUpper()[0];
            }
            while (userIdentifier != 'N' && userIdentifier != 'O');
            return userIdentifier;
        }

        public static char CheckUserType()
        {
            Console.WriteLine("Are you Librarian or Regular User");
            char userType;
            do
            {
                Console.WriteLine("Please enter L , R or E to Exit Program");
                userType = Console.ReadLine().ToUpper()[0];
            }
            while (userType != 'L' && userType != 'R' && userType != 'E');
            return userType;
        }

        public static bool CheckContinue()
        {
            Console.WriteLine("If you want to make another operation, please enter C. Otherwise, you'll return to the main menu.");
            return Console.ReadLine().ToUpper()[0] == 'C';
        }

        public static void RegularUserActions(Library library)
        {
            Console.WriteLine("You can display books (D), return borrowed book (Z) or borrow a book (B). Choose what you want:");
            char choice;
            do
            {
                choice = Console.ReadLine().ToUpper()[0];
            } while (choice != 'D' && choice != 'B' && choice!='Z');

            switch (choice)
            {
                case 'D':
                    library.DisplayBooks();
                    break;
                case 'B':
                    Console.WriteLine("Enter details for the book you need:");
                    Book book = bookDetails();

                    library.BorrowBook(book);
                    break;
                case 'Z':
                    Console.WriteLine("enter the details for the borrowed book you want to return");
                    book = bookDetails();
                    library.RemoveBorrowedBook(book);
                    break;
            }

            if (CheckContinue())
                RegularUserActions(library);
        }

        public static void NewRegularUser(Library library)
        {
            Console.WriteLine("Please enter your data:");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your card number: ");
            int cardNumber = int.Parse(Console.ReadLine());

            library.AddlibraryUser(new LibraryUser(name, new LibraryCard(cardNumber)));
            Console.WriteLine($"Welcome to our library, {name}!");
            RegularUserActions(library);
        }

        public static void OldRegularUser(Library library)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            if (library.RegularUserExist(name))
            {
                Console.WriteLine($"Welcome back, {name}!");
                RegularUserActions(library);
            }
            else
            {
                Console.WriteLine("This name does not exist.");
            }
        }

        public static void NewLibrarian(Library library)
        {
            Console.WriteLine("Please enter your data:");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your employee number: ");

            int employeeNumber=-1;
            while (employeeNumber == -1)
            {
                int.TryParse(Console.ReadLine(),out employeeNumber);
            }

            library.AddLibrian(new Librian(name, employeeNumber));
            Console.WriteLine($"Welcome to our library, {name}!");
            LibrarianActions(library);
        }

        public static void OldLibrarian(Library library)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            if (library.LibrianExist(name))
            {
                Console.WriteLine($"Welcome back, {name}!");
                LibrarianActions(library);
            }
            else
            {
                Console.WriteLine("This name does not exist.");
            }
        }

        public static void LibrarianActions(Library library)
        {
            Console.WriteLine("You can display books (D), borrow a book (B), add a book (A), return borrowed book(Z) ,or remove a book (R). Choose what you want:");
            char choice;
            do
            {
                choice = Console.ReadLine().ToUpper()[0];
            } while (choice != 'D' && choice != 'B' && choice != 'A' && choice != 'R' && choice !='Z');

            switch (choice)
            {
                case 'D':
                    library.DisplayBooks();
                    break;
                case 'B':
                    Console.WriteLine("Enter details for the book you need:");
                    Book book1 = bookDetails();
                    library.BorrowBook(book1);
                    break;

                case 'A':
                    Console.WriteLine("Enter details for the book to add:");
                   book1 = bookDetails();
                    library.AddBook(book1);
                    break;

                case 'R':
                    Console.WriteLine("Enter details for the book to remove:");
                    Book book = bookDetails();
                    library.RemoveBook(book);
                    break;
                case 'Z':
                    Console.WriteLine("enter the details for the borrowed book you want to return");
                    book = bookDetails();
                    library.RemoveBorrowedBook(book);
                    break;
            }

            if (CheckContinue())
                LibrarianActions(library);
        }

        static void Main(string[] args)
        {
            Library library = new Library();

            Console.WriteLine("Welcome to our Library");
            while (true)
            {
                char userType = CheckUserType();

                if (userType == 'R')
                {
                    HandleUser(library, "Regular", NewRegularUser, OldRegularUser);
                }
                else if (userType == 'L')
                {
                    HandleUser(library, "Librarian", NewLibrarian, OldLibrarian);
                }
                else break;
            }
        }
    }
}
