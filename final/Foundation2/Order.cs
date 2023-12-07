public class Order
{
    private Customer _customer;
    private List<Product> _product = new List<Product>();
    

    public Order (Customer customer)
    {
        _customer = customer;   
    }

    public void List (Product product)
    {
        _product.Add(product);
    }
    public double CalcTotalCost ()
    {
        double total = 0;

        foreach (Product product in _product)
        {
            total += product.CalcPrice();
        }

        if (_customer.IsCustomerInUSA())
        {
            return total + 5;
        }
        else 
        {
            return total + 35;
        }
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _product)
        {
            Console.WriteLine(product.ProdInfo());

        }
        Console.WriteLine ($"Total : ${CalcTotalCost()}");
    }

    public void GetShippingLabel ()
    {
        Console.WriteLine(_customer.InfoCustomer());
    }
}