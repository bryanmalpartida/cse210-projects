public class Customer
{
    // Private member variables
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Getter for the customer's name
    public string GetName()
    {
        return _name;
    }

    // Getter for the customer's address
    public Address GetAddress()
    {
        return _address;
    }
}