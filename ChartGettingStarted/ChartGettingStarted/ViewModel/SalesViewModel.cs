using System.Collections.Generic;

namespace ChartGettingStarted
{
    public class SalesViewModel
    {
        public List<SaleInfo> SalesData { get; set; }

        public SalesViewModel()
        {
            SalesData = new List<SaleInfo>();
            
            SalesData.Add(new SaleInfo { Year = "2014", Target = 500, Sale = 342 });
            SalesData.Add(new SaleInfo { Year = "2015", Target = 520, Sale = 393 });
            SalesData.Add(new SaleInfo { Year = "2016", Target = 560, Sale = 431 });
            SalesData.Add(new SaleInfo { Year = "2017", Target = 600, Sale = 520 });
            SalesData.Add(new SaleInfo { Year = "2018", Target = 600, Sale = 578 });
        }
    }
}