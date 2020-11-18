using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;


namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //testing ID numbers
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();

            testJob1.Id.Equals(testJob2.Id);
            Assert.IsFalse(testJob1.Id == testJob2.Id);
        }

        //testing full constuctor
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", testJob3.Name);
            Assert.AreEqual("ACME", testJob3.EmployerName.Value);
            Assert.AreEqual("Desert", testJob3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", testJob3.JobType.Value);
            Assert.AreEqual("Persistence", testJob3.JobCoreCompetency.Value);
        }

        //testing the Equals() method
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job testJob5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(testJob4.Id.Equals(testJob5.Id));
        }

        //testing ToString() method
        [TestMethod]
        public void TestToString()
        {
            Job testJob6 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string expected = "ID: 1 \n"
                + "Name: Product tester \n"
                + "Employer: ACME \n"
                + "Location: Desert \n"
                + "Position Type: Quality control \n"
                + "Core Competency: Persistence \n";

            Assert.AreEqual(expected, testJob6.ToString());
        }
    }
}
