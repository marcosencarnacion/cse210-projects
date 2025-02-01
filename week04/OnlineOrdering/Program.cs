using System;

class Program
{
    static void Main(string[] args)
    {
        // Sample addresses created
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("1 Apple Park Way", "Cupertino", "CA", "USA");

        // Sample customers created
        Customer customer1 = new Customer("Emily Johnson", address1);
        Customer customer2 = new Customer("Michael Smith", address2);
        Customer customer3 = new Customer("Olivia Martinez", address3);

        // Sample products created
        Product product1 = new Product("Laptop", "LAP123456", 999.99, 2);
        Product product2 = new Product("Smartphone", "PHN654321", 499.99, 1);
        Product product3 = new Product("Headphones", "HDP789012", 109.99, 3);
        Product product4 = new Product("Tablet", "TAB234567", 299.99, 4);
        Product product5 = new Product("Smartwatch", "SWT345678", 199.99, 5);
        Product product6 = new Product("Bluetooth Speaker", "BSP456789", 149.99, 6);

        // Create orders and add products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product5);

        Order order2 = new Order(customer2);
        order2.AddProduct(product6);
        order2.AddProduct(product4);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product1);
        order3.AddProduct(product4);
        order3.AddProduct(product2);

        // Display order details for Order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}\n");

        // Display order details for Order 2
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}\n");

        // Display order details for Order 3
        Console.WriteLine("Order 3:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order3.CalculateTotalPrice():F2}\n");
    }
}