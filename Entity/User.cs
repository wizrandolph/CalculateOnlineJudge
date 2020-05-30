using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.Entity
{
    public class User
    {
        private readonly int userID;
        private readonly string userName;

        public User()
        {
        }

        public User(int userID, string userName)
        {
            this.userID = userID;
            this.userName = userName;
        }

        public string UserName { get => userName; }
    }
}
