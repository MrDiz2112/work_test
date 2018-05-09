using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogParserTest
{
    [TestClass]
    public class LogParserTest
    {
        [TestMethod]
        public void GetFileRegexMatches_ReguestForMatches_224returned()
        {
            // arrange
            string file = "EventService_1.log";
            string pattern = @"([0-9\-]*) ([0-9:.]*).*Request for (\d*)_(\d*)_(\d*)_(\w*)";

            // act
             

            // assert
        }
    }
}
