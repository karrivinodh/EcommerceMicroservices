using Vendors.Model;

namespace Vendors.Services
{
    public class VendorServices
    {
        public static List<Vendor> VendorDataList { get; }
        static VendorServices()
        {
            VendorDataList = new List<Vendor>
            {
                new Vendor{
                    Id= 1,
                    FirstName="Vinodh",
                    LastName="Karri",
                    Mobile="9876543210",
                    Email="karriVinodh@gmail.com",
                    Address="Visakhapatnam-531011",
                    Password="vinodh",
                     CreatedAt=DateTime.UtcNow.ToString(),
                    ModifiedAt=DateTime.UtcNow.ToString(),
                },
                new Vendor{
                    Id=2,
                    FirstName="Kushal",
                    LastName="Pendse",
                    Mobile="9876543220",
                    Email="kushal@gmail.com",
                    Address="Mumbai-731022",
                    Password="kushal",
                     CreatedAt=DateTime.UtcNow.ToString(),
                    ModifiedAt=DateTime.UtcNow.ToString(),
                },
                new Vendor{
                    Id=3,
                    FirstName="Billu",
                    LastName="Sisindri",
                    Mobile="9876543221",
                    Email="billu@gmail.com",
                    Address="Tirupati-409090",
                    Password ="billu",
                     CreatedAt=DateTime.UtcNow.ToString(),
                    ModifiedAt=DateTime.UtcNow.ToString(),
                },
            };//ListEndsHere
        }
        static int nextUserID = 4;
        public static List<Vendor> Get()
        {
            return VendorDataList;
        }
        public static Vendor GetByID(int id)
        {
            return VendorDataList.FirstOrDefault(user => user.Id == id);
        }
        public static Vendor Post(Vendor user)
        {
            user.Id = nextUserID++;
            VendorDataList.Add(user);
            return user;
        }
        public Vendor GetVendor(string email, string password)
        {
            return VendorDataList.FirstOrDefault(u => u.Email == email && u.Password == password);
        }


    }
}
