using System;
using NUnit.Framework;
using TalkingClockRuleEngine;

namespace UnitTestTalkingClock
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void UnitTest_TimeToWords()
        {
            var testHrs = 11;
            var testMins = 45;
            var expectedTimeFormat = "Quarter to Twelve";
            var timeFormat=ConvertToWords.ConverttoWords(testHrs, testMins); 
            Assert.Pass(expectedTimeFormat, timeFormat);
        }
        [Test]
        public void UnitTest_TimeToWords_RoundValue()
        {
            var testHrs = 3;
            var testMins = 0;
            var timeFormat = ConvertToWords.ConverttoWords(testHrs, testMins); ;
            Assert.AreEqual("Three o'clock", timeFormat.Trim());
        }

        [Test]
        public void UnitTest_TimeToWords_Halfpast()
        {
            var TestHrs = 6;
            var TestMins = 30;
            var timeFormat = ConvertToWords.ConverttoWords(TestHrs, TestMins); ;
            Assert.AreEqual("Half past six", timeFormat.Trim());
        }
    }
}