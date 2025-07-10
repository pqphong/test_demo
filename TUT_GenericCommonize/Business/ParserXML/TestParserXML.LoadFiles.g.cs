using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestParserXML
{
    [TestMethod]
    public void LoadFileTest_31_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list91 = new List<String>();
            String list91_0 = "D:\\test";
            list91.Add(list91_0);
            Object runtimeconfiguration19 = typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("CDFFilePaths", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration19, list91);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean102 = true;
                return boolean102;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.LoadXMLStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                flag = 1;
                return new XDocument();
                ;
            }

            ;
            /* Act */
            typeof(ParserXML).GetMethod("LoadFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void LoadFileTest_31_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list95 = new List<String>();
            Object runtimeconfiguration110 = typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("CDFFilePaths", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration110, list95);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean106 = false;
                return boolean106;
            }

            ;
            Int32 int32117 = 0;
            Int32 flag = int32117;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.LoadXMLStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                flag = 1;
                return new XDocument();
                ;
            }

            ;
            /* Act */
            typeof(ParserXML).GetMethod("LoadFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}