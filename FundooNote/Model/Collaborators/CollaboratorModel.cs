using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Collaborators
{
    public class CollaboratorModel
    {
        private int id;
        private int noteId;
        private string senderEmail;
        private string receiverEmail;
        public int  NoteId{ get=>this.noteId; set=>this.noteId=value; }
        [Key]
    public int Id { get=>this.id; set=>this.id=value; }
        public string SenderEmail { get=>this.senderEmail; set=>this.senderEmail=value; }
        public string ReceiverEmail { get=>this.receiverEmail; set=>this.receiverEmail=value; }
    }
}
