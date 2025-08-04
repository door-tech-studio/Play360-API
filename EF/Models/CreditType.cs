namespace play_360.EF.Models
{
    public class CreditType
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public IList<Credit> Credits { get; } = new List<Credit>();
    }
}
