using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using UserDatas.Models;

namespace UserDatas.Services
{
    public class UserDataService
    {
        public static List<Userdata> UserDataList { get; }
        static UserDataService() {
            UserDataList = new List<Userdata>
            {
                new Userdata{
                    Id= 1,
                    FirstName="Vinodh",
                    LastName="Karri",
                    Mobile="9876543210",
                    Email="karrivinodh@gmail.com",
                    Password="vinodh",
                    Address="Mumbai-908090",
                    CreatedAt=DateTime.UtcNow.ToString(),
                    ModifiedAt=DateTime.UtcNow.ToString(),
                },
                new Userdata{
                    Id=2,
                    FirstName="Kushal",
                    LastName="Pendse",
                    Mobile="9876543220",
                    Email="kushal@gmail.com",
                    Password="kushal",
                    Address="Chennai-907890",
                     CreatedAt=DateTime.UtcNow.ToString(),
                    ModifiedAt=DateTime.UtcNow.ToString(),
                },
                new Userdata{
                    Id=3,
                    FirstName="Billu",
                    LastName="Sisindri",
                    Mobile="9876543221",
                    Email="billu@gmail.com",
                    Password ="billu",
                    Address="Hyderabad-567909",
                     CreatedAt=DateTime.UtcNow.ToString(),
                    ModifiedAt=DateTime.UtcNow.ToString(),
                },
            };//ListEndsHere
        }
        static int nextUserID = 4;
        public static List<Userdata> Get() {
            return UserDataList;
        }
        public static Userdata GetByID(int id) {
            return UserDataList.FirstOrDefault(user => user.Id == id);
        }
        public static Userdata Post(Userdata user) {
            user.Id = nextUserID++;
            UserDataList.Add(user);
            return user;
        }
        public  Userdata PostUser(string email, string password)
        {
            return UserDataList.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

    }
        
       
    }

