using System;
using NUnit.Framework;

namespace NorthWindTests
{
    [TestFixture]
    public class UnitTest1
    {
        NorthwindDTO northwindDTO = new NorthwindDTO();

        [Test]
        public void DistinctIDs()
        {
            Assert.AreEqual(true, northwindDTO.UniqueID());
        }

        [Test]
        public void TestID()
        {
            Assert.AreEqual(5, northwindDTO.IDLength(northwindDTO.CustomerToObject()[3].CustomerID));
            Assert.AreEqual("ADAM5", northwindDTO.CustomerToObject()[3].CustomerID);
        }

        [Test]
        public void TestName()
        {
            Assert.AreEqual("Fred Flintstone", northwindDTO.CustomerToObject()[3].ContactName);
        }

        [Test]
        public void TestCompanyName()
        {
            Assert.AreEqual("Alfreds Futterkiste", northwindDTO.CustomerToObject()[3].CompanyName);
        }

        [Test]
        public void TestContactTitle()
        {
            Assert.AreEqual("Sales Representative", northwindDTO.CustomerToObject()[3].ContactTitle);
        }

        [Test]
        public void TestAddress()
        {
            Assert.AreEqual("Obere Str. 57", northwindDTO.CustomerToObject()[3].Address);
        }

        [Test]
        public void TestCity()
        {
            Assert.AreEqual("Bed Rock", northwindDTO.CustomerToObject()[3].City);
        }

        [Test]
        public void TestRegion()
        {
            Assert.AreEqual(null, northwindDTO.CustomerToObject()[3].Region);
        }

        [Test]
        public void TestPostalcode()
        {
            Assert.AreEqual("12209", northwindDTO.CustomerToObject()[3].PostalCode);
        }

        [Test]
        public void TestCountry()
        {
            Assert.AreEqual("Germany", northwindDTO.CustomerToObject()[3].Country);
        }

        [Test]
        public void TestPhone()
        {
            Assert.AreEqual("030-0074321", northwindDTO.CustomerToObject()[3].Phone);
        }

        [Test]
        public void TestFax()
        {
            Assert.AreEqual("030-0076545", northwindDTO.CustomerToObject()[3].Fax);
        }
    }
}
