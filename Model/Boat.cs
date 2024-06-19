using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirProject.Model
{
    public class Boat
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Model { get; set; }
        public string Has_must { get; set; }
        public decimal Price { get; set; }
        public int RowerSeatCount{ get; set; }


        public override string ToString()
        {
            return String.Concat(Model);
        }



    }
}
