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

        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime251()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, default(int?));
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)s0);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime61()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, new int?(0));
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)s0);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime962()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, new int?(2));
            Assert.AreEqual<bool>(true, b);
            Assert.IsNotNull((object)s0);
        }

        [TestMethod]
        [PexGeneratedBy(typeof(PrimeTest))]
        public void IsPrime625()
        {
            bool b;
            Prime s0 = new Prime();
            b = this.IsPrime(s0, new int?(8));
            Assert.AreEqual<bool>(false, b);
            Assert.IsNotNull((object)s0);
        }
    }
}
