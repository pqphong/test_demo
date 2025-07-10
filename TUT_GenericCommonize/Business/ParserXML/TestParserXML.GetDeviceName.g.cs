using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestParserXML
{
    [TestMethod]
    public void GetDeviceNameTest_18_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata16.GetAllInstanceContainersString = (String moduleName) =>
            {
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                IList<Container> ilist91 = new List<Container>();
                Container ilist91_0 = new Container();
                IList<ItemValue> ilist91_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist91_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist91_0_ParameterValues_0_definitionRef = "/DeviceName";
                Object ilist91_0_ParameterValues_0_value = "R7F701420";
                ilist91.Add(ilist91_0);
                ilist91_0.ParameterValues = ilist91_0_ParameterValues;
                ilist91_0_ParameterValues.Add(ilist91_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist91_0_ParameterValues_0, ilist91_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist91_0_ParameterValues_0, ilist91_0_ParameterValues_0_value);
                result.Add("can", ilist91);
                return result;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetDeviceName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"R7F701420", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetDeviceNameTest_18_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata17 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata17.GetAllInstanceContainersString = (String moduleName) =>
            {
                IList<Container> ilist92 = new List<Container>();
                Container ilist92_0 = new Container();
                IList<ItemValue> ilist92_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist92_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist92_0_ParameterValues_0_definitionRef = "/DeviceName";
                Object ilist92_0_ParameterValues_0_value = "";
                ilist92.Add(ilist92_0);
                ilist92_0.ParameterValues = ilist92_0_ParameterValues;
                ilist92_0_ParameterValues.Add(ilist92_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist92_0_ParameterValues_0, ilist92_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist92_0_ParameterValues_0, ilist92_0_ParameterValues_0_value);
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                result.Add("can", ilist92);
                return result;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata17);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetDeviceName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual(null, (String)actualResult);
        }
    }

    [TestMethod]
    public void GetDeviceNameTest_18_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata18 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata18.GetAllInstanceContainersString = (String moduleName) =>
            {
                IList<Container> ilist93 = new List<Container>();
                Container ilist93_0 = new Container();
                IList<ItemValue> ilist93_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist93_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist93_0_ParameterValues_0_definitionRef = "/DeviceName";
                Object ilist93_0_ParameterValues_0_value = null;
                ilist93.Add(ilist93_0);
                ilist93_0.ParameterValues = ilist93_0_ParameterValues;
                ilist93_0_ParameterValues.Add(ilist93_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist93_0_ParameterValues_0, ilist93_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist93_0_ParameterValues_0, ilist93_0_ParameterValues_0_value);
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                result.Add("can", ilist93);
                return result;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata18);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetDeviceName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)null, (String)actualResult);
        }
    }

    [TestMethod]
    public void GetDeviceNameTest_18_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata19 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata19.GetAllInstanceContainersString = (String moduleName) =>
            {
                IList<Container> ilist94 = new List<Container>();
                Container ilist94_0 = new Container();
                IList<ItemValue> ilist94_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist94_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist94_0_ParameterValues_0_definitionRef = "/DeviceName";
                Object ilist94_0_ParameterValues_0_value = "";
                Container ilist94_1 = new Container();
                IList<ItemValue> ilist94_1_ParameterValues = new List<ItemValue>();
                ItemValue ilist94_1_ParameterValues_0 = new ItemValue(null, null);
                String ilist94_1_ParameterValues_0_definitionRef = "/DeviceName1";
                Object ilist94_1_ParameterValues_0_value = "R7F701420";
                ilist94.Add(ilist94_0);
                ilist94_0.ParameterValues = ilist94_0_ParameterValues;
                ilist94_0_ParameterValues.Add(ilist94_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist94_0_ParameterValues_0, ilist94_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist94_0_ParameterValues_0, ilist94_0_ParameterValues_0_value);
                ilist94.Add(ilist94_1);
                ilist94_1.ParameterValues = ilist94_1_ParameterValues;
                ilist94_1_ParameterValues.Add(ilist94_1_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist94_1_ParameterValues_0, ilist94_1_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist94_1_ParameterValues_0, ilist94_1_ParameterValues_0_value);
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                result.Add("can", ilist94);
                return result;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata19);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetDeviceName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"R7F701420", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetDeviceNameTest_18_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata110 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata110.GetAllInstanceContainersString = (String moduleName) =>
            {
                IList<Container> ilist95 = new List<Container>();
                Container ilist95_0 = new Container();
                IList<ItemValue> ilist95_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist95_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist95_0_ParameterValues_0_definitionRef = "/DeviceName";
                Object ilist95_0_ParameterValues_0_value = "R7F701403";
                Container ilist95_1 = new Container();
                IList<ItemValue> ilist95_1_ParameterValues = new List<ItemValue>();
                ItemValue ilist95_1_ParameterValues_0 = new ItemValue(null, null);
                String ilist95_1_ParameterValues_0_definitionRef = "/DeviceName1";
                Object ilist95_1_ParameterValues_0_value = "R7F701420";
                ilist95.Add(ilist95_0);
                ilist95_0.ParameterValues = ilist95_0_ParameterValues;
                ilist95_0_ParameterValues.Add(ilist95_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist95_0_ParameterValues_0, ilist95_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist95_0_ParameterValues_0, ilist95_0_ParameterValues_0_value);
                ilist95.Add(ilist95_1);
                ilist95_1.ParameterValues = ilist95_1_ParameterValues;
                ilist95_1_ParameterValues.Add(ilist95_1_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist95_1_ParameterValues_0, ilist95_1_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist95_1_ParameterValues_0, ilist95_1_ParameterValues_0_value);
                Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();
                result.Add("can", ilist95);
                return result;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata110);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetDeviceName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"R7F701403", (String)actualResult);
        }
    }
}