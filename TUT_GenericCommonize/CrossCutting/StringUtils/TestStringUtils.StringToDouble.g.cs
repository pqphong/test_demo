using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using System.Globalization;

public partial class TestStringUtils
{
    [TestMethod]
    public void StringToDoubleTest_56_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "12.2";
            String value = string91;
            NumberStyles numStype = NumberStyles.Float;
            /* Act */
            Double actualResult = (Double)typeof(StringUtils).GetMethod("StringToDouble", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(NumberStyles)}, null).Invoke(_target, new object[]{value, numStype });
            /* Assert */
            Assert.AreEqual((Double)12.2, (Double)actualResult);
        }
    }
}