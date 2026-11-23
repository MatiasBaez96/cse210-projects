public class Order
{
    private List<Product> _products = new();
    private Customer _customer;
    private float shippingCost;
    private float _total;
    public Order(Customer customer)
    {
       _customer = customer; 
    }
     public void AddProduct(Product product)
     {
        _products.Add(product);
     }
    public void CalculateTotalOrder()
    {
        // calcula costo total de la orden
        if(_customer.CustomerLocation())
        { 
            shippingCost = 5f;
            foreach(Product product in _products)
            {
              _total += product._price * product._quantity + shippingCost;
            }
            Console.WriteLine($"He is in the country");
        }
        else
        {
            shippingCost = 35f; 
            foreach(Product product in _products)
            {
              _total += product._price * product._quantity + shippingCost;
            }
            Console.WriteLine($"He is not in the country");
        }
    }

    //devuelve string: 
    // label 1: etiqueta de empaquetado
    // label 2: etiqueta de envio
    //devuelvo variables resultado y todo
    public string DisplayLabel()
    {   
        //para datos de Address uso DisplayFunction
        //para datos de Customer uso DisplayFunction
        //ANOTAR LIBRETA: uso display en estas dos clases porque
        //solo necesito leer la informacion
        //En 'Product.cs' uso getters porqe necesito hacer calculos
        //con esos datos.

        string productLabel = "";
        string customerLabel = $"{_customer.DisplayText()}";
        foreach(Product product in _products)
        {
          productLabel += $"\n Name: {product._name}\n Id: {product._id}";
        }
        return $"{customerLabel} {productLabel}\n Total: {_total}" ;
    }
}