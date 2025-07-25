namespace play_360.EF.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CreditId { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public Credit? Credit { get; set; }
    }
}