// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockDetails.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.StockAccountManagement
{
    /// <summary>
    /// class for StockDetails
    /// </summary>
    public class StockDetails
    {
        /// <summary>
        /// The stockname
        /// </summary>
        private string stockname;

        /// <summary>
        /// The share
        /// </summary>
        private int share;

        /// <summary>
        /// The shareprice
        /// </summary>
        private int shareprice;

        /// <summary>
        /// Gets or sets the name of the stock.
        /// </summary>
        /// <value>
        /// The name of the stock.
        /// </value>
        public string StockName
        {
            get
            {
                return this.stockname;
            }

            set
            {
                this.stockname = value;
            }
        }

        /// <summary>
        /// Gets or sets the share.
        /// </summary>
        /// <value>
        /// The share.
        /// </value>
        public int Share
        {
            get
            {
                return this.share;
            }

            set
            {
                this.share = value;
            }
        }

        /// <summary>
        /// Gets or sets the share price.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public int SharePrice
        {
            get
            {
                return this.shareprice;
            }

            set
            {
                this.shareprice = value;
            }
        }
    }
}
