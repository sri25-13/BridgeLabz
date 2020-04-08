using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Notes
{
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
        [Key]
        public int NoteId { get => this.noteId; set => this.noteId = value; }
        public bool Trash { get => this.trash; set => this.trash = value; }
        public string Title { get => this.title; set => this.title = value; }
        public string Description { get => this.description; set => this.description = value; }
        public DateTime? Createdate1 { get => this.createdate; set => this.createdate = value; }
        public DateTime? Modifieddate { get => this.modifieddate; set => this.modifieddate = value; }
        public bool Archeive { get => this.archeive; set => this.archeive = value; }
        public bool Pin { get => this.pin; set => this.pin = value; }
        public string ChangeColor { get => this.changeColor; set => this.changeColor = value; }
        public string AddImg { get => this.addImg; set => this.addImg = value; }
        public string Email { get => this.email; set => this.email = value; }
        public string Reminder { get => reminder; set => reminder = value; }
    }
}

