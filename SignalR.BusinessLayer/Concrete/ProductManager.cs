﻿using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
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
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public List<Product> TGetProductWithCategories()
        {
            return _productDal.GetProductWithCategories();
        }

        public int TProductCount()
        {
            return _productDal.ProductCount();
            
        }

        public int TProductCountByCategoryNameDrink()
        {
            return _productDal.ProductCountByCategoryNameDrink();
        }

        public int TProductCountByCategoryNameHamburger()
        {
            return _productDal.ProductCountByCategoryNameHamburger();
        }

        public string TProductNameByMaxPrice()
        {
            return  _productDal.ProductNameByMaxPrice();
        }

        public string TProductNameByMixPrice()
        {
           return _productDal.ProductNameByMixPrice();
        }

        public decimal TProductPriceAvg()
        {
            return _productDal.ProductPriceAvg();
        }

        public decimal TProductAvgPriceByHamburger()
        {
           return _productDal.ProductAvgPriceByHamburger();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
