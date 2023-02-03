using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.CRM;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.Tests
{
    

    [TestClass]
    public class PetTests
    {
        private Pet testPet;
        //private List<string> testVaccines;

        [TestInitialize]
        public void PetTest()
        {
            testPet = new Pet("Laika", "Dog");
            testPet.Vaccinations = new List<string> { "Rabies", "Distemper", "Parvo" };
        }

        [TestMethod]
        public void Pet_Vaccinations_Test_Creating_List()
        {
            
            string expectedResult = "Rabies, Distemper, Parvo";
            string actualResult = testPet.ListVaccinations();
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
