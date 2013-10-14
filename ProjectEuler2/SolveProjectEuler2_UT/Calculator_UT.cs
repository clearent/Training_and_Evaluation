using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using SolveProjectEuler2;

namespace SolveProjectEuler2_UT
{
    [TestClass]
    public class Calculator_UT
    {
        private ICalculator calc;
        private List<long> basicList;
        private List<long> evenList;
        private List<long> singleItemEvenList;
        private List<long> singleItemOddList;
        private MockRepository mocks = new MockRepository();

        [TestInitialize]
        public void SetUp()
        {
            calc = new Calculator();
            basicList = new List<long> { 1, 2, 3, 4, 5 };
            evenList = new List<long> { 2, 4, 6, 8, 10 };
            singleItemEvenList = new List<long> { 4 };
            singleItemOddList = new List<long> { 7 };
        }

        [TestMethod]
        public void CalculatorCanAddListOfNumbers()
        {
            var result = calc.AddList(basicList);
            Assert.AreEqual(15 ,result);
            result = calc.AddList(evenList);
            Assert.AreEqual(30 ,result);
        }

        [TestMethod]
        public void CalculatorReturnsZeroWhenAddingNullList()
        {
            var result = calc.AddList(null);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AddListAddsFilteredValue()
        {
            IEvenNumberFilter mockFilter = MockRepository.GenerateMock<IEvenNumberFilter>();
            mockFilter.Expect(f => f.IsEven(4)).Return(true);
            var result = calc.AddList(singleItemEvenList, mockFilter);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void AddListDoesNotAddFilteredValue()
        {
            IEvenNumberFilter mockFilter = MockRepository.GenerateMock<IEvenNumberFilter>();
            mockFilter.Expect(f => f.IsEven(7)).Return(false);
            var result = calc.AddList(singleItemOddList, mockFilter);
            Assert.AreEqual(0, result);
        }
    }
}
