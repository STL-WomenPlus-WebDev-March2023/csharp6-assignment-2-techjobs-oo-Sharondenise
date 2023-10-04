using System;
namespace TechJobsOO.Tests
{
	[TestClass]
	public class TestTask6
	{
         
        [TestMethod] 
        public void Test_Attributes_Of_JobField()
        {
            Type jFType = typeof(JobField);
            var expected = jFType.Attributes.ToString().Contains("Abstract") ? "true" : "false";

            Assert.AreEqual(expected, "true", "JobField is not an abstract class");
        }


        [TestMethod] 
        public void Test_DRY_Employer()
        {
            Type empType = typeof(Employer);
            ConstructorInfo[] constructorInfos = empType.GetConstructors();
            int conLength = constructorInfos.Length;
            MethodInfo[] methodInfos = empType.GetMethods();
            int methodLength = methodInfos.Length;

            Assert.AreEqual(1, conLength, "Employer class constructors not properly refactored");
            Assert.IsTrue(methodLength < 8, "Employer class methods not properly refactored");
        }


        [TestMethod] 
        public void Test_DRY_Location()
        {
            Type locType = typeof(Location);
            ConstructorInfo[] constructorInfos = locType.GetConstructors();
            int conLength = constructorInfos.Length;
            MethodInfo[] methodInfos = locType.GetMethods();
            int methodLength = methodInfos.Length;

            Assert.AreEqual(1, conLength, "Location class constructors not properly refactored");
            Assert.IsTrue(methodLength < 8, "Location class methods not properly refactored");
        }


        [TestMethod] 
        public void Test_DRY_Position()
        {
            Type posType = typeof(PositionType);
            ConstructorInfo[] constructorInfos = posType.GetConstructors();
            int conLength = constructorInfos.Length;
            MethodInfo[] methodInfos = posType.GetMethods();
            int methodLength = methodInfos.Length;

            Assert.AreEqual(1, conLength, "PositionType class constructors not properly refactored");
            Assert.IsTrue(methodLength < 8, "PositionType class methods not properly refactored");
        }


        [TestMethod] 
        public void Test_DRY_CoreCompetency()
        {
            Type ccType = typeof(CoreCompetency);
            ConstructorInfo[] constructorInfos = ccType.GetConstructors();
            int conLength = constructorInfos.Length;
            MethodInfo[] methodInfos = ccType.GetMethods();
            int methodLength = methodInfos.Length;

            Assert.AreEqual(1, conLength, "CoreCompetency class constructors not properly refactored");
            Assert.IsTrue(methodLength < 8, "CoreCompetency class methods not properly refactored");
        }

    }
}

