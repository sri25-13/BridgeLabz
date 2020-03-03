using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
   public class Stock
    {
        private string stockSymbol;
        private int numberOfShares;
        private int sharePrice;
        public string StockSymbol
        {
            set 
            {
                this.stockSymbol = value;
            }
            get
            {
                return this.stockSymbol;
            }
        }
        public int NumberOfShares
        {
            set
            {
                this.numberOfShares = value;
            }
            get
            {
                return this.numberOfShares;
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
