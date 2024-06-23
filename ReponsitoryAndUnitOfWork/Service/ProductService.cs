using ReponsitoryAndUnitOfWork.Interface;
using RepositoryAndUnitOfWork.Model;

namespace ReponsitoryAndUnitOfWork.Service
{
    public class ProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateProduct(Product product)
        {
            _unitOfWork.Products.AddProduct(product);
            _unitOfWork.Complete();
        }

        public Product? GetProduct(int id)
        {
            return _unitOfWork.Products.GetProductById(id);
        }

        public IEnumerable<Product> GetAllProducts() 
        {
            return _unitOfWork.Products.GetAllProducts();
        }

        public void UpdateProduct(Product product)
        {
            _unitOfWork.Products.UpdateProduct(product);
            _unitOfWork.Complete();
        }

        public void DeleteProduct(int id)
        {
            _unitOfWork.Products.DeleteProduct(id);
            _unitOfWork.Complete();
        }
    }
}
