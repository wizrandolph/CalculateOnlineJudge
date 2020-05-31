using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOnlineJudge.DataBaseAccessFactory_DAL;
using CalculateOnlineJudge.Entity;

namespace CalculateOnlineJudge.BusinessLogic_BLL
{
    public sealed class UserInfoLogic
    {
        private UserInfoLogic() { }
        public static OperationResult UpdateUserInfo(UserInfo userInfo, User user)
        {
            try
            {
                DataBaseFactory.DriveDataBase().UpdateUserInfo(userInfo, user.UserID);
            }
            catch (Exception)
            {
                return new OperationResult("未知错误，修改失败！", false);
            }
            return new OperationResult("修改成功！", true);
        }
        public static OperationResult<UserInfo> GetUserInfo(User user)
        {
            UserInfo userInfo = null;
            try
            {
                userInfo = DataBaseFactory.DriveDataBase().GetUserInfo(user.UserID);
                if (userInfo == null)
                {
                    return new OperationResult<UserInfo>("获取失败！", false, null);
                }
            }
            catch (Exception)
            {
                return new OperationResult<UserInfo>("未知错误，获取失败！", false, null);
            }
            return new OperationResult<UserInfo>("获取成功！", true, userInfo);
        }
    }
}
