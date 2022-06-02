using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10.db.model
{
    public class Product
    {
        //        public int Id { get; set; }
        //        public string Name { get; set; }
        //        public int Weight { get; set; }
        //        public int Qty { get; set; }

        //    }
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }


        public int? SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}