using System;
using System.Collections.Generic;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor to initialize the product
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Public properties (getters only, no setters to protect encasuplation)
    public string Name => _name;
    public string ProductId => _productId;
    public double Price => _price;
    public int Quantity => _quantity;

    // Method to calculate the total cost of this product
    public double TotalCost()
    {
        return _price * _quantity;
    }
}