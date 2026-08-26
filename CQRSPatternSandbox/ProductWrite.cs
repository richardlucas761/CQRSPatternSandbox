namespace CQRSPatternSandbox
{
    /// <summary>
    /// Write model.
    /// </summary>
    public class ProductWrite
    {
        // TODO We only need the UserRating as this is the only thing being updated in the write model?
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public decimal UnitPrice { get; set; }
        //public bool IsOutOfStock { get; set; }

        public int Id { get; set; }
        public int ProductId { get; set; }

        public double UserRating { get; set; }

        public void AddNewProduct(int userId, int productId)
        {
            // TODO userId could be used to audit who changed the rating
            Id = userId;
            ProductId = productId;
        }

        public void RateProduct(int userId, int rating)
        {
            // TODO userId could be used to audit who changed the rating

            UserRating = rating;
        }
    }
}