using System;
using System.Collections.Generic;
using System.Net.Sockets;

public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to initialize the customer
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Public property for accessing the customer's name (read-only)
    public string Name => _name;

    // Public property for accessing the customer's address (read-only)
    public Address Address => _address;

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA(); // Calls the IsInUSA method of the Address class
    }
}