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

        // Determine the shipping cost
        double shippingCost = _customer.IsInUSA ? 5m : 35m;
        return total + shippingCost;
    }

    // Method to generate packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";
        foreach (Product product in _products)
        {
            label += $"{product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    // Method to generate shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label: \n{_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }
}