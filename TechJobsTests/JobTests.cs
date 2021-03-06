using System;
using System.Collections.Generic;
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
            Assert.IsTrue(job2.Id - job1.Id == 1);
            
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

        [TestMethod]
        public void TestJobsToStringMethodForBlankSpace()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string output = test_job.ToString();
            Assert.IsTrue(output.StartsWith("\n"));
            Assert.IsTrue(output.EndsWith("\n"));
        }

        [TestMethod]
        public void TestJobToStringMethodForFields()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_job.ToString().Contains("ID"));
            Assert.IsTrue(test_job.ToString().Contains("Name"));
            Assert.IsTrue(test_job.ToString().Contains("Employer"));
            Assert.IsTrue(test_job.ToString().Contains("Location"));
            Assert.IsTrue(test_job.ToString().Contains("Job"));
            Assert.IsTrue(test_job.ToString().Contains("Competency"));
        }

         [TestMethod]
         public void IsPropertyValueEmpty()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency(""));

            Assert.IsTrue(string.IsNullOrEmpty(test_job.JobCoreCompetency.Value));
            
        }

        [TestMethod]
        public void TestJobToStringDataNotAvailableOutput()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency(""));
            string toFind = "Competency: Data not available";
            var strLength = toFind.Length;
            var stringIndex = test_job.ToString().IndexOf(toFind);
            Assert.AreEqual("Competency: Data not available", test_job.ToString().Substring(stringIndex, strLength));
         

        }

        [TestMethod]
        public void TestJobToStringDataDisplaysAfterCategory()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency(""));
            int findId = test_job.Id;
            string findName = "Name: Product tester";
            string findEmployer = "Employer: ACME";
            string findLocation = "Location: Desert";
            string findJob = "Job: Quality control";
            string findCompetency = "Competency: Data not available";

            var labels = new List<string>() { findName, findEmployer, findLocation, findJob, findCompetency};
            string idString = findId.ToString();
            int idLength = idString.Length;
            var idIndex = test_job.ToString().IndexOf(idString);

            foreach(var item in labels)
            {
                var strLength = item.Length;
                var stringIndex = test_job.ToString().IndexOf(item);
                Assert.AreEqual(item, test_job.ToString().Substring(stringIndex, strLength));
            }
                Assert.AreEqual(idString, test_job.ToString().Substring(idIndex, idLength));
        }

            
        [TestMethod]
        public void TestJobToStringOutputToEntireExpectedOutput()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual($"\nID: {test_job.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert\nJob: Quality control\nCompetency: Persistence\n", test_job.ToString());
        }

        [TestMethod]
        public void TestJobToStringMethodForOnlyIdOutput()
        {
            Job test_job = new Job();
            Assert.AreEqual("OOPS! This job does not seem to exist.", test_job.ToString());
        }


    }

}




                


                

            
           
            
                                        


           

