using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCatagoryDal : ICategoryDal
    {
        List<Category> _categories;

        public InMemoryCatagoryDal()
        {
            _categories = new List<Category>
            {
                new Category{Id=1,Name="Backend"},
                new Category{Id=2,Name="Frontend"},
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(c => c.Id == category.Id);
            _categories.Remove(categoryToDelete);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.SingleOrDefault(c => c.Id == category.Id);
            categoryToUpdate.Id = category.Id;
            categoryToUpdate.Name = category.Name;
        }
    }
}
