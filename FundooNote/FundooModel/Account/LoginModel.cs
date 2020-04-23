// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LoginModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModel.Account
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model class for Login
    /// </summary>
    public class LoginModel
    {
        private string email;
        private string password;

        /// <summary>
        /// get and sets the Email
        /// </summary>
        [Key]
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

        /// <summary>
        /// get and sets the Password
        /// </summary>
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
