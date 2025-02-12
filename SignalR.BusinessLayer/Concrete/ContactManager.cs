using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    internal class ContactManager : IContactService
    {
        private readonly IContactService _contactDal;

        public ContactManager(IContactService contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
            _contactDal.TAdd(entity);
        }

        public void TDelete(Contact entity)
        {
           _contactDal.TDelete(entity);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.TGetById(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.TGetListAll();
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.TUpdate(entity);
        }
    }
}
