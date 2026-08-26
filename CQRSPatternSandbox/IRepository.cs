namespace CQRSPatternSandbox
{
    public interface IRepository<T>
    {
        Product Find(int productId);
    }
}