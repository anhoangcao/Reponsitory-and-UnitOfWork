using ReponsitoryAndUnitOfWork.Data;
using ReponsitoryAndUnitOfWork.Interface;
using ReponsitoryAndUnitOfWork.Repository;

namespace RepositoryAndUnitOfWork.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }

        public IProductRepository Products { get; private set; }

        public IProductRepository Product => throw new NotImplementedException();

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
