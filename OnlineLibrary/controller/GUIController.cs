using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLibrary.controller
{
   public class GUIController
    {
        public static Boolean checkRegisterSucces;
        public static Boolean isValidEmail(String email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static string encrypt(string parola)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = md5.ComputeHash(utf8.GetBytes(parola));
            return Convert.ToBase64String(data);
        }

        public static Boolean checkLoginSucces;
        public static string roleAccess;
        public static Boolean checkInsertSucces;
        public static Boolean checkDeleteBookSuccess;
        public static Boolean checkUpdateBookSuccess;
        public static string getFullName;
        public static Boolean checkBookIssueSuccess;
        public static Boolean checkBookReturnedSuccess;
        public static Boolean checkDeleteIssuedBookSuccess;
        public static Boolean numberOfIssuedBooks;
    }
}
