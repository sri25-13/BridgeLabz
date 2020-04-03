﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file=RegisterModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model.Account
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model class for registering
    /// </summary>
    public class RegisterModel
    {
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        public bool Status;

        /// <summary>
        /// Get and sets the Firstname
        /// </summary>
        public string Firstname
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }
        }

        /// <summary>
        /// get and sets the Lastname
        /// </summary>
        public string Lastname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }

        /// <summary>
        /// Get and sets the Lastname
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