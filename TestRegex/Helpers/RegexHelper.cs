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
            return Regex.IsMatch(txt, @"(^(\+[0-9]{2}\s)?(([0-9]{9}))$)$|(^(\+[0-9]{2}\s)?(([0-9]{3}\s[0-9]{3}\s[0-9]{3}))$)$|(\+[0-9]{11})$|(\+[0-9]{3}\s[0-9]{8})$|(\+[0-9]{3}\s[0-9]{2}\s[0-9]{3}\s[0-9]{3})$|(^(\+[0-9]{3}\s)?(([0-9]{3}\s[0-9]{3}\s[0-9]{4}))$)$|(\+[0-9]{3}\s[0-9]{10})$|(\+[0-9]{1}\s\([0-9]{3}\)\s[0-9]{3}-[0-9]{4})$|(\+[0-9]{1}\s[0-9]{3}\s[0-9]{3}\s[0-9]{4})$|(\+[0-9]{1}\s[0-9]{3}\s[0-9]{7})$");
            #region Validaciones
            //Ejemplo españa: +34 xxxxxxxxx  o +34 123 12 12 12 + 123123123
            //Ejemplo Uy: +598 12312312 o +598 12 123 123
            //Ejemplo Argentina: +54 9 12 1234-1234 + +54 9 XXX XXX XXXX
            //Ejemplo Usa: +1 (123) 123-1234 o +1 123 123 1234

            //Validar formatos 
            //España: (prefijo2 + 9 numeros)
            //@"(^(\+[0-9]{2}\s)?(([0-9]{9})$|([0-9]{3}\s[0-9]{3}\s[0-9]{3})))$|(\+[0-9]{11})$"

            // +34 012345678     ^(\+[0-9]{2}\s)?(([0-9]{9}))$
            // +34 012 345 678   ^(\+[0-9]{2}\s)?(([0-9]{3}\s[0-9]{3}\s[0-9]{3}))$
            // 012345678         (igual que +34 xxxxxxxxx)
            // 012 345 678 (igual que +34 xxx xxx xxx)
            // +34012345678 (\+[0-9]{11})$

            //Uruguay: (prefijo3 + 8 o 9 números)
            //@"(\+[0-9]{3}\s[0-9]{8})$|(\+[0-9]{3}\s[0-9]{2}\s[0-9]{3}\s[0-9]{3})$|(0[0-9]{8})$"

            // +598 12345678   (\+[0-9]{3}\s[0-9]{8})$
            // +598 12 345 678 (\+[0-9]{3}\s[0-9]{2}\s[0-9]{3}\s[0-9]{3})$
            // 012345678 (0[0-9]{8})$ (igual que la A de españa)
            // 012 345 678 (0[0-9]{2}\s[0-9]{3}\s[0-9]{3})$ (igual que la B de españa)
            // +59801234567 (\+[0-9]{11})$  (igual que la C de españa)


            //Argentina (prefijo3 + 10 números)
            // +549 012 345 6789     ^(\+[0-9]{3}\s)?(([0-9]{3}\s[0-9]{3}\s[0-9]{4}))$
            // +549 0123456789       (\+[0-9]{3}\s[0-9]{10})$
            // 012 345 6789 (igual que F)

            // Usa (prefijo1 + 10 números)
            // +1 (012) 345-6789    (\+[0-9]{1}\s\([0-9]{3}\)\s[0-9]{3}-[0-9]{4})$
            // +1 012 345 6789  (\+[0-9]{1}\s[0-9]{3}\s[0-9]{3}\s[0-9]{4})$
            // +1 012 3456789 (\+[0-9]{1}\s[0-9]{3}\s[0-9]{7})$


            //Valida:
            //+34 012345678
            //012345678
            //012 345 678
            //+34 012 345 678
            //+34012345678
            //+598 12345678
            //+598 12 345 678
            //+549 012 345 6789
            //+549 0123456789
            //012 345 6789
            //+1 (012) 345-6789 
            //+1 012 345 6789  
            //+1 012 3456789 
            #endregion
        }

    }
}
