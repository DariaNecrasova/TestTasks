using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class GetRegistrationResponse
    {
        private String id { get; set; }
        private DateTime registrationDate { get; set; }
        private String locale { get; set; }
        private Person person { get; set; }
        private Organisation organisation { get; set; }

        public GetRegistrationResponse() { }

        public GetRegistrationResponse(String id, DateTime registrationDate, String locale, Person person)
        {
            this.id = id;
            if (StringCheck.Check_value(registrationDate.ToString(), true))
                this.registrationDate = registrationDate;
            this.locale = locale;
            this.person = person;
        }

        public GetRegistrationResponse(String id, DateTime registrationDate, String locale, Person person, Organisation organisation)
        {
            this.id = id;
            if(StringCheck.Check_value(registrationDate.ToString(), true))
                this.registrationDate = registrationDate;
            this.locale = locale;
            this.person = person;
            this.organisation = organisation;
        }

        public String getId()
        {
            return id;
        }
        
    }
}
