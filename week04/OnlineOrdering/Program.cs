// Create the address for the second customer
Address address2 = new Address(
    "456 Avenida Presidente Vargas",
    "Belém",
    "Pará",
    "Brazil"
);

// Create the second customer
Customer customer2 = new Customer("Maria Silva", address2);

// Create the second order
Order order2 = new Order(customer2);

// Create two products for the second order
Product product4 = new Product("Headphones", "P004", 75.00, 2);
Product product5 = new Product("USB Cable", "P005", 10.00, 3);

// Add products to the second order
order2.AddProduct(product4);
order2.AddProduct(product5);

// Display the second order information
Console.WriteLine();
Console.WriteLine("========== ORDER 2 ==========");
Console.WriteLine();

Console.WriteLine(order2.GetPackingLabel());

Console.WriteLine(order2.GetShippingLabel());

Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}");