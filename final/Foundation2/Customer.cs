using System.Runtime.CompilerServices;

public class Customer {
    private string _customerName;
    private Address _address = new Address();

    public bool IsUsa()
    {
        return _address.IsUsa();
    }
// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
}