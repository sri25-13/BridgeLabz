using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    interface IStockAccountInterface
    {
       public StockModel NewAccount(string path);
       public double ValueOf();
       public void Buy(StockModel model);
       public void sell(StockModel model);
       public void Save(string filename);
       public void PrintReport();
    }
}
