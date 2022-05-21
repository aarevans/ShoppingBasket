using System;

class Product
{
    public string name;
    public string description;
    public decimal price;

     public Product(string new_name, string new_description, decimal new_price)
    {
        this.name = new_name;
        this.description = new_description;
        this.price = new_price;
    }
}