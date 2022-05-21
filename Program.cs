using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] arg)
    {
        //Creates a new basket object and then generates a new_basket list
        Basket basket = new Basket();
        List<Product> new_basket = basket.CreateBasket();

        //Creates a new product object
        Product prod1 = new Product("bag","this is a bag", 20.00m);        
        Product prod2 = new Product("hat","this is a hat", 10.00m);       
        Product prod3 = new Product("scarf","this is a scarf", 15.00m);

        //Adds the new product object the the new_basket list
        basket.AddToBasket(prod1, new_basket);
        basket.AddToBasket(prod2, new_basket);
        basket.AddToBasket(prod3, new_basket);

        //Basket method to view the current products in the new_basket list
        basket.ViewBasket(new_basket);

    }
}
