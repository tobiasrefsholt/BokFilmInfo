namespace BokFilmInfo;

public class Book
{
    private string _title;
    private string _description;
    private string _author;
    private int _year;

    public Book(string title, string description, string author, int year)
    {
        _title = title;
        _description = description;
        _author = author;
        _year = year;
    }

    public void ShowDetails()
    {
        Console.Clear();
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine(_author);
        Console.WriteLine(_year);
        Console.WriteLine();
        Console.ReadKey();
    }

    public void Show(int index)
    {
        Console.WriteLine($"({index + 1}) {_title} - {_author} - {_year}");
    }
}