// See https://aka.ms/new-console-template for more information

using BokFilmInfo;

Data.AddData();

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
            Console.WriteLine("Test");
            break;
        }
        case ConsoleKey.D2:
        {
            Console.WriteLine("Test");
            break;
        }
        case ConsoleKey.D3:
        {
            Data.ShowBooks();
            break;
        }
        case ConsoleKey.D4:
        {
            Console.WriteLine("Test");
            break;
        }
    }
    Console.WriteLine(input);
}