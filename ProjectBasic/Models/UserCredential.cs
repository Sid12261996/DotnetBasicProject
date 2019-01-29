using MongoDB.Driver;
using ProjectBasic.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectBasic.Models
{
    public class UserCredential
    {
       
       public string UserName { get; set; }
        public string Password { get; set; }
        public string mobNo { get; set; }
        public string pin { get; set; }
        public string state { get; set; }
        public string Email { get; set; }
      
        
    }
    
}