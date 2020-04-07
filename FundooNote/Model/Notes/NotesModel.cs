using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Notes
{
    public class NotesModel
    {
        private int noteID;
        private bool pinNote;
        private bool archive;
        private string description;
        private string title;
        private string addImg;
        private string remainder;
        private string addColor;
        private bool trash;
        private string emailid;
        [Key]
        public int NoteID { get => noteID; set => noteID = value; }
        public string Emailid { get => emailid; set => emailid = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public bool Archive { get; set; }
        public string AddImg { get => addImg; set => addImg = value; }
        public string Remainder { get => remainder; set => remainder = value; }
        public string AddColor { get => addColor; set => addColor = value; }
    }
}
