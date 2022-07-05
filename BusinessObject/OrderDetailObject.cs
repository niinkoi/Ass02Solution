using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetailObject : AbstractEntity<int>
    {
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public float Discount { get; set; }

        [ForeignKey(nameof(OrderObject))]
        public int OrderId { get; set; }
        public OrderObject Order { get; set; }

        [ForeignKey(nameof(ProductObject))]
        public int ProductId { get; set; }
        public ProductObject Product { get; set; }
    }
}
