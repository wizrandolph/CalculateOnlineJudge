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
                if(!FormatChecker.CheckEmailFormat(userInfo.Email))
                {
                    return new OperationResult("邮箱格式错误！", false);
                }
                if(!FormatChecker.CheckPhoneFormat(userInfo.Phone))
                {
                    return new OperationResult("手机号格式错误！", false);
                }
                DataBaseFactory.DriveDataBase().UpdateUserInfo(userInfo, user.UserID);
            }
            catch (Exception e)
            {
                return new OperationResult("修改失败！" + e.Message, false);
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
            catch (Exception e)
            {
                return new OperationResult<UserInfo>("获取失败！" + e.Message, false, null);
            }
            return new OperationResult<UserInfo>("获取成功！", true, userInfo);
        }
    }
}
