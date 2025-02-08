using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _productPrice;
    private int _productQuantity;

    public Product(string name, string productId, double productPrice, int productQuantity)
    {
        _name = name;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetTotalCost()
    {
        return _productPrice * _productQuantity;
    }
}