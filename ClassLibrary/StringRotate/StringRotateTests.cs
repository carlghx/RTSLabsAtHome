using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    [TestFixture]
    public class StringRotateTests
    {
        [TestCase]
        public void TestNull()
        {
            Assert.Throws(typeof(ArgumentNullException), () => StringRotate.Rotate(null, 0));
        }

        [TestCase]
        public void TestOutOfRange()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => StringRotate.Rotate("", 1));
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => StringRotate.Rotate("1", 2));
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => StringRotate.Rotate("1", -1));
        }

        [TestCaseSource(nameof(Data))]
        public void Test(string s, int n, string result)
        {
            Assert.AreEqual(result, StringRotate.Rotate(s, n));
        }

        public static IEnumerable<TestCaseData> Data()
        {
            yield return new TestCaseData("MyString", 2, "ngMyStri");

            yield return new TestCaseData("MyString", 3, "ingMyStr");
            yield return new TestCaseData("", 0, "");
            yield return new TestCaseData("a", 1, "a");

            yield return new TestCaseData("ab", 1, "ba");
            yield return new TestCaseData("abc", 1, "cab");
            yield return new TestCaseData("abc", 2, "bca");
        }
    }
}

