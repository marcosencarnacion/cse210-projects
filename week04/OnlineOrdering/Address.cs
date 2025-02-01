using System;
using System.Collections.Generic;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructor to initialize the address
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // Public properties for access (getters only, no setters to protect encasulaption)
    public string StreetAddress => _streetAddress;
    public string City => _city;
    public string StateOrProvince => _stateOrProvince;
    public string Country => _country;

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
}