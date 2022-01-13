using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API.Registration
{
    public class RegistrationRequest
    {
        private String registrationDate { get; set; }
        private String locale { get; set; }
        private Person person { get; set; }
        private Organisation organisation { get; set; }

        public RegistrationRequest() { }

        public RegistrationRequest(DateTime registrationDate, String locale, Person person)
        {
            if (StringCheck.Check_value(registrationDate.ToString(), true))
                this.registrationDate = registrationDate.ToString();
            this.locale = locale;
            this.person = person;
        }

        public RegistrationRequest(DateTime registrationDate, String locale, Person person, Organisation organisation)
        {
            if (StringCheck.Check_value(registrationDate.ToString(), true))
                this.registrationDate = registrationDate.ToString();
            this.locale = locale;
            this.person = person;
            this.organisation = organisation;
        }

    }
}
