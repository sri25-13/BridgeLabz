using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
   public class StockAccount : IStockAccountInterface
    {
        StockModel model = null;
        public StockModel NewAccount(string path)
        {
            string jsonString = Utility.ReadFile(path);
            Console.WriteLine(jsonString);
            model = Utility.DeserializingStockAccount(jsonString);
            return model;
        }
      public  double ValueOf()
        {
            double totalValue = 0.0;
            IList<Stock> list = model.CompanyShares;
            foreach (var share in list)
                totalValue = share.NumberOfShares * share.SharePrice;
            return totalValue;
        }

   public void Buy(StockModel model)
        {

        }
       public void Sell()
        {

        }
       public void Save(string filename)
        {
            string jsonResultString = JsonConvert.SerializeObject(model);
            File.WriteAllText(filename, jsonResultString);
        }
       public void PrintReport()
        {

        }
    }
}
