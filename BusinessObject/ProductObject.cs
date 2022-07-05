using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ProductObject : AbstractEntity<int>
    {
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string Weight { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
