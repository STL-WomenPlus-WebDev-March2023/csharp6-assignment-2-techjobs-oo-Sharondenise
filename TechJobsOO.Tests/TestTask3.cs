
namespace TechJobsOO.Tests
{
	[TestClass]
	public class TestTask3
	{
        [TestMethod]
        public void Test_JobClass_Has_No_Arg_Constructor()
        {
            Type jobType = typeof(Job);
            ConstructorInfo[] constructorInfos = jobType.GetConstructors();
            List<string> conNames = new List<string>();
            string nameCheck = "No Arg Constructor";
            string existsCheck = "";

            foreach (var name in constructorInfos)
            {
                conNames.Add(name.ToString());
            }

            foreach (string name in conNames)
            {
                if (name.Equals("Void .ctor()"))
                {
                    existsCheck += "No Arg Constructor";
                    break;
                }
            }
            Assert.AreEqual(existsCheck, nameCheck, "No Argument Constructor exists");
        }


        [TestMethod]
        public void Test_No_Arg_Constructor_Sets_Unique_Id()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.AreNotEqual(testJob1, testJob2, "Unique Id Test");
            Assert.AreEqual(testJob2, testJob2, "Should have same Id");
        }


        [TestMethod] 
        public void Test_JobClass_Has_Second_Constructror()
        {
            Type jobType = typeof(Job);
            ConstructorInfo[] constructorInfos = jobType.GetConstructors();
            List<string> conNames = new List<string>();
            string nameCheck = "Second Constructor";
            string existsCheck = "";

            foreach (var name in constructorInfos)
            {
                conNames.Add(name.ToString());
            }

            foreach (string name in conNames)
            {
                if (name.Contains("Void .ctor(System.String, TechJobsOOAutoGraded6.Employer,"))
                {
                    existsCheck += "Second Constructor";
                    break;
                }
            }
            Assert.AreEqual(existsCheck, nameCheck, "Second Constructor Test");
        }


        [TestMethod] 
        public void Test_JobClass_Has_Accessors()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(testJob1.Name, "Product tester", "Testing Job Name");
            Assert.AreEqual(testJob1.EmployerName.ToString(), "ACME", "Testing EmployerName Value");
            Assert.AreEqual(testJob1.EmployerLocation.ToString(), "Desert", "Testing EmployerLocation Value");
            Assert.AreEqual(testJob1.JobType.ToString(), "Quality control", "Testing JobType Value");
            Assert.AreEqual(testJob1.JobCoreCompetency.ToString(), "Persistence", "Testing JobCoreCompetency Value");
            Assert.AreNotEqual(testJob1.Id, testJob2.Id, "Job objects should have unique ids");
        }


        [TestMethod] 
        public void Test_Equals_Method_Setup()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            MethodInfo mInfo = typeof(Job).GetMethod("Equals");
            MethodBody mBody = mInfo.GetMethodBody();
            int lviCount = mBody.LocalVariables.Count;
            string mName = mInfo.ReflectedType.Name;
            string mGBD = mInfo.GetBaseDefinition().ReflectedType.Name;

            Assert.AreNotEqual(mName, mGBD, "Equals method doesn't belong to Job Class");
            Assert.AreEqual(lviCount, 2, "Equals method doesn't have correct number of local variables");

            Assert.AreEqual(testJob1, testJob1, "Objects with same ID are equal");
            Assert.AreNotEqual(testJob1, testJob2, "Objects with different ID are not equal");
        }


        [TestMethod] 
        public void Test_GetHashCode_Setup()
        {
            Job testJob1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            MethodInfo mInfo = typeof(Job).GetMethod("GetHashCode");
            MethodBody mBody = mInfo.GetMethodBody();
            int localCount = mBody.LocalVariables.Count;

            Assert.IsTrue(localCount > 0, "GetHashCode not method setup");

            Assert.AreNotEqual(testJob1.GetHashCode(), testJob2.GetHashCode(), "GetHashCode output test");
        }
    }
}

