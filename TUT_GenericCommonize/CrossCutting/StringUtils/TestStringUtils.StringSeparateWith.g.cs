using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;

public partial class TestStringUtils
{
    [TestMethod]
    public void StringSeparateWithTest_57_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "WDG_CFG_AR_RELEASE_MAJOR_VERSION";
            String value = string91;
            String string102 = "Wdg";
            String separator = string102;
            /* Act */
            String[] actualResult = (String[])typeof(StringUtils).GetMethod("StringSeparateWith", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{value, separator});
            /* Assert */
            Object actualResult_0_15 = ((String[])actualResult)[0];
            Assert.AreEqual((String)"WDG", (String)actualResult_0_15);
            Object actualResult_1_16 = ((String[])actualResult)[1];
            Assert.AreEqual((String)"_CFG_AR_RELEASE_MAJOR_VERSION", (String)actualResult_1_16);
        }
    }

    [TestMethod]
    public void StringSeparateWithTest_57_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "WDG_CFG_AR_RELEASE_MAJOR_VERSION";
            String value = string93;
            String string104 = "Icu";
            String separator = string104;
            /* Act */
            String[] actualResult = (String[])typeof(StringUtils).GetMethod("StringSeparateWith", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{value, separator});
            /* Assert */
            Object actualResult_0_17 = ((String[])actualResult)[0];
            Assert.AreEqual((String)"", (String)actualResult_0_17);
            Object actualResult_1_18 = ((String[])actualResult)[1];
            Assert.AreEqual((String)"", (String)actualResult_1_18);
        }
    }
}