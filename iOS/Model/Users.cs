using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using UIKit;

namespace Starbox.iOS
{
    public class Users
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static async Task<bool> Login(string email, string password)
        {
            bool result = false;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                result = false;
            }
            else
            {
                var user = (await AppDelegate.MobileService.GetTable<Users>().Where(u => u.Email == email).ToListAsync()).FirstOrDefault();

                if (user.Password == password)
                {
                    AppDelegate.user = user;
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        public static async Task<bool> Register(string email, string password, string confirmPassword)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(password))
            {
                if (password == confirmPassword)
                {
                    var user = new Users()
                    {
                        Email = email,
                        Password = password
                    };

                    await AppDelegate.Insert(user);

                    result = true;
                }
            }

            return result;
        }
    }
}
