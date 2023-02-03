using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.HR;
using PetElevator.CRM;

namespace PetElevator.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void FullNameReturnsCorrectFormat()
        {
            Employee employee = new Employee("Test", "Testerson");

            string fullName = employee.FullName;

            Assert.AreEqual("Testerson, Test", fullName);
        }

        [TestMethod]
        public void RaiseSalaryTest_Positive()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(5); //raise 5%

            Assert.IsTrue(employee.Salary == 100 * 1.05);
        }

        [TestMethod]
        public void RaiseSalaryTest_Negative()
        {
            Employee employee = new Employee("Test", "Testerson");
            employee.Salary = 100;

            employee.RaiseSalary(-10); //"raise" by negative 10%

            Assert.AreEqual(100, employee.Salary); //salary should remain same
        }

        [TestMethod]
        public void GetBalanceDueTest()
        {
            Employee customer = new Employee("Albert", "Einstein");
            Dictionary<string, double> servicesRendered = new Dictionary<string, double> {
                { "brushing", 5.00 },
                { "teeth cleaning", 400.00},
                { "bonus bowtie", 2.00}};
            double expectedResult = 203.50;

            double result = customer.GetBalanceDue(servicesRendered);

            Assert.AreEqual(expectedResult, result);
        }
    }

}

