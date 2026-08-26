namespace CQRSPatternSandbox
{
    public class ProductsCommandHandler(IRepository<Product> repository) : ICommandHandler<RateProduct>
    {
        private readonly IRepository<Product> repository = repository;

        public void Handle(RateProduct command)
        {
            var product = repository.Find(command.ProductId);
            product?.RateProduct(command.UserId, command.Rating);
        }
    }
}