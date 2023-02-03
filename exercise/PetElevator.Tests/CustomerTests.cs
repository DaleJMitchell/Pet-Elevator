using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.CRM;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void GetBalanceDueTest()
        {
            Customer customer = new Customer("Albert", "Einstein");
            Dictionary<string, double> servicesRendered = new Dictionary<string, double> {
                { "brushing", 5.00 },
                { "teeth cleaning", 400.00},
                { "bonus bowtie", 2.00}};
            double expectedResult = 407.00;

            double result = customer.GetBalanceDue(servicesRendered);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
