using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Repositories.Contracts;
using Services.Contracts;
using System.Linq;
namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public ProductManager(IRepositoryManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        public void CreateProduct(ProductDtoForInsertion productDto)
        {
            Product product = _mapper.Map<Product>(productDto);
            _manager.Product.Create(product);
            _manager.Save();
        }

        public void DeleteOneProduct(int id)
        {
            Product product = GetOneProduct(id, false) ?? new Product();
            _manager.Product.DeleteOneProduct(product);
            _manager.Save();
        }

        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _manager.Product.GetAllProducts(trackChanges);
        }

        

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product = _manager.Product.GetOneProduct(id, trackChanges);
            if (product is null)
                throw new Exception(" Product Not Found");
            return product;
        }

        public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
        {
            var product = GetOneProduct(id, trackChanges);
            var productDto = _mapper.Map<ProductDtoForUpdate>(product);
            return productDto;
        }

        public void UpdateOneProduct(ProductDtoForUpdate productDto)
        {

             var entity = _mapper.Map<Product>(productDto);
            _manager.Product.UpdateOneProduct(entity);
            _manager.Save();



        }
    }
}