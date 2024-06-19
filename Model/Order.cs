using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirProject.Model
{
    public class Order
    {

        public Order(string Class, string model, string has_must, int rowerSeatCount, string color, string typeTree, string dop, decimal price, Boat boat)
        {
            this.Class = Class;
            Model = model;
            Has_must = has_must;
            RowerSeatCount = rowerSeatCount;
            Color = color;
            TypeTree = typeTree;
            this.dop = dop;
            Price = price;
            this.boat = boat;
        }
        public string Class { get; set; }
        public string Model { get; set; }
        public string Has_must { get; set; }
        public decimal Price { get; set; }
        public int RowerSeatCount { get; set; }

        public string Color { get; set;}
        public string TypeTree { get; set;}

        public string dop {  get; set;}

        public Boat boat { get; set; }

    }
}
