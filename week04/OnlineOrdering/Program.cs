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
    }
}