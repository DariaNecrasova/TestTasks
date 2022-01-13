using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class Person
    {
        private String firstName { get; set; }
        private String lastName { get; set; }
        private String email { get; set; }
        private Address address { get; set; }

        public Person() { }

        public Person(String firstName, String lastName, String email)
        {
            if (StringCheck.Check_value(firstName, true, 1, 150))
                this.firstName = firstName;
            if (StringCheck.Check_value(lastName, true, 1, 150))
                this.lastName = lastName;
            if (StringCheck.Check_value(email, true, 1, 254))
                this.email = email;
        }

        public Person(String firstName, String lastName, String email, Address address)
        {
            if (StringCheck.Check_value(firstName, true, 1, 150))
                this.firstName = firstName;
            if (StringCheck.Check_value(lastName, true, 1, 150))
                this.lastName = lastName;
            if (StringCheck.Check_value(email, true, 1, 254))
                this.email = email;
            this.address = address;
        }

        public Person(String firstName, String lastName, String email, String locale, String adressLine1, String adressLine2, String adressLine3, String city, String state, String postcode, String countryIsoCode)
        {
            if (StringCheck.Check_value(firstName, true, 1, 150))
                this.firstName = firstName;
            if (StringCheck.Check_value(lastName, true, 1, 150))
                this.lastName = lastName;
            if (StringCheck.Check_value(email, true, 1, 254))
                this.email = email;
            this.address = new Address(locale, adressLine1, adressLine2, adressLine3, city, state, postcode, countryIsoCode);
        }
    }
}
