using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class FieldError
    {
        private String? field { get; set; }
        private String? cod { get; }
        private String? message { get; }

        public FieldError() { }
        
        public FieldError(String field, String cod, String message)
        {
            this.field = field;
            this.cod = cod;
            this.message = message;
        }

        public String getField()
        {
            return field;
        }

        public String getCode()
        {
            return cod;
        }

        public String getMessage()
        {
            return message;
        }
    }
}
