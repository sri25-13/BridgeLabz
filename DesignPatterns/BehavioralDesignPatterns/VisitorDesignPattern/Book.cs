using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
   public class Book :IItemElement
    {
        private int price;
        private String isbnNumber;

        public Book(int cost, String isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        public int getPrice()
        {
            return price;
        }

        public String getIsbnNumber()
        {
            return isbnNumber;
        }

      
    public int accept(IShoppingCartVisitor visitor)
        {
            return visitor.visit(this);
        }

    }

}

