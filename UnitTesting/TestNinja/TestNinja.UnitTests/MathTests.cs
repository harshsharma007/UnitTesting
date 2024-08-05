﻿using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // var math = new Math();

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expected)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            /*
                Example of bad test case:
                Assert.That(result, Does.Contain(1));
                
                It could be the case that when you want to check that if one element is present, but in the production code you may have written
                a logic that is returning only 1.
            */

            /*
                Good test cases:
                Assert.That(result, Is.Not.Empty);
                Assert.That(result.Count(), Is.EqualTo(3));
                Assert.That(result, Does.Contain(1));
                Assert.That(result, Does.Contain(3));
                Assert.That(result, Does.Contain(5));

                To check if the list is ordered or contains unique data use below Assertions:
                Assert.That(result, Is.Ordered);
                Assert.That(result, Is.Unique);
            */
        }
    }
}
