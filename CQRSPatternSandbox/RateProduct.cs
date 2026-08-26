namespace CQRSPatternSandbox
{
    public class RateProduct : ICommand
    {
        public RateProduct()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; }
    }
}