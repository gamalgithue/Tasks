using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement4
{
    public class RentalService
    {
        private List<Movie> movies;
        private List<Customer> customers;
        private List<Rental> rentals;

        public RentalService()
        {
            movies = new List<Movie>();
            customers = new List<Customer>();
            rentals = new List<Rental>();

        }

        public void AddMovie(string title, string genre)
        {
            movies.Add(new Movie(title, genre));
        }

        public void AddCustomer(string name)
        {
            customers.Add(new Customer(name));
        }

        public bool RentMovie(string customerName, string movieTitle)
        {
            Customer customer = customers.Find(c => c.Name == customerName);
            Movie movie = movies.Find(m => m.Title == movieTitle);

            if (customer != null && movie != null && customer.RentMovie(movie))
            {
                rentals.Add(new Rental(customer, movie));
                return true;
            }
            return false;
        }

        public bool ReturnMovie(string customerName, string movieTitle)
        {
            Customer customer = customers.Find(c => c.Name == customerName);
            Movie movie = movies.Find(m => m.Title == movieTitle);

            if (customer != null && movie != null)
            {
                return customer.ReturnMovie(movie);
            }
            return false;
        }

        public void DisplayAvailableMovies()
        {
            Console.WriteLine("Available Movies:");
            foreach (var movie in movies)
            {
                if (movie.IsAvailable)
                {
                    Console.WriteLine($"- {movie.Title} ({movie.Genre})");
                }
            }
        }
        public void DisplayCustomerRentals(string customerName)
        {
            Customer customer = customers.Find(c => c.Name == customerName);
            if (customer != null)
            {
                Console.WriteLine($"Movies rented by {customer.Name}:");
                foreach (var movie in customer.RentedMovies)
                {
                    Console.WriteLine($"- {movie.Title}");
                }
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
        }


        public void DisplayRentailDetails()
        {

            Console.WriteLine("All Rental Details:");

            foreach (var rental in rentals)
            {
                Console.WriteLine($"Customer: {rental.Customer.Name}");
                Console.WriteLine($"Movie: {rental.Movie.Title}");
                Console.WriteLine($"Rental Date: {rental.RentalDate}");
                Console.WriteLine("-----------------------------");
            }
        }



    }
}

