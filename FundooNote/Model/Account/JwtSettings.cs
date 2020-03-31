using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Account
{
   public class JwtSettings
    {
        private string secret;
        public string Secret { get => this.secret; set => this.secret = value; }
    }
}
