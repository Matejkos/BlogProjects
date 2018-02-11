using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Collections.Generic;
using FluentAssertionsPlayGround;

namespace FluentAssertionsTests
{
    [TestClass]
    public class LogicClassTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool actualBool = true;
            actualBool.Should().BeTrue();

            int actualInt = 234;
            actualInt.Should().BeInRange(0, 255);

            actualInt.Should().BePositive();
            actualInt.Should().Be(234);

            double actualDouble = 234.567;
            actualDouble.Should().BeApproximately(234.5, 0.25);
            actualDouble.Should().BeInRange(0, 255);

            List<string> actualList = new List<string>() { "ala", "ma", "kota"};

            actualList.Should().NotBeEmpty();
            actualList.Should().NotContainNulls();
            actualList.Should().OnlyHaveUniqueItems();
            actualList.Should().HaveElementPreceding("kota", "ma");

            ChopData actualComplex = new ChopData();
            actualComplex.Words = new string[] { "ala", "ma", "kota" };
            actualComplex.WordsCount = 3;

            ChopData expectedComplex = new ChopData();

            expectedComplex.Words = new string[] { "ala", "ma", "kota" };
            expectedComplex.WordsCount = 3;
            actualComplex.Should().BeEquivalentTo(expectedComplex);

            string actualString = "alaMaKOta";

            actualString.Should().NotBeNullOrEmpty();

            LogicClass testedClass = new LogicClass();
            Action act = () => testedClass.ThrowException() ;
            act.Should().Throw<Exception>().WithMessage("Invalida argument exception");

        }
    }
}
