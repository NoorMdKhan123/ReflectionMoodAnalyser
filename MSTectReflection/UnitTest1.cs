using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReflectioProject;
namespace MSTectReflection
{
    [TestClass]
    public class UnitTest1
    {
        //4.1 Given mood analyser class should return mood analyser object
        [TestMethod]
        public void GivenMoodAnalyserClass_ShouldReturnMoodAnalyser_Object()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse
                ("ReflectioProject.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
    }
}
