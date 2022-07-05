using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderObject : AbstractEntity<int>
    {
        public DateTime OrderDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }

        [ForeignKey(nameof(MemberObject))]
        public int MemberId { get; set; }
        public MemberObject Member { get; set; }
    }
}
