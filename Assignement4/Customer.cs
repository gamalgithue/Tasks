using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement4
{
    public class Customer
    {
        private string name;
        private List<Movie> rentedMovies;

        public string Name { get => name; }
        public IReadOnlyList<Movie> RentedMovies { get => rentedMovies.AsReadOnly(); }

        public Customer(string name)
        {
            this.name = name;
            this.rentedMovies = new List<Movie>();
        }

        public bool RentMovie(Movie movie)
        {
            if (movie.Rent())
            {
                rentedMovies.Add(movie);
                return true;
            }
            return false;
        }

        public bool ReturnMovie(Movie movie)
        {
            if (rentedMovies.Remove(movie))
            {
                movie.Return();
                return true;
            }
            return false;
        }
    }

}

