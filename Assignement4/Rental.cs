using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement4
{
    public class Rental
    {
        public Customer Customer { get; }
        public Movie Movie { get; }
        public DateTime RentalDate { get; }

        public Rental(Customer customer, Movie movie)
        {
            Customer = customer;
            Movie = movie;
            RentalDate = DateTime.Now;
        }
    }
}
