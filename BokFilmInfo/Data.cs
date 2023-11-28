using Microsoft.VisualBasic;

namespace BokFilmInfo;

public class Data
{
    private static List<Book> _books = new List<Book>();

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
        Console.Write("Trykk på noe for å fortsette");
        Console.ReadKey();
    }
}