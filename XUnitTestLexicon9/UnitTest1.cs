using System;
using Xunit;
using WebAppLexicon9.Controllers;
using System.Collections.Generic;

namespace XUnitTestLexicon9
{
    public class UnitTest_Home
    {
        [Fact]
        public void Test_GetTmpArrayIOT()
        {
            Xunit.Assert.Equal(new string[]{ "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }, HomeController.GetTmpArrayIOT());
        }
        [Fact]
        public void Test_GetTmpArrayIOT_Fail()
        {
            Xunit.Assert.Equal(new string[] {  "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }, HomeController.GetTmpArrayIOT());
        }
    }
}
