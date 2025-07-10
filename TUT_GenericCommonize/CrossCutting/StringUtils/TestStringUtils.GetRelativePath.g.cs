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
    public void GetRelativePathTest_28_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String toPath = string91;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetCurrentDirectoryNullableOfInt32 = (Nullable<Int32> exitCode) =>
            {
                String string102 = "U:\\internal";
                return string102;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (String path, Nullable<Int32> exitCode) =>
            {
                String string113 = "U:\\internal";
                return string113;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetRelativePath", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{toPath});
            /* Assert */
            Assert.AreEqual((String)".\\", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetRelativePathTest_28_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "";
            String toPath = string94;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetCurrentDirectoryNullableOfInt32 = (Nullable<Int32> exitCode) =>
            {
                String string105 = "https://www.google.com/";
                return string105;
            }
            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = ( String path,  Nullable<Int32> exitCode) => 
            {
                String string116 = "U:\\internal";
                return string116;
            }
            ; 
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetRelativePath", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{toPath});
            /* Assert */
            Assert.AreEqual((String)"U:\\internal", (String)actualResult);
            }
        }

    [TestMethod]
    public void GetRelativePathTest_28_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "";
            String toPath = string97;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetCurrentDirectoryNullableOfInt32 = (Nullable<Int32> exitCode) =>
            {
                String string108 = "https://www.google.com/abc";
                return string108;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (String path, Nullable<Int32> exitCode) =>
            {
                String string119 = "https://www.google.com/";
                return string119;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetRelativePath", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{toPath});
            /* Assert */
            Assert.AreEqual((String)"..//",(String)actualResult);
        }
    }
} 