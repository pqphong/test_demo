using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestContainer
{
    [TestMethod]
    public void EqualsTest_110_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object91 = null;
            Object target = object91;
            /* Act */
            Boolean actualResult = (Boolean)typeof(Container).GetMethod("Equals", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Object)}, null).Invoke(_target, new object[]{target});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void EqualsTest_110_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Container testObject = new Container();
            Object target = testObject;
            testObject.Uuid = "InValue of Uuid";
            testObject.ShortName = "InValue of ShortName";
            String string105 = "Value of Uuid";
            typeof(Container).GetProperty("Uuid", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string105);
            String string116 = "Value of ShortName";
            typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string116);
            /* Act */
            Boolean actualResult = (Boolean)typeof(Container).GetMethod("Equals", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Object)}, null).Invoke(_target, new object[]{target});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void EqualsTest_110_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Container testObject = new Container();
            Object target = testObject;
            testObject.Uuid = "Value of Uuid";
            testObject.ShortName = "Value of ShortName";
            String string108 = "Value of Uuid";
            typeof(Container).GetProperty("Uuid", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string108);
            String string119 = "Value of ShortName";
            typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string119);
            /* Act */
            Boolean actualResult = (Boolean)typeof(Container).GetMethod("Equals", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Object)}, null).Invoke(_target, new object[]{target});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }
}