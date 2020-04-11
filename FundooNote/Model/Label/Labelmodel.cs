// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Model.Label
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// class for labelmodel
    /// </summary>
    public class Labelmodel
    {
        private int labelId;
        private string labelname;

        /// <summary>
        /// get an sets the labelid
        /// </summary>
       [Key]
        public int LabelId { get => this.labelId; set => this.labelId = value; }

        /// <summary>
        /// get and set labelname
        /// </summary>
        public string LabelName { get => this.labelname; set => this.labelname = value; }
    }
}