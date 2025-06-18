using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LybrarySystem;

public class Book
{
    public string Title { get; }
    public string Author { get; }

    public Book(string  title, string author)
    {
        if(string.IsNullOrWhiteSpace(title))throw new ArgumentNullException("title cannot be null");
        this.Title = title;
        if (string.IsNullOrWhiteSpace(author)) throw new ArgumentNullException("authour cannot be null");
        this.Author = author;
    }
}
