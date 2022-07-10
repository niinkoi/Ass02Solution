using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repositories.implements
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext = new RepositoryContext();

        private IMemberRepository _memberRepository;
        private IOrderRepository _orderRepository;
        private IOrderDetailRepository _orderDetailRepository;
        private IProductRepository _productRepository;

        public RepositoryManager()
        {
        }

        public IMemberRepository Member
        {
            get
            {
                if (_memberRepository == null)
                {
                    _memberRepository = new MemberRepository(_repositoryContext);
                }
                return _memberRepository;
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_repositoryContext);
                }
                return _orderRepository;
            }
        }

        public IOrderDetailRepository OrderDetail
        {
            get
            {
                if (_orderDetailRepository == null)
                {
                    _orderDetailRepository = new OrderDetailRepository(_repositoryContext);
                }
                return _orderDetailRepository;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_repositoryContext);
                }
                return _productRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
