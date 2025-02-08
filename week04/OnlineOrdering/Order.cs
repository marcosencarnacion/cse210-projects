using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double shippingCost;

        if (_customer.IsInUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        double totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        totalCost += shippingCost;
        return totalCost;

    }

    public string GetPackingLabel()
    {

    }

    public string GetShippingLabel()
    {

    }
}