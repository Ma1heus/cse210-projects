using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1000, 1));
        order1.AddProduct(new Product("Mouse", "P002", 50, 2));

        // Order 2 (International)
        Address address2 = new Address("456 King St", "Curitiba", "PR", "Brazil");
        Customer customer2 = new Customer("Maria Silva", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "P003", 100, 1));
        order2.AddProduct(new Product("Monitor", "P004", 300, 1));

        // Display Order 1
        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}");

        // Display Order 2
        Console.WriteLine("\nORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}