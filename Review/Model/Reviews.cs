using ReviewMicroService.Model;

namespace Review.Model
{
    public class Reviews
    {
        public int Id { get; set; }
        public Userdata Userdata { get; set; } 
        public Product Product { get; set; } 
        public string Value { get; set; } 
        public string CreatedAt { get; set; } 
    }
}
