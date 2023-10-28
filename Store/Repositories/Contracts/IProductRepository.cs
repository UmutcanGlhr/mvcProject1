using Entities.Dtos;
using Entities.Models;

namespace Repositories.Contracts
{
    public interface IProductRepository: IRepositoriesBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
        Product? GetOneProduct(int id ,bool trackChanges);

        void CreateProduct(Product product);
        void DeleteOneProduct(Product product);
        void UpdateOneProduct(Product entity);
    }
}