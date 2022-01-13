using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask_API
{
    public class StringCheck //adittional class for checking string
    {
        public static bool Check_value(String stringToCheck, bool required)
        {
            if (required && stringToCheck.Length != 0)
                return true;
            if (!required)
                return true;

            return false;
        }

        public static bool Check_value(String stringToCheck, bool required, int min_length)
        {
            if (Check_value(stringToCheck, required))
                if (stringToCheck.Length >= min_length)
                    return true;

            return false;
        }
        public static bool Check_value(String stringToCheck, bool required, int min_length, int max_length)
        {
            if (Check_value(stringToCheck, required))
                if (stringToCheck.Length >= min_length)
                    if (stringToCheck.Length <= max_length)
                        return true;

            return false;
        }
    }
}
