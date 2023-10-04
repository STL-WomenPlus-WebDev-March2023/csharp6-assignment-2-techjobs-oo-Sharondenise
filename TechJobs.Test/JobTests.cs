
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace TechJobs.Tests
{
	[TestClass]
	public class JobTests
	{
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(job1.Id != job2.Id);
            Assert.AreEqual(job2.Id, job1.Id + 1);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester");
            Assert.AreEqual(job3.EmployerName.Value, "ACME");
            Assert.AreEqual(job3.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job3.JobType.Value, "Quality control");
            Assert.AreEqual(job3.JobCoreCompetency.Value, "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string jobString = job3.ToString();
            Assert.IsTrue(jobString.StartsWith("\n"));
            Assert.IsTrue(jobString.EndsWith("\n"));
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.AreEqual(job3.ToString(), $"\nID: {job3.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n");
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            //string emptyString = "";
            //Assert.AreEqual(emptyString.ToString, "");
        }
    }
}

//job3.ToString().Contains()