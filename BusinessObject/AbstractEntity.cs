using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class AbstractEntity<TKey> where TKey : IEquatable<TKey>
    {
        [Key]
        [Required]
        public virtual TKey ID { get; set; }
    }
}
