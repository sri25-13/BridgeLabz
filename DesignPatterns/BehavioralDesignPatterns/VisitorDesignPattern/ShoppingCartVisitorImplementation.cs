using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
   public class ShoppingCartVisitorImplementation :IShoppingCartVisitor
    {
        public int visit(Book book)
        {
            int cost = 0;
            //apply 5$ discount if book price is greater than 50 
            if (book.getPrice() > 50)
            {
                cost = book.getPrice() - 5;
            }
            else
                cost = book.getPrice();

           Console.WriteLine("Book ISBN::" + book.getIsbnNumber() + " cost =" + cost);
            return cost;
        }

     
    public int visit(Fruit fruit)
        {
            int cost = fruit.getPricePerKg() * fruit.getWeight();
            Console.WriteLine(fruit.getName() + " cost = " + cost);
            return cost;
        }

    }
}

