using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBookProblem
{
    public class AddressBookDetails
    {
        private string firstname;
        private string lastname;
        private string address;
        private string state;
        private string city;
        private int zip;
        private long phonenumber;
        public string Firstname
        {
            set
            {
                this.firstname = value;
            }
            get
            {
                return this.firstname;
            }
        }
        public string Lastname
        {
            set
            {
                this.lastname = value;
            }
            get
            {
                return this.lastname;
            }
        }
        public string Address
        {
            set
            {
                this.address = value;
            }
            get
            {
                return this.address;
            }
        }
        public string State
        {
            set
            {
                this.state = value;
            }
            get
            {
                return this.state;
            }
        }
        public string City
        {
            set
            {
                this.city = value;
            }
            get
            {
                return this.city;
            }
        }
        public int Zip
        {
            set
            {
                this.zip = value;
            }
            get
            {
                return this.zip;
            }
        }
        public long PhoneNumber
        {
            set
            {
                this.phonenumber = value;
            }
            get
            {
                return this.phonenumber;
            }
        }
    }
}
