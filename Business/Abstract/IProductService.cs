using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        public IDataResult<List<Product>> GetAll();
        public IDataResult<List<Product>> GetAllByCategoryId(int id);
        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        public IDataResult<List<ProductDetailDto>> GetProductDetails();
        public IResult Add(Product product);
        public IDataResult<Product> GetById(int productId);
    }
}
