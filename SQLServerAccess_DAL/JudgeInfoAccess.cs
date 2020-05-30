using CalculateOnlineJudge.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.SQLServerAccess_DAL
{
    public partial class DataBaseAccess : CalculateOnlineJudge.DataBaseAccessFactory_DAL.IDataBaseAccess
    {
        public JudgeInfo GetJudgeInfo(int userID)
        {
            JudgeInfo userInformation = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    string.Format(
                        @"
                        SELECT 
                            totalNum, 
                            errorNum, 
                            latestTime
                        FROM  
                            dbo.judgeinformation_table 
                        WHERE 
                            userID = {0}
                        ",
                        userID),
                    connection);
                command.Connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read() && reader.HasRows)
                {
                    userInformation = new JudgeInfo(
                        reader.GetInt32(0)
                        , reader.GetInt32(1)
                        , reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2));
                }
            }
            return userInformation;
        }

        public void UpdateJudgeInfo(JudgeInfo judgeInfo, int userID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    string.Format(
                        @"
                        UPDATE  
                            dbo.judgeinformation_table 
                        SET 
                            totalNum = {0} 
                            errorNum = {1}
                            latestTime = N'{2}'
                        WHERE 
                            userid = {3}
                        ",
                        judgeInfo.QuestionNum,
                        judgeInfo.QuestionErrorNum,
                        judgeInfo.LastestCompleteTime,
                        userID),
                    connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
