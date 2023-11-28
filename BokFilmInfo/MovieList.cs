using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokFilmInfo
{
    internal class MovieList
    {
        private static List<Movie> _movies = new();
        
        public static void AddData()
        {
            _movies.Add(new Movie("Monty Python and the Holy Grail",
                "King Arthur and his Knights of the Round Table embark on a surreal, low-budget search for the Holy Grail, encountering many, very silly obstacles.",
                "Terry Gilliam, Terry Jones",
                1975,
                new List<string>{
                    "Graham Chapman", "John Cleese", "Eric Idle"}));
            _movies.Add(new Movie("The Meaning of Life",
                "The comedy team takes a look at life in all of its stages in their own uniquely silly way.",
                "Terry Jones",
                1983,
                new List<string> {
                "Graham Chapman", "John Cleese", "Eric Idle" }));
            _movies.Add(new Movie("Life of Brian",
                "Born on the original Christmas in the stable next door to Jesus Christ, Brian of Nazareth spends his life being mistaken for a messiah.",
                "Terry Jones",
                1979,
                new List<string> {
                    "Graham Chapman", "John Cleese", "Eric Idle" }));
        }

        public static void ShowMovies()
        {
            Console.Clear();
            for (var index = 0; index < _movies.Count; index++)
            {
                var movie = _movies[index];
                movie.Show(index);
            }
            Console.WriteLine("Velg en film");
            var input = Convert.ToInt32(Console.ReadLine());
            if ((input < _movies.Count))
            {
                var movie = _movies[input -1];
                movie.ShowDetails();
            }
        }

        public static void NewMovie()
        {
            var actorList = new List<string>();
            Console.Clear();
            Console.WriteLine("Hva er tittelen på din nye film?");
            var titleInput = Console.ReadLine();
            Console.WriteLine("Regissørn av filmen?");
            var directorInput = Console.ReadLine();
            Console.WriteLine("Beskrivelse av filmen?");
            var descriptionInput = Console.ReadLine();
            Console.WriteLine("År filmen kom ut");
            var yearInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vil du legge til skuespillere? (j/n)");
            var yesOrNoInput = Console.ReadLine();
            if (yesOrNoInput == "j")
            {
                while (true)
                {
                    var actorInput = Console.ReadLine();
                    if (actorInput == string.Empty)
                    {
                        break;
                    }
                    actorList.Add(actorInput);
                }
            }
            
            var thisBook = new Movie(titleInput, descriptionInput, directorInput, yearInput, actorList);
            _movies.Add(thisBook);
            Console.Clear();
            thisBook.ShowDetails();
        }
    }
}
