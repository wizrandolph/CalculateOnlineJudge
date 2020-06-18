using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOnlineJudge.Entity;
using CalculateOnlineJudge.DataBaseAccessFactory_DAL;

namespace CalculateOnlineJudge.BusinessLogic_BLL
{
    public sealed class UserLogic
    {
        private UserLogic() { }

        public static OperationResult CreateUser(string userName, string password)
        {
            try
            {
                if (!FormatChecker.CheckUserNameFormat(userName))
                {
                    return new OperationResult("用户名格式错误，创建失败！", false);
                }
                if (!FormatChecker.CheckPasswordFormat(password))
                {
                    return new OperationResult("密码格式错误，创建失败！", false);
                }
                if (!DataBaseFactory.DriveDataBase().CheckUserName(userName))
                {
                    return new OperationResult("用户名不唯一，创建失败！", false);
                }
                if (!DataBaseFactory.DriveDataBase().CreateUser(userName, password))
                {
                    return new OperationResult("创建失败！", false);
                }
            }
            catch (Exception e)
            {
                return new OperationResult("创建失败！" + e.Message, false);
            }
            return new OperationResult("用户创建成功！", true);
        }
        public static OperationResult<User> LogInUser(string userName, string password)
        {
            User user = null;
            try
            {
                if (!FormatChecker.CheckUserNameFormat(userName))
                {
                    return new OperationResult<User>("用户名格式错误，创建失败！", false, null);
                }
                if (!FormatChecker.CheckPasswordFormat(password))
                {
                    return new OperationResult<User>("密码格式错误，创建失败！", false, null);
                }
                if (!DataBaseFactory.DriveDataBase().LogInUser(userName, password))
                {
                    return new OperationResult<User>("用户不存在或密码错误，登录失败！", false, null);
                }
                user = DataBaseFactory.DriveDataBase().GetUser(userName);
            }
            catch (Exception e)
            {
                return new OperationResult<User>("创建失败！" + e.Message, false, null);
            }
            return new OperationResult<User>("用户登录成功！", true, user);
        }
        public static OperationResult DeleteUser(User user)
        {
            try
            {
                DataBaseFactory.DriveDataBase().DeleteUser(user.UserID);  
            }
            catch (Exception e)
            {
                return new OperationResult("删除失败！" + e.Message, false);
            }
            return new OperationResult("用户删除成功！", true);
        }
    }
}
