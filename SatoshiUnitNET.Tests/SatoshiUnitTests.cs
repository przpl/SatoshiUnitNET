using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SatoshiUnitNET.Tests
{
    [TestClass]
    public class SatoshiUnitTests
    {
        [TestMethod]
        public void Constructor_FractionalValue_ValueIsRoundedToWholeSatoshis()
        {
            var sut = new SatoshiUnit(1.6m);

            Assert.AreEqual(2m, sut.Satoshis);
        }

        [TestMethod]
        public void SatoshisProperty_FractionalValue_ValueIsRoundedToWholeSatoshis()
        {
            var sut = new SatoshiUnit(0);
            sut.Satoshis = 1.6m;

            Assert.AreEqual(2m, sut.Satoshis);
        }

        [TestMethod]
        public void FromSatoshis()
        {
            var sut = SatoshiUnit.FromSatoshis(1);

            Assert.AreEqual(1, sut.Satoshis);
        }

        [TestMethod]
        public void FromFinnies()
        {
            var sut = SatoshiUnit.FromFinnies(1);

            Assert.AreEqual(10, sut.Satoshis);
        }

        [TestMethod]
        public void FromMicrobitcoins()
        {
            var sut = SatoshiUnit.FromMicrobitcoins(1);

            Assert.AreEqual(100, sut.Satoshis);
        }

        [TestMethod]
        public void FromMilibitcoins()
        {
            var sut = SatoshiUnit.FromMilibitcoins(1);

            Assert.AreEqual(100000, sut.Satoshis);
        }

        [TestMethod]
        public void FromCentibitcoins()
        {
            var sut = SatoshiUnit.FromCentibitcoins(1);

            Assert.AreEqual(1000000, sut.Satoshis);
        }

        [TestMethod]
        public void FromDecibitcoins()
        {
            var sut = SatoshiUnit.FromDecibitcoins(1);

            Assert.AreEqual(10000000, sut.Satoshis);
        }

        [TestMethod]
        public void FromBitcoins()
        {
            var sut = SatoshiUnit.FromBitcoins(1);
            
            Assert.AreEqual(100000000, sut.Satoshis);
        }
    }
}
