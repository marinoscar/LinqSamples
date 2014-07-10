using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Models;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class WhenPartsAreQueried
    {

        private PartsRepository _target;

        [SetUp]
        public void Setup()
        {
           _target = new PartsRepository();
            _target.InitializeDemoData();
        }

        [Test]
        public void ItShouldReturnTheCorrectPartByCode()
        {
            var result = _target.GetPartByCode("IN-01");
            Assert.IsNotNull(result);
            Assert.AreEqual("IN-01", result.Code);
        }

        [Test]
        public void ItShouldReturnTheCorrectPartsByPartTypeCode()
        {
            var result = _target.GetPartsByPartType("Exterior");
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }
    }
}
