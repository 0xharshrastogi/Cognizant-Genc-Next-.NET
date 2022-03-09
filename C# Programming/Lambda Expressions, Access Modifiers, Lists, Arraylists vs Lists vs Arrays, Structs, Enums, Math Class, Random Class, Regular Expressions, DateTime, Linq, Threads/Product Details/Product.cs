using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    private string productName;
    private string serialNumber;
    private DateTime purchaseDate;
    private double cost;

    public string ProductName { get => productName; set => productName = value; }
    public string SerialNumber { get => serialNumber; set => serialNumber = value; }
    public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
    public double Cost { get => cost; set => cost = value; }

    public Product(string productName, string serialNumber, DateTime purchaseDate, double cost)
    {
        this.ProductName = productName;
        this.SerialNumber = serialNumber;
        this.PurchaseDate = purchaseDate;
        this.Cost = cost;
    }

    public override string ToString()
    {
        return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", ProductName, SerialNumber, String.Format("{0:d}", PurchaseDate), Cost);
    }
}