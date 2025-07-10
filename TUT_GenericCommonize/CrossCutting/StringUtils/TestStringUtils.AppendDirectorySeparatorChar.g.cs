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
    public void appendDirectorySeparatorCharTest_36_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "path/path.extension\\";
            String path = string92;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("appendDirectorySeparatorChar", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Assert.AreEqual((String)"path/path.extension\\", (String)actualResult);
        }
    }

    [TestMethod]
    public void appendDirectorySeparatorCharTest_36_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "path/path";
            String path = string93;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("appendDirectorySeparatorChar", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Assert.AreEqual((String)"path/path\\", (String)actualResult);
        }
    }

    [TestMethod]
    public void appendDirectorySeparatorCharTest_36_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "path/path.extension";
            String path = string94;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("appendDirectorySeparatorChar", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Assert.AreEqual((String)"path/path.extension", (String)actualResult);
        }
    }
}