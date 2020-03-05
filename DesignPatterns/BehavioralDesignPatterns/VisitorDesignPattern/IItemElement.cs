using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.VisitorDesignPattern
{
    public interface IItemElement
    {
        public int accept(IShoppingCartVisitor visitor);
    }
}

