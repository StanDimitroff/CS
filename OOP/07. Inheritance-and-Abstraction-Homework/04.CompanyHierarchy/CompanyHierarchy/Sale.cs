﻿using System;

public class Sale : ISale
{
    private string productName;
    private DateTime date;
    private decimal price;

    public Sale(string productName, DateTime date, decimal price)
    {
        this.ProductName = productName;
        this.Date = date;
        this.Price = price;
    }

    public string ProductName
    {
        get
        {
            return this.productName;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(
                    "productName", "Product Name can not be null or empty!");
            }

            this.productName = value;
        }
    }

    public DateTime Date
    {
        get { return this.date; }
        set { this.date = value; }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price can not be negative!", "price");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Product Name:{0}, Date:{1:dd-MM-yyyy}, Price:{2:F2}", this.ProductName, this.Date, this.Price);
    }
}