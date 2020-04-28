// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LabelModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModel.Label
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// class for labelmodel
    /// </summary>
    public class Labelmodel
    {
        private int labelId;
        private string labelname;
        private string email;
        private int noteId;

        /// <summary>
        /// get an sets the labelid
        /// </summary>
        [Key]
        public int LabelId { get => this.labelId; set => this.labelId = value; }
        public int NoteId { get => this.noteId; set => this.noteId = value; }
        /// <summary>
        /// get and set labelname
        /// </summary>
        public string LabelName { get => this.labelname; set => this.labelname = value; }
        public string Email { get => this.email; set => this.email = value; }
    }
}
