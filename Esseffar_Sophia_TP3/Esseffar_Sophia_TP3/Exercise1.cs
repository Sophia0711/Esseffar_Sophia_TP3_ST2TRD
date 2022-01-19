using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Esseffar_Sophia_TP3
{
    public static class Exercise1
    {
        public static void queries()
        {
            var movies = new MovieCollection().Movies;

            //

            var oldmovie = movies.OrderBy(movies => movies.ReleaseDate).First().Title;

            Console.WriteLine(oldmovie);

            //

            var total = movies.Count();

            Console.WriteLine(total);

            //

            var counte = movies.Count(movie => movie.Title.Contains("e"));

            Console.WriteLine(counte);

            //

            int nb = 0;
            foreach (var movie in movies)
            {
                nb += movie.Title.Count(movie => movie == 'f');
            }

            Console.WriteLine(nb);

            //

            var budget = movies.OrderBy(movies => movies.Budget).Last().Title;

            Console.WriteLine(budget);

            //

            var bo = movies.OrderBy(movies => movies.BoxOffice).First().Title;

            Console.WriteLine(bo);

            //

            var reverse = movies.OrderByDescending(movies => movies.Title).Take(11);

            foreach (var movie in reverse)
            {
                Console.WriteLine(movie.Title);
            }

            //


            var before = movies.Count(movie => movie.ReleaseDate < new DateTime(1980));

            Console.WriteLine(before);

            //


            //

            var letters = movies
                .Where(movie => (movie.Title.Contains("H")) || (movie.Title.Contains("W")))
                .Where(movie => !((movie.Title.Contains("I")) || (movie.Title.Contains("T"))));

            foreach (var movie in letters)
            {
                Console.WriteLine(movie.Title);
            }

            //

            var averageBudget = movies.Average(movie => movie.Budget);
            var averageBox = movies.Average(movie => movie.BoxOffice);

            Console.WriteLine(averageBudget);
            Console.WriteLine(averageBox);
        }
    }
}
