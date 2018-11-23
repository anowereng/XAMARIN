using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinCrossApp.Models
{
   public class UserInfo
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public UserInfo() { }
        public UserInfo(string userame, string password) {
            this.Username = userame;
            this.Password = password;
        }

       public string IsUserExist()
        {
            try
            {
                if (!this.Username.Equals("") && !this.Password.Equals(""))

                    return "true";
                else
                    return "false";
            }catch(Exception ex) { throw ex; }
         
        }
    }
}
