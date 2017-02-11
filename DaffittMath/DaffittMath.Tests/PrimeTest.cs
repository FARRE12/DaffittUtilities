// <copyright file="PrimeTest.cs">Copyright ©  2017</copyright>

using System;
using DaffittMath;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DaffittMath.Tests
{
    [TestClass]
    [PexClass(typeof(Prime))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PrimeTest
    {

        [PexMethod]
        public bool IsPrime([PexAssumeUnderTest]Prime target, int? number)
        {
            bool result = target.IsPrime(number);
            return result;
            // TODO: add assertions to method PrimeTest.IsPrime(Prime, Nullable`1<Int32>)
        }
    }
}
