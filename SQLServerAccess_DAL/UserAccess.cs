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
                    DECLARE @responseMessage bit
                    EXEC dbo.DeleteUser
                        @userID = N'{0}',
                        @responseMessage = @responseMessage OUTPUT
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
        public User GetUser(string userName)
        {
            User user = null;
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
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read() && reader.HasRows)
                {
                    user = new User(reader.GetInt32(0), userName);
                }
            }
            return user;
        }
    }
}
