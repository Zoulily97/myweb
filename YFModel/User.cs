﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.Model//实体类  --定义属性
{
   public class User
    {
        private int id;
        //crtl+r+e
        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Name { get => name; set => name = value; }
        public string Adress { get => adress; set => adress = value; }
        public int Sex { get => sex; set => sex = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Email { get => email; set => email = value; }
        public string Qq { get => qq; set => qq = value; }
        public int State { get => state; set => state = value; }
        public DateTime Addate { get => addate; set => addate = value; }
        public string Password { get => password; set => password = value; }

        private string username;
        private string password;
        private string name;
        private string adress;
        private int sex;
        private string mobile;
        private string email;
        private string qq;
        private int state;
        private DateTime addate;

            

    }
}
