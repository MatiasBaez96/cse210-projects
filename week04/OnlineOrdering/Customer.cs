public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
      _name = name;
      _address = address;
    }
    public bool CustomerLocation()
    {           
        _address.DetermineLocation();
        bool isInCountry = _address.IsInCountry();
        return isInCountry;
    } 
    public string DisplayText()
    {  
       return $"{_name}\n {_address.DisplayText()}"; 
    }
}