using CartMicroservice.Model;

namespace CartMicroService.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public Userdata User { get; set; } = new Userdata();
        public List<CartItem> CartItems { get; set; } = new();
        public bool Ordered { get; set; }
        public string OrderedOn { get; set; } = string.Empty;
    }
}
