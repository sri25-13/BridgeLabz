using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Account
{
   public class ResetPassword
    {
        private string email;
        private string password;
        private string newpassword;
        private string confirmpassword;

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

        public string NewPassword
        {
            get
            {
                return this.newpassword;
            }
            set
            {
                this.newpassword = value;
            }
        }
        public string ConfirmPassword
        {
            get
            {
                return this.confirmpassword;
            }
            set
            {
                this.confirmpassword = value;
            }
        }
    }
}

