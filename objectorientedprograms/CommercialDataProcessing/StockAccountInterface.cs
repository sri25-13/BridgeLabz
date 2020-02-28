using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    interface IStockAccountInterface
    {
        StockModel NewAccount(string path);
        double ValueOf();
        void buy(StockModel model);
        void sell(StockModel model);
        void Save(string filename);
        void PrintReport();
    }
}
