using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace CQRSPatternSandbox
{
    public class ProductsCommandHandler(IRepository<ProductWrite> repository) : ICommandHandler<RateProduct>,
        ICommandHandler<AddNewProduct>
    {
        private readonly IRepository<ProductWrite> repository = repository;

        public void Handle(RateProduct command)
        {
            var product = repository.Find(command.ProductId);
            product?.RateProduct(command.UserId, command.Rating);
        }

        public void Handle(AddNewProduct command)
        {
            product?.AddNewProduct(int userId, int productId);
        }
    }
}