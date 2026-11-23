using System;

class Program
{
    static void Main(string[] args)
    {   
        Address address = new Address(3438, "Provo", "Utah", "EE.UU");
        Customer customer1 = new Customer("Matias", address);
        Order order = new Order(customer1);
        
        Address address2 = new Address(3438, "Lujan", "Buenos Aires", "Arg");
        Customer customer2 = new Customer("Gabriel", address2);
        Order order2 = new Order(customer2);
       
        Product playStation = new Product("Ps5", 4567, 600, 2);
        Product sega = new Product("Sega", 4566, 20, 2);
        
        order.AddProduct(playStation);
        order.AddProduct(sega);
        order.CalculateTotalOrder();
        Console.WriteLine($"{order.DisplayLabel()}");
        
        order2.AddProduct(sega);
        order2.CalculateTotalOrder();
        Console.WriteLine($"{order2.DisplayLabel()}");

        //ANOTAR EN LIBRETA:
        //El 'Console.WriteLine' es mejor hacerlo fuera de las clases
        //o metodos internos, es mejor hacerlo en el mMain o Program.cs,
        //de lo contrario los metodos internos se vuelven menos reutilizables

        //TAMBIEN ANOTAR: cuando usar getters, solo cuando devuelve
        //un unico valor y no tiene logica como condicionales, etc.
    }
}