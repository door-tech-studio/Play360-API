namespace play_360.EF.Models
{
    public class Credit
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CreditTypeId { get; set; }
        public int Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public User User { get; set; } = null;
        public Transaction? Transaction { get; set; }
    }
}
