using System.Configuration;
using System.Reflection;

namespace CalculateOnlineJudge.DataBaseAccessFactory_DAL
{
    public sealed class ExerciseGeneratorFactory
    {
        private ExerciseGeneratorFactory() { }
        private static readonly string accessKey = "ExerciseGeneratorAccess";
        private static readonly string relativeClassName = "ExerciseGeneratorAccess";

        public static IExerciseGeneratorAccess DriveDataBase()
        {
            string path = ConfigurationManager.AppSettings[accessKey];
            string className = path + relativeClassName;
            return Assembly.Load(path).CreateInstance(className) as IExerciseGeneratorAccess;
        }
    }
}
