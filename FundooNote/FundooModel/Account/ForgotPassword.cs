// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ForgotPassword.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModel.Account
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model class for ForgotPassword
    /// </summary>
    public class ForgotPassword
    {
        private string email;

        /// <summary>
        /// get and sets the Email
        /// </summary>
        [EmailAddress]
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

