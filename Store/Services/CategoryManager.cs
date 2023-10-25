using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _maneger;

        public CategoryManager(IRepositoryManager maneger)
        {
            _maneger = maneger;
        }

        public IEnumerable<Category> GetAllCategory(bool trackChanges)
        {
           return _maneger.Category.FindAll(trackChanges);
        }
    }
}