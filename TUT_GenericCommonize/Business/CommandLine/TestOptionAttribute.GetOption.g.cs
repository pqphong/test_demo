using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;

public partial class TestOptionAttribute
{
    [TestMethod]
    public void GetOptionTest_71_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            /* Act */
            String actualResult = (String)typeof(OptionAttribute).GetMethod("GetOption", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetOptionTest_71_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "-h";
            typeof(OptionAttribute).GetField("option", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string92);
            /* Act */
            String actualResult = (String)typeof(OptionAttribute).GetMethod("GetOption", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"-h", (String)actualResult);
        }
    }
}