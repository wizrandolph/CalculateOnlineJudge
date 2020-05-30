using System.Configuration;
using System.Reflection;

namespace CalculateOnlineJudge.DataBaseAccessFactory_DAL
{
    public sealed class DataBaseFactory
    {
        private DataBaseFactory() { }
        private static readonly string accessKey = "DataBaseAccess";
        private static readonly string relativeClassName = "DataBaseAccess";

        public static IDataBaseAccess DriveDataBase()
        {
            string path = ConfigurationManager.AppSettings[accessKey];
            string className = path + relativeClassName;
            return Assembly.Load(path).CreateInstance(className) as IDataBaseAccess;
        }
    }
}
