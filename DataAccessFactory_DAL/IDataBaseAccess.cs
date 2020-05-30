using CalculateOnlineJudge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.DataBaseAccessFactory_DAL
{
    public interface IDataBaseAccess
    {
        #region User
        bool CreateUser(string userName, string password);
        void DeleteUser(int userID);
        bool LogInUser(string userName, string password);
        bool CheckUserName(string userName);
        User GetUser(int userID);
        #endregion
        #region UserInfo
        void UpdateUserInfo(UserInfo userInfo, int userID);
        UserInfo GetUserInfo(int userID);
        #endregion
        #region JudgeInfo
        void UpdateJudgeInfo(JudgeInfo judgeInfo, int userID);
        UserInfo GetJudgeInfo(int userID);
        #endregion
    }
}
