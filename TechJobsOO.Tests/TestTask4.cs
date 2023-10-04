using TechJobs.Tests;
namespace TechJobsOO.Tests
{
    [TestClass]
	public class TestTask4
	{

        [TestMethod] 
        public void Test_TestSettingJobIdExists()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();
            string nameCheck = "TestSettingJobId";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }
            Assert.AreEqual("true", existsCheck, "'TestSettingJobId' not created");
        }


        [TestMethod] 
        public void Test_TestJobConstructorSetsAllFields()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();
            string nameCheck = "TestJobConstructorSetsAllFields";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            Assert.AreEqual("true", existsCheck, "'TestJobConstructorSetsAllFields' not found");
        }


        [TestMethod] 
        public void Test_TestJobsForEquality()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();
            string nameCheck = "TestJobsForEquality";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }
            Assert.AreEqual("true", existsCheck, "'TestJobsForEquality' not found");
        }

    }
}

