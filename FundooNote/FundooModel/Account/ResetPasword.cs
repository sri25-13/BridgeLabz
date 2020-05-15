using System;
using System.Collections.Generic;
using System.Text;

namespace FundooModel.Account
{
    public class ResetPassword
    {
        private string newpassword;
        private string confirmpassword;
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


