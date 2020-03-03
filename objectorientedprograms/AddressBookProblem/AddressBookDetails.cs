// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookDetails.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.AddressBookProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class for addressbookdetails
    /// </summary>
    public class AddressBookDetails
    {
        private string firstname;
        private string lastname;
        private string address;
        private string state;
        private string city;
        private int zip;
        private long phonenumber;

        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        /// <value>
        /// The firstname.
        /// </value>
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
        /// Gets or sets the lastname.
        /// </summary>
        /// <value>
        /// The lastname.
        /// </value>
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
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                this.address = value;
            }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.city = value;
            }
        }

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        /// <value>
        /// The zip.
        /// </value>
        public int Zip
        {
            get
            {
                return this.zip;
            }

            set
            {
                this.zip = value;
            }
        }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public long PhoneNumber
        {
            get
            {
                return this.phonenumber;
            }

            set
            {
                this.phonenumber = value;
            }
        }
    }
}
