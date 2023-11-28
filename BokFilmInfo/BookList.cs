using Microsoft.VisualBasic;
using System;

namespace BokFilmInfo;

public class BookList
{
    private static List<Book> _books = new();

    public static void AddData()
    {
        _books.Add(new Book("Bibelen", "Gudegreier", "Gud", 0));
        _books.Add(new Book("Bibelen2", "Mer gudegreier", "Gud", 0));
        _books.Add(new Book("Bibelen3", "Enda mer gudegreier", "Gud", 0));
    }

    public static void ShowBooks()
    {
        Console.Clear();
        for (var index = 0; index < _books.Count; index++)
        {
            var book = _books[index];
            book.Show(index);
        }
        Console.WriteLine("Velg en bok");
        var input = Convert.ToInt32(Console.ReadLine());
        if ((input < _books.Count))
        {
            var book = _books[input -1];
            book.ShowDetails();
        }
    }

    public static void NewBook()
    {
        Console.Clear();
        Console.WriteLine("Hva er tittelen på din nye bok?");
        var titleInput = Console.ReadLine();
        Console.WriteLine("Forfattern av boka?");
        var authorInput = Console.ReadLine();
        Console.WriteLine("Beskrivelse av boka?");
        var descriptionInput = Console.ReadLine();
        Console.WriteLine("År boka kom ut");
        var yearInput = Convert.ToInt32(Console.ReadLine());
        var thisBook = new Book(titleInput, descriptionInput, authorInput, yearInput);
        _books.Add(thisBook);
        Console.Clear();
        thisBook.ShowDetails();
    }
}