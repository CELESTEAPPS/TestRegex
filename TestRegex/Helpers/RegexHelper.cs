using System.Text.RegularExpressions;

namespace TestRegex.Helpers
{
    public class RegexHelper
    {
        public static bool IsContainsText(string txt)
        {
            string pattern = @"([A-Za-z])";
            var IsMatchES = Regex.IsMatch(txt, pattern);

            if (IsMatchES)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsNumber(string txt)
        {
            string pattern = @"([0-9])";
            var IsMatchES = Regex.IsMatch(txt, pattern);

            if (IsMatchES)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsAlphaNumeric(string txt)
        {
            string pattern = @"(^[A-Za-z0-9]+$)";
            var IsMatchES = Regex.IsMatch(txt, pattern);

            if (IsMatchES)
            {
                return true;
            }
            return false;
        }
        public static bool IsValidUserNameId(string txt)
        {
            string pattern = @"(^[A-Za-z0-9]+$)";
            var IsMatchES = Regex.IsMatch(txt, pattern);

            if (IsMatchES)
            {
                return true;
            }
            return false;
        }
        public static bool IsValidUserNameIdBox(string txt)
        {
            string pattern = @"(^[A-Za-z0-9]{6,30}$)";
            var IsMatchES = Regex.IsMatch(txt, pattern);

            if (IsMatchES)
            {
                return true;
            }
            return false;
        }
        public static bool IsCoordinatesTxt(string txt)
        {
            string pattern = @"[^a-zA-Z]([-]?([0-9]{0,2}\.[0-9]{6})1*)";
            var IsMatchES = Regex.IsMatch(txt, pattern);

            if (IsMatchES)
            {
                return true;
            }
            return false;
        }
        public static bool IsDuplicateWords(string txt)
        {
            txt = txt.ToLower();
            string pattern = @"\b(\w+?)\s\1\b";

            var IsMatchES = Regex.IsMatch(txt, pattern);

            if (IsMatchES)
            {
                return true;
            }
            return false;
        }
        public static bool Is_A_URLTxt(string txt)
        {
            txt = txt.ToLower();
            var cadenaURLS =
                "http://|" +
                "https://|" +
                "ftp://|" +
                "://";

            var exp1 = "\\w+(" + cadenaURLS + ")\\w+";
            var exp2 = "(" + cadenaURLS + ")\\w+";
            var exp3 = "\\w+(" + cadenaURLS + ")";
            var exp4 = "(" + cadenaURLS + ")";

            var IsMatchES = Regex.IsMatch(txt, exp1) || Regex.IsMatch(txt, exp2) || Regex.IsMatch(txt, exp3) || Regex.IsMatch(txt, exp4);

            if (IsMatchES)
            {
                return true;
            }


            return false;
        }
        public static bool Is_Facebook_bool(string txt)
        {
            txt = txt.ToLower();

            var cadenaURLS = "facebook.com";

            var exp1 = "\\w+(" + cadenaURLS + ")\\w+";
            var exp2 = "(" + cadenaURLS + ")\\w+";
            var exp3 = "\\w+(" + cadenaURLS + ")";
            var exp4 = "(" + cadenaURLS + ")";

            var IsMatchES = Regex.IsMatch(txt, exp1) || Regex.IsMatch(txt, exp2) || Regex.IsMatch(txt, exp3) || Regex.IsMatch(txt, exp4);

            if (IsMatchES)
            {
                return true;
            }


            return false;
        }
        public static bool IsValidEmail(string txt)
        {
            //https://stackoverflow.com/questions/5342375/regex-email-validation
            return Regex.IsMatch(txt, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public static bool IsValidPhone(string txt)
        {
            //https://stackoverflow.com/questions/18584492/regular-expression-for-asp-net-for-international-local-phone-numbers
            return Regex.IsMatch(txt, @"^([\+]?[0-9]{1,3}[\s.-][0-9]{1,12})([\s.-]?[0-9]{1,4}?)$");
        }

    }
}
