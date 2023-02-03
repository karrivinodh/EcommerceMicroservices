using System.ComponentModel.DataAnnotations;

namespace UserDatas.Models
{
    public class Userdata
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } 
        public string Address { get; set; } 
        public string Mobile { get; set; } 
        public string Password { get; set; }

        public string CreatedAt { get; set; } = string.Empty;
        public string ModifiedAt { get; set; } = string.Empty;



    }
}
