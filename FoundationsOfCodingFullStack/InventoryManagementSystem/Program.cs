using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static List<Product> inventory = new List<Product>();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n===== Inventory Management System =====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Stock");
            Console.WriteLine("3. View All Products");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;

                case "2":
                    UpdateStock();
                    break;

                case "3":
                    ViewProducts();
                    break;

                case "4":
                    RemoveProduct();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose 1-5.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Product product = new Product();

        Console.Write("Enter product name: ");
        product.Name = Console.ReadLine();

        Console.Write("Enter product price: ");
        product.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter stock quantity: ");
        product.Quantity = Convert.ToInt32(Console.ReadLine());

        inventory.Add(product);

        Console.WriteLine("Product added successfully!");
    }

    static void UpdateStock()
    {
        Console.Write("Enter product name to update: ");
        string name = Console.ReadLine();

        foreach (Product product in inventory)
        {
            if (product.Name.ToLower() == name.ToLower())
            {
                Console.Write("Enter new stock quantity: ");
                product.Quantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Stock updated successfully!");
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }

    static void ViewProducts()
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("No products in inventory.");
            return;
        }

        Console.WriteLine("\n===== Product List =====");

        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine($"Product #{i + 1}");
            Console.WriteLine($"Name: {inventory[i].Name}");
            Console.WriteLine($"Price: ${inventory[i].Price:F2}");
            Console.WriteLine($"Quantity: {inventory[i].Quantity}");
            Console.WriteLine("----------------------");
        }
    }

    static void RemoveProduct()
    {
        Console.Write("Enter product name to remove: ");
        string name = Console.ReadLine();

        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].Name.ToLower() == name.ToLower())
            {
                inventory.RemoveAt(i);
                Console.WriteLine("Product removed successfully!");
                return;
            }
        }

        Console.WriteLine("Product not found.");
    }
}