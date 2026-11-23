public class Address
{
   private int _street;
   private string _city;
   private string _state;
   private string _country;

   private bool _isInCountry;
   
   public Address(int street, string city, string state, string country)
    {
     _street = street;
     _city = city;
     _state = state;
     _country = country;   
    } 
 
   public bool IsInCountry()
   {   
    return _isInCountry;
   } 
   
   public void DetermineLocation()
   {
     if(_country == "EE.UU")
     {
        _isInCountry = true;       
     }
     else
     {
        _isInCountry = false;       
     }
   }

   public string DisplayText()
   {
    // devolver todos los datos en una unica cadena de texto,
    // usando saltos de linea si es necesario
    return $"Street: {_street}\n City: {_city}\n State: {_state}\n Country: {_country}";
   }
}