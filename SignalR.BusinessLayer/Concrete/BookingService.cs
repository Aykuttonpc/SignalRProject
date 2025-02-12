using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    internal class BookingService : IBookingService
    {
        private readonly IBookingService _bookingDal;

        public BookingService(IBookingService bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void TAdd(Booking entity)
        {
            _bookingDal.TAdd(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.TDelete(entity);
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.TGetById(id);
        }

        public List<Booking> TGetListAll()
        {
           return _bookingDal.TGetListAll();
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.TUpdate(entity);
        }
    }
}
