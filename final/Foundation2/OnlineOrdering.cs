using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Numerics;

class Product
{
    private string name;
    private string productId;
    private decimal pricePerUnit;
    private int quanity;

    public Product(string name, string productId, decimal pricePerUnit, int quanity)
    {
        this.name = name;
        this.productId = productId;
        this.pricePerUnit = pricePerUnit;
        this.quanity = quanity;
    }

    public string GetName() => name;
    public string GetProductId() => productId;
    public decimal GetPricePerUnit() => pricePerUnit;
    public int GetQuanity() => quanity;

    public decimal GetTotalCost()
    {
        return pricePerUnit * quanity;
    }
}

class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public string GetFormatAddress()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
    public bool IsInUSA()
    {
        return country.Trim().ToLower() == "usa";

    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
    public string GetName() => name;
    public Address GetAddress() => address;
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}

class Order
{
    private List<Product> products;
    private Customer customer;
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public decimal GetTotalCost()
    {
        decimal productTotal = 0;

        foreach (var product in products)
        {
            productTotal += product.GetTotalCost();
        }

        if (discountCode != null)
        {
            decimal discountAmount = productTotal * discountCode.GetDiscountPercent();
            productTotal -= discountAmount;
        }
        decimal shipping = customer.IsInUSA() ? 5 : 35;
        return productTotal + shipping;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFormatAddress}";
    }
    private DiscountCode discountCode;

    public void ApplyDiscountCode(DiscountCode code)
    {
        discountCode = code;
    }

}

class DiscountCode
{
    private string codeName;
    private decimal discountPercent;
    public DiscountCode(string codeName, decimal discountPercent)
    {
        this.codeName = codeName;
        this.discountPercent = discountPercent;
    }
    public string GetCodeName() => codeName;
    public decimal GetDiscountPercent() => discountPercent;
}

class Program
{
    static void Main()
    {
        Address addr1 = new Address("123 Berry St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Connor Allison", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("HDMI cable", "U1001", 6.99m, 4));
        order1.AddProduct(new Product("XBOX", "W2450", 260m, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine(new string('-', 50));

        Address addr2 = new Address("456 Pine Rd", "Toronto", "ON", "Canada");

    }
}



