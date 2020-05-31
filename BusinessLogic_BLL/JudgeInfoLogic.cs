using CalculateOnlineJudge.DataBaseAccessFactory_DAL;
using CalculateOnlineJudge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.BusinessLogic_BLL
{
    public sealed class JudgeInfoLogic
    {
        private JudgeInfoLogic() { }
        public static OperationResult UpdateJudgeInfo(JudgeInfo judgeInfo, User user)
        {
            try
            {
                DataBaseFactory.DriveDataBase().UpdateJudgeInfo(judgeInfo, user.UserID);
            }
            catch (Exception)
            {
                return new OperationResult("未知错误，修改失败！", false);
            }
            return new OperationResult("修改成功！", true);
        }
        public static OperationResult<JudgeInfo> GetJudgeInfo(User user)
        {
            JudgeInfo judgeInfo = null;
            try
            {
                judgeInfo = DataBaseFactory.DriveDataBase().GetJudgeInfo(user.UserID);
                if (judgeInfo == null)
                {
                    return new OperationResult<JudgeInfo>("获取失败！", false, null);
                }
            }
            catch (Exception)
            {
                return new OperationResult<JudgeInfo>("未知错误，获取失败！", false, null);
            }
            return new OperationResult<JudgeInfo>("获取成功！", true, judgeInfo);
        }
    }
}
