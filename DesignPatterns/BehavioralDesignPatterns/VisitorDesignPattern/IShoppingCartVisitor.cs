using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
   public interface IShoppingCartVisitor
    {
        int visit(Book book);
        int visit(Fruit fruit);
    }
}
