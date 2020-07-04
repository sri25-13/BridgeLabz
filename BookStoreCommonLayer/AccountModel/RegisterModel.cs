using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStoreCommonLayer.AccountModel
{
   public class RegisterModel
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        [Key]
        public int Id { get => this.id; set => this.id = value; }

        [Required(ErrorMessage = "Firstname is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]$",
         ErrorMessage = "Characters are not allowed.")]
        public string FirstName { get => this.firstName; set => this.firstName = value; }


        [Required(ErrorMessage = "Lastname is required.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]$",
         ErrorMessage = "Characters are not allowed.")]
        public string LastName { get => this.lastName; set => this.lastName = value; }


        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Not a valid email address")]
        public string Email { get => this.email; set => this.email = value; }


        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get => this.password; set => this.password = value;
        }
    }
}
