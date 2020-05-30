using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.Entity
{
    public class UserInfo
    {
        private DateTime? birthday;
        private string phone;
        private string email;

        public UserInfo(DateTime? birthday, string phone, string email)
        {
            this.birthday = birthday;
            this.phone = phone;
            this.email = email;
        }

        public DateTime? Birthday { get => birthday; set => birthday = (DateTime?)value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}
