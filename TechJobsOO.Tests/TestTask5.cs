using TechJobs.Tests;
namespace TechJobsOO.Tests
{
	[TestClass]
    public class TestTask5
    {

        [TestMethod]  
        public void TestToStringStartsAndEndsWithNewLineExists()
        {
            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();
            string nameCheck = "TestToStringStartsAndEndsWithNewLine";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }
            Assert.AreEqual("true", existsCheck, "'TestToStringStartsAndEndsWithNewLine' not created");
        }


        [TestMethod] 
        public void Test_TestToString_Starts_And_Ends_With_NewLine()
        {

            string text = System.IO.File.ReadAllText("StartsAndEndsWithNewLine.txt").ToString();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var job = new RunTechJobs();
            job.RunProgram();
            var output = stringWriter.ToString();

            Assert.AreEqual(text, output, "New Line issue");
        }

        [TestMethod]  
        public void TestToStringContainsCorrectLabelsAndData_Exists()
        {

            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();
            string nameCheck = "TestToStringContainsCorrectLabelsAndData";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            Assert.AreEqual("true", existsCheck, "'TestToStringContainsCorrectLabelsAndData' not created");
        }


        [TestMethod]  
        public void Test_TestToStringContainsCorrectLabelsAndData()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var job = new RunTechJobs();
            job.RunProgram();
            var output = stringWriter.ToString();

            Assert.IsTrue(output.Contains($"Name: Product tester") && output.Contains("Employer: ACME") && output.Contains("Location: Desert") && output.Contains("Position Type: Quality control") && output.Contains("Core Competency: Persistence"));
        }



        [TestMethod] 
        public void TestToStringHandlesEmptyField_Exists()
        {

            Type testType = typeof(JobTests);
            MemberInfo[] memberInfos = testType.GetMembers();
            string nameCheck = "TestToStringHandlesEmptyField";
            string existsCheck = "";

            foreach (var mCheck in memberInfos)
            {
                if (mCheck.Name == nameCheck)
                {
                    existsCheck += "true";
                    break;
                }
            }

            Assert.AreEqual("true", existsCheck, "'TestToStringHandlesEmptyField' not created");
        }


        [TestMethod] 
        public void Test_TestToStringHandlesEmptyField()
        {
            string text = System.IO.File.ReadAllText("EmptyFieldTest.txt").ToString();
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
            var job = new RunTechJobs();
            job.RunProgram();
            var output = stringWriter.ToString();

            Assert.AreEqual(text, output, "Empty string handling error");
        }
    }
}

