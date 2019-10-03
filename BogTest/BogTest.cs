using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obl_Opgave_1_Henrik_Nielsen;

namespace BogTest
{
    [TestClass]
    public class BogTest
    {
        private Bog _z;
        private Bog _a;

        [TestInitialize]
        public void StartUp()
        {
            _z = new Bog("En lille tur på landet", "Anders Holm", 67, "QWERTYASDFGH1");
            _a = new Bog();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TitelTest1()
        {
            ///Tests starting value
            Assert.AreEqual("En lille tur på landet", _z.Titel);

            ///Sets value and tests
            _z.Titel = "Hans på rundtur";
            Assert.AreEqual("Hans på rundtur", _z.Titel);

            ///Sets value to provoke an ArgumentOutOfRangeException, as the test expects
            _z.Titel = "Q";
        }

        [TestMethod]
        public void ForfatterTest1()
        {
            ///Tests starting value
            Assert.AreEqual("Anders Holm", _z.Forfatter);

            ///Sets value and tests
            _z.Forfatter = "Bob Builder";
            Assert.AreEqual("Bob Builder", _z.Forfatter);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SidetalTest1()
        {
            ///Tests starting value
            Assert.AreEqual(67, _z.Sidetal);

            ///Sets value and tests
            _z.Sidetal = 198;
            Assert.AreEqual(198, _z.Sidetal);

            ///Sets value under the minimum to provoke an ArgumentOutOfRangeException, as the test expects
            _z.Sidetal = 9;
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SidetalTest2()
        {
            ///Sets value above the maximum provoke an ArgumentOutOfRangeException, as the test expects
            ///Done in a second test to make sure it responds properly
            _z.Sidetal = 1001;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Isbn13Test1()
        {
            ///Tests starting value
            Assert.AreEqual("QWERTYASDFGH1", _z.Isbn13);

            ///Sets value and tests
            _z.Isbn13 = "YTREWQASDFGHJ";
            Assert.AreEqual("YTREWQASDFGHJ", _z.Isbn13);

            ///Sets value to provoke an ArgumentOutOfRangeException, as the test expects
            _z.Isbn13 = "QWERTY";
        }

        //[TestMethod]
        //public void TestMethod1()
        //{
        //}
    }
}
