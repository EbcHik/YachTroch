using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirProject.Model
{
    public class BoatOrder
    {
        public string ProductName { get; set; }
        public string OrderNumber { get; set; }
        public string BoatType { get; set; }
        public int RowerSeatCount { get; set; }
        public string WoodType { get; set; }
        public string Color { get; set; }
        public string HasMast { get; set; }
        public decimal BasePrice { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPassportNumber { get; set; }
        public string OrderReady { get; set; }

        public DateTime orderDate { get; set; }
        public string dopService { get; set; }
        public string resPrice { get; set; }
        public int countDopServises {  get; set; }
    }

}
