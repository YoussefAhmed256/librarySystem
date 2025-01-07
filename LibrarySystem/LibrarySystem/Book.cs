using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibrarySystem
{
    public class Book
    {
        public int? Year { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(int? year, string title, string author)
        {
            Year = year;
            Title = title;
            Author = author;
        }

        public static bool operator ==(Book a, Book b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Equals(b);
        }
        public static bool operator !=(Book a, Book b)
        {
            return !(a==b);
        }
        public override string ToString()=> $"book Title: {Title}, book Author {Author}, published year {Year}";
        public override bool Equals(object obj) => obj is Book other && Title == other.Title && Author == other.Author && Year == other.Year;
        public override int GetHashCode()=> HashCode.Combine(Title, Author, Year);
        
    }
}
