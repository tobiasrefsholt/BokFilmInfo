// See https://aka.ms/new-console-template for more information

using BokFilmInfo;

BookList.AddData();
MovieList.AddData();

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Legg til bok");
    Console.WriteLine("2. Legg til film");
    Console.WriteLine("3. Vis bøker");
    Console.WriteLine("4. Vis filmer");
    var input = Console.ReadKey().Key;
    switch (input)
    {
        case ConsoleKey.D1:
        {
            BookList.NewBook();
            break;
        }
        case ConsoleKey.D2:
        {
            MovieList.NewMovie();
            break;
        }
        case ConsoleKey.D3:
        {
            BookList.ShowBooks();
            break;
        }
        case ConsoleKey.D4:
        {
            MovieList.ShowMovies();
            break;
        }
        default:
            Console.Clear();
            Console.WriteLine("Ugyldig input!");
            Console.ReadKey();
            break;
    }
    Console.WriteLine(input);
}