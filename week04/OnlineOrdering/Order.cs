using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor 
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); // Initialize empty product list.
    }

}