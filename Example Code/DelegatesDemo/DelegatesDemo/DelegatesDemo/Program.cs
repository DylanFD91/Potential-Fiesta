using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Calculator calculator = new Calculator();

            calculator.PrintResult(10, 20, calculator.AddTwoNumbers);

            calculator.PrintResult(10, 20, calculator.MultiplyTwoNumbers);

            //*****************************************************************************************

            List<int> grades = new List<int>() { 100, 85, 97, 61, 55, 89 };
            IEnumerable<int> result = GradeChecker.CheckGrades(grades, GradeChecker.LessThanEighty);
            foreach (int grade in result)
            {
                Console.WriteLine(grade);
            }

            //*****************************************************************************************

            MovieLibrary movieLibrary = new MovieLibrary();
            List<Movie> movies = movieLibrary.GetMovies();
            List<Movie> hourAndAHalfMovieRunTime = movies.FindAll(m => m.runTime > 90);
            foreach (var movie in hourAndAHalfMovieRunTime)
            {
                Console.WriteLine(movie.title);
            }

            var ninetyMinuteMovies = movies.Where(m => m.runTime >= 90);
            var ninentyMinuteMoviesSorted = ninetyMinuteMovies.OrderBy(m => m.title);

            //string name = "mike";
            //var printer = PrintResult;

            //printer();
        }


        //m => m.runTime >= 90
        static bool CheckEachMovie(Movie m)
        {
            if(m.runTime >= 90)
            {
                return true;
            }
            return true;
        }
    }
}
