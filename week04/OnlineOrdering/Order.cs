using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double shippingCost;
        double totalCost = 0;

        if (_customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }


        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += shippingCost;
        return totalCost;

    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
    }
}