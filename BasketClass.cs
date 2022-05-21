using System;
using System.Collections.Generic;

class Basket
{

    public List<Product> CreateBasket()
    {
        List<Product> basket = new List<Product>();
        return basket;

    }

    public void AddToBasket(Product prod, List<Product> basket)
    {
        basket.Add(prod);
    }

    public void ViewBasket(List<Product> basket)
    {
        foreach (Product prod in basket)
        {
            Console.WriteLine(prod.name);
            Console.WriteLine(prod.description);
            Console.WriteLine(prod.price);
        }
        

    }
}