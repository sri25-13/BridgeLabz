using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Account
{
    public class ForgotPassword
    {
        private string email;
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
    }
}

