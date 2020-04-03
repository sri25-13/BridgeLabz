// --------------------------------------------------------------------------------------------------------------------
// <copyright file=JwtSettings.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model.Account
{
    /// <summary>
    /// Model class for Jwt
    /// </summary>
    public class JwtSettings
    {
        private string secret;

        /// <summary>
        /// get and sets the secret key
        /// </summary>
        public string Secret { get => this.secret; set => this.secret = value; }
    }
}
