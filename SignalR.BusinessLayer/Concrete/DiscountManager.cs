using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountDal
    {
        private readonly IDiscountService _discountDal;

        public DiscountManager(IDiscountService discountDal)
        {
            _discountDal = discountDal;
        }

        public void Add(Discount entity)
        {
            _discountDal.TAdd(entity);
        }

        public void Delete(Discount entity)
        {
            _discountDal.TDelete(entity);
        }

        public Discount GetById(int id)
        {
            return _discountDal.TGetById(id);
        }

        public List<Discount> GetListAll()
        {
            return _discountDal.TGetListAll();
        }

        public void Update(Discount entity)
        {
            _discountDal.TUpdate(entity);
        }
    }
}
