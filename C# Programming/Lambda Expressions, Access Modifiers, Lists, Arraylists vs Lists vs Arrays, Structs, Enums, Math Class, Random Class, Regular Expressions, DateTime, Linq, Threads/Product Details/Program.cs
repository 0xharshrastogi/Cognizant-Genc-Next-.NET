using System.Collections;
using System.IO;
using System;

public class Program
{
    public static Product parseProduct(string productstr)
    {
        var items = productstr.Split(",");

        var productName = items[0].Trim();
        var serialNumber = items[1].Trim();
        var purchaseDate = DateTime.ParseExact(items[2].Trim(), "dd-MM-yyyy", null);
        var cost = double.Parse(items[3].Trim());

        return new Product(productName, serialNumber, purchaseDate, cost);
    }

    public static void Display(ArrayList products)
    {
        Console.WriteLine(String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number", "Purchase Date", "Cost"));

        foreach (Product product in products) Console.WriteLine(product);
    }

    public static void Main(string[] args)
    {
        var filename = "input.csv";
        var readStream = new StreamReader(filename);
        var products = new ArrayList();

        while (readStream.Peek() >= 0)
        {
            var product = parseProduct(readStream.ReadLine());
            products.Add(product);
        }

        Display(products);
    }
}