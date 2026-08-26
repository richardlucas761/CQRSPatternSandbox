namespace CQRSPatternSandbox
{
    /// <summary>
    /// Read model.
    /// </summary>
    public class ProductDisplay
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsOutOfStock { get; set; }
        public double UserRating { get; set; }
    }
}
