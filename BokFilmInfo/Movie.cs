using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokFilmInfo
{
    internal class Movie
    {
        private string _title;
        private string _description;
        private string _director;
        private int _year;
        private List<string> _actors;

        // private static List<string> _actors = new();
        public Movie(string title, string description, string director, int year, List<string> actors)
        {
            _title = title;
            _description = description;
            _director = director;
            _year = year;
            _actors = actors;
        }

        public void ShowDetails()
        {
            Console.Clear();
            Console.WriteLine(_title);
            Console.WriteLine(_description);
            Console.WriteLine(_director);
            Console.WriteLine(_year);
            Console.WriteLine("Skuespillere:");
            foreach (var actor in _actors)
            {
                Console.WriteLine("- ".PadLeft(15) + actor);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public void Show(int index)
        {
            Console.WriteLine($"({index + 1}) {_title} - {_director} - {_year}");
        }
    }
}
