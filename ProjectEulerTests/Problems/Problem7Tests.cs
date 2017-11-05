using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems.Tests
{
    [TestClass()]
    public class Problem7Tests
    {
        [TestMethod()]
        public void DoSolutionSolveTest()
        {
            var p7 = new Problem7();

            p7.number = 10;
            Assert.AreEqual(29, p7.DoSolutionSolve());

            p7.number = 20;
            Assert.AreEqual(71, p7.DoSolutionSolve());

            p7.number = 30;
            Assert.AreEqual(113, p7.DoSolutionSolve());

            p7.number = 40;
            Assert.AreEqual(173, p7.DoSolutionSolve());

            p7.number = 50;
            Assert.AreEqual(229, p7.DoSolutionSolve());
        }
    }
}