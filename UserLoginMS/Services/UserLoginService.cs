using UserDatas.Models;
using UserDatas.Services;
using UserLoginMS.Models;

namespace UserLoginMS.Services
{
    public static class UserLoginService
    {
        public static List<UserDataLogin> UserDataLogin { get; }
        static UserLoginService() {
            UserDataLogin = new List<UserDataLogin> {
                new UserDataLogin{
                    UserLoginPKID = 1,
                    UserID = 1,
                    UserName = "Pratik@Admin",
                    Password= "password",
                },
                new UserDataLogin{
                    UserLoginPKID = 2,
                    UserID = 2,
                    UserName = "Omkar@Admin",
                    Password= "password",
                },
                new UserDataLogin{
                    UserLoginPKID = 3,
                    UserID = 3,
                    UserName = "Mangesh@Admin",
                    Password= "password",
                }
            };//List ends here
        }
        static int UserLoginPKID = 4;
        public static UserData Get(string userName) {
            var UserLoginData = UserDataLogin.FirstOrDefault(x => x.UserName == userName);
            var user = UserDataService.GetByID(UserLoginData.UserID);
            return user;
        }
        public static string Post(UserDataLogin userdata) {
            userdata.UserLoginPKID = UserLoginPKID++;
            UserDataLogin.Add( userdata );
            return "Your account has been created.";
        }
    }
}
