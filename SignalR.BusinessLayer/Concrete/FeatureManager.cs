using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureService _featureDal;

        public FeatureManager(IFeatureService featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature entity)
        {
            _featureDal.TAdd(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureDal.TDelete(entity);
        }

        public Feature TGetById(int id)
        {
           return  _featureDal.TGetById(id);
        }

        public List<Feature> TGetListAll()
        {
            return _featureDal.TGetListAll();
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.TUpdate(entity);
        }
    }
}
