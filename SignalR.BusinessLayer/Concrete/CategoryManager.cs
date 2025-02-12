using SignalR.BusinessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryService _categoryDal;

        public CategoryManager(ICategoryService categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TAdd(Category entity)
        {
            _categoryDal.TAdd(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDal.TDelete(entity);
        }

        public Category TGetById(int id)
        {
           return _categoryDal.TGetById(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDal.TGetListAll();
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.TUpdate(entity);
        }
    }
}
