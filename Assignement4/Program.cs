using Assignement4;
using System.Xml.Serialization;




namespace Assignement4 { 

    class Program
    {
        static void Main(string[] args) {


            RentalService rentalService = new RentalService();

            // Adding movies
            rentalService.AddMovie("Inception", "Sci-Fi");
            rentalService.AddMovie("The Godfather", "Drama");
            rentalService.AddMovie("The Dark Knight", "Action");

            // Adding customers
            rentalService.AddCustomer("Gamal Moemen");
            rentalService.AddCustomer("Ahmed Mohamed");

            while (true)
            {
                Console.WriteLine("\nMovie Rental Service");
                Console.WriteLine("1. Rent a movie");
                Console.WriteLine("2. Return a movie");
                Console.WriteLine("3. Display available movies");
                Console.WriteLine("4. Display customer rentals");
                Console.WriteLine("5. Display Rentail Details");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter customer name: ");
                        string rentCustomer = Console.ReadLine();
                        Console.Write("Enter movie title: ");
                        string rentMovie = Console.ReadLine();
                        if (rentalService.RentMovie(rentCustomer, rentMovie))
                        {
                            Console.WriteLine("Movie rented successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to rent the movie.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter customer name: ");
                        string returnCustomer = Console.ReadLine();
                        Console.Write("Enter movie title: ");
                        string returnMovie = Console.ReadLine();
                        if (rentalService.ReturnMovie(returnCustomer, returnMovie))
                        {
                            Console.WriteLine("Movie returned successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to return the movie.");
                        }
                        break;

                    case "3":
                        rentalService.DisplayAvailableMovies();
                        break;

                    case "4":
                        Console.Write("Enter customer name: ");
                        string customerName = Console.ReadLine();
                        rentalService.DisplayCustomerRentals(customerName);
                        break;
                    case "5":
                        rentalService.DisplayRentailDetails();
                        break;

                    case "6":
                        Console.WriteLine("Thank you for using the Movie Rental Service!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
    }

