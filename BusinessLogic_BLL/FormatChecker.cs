using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.BusinessLogic_BLL
{
    public sealed class FormatChecker
    {
        private FormatChecker() { }
        public static bool CheckUserNameFormat(string userName)
        {
            return userName == null ? false : Regex.IsMatch(userName, @"^[_A-Za-z0-9\u4E00-\u9FA5]{6,20}$");
        }
        public static bool CheckPasswordFormat(string password)
        {
            return password == null ? false : Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$");
        }
        public static bool CheckPhoneFormat(string phone)
        {
            return phone == null ? false : Regex.IsMatch(phone, @"^(13[0-9]|14[5|7]|15[0|1|2|3|5|6|7|8|9]|18[0|1|2|3|5|6|7|8|9])\d{8}$");
        }
        public static bool CheckEmailFormat(string email)
        {
            return email == null ? false : Regex.IsMatch(email, @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }
    }
}
