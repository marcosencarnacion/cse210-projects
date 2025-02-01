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

    
}