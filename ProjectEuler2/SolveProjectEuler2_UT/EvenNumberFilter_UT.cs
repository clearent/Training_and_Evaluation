using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveProjectEuler2;

namespace SolveProjectEuler2_UT
{
    [TestClass]
    public class EvenNumberFilter_UT
    {
        [TestMethod]
        public void EvenNumberFilterReturnsTrueWhenPassedAnEvenNumber()
        {
            IEvenNumberFilter filter = new EvenNumberFilter();
            Assert.AreEqual(true, filter.IsEven(6));
        }

        [TestMethod]
        public void EvenNumberFilterReturnsFalseWhenPassedAnOddNumber()
        {
            IEvenNumberFilter filter = new EvenNumberFilter();
            Assert.AreEqual(false, filter.IsEven(7));
        }
    }
}
