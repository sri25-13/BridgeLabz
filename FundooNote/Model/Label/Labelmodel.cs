using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Label
{
    public class Labelmodel
    {
        private int labelId;
        private int noteid;
        private string labelname;
        public int LabelId { get => this.labelId; set => this.labelId = value; }
        public string LabelName { get => this.labelname; set => this.labelname = value; }
        public int Noteid { get => this.noteid; set => this.noteid = value; }
    }
}

