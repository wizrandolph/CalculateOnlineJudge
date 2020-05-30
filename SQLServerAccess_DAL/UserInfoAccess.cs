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
        public UserInfo GetUserInfo(int userID)
        {
            UserInfo userInformation = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    string.Format(
                        @"
                        SELECT 
                            birth, 
                            phone, 
                            email
                        FROM  
                            dbo.userinformation_table 
                        WHERE 
                            userID = {0}
                        ",
                        userID),
                    connection);
                command.Connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read() && reader.HasRows)
                {
                    userInformation = new UserInfo(
                        reader.IsDBNull(0) ? (DateTime?)null : reader.GetDateTime(0)
                        , reader.IsDBNull(1) ? null : reader.GetString(1)
                        , reader.IsDBNull(2) ? null : reader.GetString(2));
                }
            }
            return userInformation;
        }
        public void UpdateUserInfo(UserInfo userInfo, int userID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    string.Format(
                        @"
                        UPDATE  
                            dbo.userinformation_table 
                        SET 
                            birth = {0} 
                            phone = N'{1}'
                            email = N'{2}'
                        WHERE 
                            userid = {3}
                        ",
                        userInfo.Birthday,
                        userInfo.Phone,
                        userInfo.Email,
                        userID),
                    connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
