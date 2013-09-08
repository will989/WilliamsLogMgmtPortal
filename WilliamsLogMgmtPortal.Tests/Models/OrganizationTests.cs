using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WilliamsLogMgmtPortal.Models;

namespace WilliamsLogMgmtPortal.Tests.Models
{
    [TestClass()]
    public class OrganizationTests
    {
        [TestMethod()]
        public void validateGoodOrganizationTest()
        {
            Organization organization = new Organization();
            organization.OrganizationID = 1;
            organization.Name = "testorg";
            organization.Street = "Testing St";
            organization.City = "Anytown";
            organization.State = "CO";
            organization.Zip = "80000";
            organization.StartDate = System.DateTime.Now;

            Assert.IsTrue(organization.validate());

        }

        [TestMethod()]
        public void validateBadOrganizationTest()
        {
            Organization organization = new Organization();
            organization.OrganizationID = -1;
            organization.Name = "testorg";
            organization.Street = "Testing St";
            organization.City = "Anytown";
            organization.State = "CO";
            organization.Zip = "80000";
            organization.StartDate = System.DateTime.Now;

            Assert.IsFalse(organization.validate());

        }

        //verify that organizations are equal
        [TestMethod()]
        public void equalsTest()
        {
            DateTime current = System.DateTime.Now;

            Organization organization1 = new Organization();
            organization1.OrganizationID = 1;
            organization1.Name = "testorg";
            organization1.Street = "Testing St";
            organization1.City = "Anytown";
            organization1.State = "CO";
            organization1.Zip = "80000";
            organization1.StartDate = current;


            Organization organization2 = new Organization();
            organization2.OrganizationID = 1;
            organization2.Name = "testorg";
            organization2.Street = "Testing St";
            organization2.City = "Anytown";
            organization2.State = "CO";
            organization2.Zip = "80000";
            organization2.StartDate = current;

            Assert.IsTrue(organization1.equals(organization2));
        }

        //verify that organizations are different
        [TestMethod()]
        public void notEqualsTest()
        {
            DateTime current = System.DateTime.Now;

            Organization organization1 = new Organization();
            organization1.OrganizationID = 1;
            organization1.Name = "testorg";
            organization1.Street = "Testing St";
            organization1.City = "Anytown";
            organization1.State = "CO";
            organization1.Zip = "80000";
            organization1.StartDate = current;


            Organization organization2 = new Organization();
            organization2.OrganizationID = 2;
            organization2.Name = "testorg";
            organization2.Street = "Testing St";
            organization2.City = "Anytown";
            organization2.State = "CO";
            organization2.Zip = "80000";
            organization2.StartDate = current;

            Assert.IsFalse(organization1.equals(organization2));
        }
    }
}
