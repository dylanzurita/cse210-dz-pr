using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Javier Loyola", "Quito", "Pichincha", "Ecuador");
        Customer cust1 = new Customer ("Dylan Zurita", address1);
        Product prod11 = new Product ("Water", 101, 1.50, 6);
        Product prod12 = new Product ("Brownies", 201, 3, 3);
        Order ord1 = new Order (cust1);
        ord1.List(prod11);
        ord1.List(prod12);
        ord1.GetShippingLabel();
        Console.WriteLine();
        ord1.GetPackingLabel();
        Console.WriteLine();


        Address address2 = new Address("Coronet Way", "Charlotte", "North Carolina", "USA");
        Customer cust2 = new Customer ("John Doe", address2);
        Product prod21 = new Product ("Protein Jar", 421, 15, 1);
        Product prod22 = new Product ("Maple Syrup", 602, 3.50,1);
        Order ord2 = new Order (cust2);
        ord2.List(prod21);
        ord2.List(prod22);
        Console.WriteLine("--------------------------------------");
        ord2.GetShippingLabel();
        Console.WriteLine();
        ord2.GetPackingLabel();
        Console.WriteLine();

         Address address3 = new Address("Napoleon st", "Paris", "Hauts-de-France", "France");
        Customer cust3 = new Customer ("Domenic de Coco", address3);
        Product prod31 = new Product ("Blue cheese", 210, 10, 1);
        Product prod32 = new Product ("Workbench", 1001, 120.90,1);
        Order ord3 = new Order (cust3);
        ord3.List(prod31);
        ord3.List(prod32);
        Console.WriteLine("--------------------------------------");
        ord3.GetShippingLabel();
        Console.WriteLine();
        ord3.GetPackingLabel();
    }
}