using System;

public class Order
{
    private List<string> _products;
    private string _customer;

    public Order(string customer)
    {
        _products = new List<string>();
        _customer = customer;
    }

    public double CalculateTotalCost()
    {

    }

    public string GetPackingLabel()
    {

    }

    public string GetShippingLabel()
    {

    }
}