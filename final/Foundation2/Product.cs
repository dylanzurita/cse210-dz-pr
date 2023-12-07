public class Product
{
    private int _productId;
    private string _prodName;
    private double _price;
    private int _quantity;

    public Product ( string prodName, int productId, double price, int quantity)
    {
        _productId = productId;
        _prodName =prodName;
        _price = price;
        _quantity = quantity;
    }

    public double CalcPrice ()
    {
        return _price * _quantity;
    }

    public string ProdInfo ()
    {
        return $"{_productId} = {_prodName}";
    }
}