using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirProject.Model
{
    internal class DopService
    {
        public DopService(string name,int price){
            Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public int Price {  get; set; }


        public override string ToString()
        {
            return String.Concat(Name);
        }

    }
}
