using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CalculateOnlineJudge.Entity;

namespace CalculateOnlineJudge.SQLServerAccess_DAL
{
    public partial class DataBaseAccess : CalculateOnlineJudge.DataBaseAccessFactory_DAL.IDataBaseAccess
    {
        public bool CreateUser(string userName, string password)
        {
            bool success = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(
                string.Format(
                    @"            
                    DECLARE @responseMessage bit
                    EXEC dbo.AddUser
                        @userName = N'{0}',
                        @password = N'{1}',
                        @responseMessage = @responseMessage OUTPUT
                    SELECT 
                        @responseMessage
                    "
                    , userName, password),
                    connection
                    );
                try
                {
                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read() && reader.HasRows)
                    {
                        success = reader.GetBoolean(0);
                    }
                }
                catch (Exception)
                {
                    success = false;
                }
            }
            return success;
        }
        public void DeleteUser(int userID)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(
                string.Format(
                    @"            
                    DELETE FROM
                        dbo.user_table
                    WHERE
                        userid = {0}
                    DELETE FROM
                        dbo.userinfo_table
                    WHERE
                        userid = {0}
                    DELETE FROM
                        dbo.judgeinfo_table
                    WHERE
                        userid = {0}
                    "
                    , userID),
                    connection
                    );
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public bool LogInUser(string userName, string password)
        {
            bool isSuccess = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    string.Format(
                        @"            
                        DECLARE @responseMessage bit
                        EXEC dbo.LogInUser
                            @userName = N'{0}',
                            @password = N'{1}',
                            @responseMessage = @responseMessage OUTPUT
                        SELECT
                            @responseMessage
                        ",
                        userName,
                        password),
                    connection
                    );
                try
                {
                    connection.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read() && reader.HasRows)
                    {
                        isSuccess = reader.GetBoolean(0);
                    }
                }
                catch (Exception)
                {
                    isSuccess = false;
                }
            }
            return isSuccess;
        }
        public bool CheckUserName(string userName)
        {
            bool isUnique = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    string.Format(
                        @"
                        SELECT 
                            userid 
                        FROM 
                             dbo.user_table 
                        WHERE 
                            name = N'{0}'
                        ",
                        userName),
                    connection);
                command.Connection.Open();
                var reader = command.ExecuteReader();
                isUnique = !(reader.Read() && reader.HasRows);
            }
            return isUnique;
        }
        public User GetUser(int userID)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(
                    string.Format(
                        @"
                        SELECT 
                            name 
                        FROM            
                             dbo.user_table 
                        WHERE 
                            userid = {0}
                        ",
                        userID),
                    connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read() && reader.HasRows)
                {
                    user = new User(userID, reader.GetString(1));
                }
            }
            return user;
        }
    }
}
