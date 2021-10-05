using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskEtClassLibrary;

namespace ObligatoriskClassLibraryTests
{
    [TestClass]
    public class FootballPlayerTests
    {
        [TestMethod]
        public void NullTest()
        {
            Action newPlayer = () => new FootballPlayer(1, null, 2, 3);
            Assert.ThrowsException<ArgumentNullException>(newPlayer);
        }

        [TestMethod]
        public void PriceOutOfRangeTest()
        {
            Action newPlayer = () => new FootballPlayer(1, "TestName", -1, 3);
            Assert.ThrowsException<ArgumentOutOfRangeException>(newPlayer);
        }
        [TestMethod]
        public void ShirtNumberOutOfRangeTest()
        {
            Action newPlayer = () => new FootballPlayer(1, "NameTest", 2, 101);
            Assert.ThrowsException<ArgumentOutOfRangeException>(newPlayer);
        }

        [TestMethod]
        public void NameOutOfRangeTest()
        {
            Action newPlayer = () => new FootballPlayer(1, "Tim", 2, 67);
            Assert.ThrowsException<ArgumentOutOfRangeException>(newPlayer);
        }

    }
}
