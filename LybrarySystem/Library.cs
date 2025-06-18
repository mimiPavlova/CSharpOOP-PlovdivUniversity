using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LybrarySystem;

public class Library
{
    public List<Book> Books;
    public Library()
    {
        Books = new List<Book>();
    }
    public void AddBook(Book book)
    {
        if (Books.Any(b=>b.Title==book.Title&&b.Author==book.Author))
        {
            Console.WriteLine("Book alredy exists");
        }
        else
        {
            Books.Add(book);
            Console.WriteLine("Book added");
        }
    }
    public void RemoveBook(string title, string authour)
    {
        Book book = Books.FirstOrDefault(b => b.Title==title&&b.Author==authour);
        if (book!=null)
        {
            Books.Remove(book);
        }
        else
        {
            Console.WriteLine("book doesn't exists in the library");
        }
    }

    public void DisplayBooks()
    {
        if (Books.Count==0) Console.WriteLine("Library is empty");
        foreach (Book book in Books)
        {
            Console.WriteLine($"{book.Title} --- {book.Author}");
        }
    }

}
