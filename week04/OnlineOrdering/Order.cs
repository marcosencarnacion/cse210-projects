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

    // Public property for _products (read-only, products can be added via method)
    public List<Product> Products => _products;

    // Public property for _customer (only get, no set to prevent external modification)
    public Customer Customer => _customer;

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate the total price (including shipping)
    public double CalculateTotalPrice()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.TotalCost(); // Calls TotalCos() method of Product
        }

        
    }

}