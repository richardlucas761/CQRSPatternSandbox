namespace CQRSPatternSandbox
{
    public class AddNewProduct : ICommand
    {
        public AddNewProduct()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public int UserId { get; set; }
    }
}