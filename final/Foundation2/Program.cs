using System;

class Program
{
    static void Main(string[] args)
    {
        Address home1 = new Address("123 north", "Rexburg,", "ID", "USA");
        Customer customer1 = new Customer("John", home1);
        Product product1a = new Product("Spoon", 12345, 2.5, 5);
        Product product1b = new Product("Fork", 23456, 1.5, 4);
        Product product1c = new Product("Knife", 34567, 3.2, 3);

        Order order1 = new Order(new List<Product>{product1a, product1b, product1c}, new List<Customer>{customer1});
        
        Address home2 = new Address("1000 SSangyong Rd","Busan","Gyeongsangnamdo","South Korea");
        Customer customer2 = new Customer("Yujin", home2);
        Product product2a = new Product("Fantasy book", 09876, 12.99, 2);
        Product product2b = new Product("Autobiography book", 98765, 24.99, 1);
        Product product2c = new Product("Textbook", 87654, 56.99, 4);

        Order order2 = new Order(new List<Product>{product2a, product2b, product2c}, new List<Customer>{customer2});

        order1.Shippinglabel();
        order1.PackingLabel(); 
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine("");

        Console.WriteLine("===============================================");

        order2.Shippinglabel();
        order2.PackingLabel(); 
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}

// Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, 
// // the shipping label, and the total price of the order, and display the results of these methods.            