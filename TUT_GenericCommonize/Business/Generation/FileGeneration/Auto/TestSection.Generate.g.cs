using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;

public partial class TestSection
{
    [TestMethod]
    public void GenerateTest_167_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Global Data Types";
            typeof(Section).GetField("title", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string91);
            /* Act */
            String actualResult = (String)typeof(Section).GetMethod("Generate", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.IsTrue(actualResult.ToString().Contains("Global Data Types"));
        }
    }

    [TestMethod]
    public void GenerateTest_167_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "";
            typeof(Section).GetField("title", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string92);
            /* Act */
            String actualResult = (String)typeof(Section).GetMethod("Generate", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.IsTrue(!actualResult.ToString().Contains("Global Data Types"));
        }
    }
}