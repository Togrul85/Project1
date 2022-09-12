using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Models
{
    class User
    {
        
        public int Id { get; }
        public bool IsAdmin { get; set; }    
        public string Password { get;set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
       

        


        //public string login
        //{
        //    get { return _login; }
        //    set
        //    {
        //        if (value.Length>=3 && value.Length<=16)
        //        {
        //             = value;
        //        }
        //    }
        //}
        //public string password
        //{
        //    get { return _password; }
        //    set
        //    {
        //        if (value.Length>=6 && value.Length<=16)
        //        {
        //            _password = value;
        //        }
        //    }
        //}



    }

   

}
