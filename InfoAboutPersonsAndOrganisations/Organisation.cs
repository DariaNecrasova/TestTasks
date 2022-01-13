using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class Organisation
    {
        private String name { get; set; }
        private Address address { get; set; }

        public Organisation() { }
        
        public Organisation(String name, Address address)
        {
            if (StringCheck.Check_value(name, true, 1, 120))
                this.name = name;
            this.address = address;
        }

        public Organisation(String name, String locale, String adressLine1, String adressLine2, String adressLine3, String city, String state, String postcode, String countryIsoCode)
        {
            if (StringCheck.Check_value(name, true, 1, 120))
                this.name = name;
            this.address = new Address(locale, adressLine1, adressLine2, adressLine3, city, state, postcode, countryIsoCode);
        }

    }
}
