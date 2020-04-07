using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Label
{
    public class Labelmodel
    {
        private int labelId;
        private string labelname;
       [Key]
        public int LabelId { get => this.labelId; set => this.labelId = value; }
        public string LabelName { get => this.labelname; set => this.labelname = value; }
    }
}