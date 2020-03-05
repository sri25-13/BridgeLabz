using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
  public  class ShoppingCartClient
    {
        public static void ShoppingCart()
        { 
        IItemElement[] items = new IItemElement[]{new Book(20, "1234"),
                              new Book(100, "5678"), new Fruit(10, 2, "Banana"),
                              new Fruit(5, 5, "Apple")};

        int total = calculatePrice(items);
        Console.WriteLine("Total Cost = "+total);
    }

    private static int calculatePrice(IItemElement[] items)
    {
        IShoppingCartVisitor visitor = new ShoppingCartVisitorImplementation();
        int sum = 0;
        foreach (IItemElement item in items)
        {
            sum = sum + item.accept(visitor);
        }
        return sum;
    }

}
}
