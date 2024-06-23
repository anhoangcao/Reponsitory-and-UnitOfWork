using RepositoryAndUnitOfWork.Model;

namespace ReponsitoryAndUnitOfWork.Interface
{
    public interface IProductRepository
    {
        Product? GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
