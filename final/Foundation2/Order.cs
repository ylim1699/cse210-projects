using System.Net.Http.Headers;

public class Order {
    List<Product> _products = new List<Product>();
    List<Customer> _customers = new List<Customer>();

    public Order (List<Product> products, List<Customer> customer)
    {
        _products = products;
        _customers = customer;
    }

    public double GetTotalCost()
    {
        double productCost = 0;
        foreach (Customer customer in _customers)
        {
            bool countryOrigin = customer.IsUsa();
            if (countryOrigin == true)
            {
                foreach (Product product in _products)
                {
                    double costOfEachProduct = product.GetTotalCost();
                    productCost += costOfEachProduct;
                }
                productCost+=5;
            }
            else if (countryOrigin == false)
            {
                foreach (Product product in _products)
                {
                    double costOfEachProduct = product.GetTotalCost();
                    productCost += costOfEachProduct;
                }
                productCost+=35;
            }
        }
        return productCost;
    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product Name: {product.GetName()}");
            Console.WriteLine($"Product ID: {product.GetID()}");
            Console.WriteLine("");
        }
    }

    public void Shippinglabel()
    {
        foreach (Customer customer in _customers)
        {
            Console.WriteLine($"Customer Name: {customer.GetName()}");
            customer.GetAddress();
            Console.WriteLine("");
        } 
    }
}

// Contains a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
// The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer