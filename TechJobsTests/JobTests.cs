using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class TechJobsTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10,10,.001);

        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(1, job1.Id);
            Assert.AreEqual(2, job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", test_job.Name);
            Assert.AreEqual("ACME", test_job.EmployerName.Value);
            Assert.AreEqual("Desert", test_job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test_job.JobType.Value);
            Assert.AreEqual("Persistence", test_job.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job test_job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(test_job == test_job2);

        }

    }
}
