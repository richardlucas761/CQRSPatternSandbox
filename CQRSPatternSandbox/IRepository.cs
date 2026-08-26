namespace CQRSPatternSandbox
{
    public interface IRepository<T>
    {
        ProductWrite Find(int productId);
    }
}