using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveProjectEuler2;
using System.Collections.Generic;

namespace SolveProjectEuler2_UT
{
    [TestClass]
    public class FibonacciSequencer_UT
    {
        [TestMethod]
        public void SequencerUsesMaxNumber()
        {
            // Arrange
            long first = 0;
            long second = 1;
            long max = 3;
            IList<long> newList = new List<long>();
            IList<long> expectedList = new List<long>{ 0, 1, 2 };

            IFibonacciSequencer sequencer = new FibonacciSequencer();

            // Act
            var result = sequencer.GenerateFibonacciSequence(first, second, max, newList);

            // Assert
            Assert.AreEqual(expectedList.Count, result.Count);
        }
    }
}
