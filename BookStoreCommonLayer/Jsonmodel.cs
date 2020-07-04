using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreCommonLayer
{
   public class Jsonmodel
    {
        private string errorMessage;
        private int errorCode;
        public string ErrorMessage { get => this.errorMessage; set => this.errorMessage = value; }
        public int ErrorCode { get => this.errorCode; set => this.errorCode = value; }
    }
}
