namespace ReponsitoryAndUnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }

        int Complete();
    }
}
