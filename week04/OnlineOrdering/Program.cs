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
        Product product1 = new Product("Laptop", 101, 999.99, 2);
        Product product2 = new Product("Smartphone", 102, 499.99, 1)
    }
}