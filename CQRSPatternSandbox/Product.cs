namespace CQRSPatternSandbox
{
    /// <summary>
    /// Write model.
    /// </summary>
    public class Product
    {
        // TODO We only need the UserRating as this is the only thing being updated in the write model?
        //public string Name { get; set; }
        //public string Description { get; set; }
        //public decimal UnitPrice { get; set; }
        //public bool IsOutOfStock { get; set; }

        public int Id { get; set; }

        public double UserRating { get; set; }

        internal void RateProduct(int userId, int rating)
        {
            // TODO userId could be used to audit who changed the rating

            UserRating = rating;
        }
    }
}