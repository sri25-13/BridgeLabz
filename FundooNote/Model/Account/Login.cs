﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Account
{
   public class Login
    {
        private string email;
        private string password;
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }

        }
    }
}

