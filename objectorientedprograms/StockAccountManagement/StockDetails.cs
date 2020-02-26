using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.StockAccountManagement
{
   public class StockDetails
    {
        private string stockname;
        private int share;
        private int shareprice;
        public string StockName
        {
            set
            {
                this.stockname = value;
            }
            get
            {
                return this.stockname;
            }
        }
        public int Share
        {
            set
            {
                this.share = value;
            }
            get
            {
                return this.share;
            }
        }
        public int SharePrice
        {

            set
            {
                this.shareprice = value;
            }
            get
            {
                return this.shareprice;
            }
        }
    }
}
