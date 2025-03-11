using System.Runtime.CompilerServices;

public class Customer {
    private string _customerName;
    private Address _address = new Address();

    public Customer()
    {}

    public Customer (string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool IsUsa()
    {
        return _address.IsUsa();
    }

    public string GetName()
    {
        return _customerName;
    }

    public void GetAddress()
    {
        Console.WriteLine(_address.GetAddress());
    }
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
}