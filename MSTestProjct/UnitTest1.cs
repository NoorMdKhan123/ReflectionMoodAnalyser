
using System;
using System.Collections.Generic;
using System.Text;
using ReflectioProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProjct
{
    [TestClass]
    public class UnitTest1
    {
       

        //5.1 Given Mood Analyser class name should return mood analyser object
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyseObject_Using_ParamaterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingPrametrizedConstructor("ReflectioProject.MoodAnalyser",
                "MoodAnalyser", "HAPPY");

        }


    }
}