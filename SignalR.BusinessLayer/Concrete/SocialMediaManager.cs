using SignalR.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    internal class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaService _SocialMediaDal;

        public SocialMediaManager(ISocialMediaService socialMediaDal)
        {
            _SocialMediaDal = socialMediaDal;
        }

        public void TAdd(ISocialMediaService entity)
        {
            _SocialMediaDal.TAdd(entity);
        }

        public void TDelete(ISocialMediaService entity)
        {
            _SocialMediaDal?.TDelete(entity);   
        }

        public ISocialMediaService TGetById(int id)
        {
            return _SocialMediaDal.TGetById(id);
        }

        public List<ISocialMediaService> TGetListAll()
        {
            return _SocialMediaDal.TGetListAll();

        }

        public void TUpdate(ISocialMediaService entity)
        {
            _SocialMediaDal.TUpdate(entity);
        }
    }
}
