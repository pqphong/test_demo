using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestBasicConfiguration
{
    [TestMethod]
    public void ToInstanceValueTest_141_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Boolean boolean91 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean91);
            AppendType appendtype113 = AppendType.FULL_UPPER;
            AppendType type = appendtype113;
            Int32 int32124 = 0;
            typeof(BasicConfiguration).GetProperty("InstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, int32124);
            Int32 int32135 = 59;
            typeof(BasicConfiguration).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, int32135);
            String string146 = "Inst0";
            typeof(BasicConfiguration).GetProperty("VendorApiInfix", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string146);
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("ToInstanceValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(AppendType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((String)"_59_INST0", (String)actualResult);
        }
    }

    [TestMethod]
    public void ToInstanceValueTest_141_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Boolean boolean97 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean97);
            AppendType appendtype119 = AppendType.ORIGINAL;
            AppendType type = appendtype119;
            Int32 int321210 = 0;
            typeof(BasicConfiguration).GetProperty("InstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, int321210);
            Int32 int321311 = 59;
            typeof(BasicConfiguration).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, int321311);
            String string1412 = "Inst0";
            typeof(BasicConfiguration).GetProperty("VendorApiInfix", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1412);
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("ToInstanceValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(AppendType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((String)"_59_Inst0", (String)actualResult);
        }
    }

        [TestMethod]
    public void ToInstanceValueTest_141_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Boolean boolean925 = false;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean925);
            AppendType appendtype1127 = AppendType.FULL_UPPER;
            AppendType type = appendtype1127;
            Int32 int321228 = 0;
            typeof(BasicConfiguration).GetProperty("InstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, int321228);
            Int32 int321329 = 59;
            typeof(BasicConfiguration).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, int321329);
            String string1430 = "Inst0";
            typeof(BasicConfiguration).GetProperty("VendorApiInfix", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1430);
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("ToInstanceValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(AppendType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}