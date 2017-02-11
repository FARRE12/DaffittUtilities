using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DaffittMath;
// <copyright file="PrimeTest.IsPrime.g.cs">Copyright ©  2017</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace DaffittMath.Tests
{
    public partial class PrimeTest
    {
        // Test the result of passing NULL value to the IsPrime method
        // This test should pass (return False) because NULL is NOT a prime number
        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime_Null()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, default(int?));
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)s0);
        }

        // Test the result of passing 0 to the IsPrime method
        // This test should pass (return False) because 0 is NOT a prime number
        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime_0()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, new int?(0));
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)s0);
        }

        // Test the result of passing 1 to the IsPrime method
        // This test should pass (return False) because 1 is NOT a prime number
        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime_1()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, new int?(1));
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)s0);
        }

        // Test the result of passing 2 to the IsPrime method
        // This test should pass (return True) because 2 IS a prime number
        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime_2()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, new int?(2));
            Assert.AreEqual<bool>(true, b);
            Assert.IsNotNull((object)s0);
        }

        // Test the result of passing 7 to the IsPrime method
        // This test should pass (return True) because 7 IS a prime number
        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime_7()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, new int?(7));
            Assert.AreEqual<bool>(true, b);
            Assert.IsNotNull((object)s0);
        }

        // Test the result of passing 9 to the IsPrime method
        // This test should pass (return False) because 9 is NOT a prime number
        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime_9()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, new int?(9));
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)s0);
        }

    }
}
