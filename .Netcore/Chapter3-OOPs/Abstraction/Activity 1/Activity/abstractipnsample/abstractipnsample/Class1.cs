using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractipnsample
{
    abstract class User
    {
        public int Id { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public bool Login(string email,string password)
        {
           
                Console.WriteLine("Login Successful.................!!!");
                return true;
            
        }
        abstract public void Welcome();
    }
}
