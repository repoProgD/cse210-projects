public class Customer
{
    string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool isInUSA()
    {
        return _address.IsInUSA();
    }

    public string getAddressString()
    {
        return $"{_name}\n{_address.getFullAddress()}";
    }
}