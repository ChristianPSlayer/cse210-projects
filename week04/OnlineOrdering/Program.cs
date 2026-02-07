using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Products
            Product product1 = new Product("Ebike", 399.00, 2);
            Product product2 = new Product("Helmet", 50.0, 1);

            // Customers
            Address address1 = new Address("5186 8th road south st", "Arlington", "USA");
            Customer customer1 = new Customer("Luis", address1);

            Address address2 = new Address("43 nueva st", "Montreal", "Canada");
            Customer customer2 = new Customer("Alirio", address2);

            // Orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product1);
            order2.AddProduct(product2);

            // Display
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}");

            Console.WriteLine("\nOrder 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");
        }
    }
}