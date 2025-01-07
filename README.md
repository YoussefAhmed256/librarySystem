## Library System README

### Project Title
Library Management System

### Introduction
The Library Management System is a console-based application designed to manage library operations efficiently. This system handles two primary types of users: regular users and librarians. Regular users can borrow, return, and view books, while librarians can manage the library by adding/removing books, borrowing books, and performing various administrative tasks.

### Table of Contents
1. [Installation](#installation)
2. [Usage](#usage)
3. [Features](#features)
4. [Dependencies](#dependencies)
5. [Configuration](#configuration)
6. [Documentation](#documentation)
7. [Examples](#examples)
8. [Troubleshooting](#troubleshooting)

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-repository/LibrarySystem.git
   ```

2. **Open the project in Visual Studio or any C# IDE.**

3. **Build the project** to restore the necessary packages and compile the application.

4. **Run the application** using your IDE or from the terminal:
   ```bash
   dotnet run
   ```

### Usage

Upon running the application, users will be prompted to select their role:

1. **Regular User Actions:**
   - Display all available books.
   - Borrow a book.
   - Return a borrowed book.

2. **Librarian Actions:**
   - Display all books in the library.
   - Borrow a book.
   - Add a new book to the library.
   - Remove a book from the library.
   - Return a borrowed book.

Both regular users and librarians must identify whether they are new or existing users, which involves entering their name, and for regular users, a library card number.

### Features

- **User Management:** Supports new and existing users (both regular users and librarians).
- **Book Management:** Add, remove, borrow, and return books.
- **User Role Management:** Differentiates between regular users and librarians with distinct capabilities.
- **Borrowing and Returning Books:** Both regular users and librarians can borrow or return books.
- **Validation:** Ensures users enter valid inputs (e.g., book details, user names, year of publication).
- **Reusability:** The program allows for repeated actions such as borrowing and returning books.

### Dependencies

- **.NET 5.0 or higher**: This project uses C# and runs on the .NET framework.
- **C# Standard Libraries**: The application uses built-in libraries such as `System`, `System.Collections.Generic`, `System.Linq`, etc.

### Configuration

There are no external configurations for this project. Configuration happens through user input, such as entering the type of user (regular user or librarian) and interacting with the library (adding books, borrowing books, etc.).

### Documentation

The system has the following core classes:

- **Library**: Manages the collection of books and users. Provides methods for adding, removing, borrowing, and displaying books.
- **Book**: Represents a book in the library with properties like `Title`, `Author`, and `Year`.
- **User**: The base class for all users (both regular users and librarians).
- **LibraryUser**: Derived from `User`, represents regular users who interact with books in the library.
- **Librian**: Derived from `User`, represents librarians who manage the library.
- **LibraryCard**: Represents a unique card number for a regular user.

### Examples

#### Example 1: Regular User Borrowing a Book

1. The user is prompted to enter whether they are a **new** or **old** user.
2. A new regular user enters their name and card number.
3. The user can then choose to borrow a book, display books, or return a borrowed book.

```bash
Welcome to our Library
Are you Librarian or Regular User (L/R):
R
Please enter your data:
Enter your name: Alice
Enter your card number: 1234
Welcome to our library, Alice!
You can display books (D), borrow a book (B), or return a book (Z).
Choose what you want: B
Enter details for the book you need:
Enter book title: C# Programming
Enter book author: John Doe
Enter book year: 2021
You borrowed this book successfully
```

#### Example 2: Librarian Adding a Book

1. The librarian enters their name and employee number.
2. They can choose to add a new book to the library.

```bash
Welcome to our Library
Are you Librarian or Regular User (L/R):
L
Please enter your data:
Enter your name: Bob
Enter your employee number: 5678
Welcome to our library, Bob!
You can display books (D), borrow a book (B), add a book (A), or remove a book (R).
Choose what you want: A
Enter details for the book to add:
Enter book title: Advanced C#
Enter book author: Jane Smith
Enter book year: 2020
This book has been added successfully.
```

### Troubleshooting

- **Error: "Book not found"**
  - Ensure the book you are trying to borrow or return is listed in the library’s collection.
  
- **Error: "Invalid year"**
  - Ensure that you enter a valid year when prompted for book details.

- **Error: "User does not exist"**
  - Ensure that you are entering the correct name for an existing user.

---

This README provides an overview of the Library Management System and should guide users through its setup, usage, and troubleshooting.
