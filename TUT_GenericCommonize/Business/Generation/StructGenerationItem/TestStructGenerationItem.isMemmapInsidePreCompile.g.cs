using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestStructGenerationItem
{
    [TestMethod]
    public void isMemmapInsidePreCompileTest_194_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Adc_gst";
            String structName = string91;
            Dictionary<String, List<String>> dictionary102 = new Dictionary<String, List<String>>();
            List<String> dictionary102_mem1 = new List<string>()
            {"Adc_gst", "Wdg_gst"};
            dictionary102["mem1"] = dictionary102_mem1;
            typeof(StructGenerationItem).GetProperty("memorySectionMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary102);
            Dictionary<String, String> dictionary113 = new Dictionary<String, String>();
            String dictionary113_Adcgst = "precompile1";
            String dictionary113_Wdggst = "precompile2";
            dictionary113["Adc_gst"] = dictionary113_Adcgst;
            dictionary113["Wdg_gst"] = dictionary113_Wdggst;
            typeof(StructGenerationItem).GetProperty("preCompileMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary113);
            /* Act */
            Boolean actualResult = (Boolean)typeof(StructGenerationItem).GetMethod("isMemmapInsidePreCompile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{structName});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isMemmapInsidePreCompileTest_194_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "Adc_gst";
            String structName = string94;
            Dictionary<String, List<String>> dictionary105 = new Dictionary<String, List<String>>();
            List<String> dictionary105_mem1 = new List<string>()
            {"Wdg_gst"};
            dictionary105["mem1"] = dictionary105_mem1;
            typeof(StructGenerationItem).GetProperty("memorySectionMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary105);
            Dictionary<String, String> dictionary116 = new Dictionary<String, String>();
            String dictionary116_Adcgst = "precompile1";
            String dictionary116_Wdggst = "precompile2";
            dictionary116["Adc_gst"] = dictionary116_Adcgst;
            dictionary116["Wdg_gst"] = dictionary116_Wdggst;
            typeof(StructGenerationItem).GetProperty("preCompileMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary116);
            /* Act */
            Boolean actualResult = (Boolean)typeof(StructGenerationItem).GetMethod("isMemmapInsidePreCompile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{structName});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isMemmapInsidePreCompileTest_194_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "Adc_gst";
            String structName = string97;
            Dictionary<String, List<String>> dictionary108 = new Dictionary<String, List<String>>();
            List<String> dictionary108_mem1 = new List<string>()
            {"Adc_gst", "Wdg_gst"};
            dictionary108["mem1"] = dictionary108_mem1;
            typeof(StructGenerationItem).GetProperty("memorySectionMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary108);
            Dictionary<String, String> dictionary119 = new Dictionary<String, String>();
            String dictionary119_Wdggst = "precompile2";
            dictionary119["Wdg_gst"] = dictionary119_Wdggst;
            typeof(StructGenerationItem).GetProperty("preCompileMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary119);
            /* Act */
            Boolean actualResult = (Boolean)typeof(StructGenerationItem).GetMethod("isMemmapInsidePreCompile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{structName});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isMemmapInsidePreCompileTest_194_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string910 = "Adc_gst";
            String structName = string910;
            Dictionary<String, List<String>> dictionary1011 = new Dictionary<String, List<String>>();
            List<String> dictionary1011_mem1 = new List<string>()
            {"Adc_gst", "Wdg_gst"};
            dictionary1011["mem1"] = dictionary1011_mem1;
            typeof(StructGenerationItem).GetProperty("memorySectionMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary1011);
            Dictionary<String, String> dictionary1112 = new Dictionary<String, String>();
            String dictionary1112_Adcgst = "";
            String dictionary1112_Wdggst = "precompile2";
            dictionary1112["Adc_gst"] = dictionary1112_Adcgst;
            dictionary1112["Wdg_gst"] = dictionary1112_Wdggst;
            typeof(StructGenerationItem).GetProperty("preCompileMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary1112);
            /* Act */
            Boolean actualResult = (Boolean)typeof(StructGenerationItem).GetMethod("isMemmapInsidePreCompile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{structName});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}