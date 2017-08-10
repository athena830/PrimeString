using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace PrimeString
{
    [TestFixture]
    public class PrimeStringTest
    {
        [Test]
        public void Input_a_Should_Be_True()
        {
            Assert_Should_Be_PrimeString("a");
        }

        [Test]
        public void Input_x_Should_Be_True()
        {
            Assert_Should_Be_PrimeString("x");
        }


        [Test]
        public void Input_abc_Should_Be_True()
        {
            Assert_Should_Be_PrimeString("abc");
        }

        [Test]
        public void Input_abac_Should_Be_True()
        {
            Assert_Should_Be_PrimeString("abac");
        }

        [Test]
        public void Input_abba_Should_Be_True()
        {
            Assert_Should_Be_PrimeString("abba");
        }

        [Test]
        public void Input_abab_Should_Be_False()
        {
            Assert_Should_Not_Be_PrimeString("abab");
        }

        [Test]
        public void Input_aaaa_Should_Be_False()
        {
            Assert_Should_Not_Be_PrimeString("aaaa");
        }

        [Test]
        public void Input_fdsyffdsyffdsyffdsyffdsyf_Should_Be_False()
        {
            Assert_Should_Not_Be_PrimeString("fdsyffdsyffdsyffdsyffdsyf");
        }

        [Test]
        public void Input_utdutdtdutd_Should_Be_True()
        {
            Assert_Should_Be_PrimeString("utdutdtdutd");
        }

        private static void Assert_Should_Be_PrimeString(string actual)
        {
            Assert.AreEqual(true, new Kata().PrimeString(actual));
        }

        private static void Assert_Should_Not_Be_PrimeString(string actual)
        {
            Assert.AreEqual(false, new Kata().PrimeString(actual));
        }
    }
}