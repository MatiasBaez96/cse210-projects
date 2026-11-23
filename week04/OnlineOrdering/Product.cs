public class Product
{
    public string _name{get; }
    public int _id{get; }
    public float _price{get; }
    public int _quantity{get; }

    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }  
    //no hay logica solo accedo a datos>asiqe puedo usar getter
}