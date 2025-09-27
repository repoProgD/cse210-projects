public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void addProduct(Product product)
    {
        _products.Add(product);
    }

    public double calculateTotalCost()
    {
        double total = 0;
        foreach (Product p in _products) {
            total += p.getTotalCost();
        }
        if (_customer.isInUSA())
        {
            total += 5;
        }

        else
        {
            total += 35;
        }

        return total;
    }


    public string getPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product p in _products)
        {
            label += " " + p.GetPackingInfo() + "\n";
        }

        return label;
    }
    public string getShippingLabel()
    {
        return "Shipping Label:\n " + _customer.getAddressString();
    }
}