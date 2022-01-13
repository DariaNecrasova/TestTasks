using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class Error
    {
        private String? code { get; set; }
        private String? message { get; set; }

        public Error() { }
        
        public Error(String code, String message)
        {
            this.code = code;
            this.message = message;
        }

        public String getcode()
        {
            return code;
        }

        public String getMessege()
        {
            return message;
        }
    }
}
