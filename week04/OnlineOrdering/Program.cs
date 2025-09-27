using System;

class Program
{
    static void Main(string[] args)
    {   /*Addresses for the customers*/
        Address address1 = new Address(
            "123 1st Avenue",
            "New York",
            "NY",
            "USA"
        );

        Address address2 = new Address(
            "1270 Avenida Crovara",
            "Buenos Aires",
            "BS. AS.",
            "ARG"

        );

        /* The customer itself*/
        Customer customer1 = new Customer("Clint Eastwood", address1);
        Customer customer2 = new Customer("Luis Luque", address2);

        /*order for the customer1*/
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        /*Products in the order*/
        Product product1 = new Product("Graphic Card X8500", "IdP001", 1100, 1);
        Product product2 = new Product("Keyboard Alpha Pro-Max", "IdP002", 100, 2);

        Product product3 = new Product("Mate Stanley", "IdP12001", 85, 10);
        Product product4 = new Product("Termo Stanley", "IdP12005", 100, 2);

        /*Adding products to  order1*/
        order1.addProduct(product1);
        order1.addProduct(product2);

        order2.addProduct(product3);
        order2.addProduct(product4);


        // Display order1

        Console.WriteLine(order1.getPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.getShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.calculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine("------------------------------------");


        // Display order2

        Console.WriteLine(order2.getPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.getShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.calculateTotalCost()}");
        Console.WriteLine();
        Console.WriteLine("------------------------------------");

    }
}