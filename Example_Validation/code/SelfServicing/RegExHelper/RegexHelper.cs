/*
    -- This is a third-party code that will help us to validate some fields 
    -- against regular expressions.
    
        Applies To: .NET Framework 2.0, C#
        Category: Data Validation
        Author: Jonathan Bailey
        URL: http://channel9.msdn.com/wiki/default.aspx/SecurityWiki.RegExInputValCode
 
 * ----------------------------------------------------------------------------------------- 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SD.LLBLGen.Pro.Examples.RegularExpressionHelper
{
    public static class RegexHelper
    {
        // Decomposed method which actually creates the pattern object and determines the match.
        // Used by all of the other functions. 
        public static bool MatchString(string str, string regexstr)
        {
            str = str.Trim();
            System.Text.RegularExpressions.Regex pattern = new System.Text.RegularExpressions.Regex(regexstr);


            return pattern.IsMatch(str);
        }


        public static bool IsValidUserName(string strUsername)
        {
            // Allows word characters [A-Za-z0-9_], single quote, dash and period
            // must be at least two characters long and less then 128
            string regExPattern = @"^[\w-'\.]{2,128}$";


            // We also permit email address characters in user name. Set to false
            // if you don't permit email addresses as usernames. 
            bool allowEmailUsernames = true;


            if (allowEmailUsernames)
            {
                return (MatchString(strUsername, regExPattern) || IsValidEmailAddress(strUsername));
            }
            else
            {
                return MatchString(strUsername, regExPattern);
            }
        }


        public static bool IsValidPassword(string strPassword)
        {
            // Allows any type of character


            // If complexity is enabled, the password must be longer
            // and contain at least one uppercase, one lowercase, 
            // one numeric and one symbolic character. Set to false 
            // if your requirements differ.
            bool passwordComplexity = true;


            // These are some proposed minimum password lengths. If
            // complexity is enabled (above), the stronger (longer) 
            // minimum password rule applies. 
            int minPasswordLen = 6;
            int strongPasswordLen = 8;


            if (passwordComplexity)
            {
                string regExPattern = @"^.*(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[`~!@#\$%\^\&\*\(\)-_\=\+\[\{\]\}\\\|;:',<\.>/?]).*$";
                return (strPassword.Length >= strongPasswordLen &&
                    MatchString(strPassword, regExPattern));
            }
            else
            {
                return (strPassword.Length >= minPasswordLen);
            }
        }


        public static bool IsValidName(string strName)
        {
            // Allows alphabetical chars, single quote, dash and space
            // must be at least two characters long and caps out at 128 (database size)
            string regExPattern = @"^[a-zA-Záéíóú'\.\s]{2,255}$";
            return MatchString(strName, regExPattern);
        }


        public static bool IsValidStreetAddress(string strAddress)
        {
            // Since so many different types of address formats we're just going to swing the bat at 
            // this one for now and do a match against a series of digits (potentially containing
            // punctuation), followed by a series of characters representing the street name and then
            // potentially a type of street and unit number
            string regExPattern = @"\d{1,3}.?\d{0,3}\s[a-zA-Z]{2,30}(\s[a-zA-Z]{2,15})?([#\.0-9a-zA-Z]*)?";
            return MatchString(strAddress, regExPattern);
        }


        public static bool IsValidCity(string strCity)
        {
            // Here we simply treat city names like people names and defer to our name validation function. 
            return IsValidName(strCity);
        }


        public static bool IsValidUSState(string strState)
        {
            // Names of 50 US States
            string[] stateNames =         { "ALABAMA", "ALASKA", "ARIZONA", "ARKANSAS", "CALIFORNIA", "COLORADO", "CONNECTICUT", "DELAWARE", "FLORIDA", "GEORGIA", "HAWAII", "IDAHO", "ILLINOIS", "INDIANA", "IOWA", "KANSAS", "KENTUCKY", "LOUISIANA", "MAINE", "MARYLAND", "MASSACHUSETTS", "MICHIGAN", "MINNESOTA", "MISSISSIPPI", "MISSOURI", "MONTANA", "NEBRASKA", "NEVADA", "NEW HAMPSHIRE", "NEW JERSEY", "NEW MEXICO", "NEW YORK", "NORTH CAROLINA", "NORTH DAKOTA", "OHIO", "OKLAHOMA", "OREGON", "PENNSYLVANIA", "RHODE ISLAND", "SOUTH CAROLINA", "SOUTHDAKOTA", "TENNESSEE", "TEXAS", "UTAH", "VERMONT", "VIRGINIA", "WASHINGTON", "WEST VIRGINIA", "WISCONSIN", "WYOMING" };
            // Postal codes of 50 US States
            string[] stateCodes =         { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };




            // This one is somewhat easier because we have a finite set of values to check against.
            // We simply uppercase our value anc check against our list.
            strState = strState.ToUpper();


            ArrayList stateCodesArray = new ArrayList(stateCodes);
            ArrayList stateNamesArray = new ArrayList(stateNames);


            return (stateCodesArray.Contains(strState) || stateNamesArray.Contains(strState));
        }


        public static bool IsValidZIPCode(string strZIP)
        {
            // Allows 5 digit, 5+4 digit and 9 digit zip codes
            // must be at least two characters long and caps out at 128 (database size)
            string regExPattern = @"^(\d{5}-\d{4}|\d{5}|\d{9})$";
            return MatchString(strZIP, regExPattern);
        }


        public static bool IsValidUSPhoneNumber(string strPhone)
        {
            // Allows phone number of the format: NPA = [2-9][0-8][0-9] Nxx = [2-9][0-9][0-9] Station = [0-9][0-9][0-9][0-9]
            string regExPattern = @"^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$";
            return MatchString(strPhone, regExPattern);
        }


        public static bool IsValidCCNumber(string strCCNumber)
        {
            // This expression is basically looking for series of numbers confirming to the standards
            // for Visa, MC, Discover and American Express with optional dashes between groups of numbers
            string regExPattern = @"^((4\d{3})|(5[1-5]\d{2})|(6011))-?\d{4}-?\d{4}-?\d{4}|3[4,7][\d\s-]{15}$";
            return MatchString(strCCNumber, regExPattern);
        }


        public static bool IsValidSSN(string strSSN)
        {
            // Allows SSN's of the format 123-456-7890. Accepts hyphen delimited SSN’s or plain numeric values.
            string regExPattern = @"^\d{3}[-]?\d{2}[-]?\d{4}$";
            return MatchString(strSSN, regExPattern);
        }


        public static bool IsValidEmailAddress(string strEmail)
        {
            // Allows common email address that can start with a alphanumeric char and contain word, dash and period characters
            // followed by a domain name meeting the same criteria followed by a alpha suffix between 2 and 9 character lone
            string regExPattern = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
            return MatchString(strEmail, regExPattern);
        }


        public static bool IsValidURL(string strURL)
        {
            // Allows HTTP and FTP URL's, domain name must start with alphanumeric and can contain a port number
            // followed by a path containing a standard path character and ending in common file suffixies found in URL's
            // and accounting for potential CGI GET data
            string regExPattern = @"^^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_=]*)?$";
            return MatchString(strURL, regExPattern);
        }


        public static bool IsValidIPAddress(string strIP)
        {
            // Allows four octets of numbers that contain values between 4 numbers in the IP address to 0-255 and are separated by periods
            string regExPattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            return MatchString(strIP, regExPattern);
        }


        public static bool IsValidAlphaText(string strAlpha)
        {
            // Allows one or more alphabetical characters. This is a more generic validation function.
            string regExPattern = @"^[A-Za-z- .]+$";
            return MatchString(strAlpha, regExPattern);
        }


        public static bool IsValidAlphaNumericText(string strAlphaNum)
        {
            // Allows one or more alphabetical and/or numeric characters. This is a more generic validation function.
            string regExPattern = @"^[A-Za-z0-9]+$";
            return MatchString(strAlphaNum, regExPattern);
        }


        public static bool IsValidNumericText(string strNumeric)
        {
            // Allows one or more positive or negative, integer or decimal numbers. This is a more generic validation function.
            string regExPattern = @"/[+-]?\d+(\.\d+)?$";
            return MatchString(strNumeric, regExPattern);
        }
    }
}
