// --------------------------------------------------------------------------------------------------------------------
// <copyright file=NotesModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooModel.Notes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Class for NotesModel
    /// </summary>
    public class NotesModel
    {
        private int noteId;
        private string title;
        private string email;
        private string description;
        private DateTime? createdate;
        private DateTime? modifieddate;
        private bool archeive;
        private bool pin;
        private string changeColor;
        private string addImg;
        private string reminder;
        private bool trash;

        /// <summary>
        /// get and sets the noteId
        /// </summary>
        [Key]
        public int NoteId { get => this.noteId; set => this.noteId = value; }

        /// <summary>
        /// Get and sets thr trash
        /// </summary>
        public bool Trash { get => this.trash; set => this.trash = value; }

        /// <summary>
        /// Get and sets the title
        /// </summary>
        public string Title { get => this.title; set => this.title = value; }

        /// <summary>
        /// Get and Sets the description
        /// </summary>
        public string Description { get => this.description; set => this.description = value; }

        /// <summary>
        /// Get and sets the createdate
        /// </summary>
        public DateTime? Createdate1 { get => this.createdate; set => this.createdate = value; }

        /// <summary>
        /// Get and sets the modifieddate
        /// </summary>
        public DateTime? Modifieddate { get => this.modifieddate; set => this.modifieddate = value; }

        /// <summary>
        /// Get and sets the archeive
        /// </summary>
        public bool Archeive { get => this.archeive; set => this.archeive = value; }

        /// <summary>
        /// Get and sets the pin
        /// </summary>
        public bool Pin { get => this.pin; set => this.pin = value; }

        /// <summary>
        /// Get and sets the changecolor
        /// </summary>
        public string ChangeColor { get => this.changeColor; set => this.changeColor = value; }

        /// <summary>
        /// get and sets the addImg
        /// </summary>
        public string AddImg { get => this.addImg; set => this.addImg = value; }

        /// <summary>
        /// Get and sets the email
        /// </summary>
        public string Email { get => this.email; set => this.email = value; }

        /// <summary>
        /// Get and sets the reminder
        /// </summary>
        public string Reminder { get => reminder; set => reminder = value; }
    }
}
