using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductService _productDal;

        public ProductManager(IProductService productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            _productDal.TAdd(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.TDelete(entity);
        }

        public Product TGetById(int id)
        {
            return _productDal.TGetById(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.TGetListAll();
        }

        public void TUpdate(Product entity)
        {
            _productDal.TUpdate(entity);
        }
    }
}
