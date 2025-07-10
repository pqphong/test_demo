using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestUserInterface
{
    [TestMethod]
    public void getDateTimeTest_49_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            System.Fakes.ShimDateTime.NowGet = () => 
            {
                return new DateTime(2018, 8, 1);
            };

            /* Act */
            string result = (string)_target.GetType().GetMethod("getDateTime", BindingFlags.NonPublic | BindingFlags.Instance)
                .Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual("01 Aug 2018 - 00:00:00", (string)result);
        }
    }
}