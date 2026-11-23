using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("3438 S. 4421 W.", "Provo", "Utah", "USA");
        Customer customer1 = new Customer("Matias", address1);
        Order order1 = new Order(customer1);

        Address address2 = new Address("Alvarado 120 Ruta 25", "Lujan", "Buenos Aires", "Argentina");
        Customer customer2 = new Customer("Gabriel", address2);
        Order order2 = new Order(customer2);

        Product playStation = new Product("PS5", 4567, 600, 2);
        Product sega = new Product("Sega", 4566, 20, 2);
        Product xbox = new Product("Xbox Series X", 4568, 500, 1);
        Product control = new Product("Control extra", 4570, 45, 2);
        Product hdmi = new Product("Cable HDMI", 4571, 10, 3);

        order1.AddProduct(playStation);
        order1.AddProduct(sega);

        order2.AddProduct(xbox);
        order2.AddProduct(control);
        order2.AddProduct(hdmi);

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("----- PACKING LABEL -----");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("----- SHIPPING LABEL -----");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"TOTAL COST: ${order.CalculateTotalCost():0.00}");
        Console.WriteLine();
    }
}