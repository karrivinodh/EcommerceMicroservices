using PaymentMicroService.Models;

namespace PaymentMicroService.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Userdata Userdata { get; set; }
        public int TotalAmount { get; set; }
        public int ShipingCharges { get; set; }
        public int AmountReduced { get; set; }
        public int AmountPaid { get; set; }
        public string CreatedAt { get; set; }
    }
}
