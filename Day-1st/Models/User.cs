using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace XamarinCrossApp.Models
{
   public class User
    {
        [PrimaryKey][AutoIncrement]
        public int UserId { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}
