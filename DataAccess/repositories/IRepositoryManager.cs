using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repositories
{
    public interface IRepositoryManager
    {
        IMemberRepository Member { get; }
        IOrderRepository Orders { get; }
        IOrderDetailRepository OrderDetail { get; }
        IProductRepository Product { get; }
        void Save();
        void RemoveTracker();
    }
}
