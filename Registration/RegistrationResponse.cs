using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class RegistrationResponse
    {
        String registrationId { get; set; }

        public RegistrationResponse() { }
        
        public RegistrationResponse(String registrationId)
        {
            this.registrationId = registrationId;
        }

        public String getRegistrationResponse()
        {
            return registrationId;
        }
    }
}
