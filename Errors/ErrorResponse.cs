using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class ErrorResponse
    {
        private Error error { get; set; }
        private FieldError? fieldErrors { get; set; }

        public ErrorResponse() { }
        
        public ErrorResponse(Error error, FieldError fieldErrors)
        {
            this.error = error;
            this.fieldErrors = fieldErrors;
        }
    }
}
