using System;
using System.Collections.Generic;

class Basket
{
    public decimal total_price = 0.00m;

    public List<Product> CreateBasket()
    {
        List<Product> basket = new List<Product>();
        return basket;

    }

    public void AddToBasket(Product prod, List<Product> basket)
    {
        basket.Add(prod);
    }

    public void ViewItemsInBasket(List<Product> basket)
    {
        foreach (Product prod in basket)
        {
            Console.Write(prod.name + ", ");
        }
    }

    public decimal DisplayPrice(List<Product> basket, decimal total_price)
    {
        foreach(Product prod in basket)
        {
            total_price =+ prod.price;
        }

        return total_price;
    }
}