using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogParser.Test
{
    [TestClass]
    public class LogParserTest
    {
        [TestMethod]
        public void GetFileRegexMatches_EventServiceRequestForCount_224()
        {
            // arrange
            string file = @"C:\EventService_1.log";
            string pattern = @"([0-9\-]*) ([0-9:.]*).*Request for (\d*)_(\d*)_(\d*)_(\w*)";
            int expected = 224;

            // act
            List<string[]> matches =  LogParserLib.LogParser.GetFileRegexMatches(file, pattern);
            int actual = matches.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFileRegexMatches_EventServiceFirstMatchSecondGroup_12_19_17_3278()
        {
            // arrange
            string file = @"C:\EventService_1.log";
            string pattern = @"([0-9\-]*) ([0-9:.]*).*Request for (\d*)_(\d*)_(\d*)_(\w*)";
            string expected = "12:19:17.3278";

            // act
            List<string[]> matches = LogParserLib.LogParser.GetFileRegexMatches(file, pattern);
            string actual = matches[0][1];

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
