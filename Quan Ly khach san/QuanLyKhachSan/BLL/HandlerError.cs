using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class HandlerError
    {
        public static string sanitizeString(string raw)
        {
            string invalidChar = " ~!@#$%^&*()+_`-=,./<>?;':[]{ }\\|";
            foreach (var symbol in invalidChar.ToCharArray())
            {
                raw = raw.Replace(symbol.ToString(), string.Empty);
            }
            return raw.Trim();
        }
        public static void CheckRequire(string raw, string errMessage)
        {
            if (sanitizeString(raw).Length == 0)
                throw new Exception(errMessage);
        }
        public static void CheckLengthEqualTO(string raw, int length, string errMessage)
        {
            if (sanitizeString(raw).Length != length)
                throw new Exception(errMessage);
        }
        public static void checkminlength(string raw, int min, string errmessage)
        {
            if (sanitizeString(raw).Length < min)
                throw new Exception(errmessage);
        }
        public static void checkmaxlength(string raw, int max, string errmessage)
        {
            if (sanitizeString(raw).Length > max)
                throw new Exception(errmessage);
        }
        //public static void AutoCheck(object[] param = null, string[] err = null, string[] errNumber = null, int[] number = null)
        //{
        //    if (param != null && err != null)
        //    {
        //        int i = 0;
        //        foreach (string item in param)
        //        {
        //            CheckRequire(item, err[i]);
        //            if(number != null && errNumber !=null)
        //            {
        //                CheckLengthEqualTO(item, number[i], errNumber[i]);

        //            }
        //            i++;
        //        }
        //    }
              
        //}
    }
}
