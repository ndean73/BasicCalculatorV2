using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations.Tests
{
    [TestClass()]
    public class SquareRootTests
    {

        //private readonly double b = 4;
        Random b = new Random();

        [TestMethod()]
        public void SqrRootTest()
        {
            Assert.AreEqual(2, SquareRoot.SqrRoot(b.Next(1,50)));
        }

        
    }
}