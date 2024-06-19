using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirProject.Model
{
    public static class Basket
    {
        public static List<Order> orders = new List<Order>();

        public static decimal resPrice = 0;

        public static int userID { get; set; }


    }
}
