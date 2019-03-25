using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private static List<object[]> _testCases =
        new List<object[]>{
            new object[]{5, "Buzz"},
            new object[]{15, "FizzBuzz"},
            new object[]{3, "Fizz"},
            new object[]{7, "7"},
            new object[]{0, "FizzBuzz"},
            new object[]{1, "1"},
            new object[]{-1, "-1"},
            new object[]{-3, "Fizz"},
            new object[]{-5, "Buzz"},
            new object[]{-15, "FizzBuzz"},
            new object[]{Int32.MinValue, "-2147483648"},
            new object[]{Int32.MaxValue, "2147483647"}
        };

        [Test, TestCaseSource(nameof(_testCases))]
        public void IsFizzBuzzCorrect(int input, string expected) 
        {
            Assert.AreEqual(expected, FizzBuzz.FizzBuzz.CreateFizzBuzz(input));
        }

        private static int[] _values = {1, 2, 3, 4, 5, 6, 7, 8};
        [Test, TestCaseSource(nameof(_values))]
        public void Test2(int input)
        {
            if(input == 5)
                Assert.Fail("Input ist 5.");
            
            Assert.AreEqual(5, 5);
        }
    }
}