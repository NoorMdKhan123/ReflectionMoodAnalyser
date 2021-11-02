using System;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace ReflectioProject
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse
            (string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);

                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.
                        ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.
                    ExceptionType.NO_SUCH_METHOD, "Cosntructor is not found");
            }
        }
    }
}
