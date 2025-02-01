using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = CreateOrders();
        DisplayOrders(orders);
    }

    static List<Order> CreateOrders()
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        Product product1 = new Product("Donuts", "GP001", 299.99, 1);
        Product product2 = new Product("Nuclear Reactors for Dummies", "WP002", 19.99, 3);
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        orders.Add(order1);

        Address address2 = new Address("456 Oak Ave", "Shelbyville", "ON", "Canada");
        Customer customer2 = new Customer("Jane Doe", address2);
        Product product3 = new Product("Super Phone DELUXE", "SP003", 799.99, 1);
        Product product4 = new Product("Charger MAX", "CM004", 29.99, 2);
        Order order2 = new Order(customer2, new List<Product> { product3, product4 });
        orders.Add(order2);

        return orders;
    }

    static void DisplayOrders(List<Order> orders)
    {
        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}
