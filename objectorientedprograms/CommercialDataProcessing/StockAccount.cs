/*using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    class StockAccount : IStockAccountInterface
    {
        StockModel model = null;
        public StockModel NewAccount(string path)
        {
            string jsonString = Utility.ReadFile(path);
            Console.WriteLine(jsonString);
            model = Utility.DeserializingStockAccount(jsonString);
            return model;
        }
        double ValueOf()
        {
            double totalValue = 0.0;
            IList<Stock> list = model.CompanyShares;
            foreach (var share in list)
                totalValue = share.NumberOfShares * share.SharePrice;
            return totalValue;
        }

    void Buy(StockModel model)
        {

        }
        void sell()
        {

        }
        void Save()
        {

        }
        void PrintReport()
        {

        }
    }
}
*/