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
    public void DoubleToStringTest_55_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Double double91 = 12.2;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("DoubleToString", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(Double)}, null).Invoke(_target, new object[]{double91});
            /* Assert */
            Assert.AreEqual((String)"12.2", (String)actualResult);
        }
    }
}