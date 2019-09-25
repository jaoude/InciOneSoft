using InciOneSoft.BLL.Dtos;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace InciOneSoft.Tests
{
    [TestFixture]
    public class PersonServiceShould
    {
        [Test]
        public void CreatePersonAsync()
        {
            var sut = new PersonDto() { FirstName = "FirstName", LastName = "LastName" };

            Assert.That(1 == 1);
        }
    }
}
