using System.Dynamic;
using System.Runtime.CompilerServices;

public class Address {
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    
    public bool IsUsa()
    {
        if (_country == "USA")
        {
            return true; 
        }
        else 
        {
            return false;
        }
    }

    public void GetAddress()
    {
        Console.WriteLine($"Address || street: {_streetAddress}, city: {_city}, State: {_state}, Country: {_country}.");
    }
}
// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)