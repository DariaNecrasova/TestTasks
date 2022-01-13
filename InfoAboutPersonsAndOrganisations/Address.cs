using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class Address
    {
        private String locale { get; set; }
        private String adressLine1 { get; set; } //example Gateway House
        private String adressLine2 { get; set; } //example 28 The Quadrant
        private String adressLine3 { get; set; }
        private String city { get; set; } //example Richmond
        private String state { get; set; } //example Surrey
        private String postcode { get; set; } //example TW9 1DN
        private String countryIsoCode { get; set; } //example GRB

        public Address() { }
        
        public Address(String locale, String adressLine1, String adressLine2, String adressLine3, String city, String state, String postcode, String countryIsoCode)
        {
            if (StringCheck.Check_value(locale, false))
                this.locale = locale;
            if (StringCheck.Check_value(adressLine1, true, 1, 150))
                this.adressLine1 = adressLine1;
            if (StringCheck.Check_value(adressLine2, false, 0 ,150))
                this.adressLine2 = adressLine2;
            if (StringCheck.Check_value(adressLine3, false, 0, 150))
                this.adressLine3 = adressLine3;
            if (StringCheck.Check_value(city, false, 0, 40))
                this.city = city;
            if (StringCheck.Check_value(state, false, 0, 60))
                this.state = state;
            if (StringCheck.Check_value(postcode, false, 0, 60))
                this.postcode = postcode;
            if (StringCheck.Check_value(countryIsoCode, true, 1))
                this.countryIsoCode = countryIsoCode;
        }

        

    }
}
