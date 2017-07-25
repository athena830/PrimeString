using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace PrimeString
{
    [TestFixture]
    public class myjinxin
    {
        [Test]
        public void Should_Be_PrimeString_a()
        {
            var kata = new Kata();
            Assert.AreEqual(true, kata.PrimeString("a"));
        }

        [Test]
        public void Should_Be_PrimeString_x()
        {
            var kata = new Kata();
            Assert.AreEqual(true, kata.PrimeString("x"));
        }


        [Test]
        public void Should_Be_PrimeString_abc()
        {
            var kata = new Kata();
            Assert.AreEqual(true, kata.PrimeString("abc"));
        }

        [Test]
        public void Should_Be_PrimeString_abac()
        {
            var kata = new Kata();
            Assert.AreEqual(true, kata.PrimeString("abac"));
        }

        [Test]
        public void Should_Not_Be_PrimeString_abab()
        {
            var kata = new Kata();
            Assert.AreEqual(false, kata.PrimeString("abab"));
        }

        [Test]
        public void Should_Not_Be_PrimeString_aaaa()
        {
            var kata = new Kata();
            Assert.AreEqual(false, kata.PrimeString("aaaa"));
        }

        [Test]
        public void Should_Not_Be_PrimeString_fdsyffdsyffdsyffdsyffdsyf()
        {
            var kata = new Kata();
            Assert.AreEqual(false, kata.PrimeString("fdsyffdsyffdsyffdsyffdsyf"));
        }

        [Test]
        public void Should_Be_PrimeString_utdutdtdutd()
        {
            var kata = new Kata();
            Assert.AreEqual(true, kata.PrimeString("utdutdtdutd"));
        }

        [Test]
        public void ShouldBe_PrimeString_abba()
        {
            var kata = new Kata();
            Assert.AreEqual(true, kata.PrimeString("abba"));
        }
    }
}