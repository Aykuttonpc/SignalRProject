using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialService _testimonialDal;

        public TestimonialManager(ITestimonialService testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialDal.TAdd(entity);   
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.TDelete(entity);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.TGetById(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonialDal.TGetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.TUpdate(entity);    
        }
    }
}
