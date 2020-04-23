// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CollaboratorModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModel.Collaborators
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Class for CollaboratorModel
    /// </summary>
    public class CollaboratorModel
    {
        private int id;
        private int noteId;
        private string senderEmail;
        private string receiverEmail;

        /// <summary>
        /// Get and sets the noteId
        /// </summary>
        public int NoteId { get => this.noteId; set => this.noteId = value; }

        /// <summary>
        /// Get and sets the id
        /// </summary>
        [Key]
        public int Id { get => this.id; set => this.id = value; }

        /// <summary>
        /// Get and sets the senderEmail
        /// </summary>
        public string SenderEmail { get => this.senderEmail; set => this.senderEmail = value; }

        /// <summary>
        /// Get and sets the receiverEmail
        /// </summary>
        public string ReceiverEmail { get => this.receiverEmail; set => this.receiverEmail = value; }
    }
}
