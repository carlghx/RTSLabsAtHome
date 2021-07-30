using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    [TestFixture]
    public class AboveAndBelowTests
    {
        [TestCase]
        public void TestNull()
        {
            Assert.Throws(typeof(ArgumentNullException), () => AboveAndBelow.Find(null, 0, out int above, out int below));

        }

        [TestCaseSource(nameof(Data))]
        public void Test(int[] inputArray, int target, int expectedAbove, int expectedBelow)
        {
            AboveAndBelow.Find(inputArray, target, out int above, out int below);
            Assert.AreEqual(expectedAbove, above);
            Assert.AreEqual(expectedBelow, below);
        }

        public static IEnumerable<TestCaseData> Data()
        {
            yield return new TestCaseData(new int[] { 1, 5, 2, 1, 10 }, 6, 1, 4);

            yield return new TestCaseData(new int[] { }, 0, 0, 0);
            yield return new TestCaseData(new int[] { }, -1, 0, 0);
            yield return new TestCaseData(new int[] { }, 1, 0, 0);

            yield return new TestCaseData(new int[] { 1 }, 1, 0, 0);
            yield return new TestCaseData(new int[] { 1 }, 2, 0, 1);
            yield return new TestCaseData(new int[] { 1 }, 0, 1, 0);

            yield return new TestCaseData(new int[] { -1 }, 0, 0, 1);
            yield return new TestCaseData(new int[] { 0 }, -1, 1, 0);

            yield return new TestCaseData(new int[] { 1, 2, 3 }, 2, 1, 1);
            yield return new TestCaseData(new int[] { 1, 2, 3 }, int.MaxValue, 0, 3);
            yield return new TestCaseData(new int[] { 1, 2, 3 }, int.MinValue, 3, 0);
            yield return new TestCaseData(new int[] { int.MaxValue, int.MinValue }, 0, 1, 1);
        }
    }
}

