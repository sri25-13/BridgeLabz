using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
   public class Stock
    {
        private string stocksymbol;
        private int numberofshares;
        private int sharePrice;
        public string StockSymbol
        {
            set 
            {
                this.stocksymbol = value;
            }
            get
            {
                return this.stocksymbol;
            }
        }
        public int NumberOfShares
        {
            set
            {
                this.numberofshares = value;
            }
            get
            {
                return this.numberofshares;
            }
        }
        public int SharePrice
        {
            set
            {
                this.sharePrice = value;
            }
            get
            {
                return this.sharePrice;
            }
        }
    }
}
