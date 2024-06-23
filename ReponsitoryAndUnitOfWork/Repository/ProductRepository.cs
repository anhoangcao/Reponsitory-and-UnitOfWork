using ReponsitoryAndUnitOfWork.Data;
using ReponsitoryAndUnitOfWork.Interface;
using RepositoryAndUnitOfWork.Model;
using System;

namespace ReponsitoryAndUnitOfWork.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product? GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
        }
    }
}
