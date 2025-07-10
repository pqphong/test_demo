using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using static Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.StructGenerationItem;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestStructGenerationItem
{
    [TestMethod]
    public void genMemorySectionTest_79_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "can_gaa";
            String structName = string91;
            MemorySection memorysection102 = MemorySection.START_SECTION;
            MemorySection memorySection = memorysection102;
            IBasicConfiguration ibasicconfiguration113 = BasicConfiguration.Instance;
            String ibasicconfiguration113_ModuleName = "Can";
            ibasicconfiguration113.ModuleName = ibasicconfiguration113_ModuleName;
            typeof(StructGenerationItem).GetProperty("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ibasicconfiguration113);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            String string135 = "";
            String includeMem = string135;
            Dictionary<String, List<String>> dictionary146 = new Dictionary<String, List<String>>();
            List<String> dictionary146_STARTSECTION = new List<String>();
            String dictionary146_STARTSECTION_0 = "can_gaa";
            List<String> dictionary146_STOPSECTION = new List<String>();
            String dictionary146_STOPSECTION_0 = "can_gaa";
            dictionary146["START_SECTION"] = dictionary146_STARTSECTION;
            dictionary146_STARTSECTION.Add(dictionary146_STARTSECTION_0);
            dictionary146["STOP_SECTION"] = dictionary146_STOPSECTION;
            dictionary146_STOPSECTION.Add(dictionary146_STOPSECTION_0);
            Dictionary<String, List<String>> MemorySectionMapping = dictionary146;
            /* Act */
            List<BaseGenerationItem> actualResult = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetMethod("genMemorySection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(MemorySection), typeof(String), typeof(Dictionary<String, List<String>>), typeof(bool)}, null).Invoke(_target, new object[]{structName, memorySection, includeMem, MemorySectionMapping, false});
            /* Assert */
            Object actualResult_count_125 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)6, (Int32)actualResult_count_125);
            Object Name1 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Object Name2 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[1]);
            Object Name3 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[2]);
            Object Name4 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[3]);
            Object Name5 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[4]);
            Object Name6 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[5]);
            Assert.AreEqual("CAN_START_SEC_START_SECTION", Name1);
            Assert.AreEqual("CAN_START_SEC_STOP_SECTION", Name4);
            Assert.AreEqual("", Name2);
            Assert.AreEqual("", Name3);
            Assert.AreEqual("", Name5);
            Assert.AreEqual("", Name6);

        }
    }

    [TestMethod]
    public void genMemorySectionTest_79_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "can_gaa";
            String structName = string97;
            MemorySection memorysection108 = MemorySection.STOP_SECTION;
            MemorySection memorySection = memorysection108;
            IBasicConfiguration ibasicconfiguration119 = BasicConfiguration.Instance;
            String ibasicconfiguration119_ModuleName = "Can";
            ibasicconfiguration119.ModuleName = ibasicconfiguration119_ModuleName;
            typeof(StructGenerationItem).GetProperty("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ibasicconfiguration119);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            String string1311 = "";
            String includeMem = string1311;
            Dictionary<String, List<String>> dictionary1412 = new Dictionary<String, List<String>>();
            List<String> dictionary1412_STARTSECTION = new List<String>();
            String dictionary1412_STARTSECTION_0 = "can_gaa";
            List<String> dictionary1412_STOPSECTION = new List<String>();
            String dictionary1412_STOPSECTION_0 = "can_gaa";
            dictionary1412["START_SECTION"] = dictionary1412_STARTSECTION;
            dictionary1412_STARTSECTION.Add(dictionary1412_STARTSECTION_0);
            dictionary1412["STOP_SECTION"] = dictionary1412_STOPSECTION;
            dictionary1412_STOPSECTION.Add(dictionary1412_STOPSECTION_0);
            Dictionary<String, List<String>> MemorySectionMapping = dictionary1412;
            /* Act */
            List<BaseGenerationItem> actualResult = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetMethod("genMemorySection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(MemorySection), typeof(String), typeof(Dictionary<String, List<String>>), typeof(bool) }, null).Invoke(_target, new object[]{structName, memorySection, includeMem, MemorySectionMapping, true});
            /* Assert */
            Object actualResult_count_126 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)6, (Int32)actualResult_count_126);
            Object Name1 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Object Name2 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[1]);
            Object Name3 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[2]);
            Object Name4 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[3]);
            Object Name5 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[4]);
            Object Name6 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult[5]);
            Assert.AreEqual("CAN_STOP_SEC_START_SECTION", Name1);
            Assert.AreEqual("CAN_STOP_SEC_STOP_SECTION", Name4);
            Assert.AreEqual("", Name2);
            Assert.AreEqual("", Name3);
            Assert.AreEqual("", Name5);
            Assert.AreEqual("", Name6);
        }
    }

    [TestMethod]
    public void genMemorySectionTest_79_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string913 = "can_gaa";
            String structName = string913;
            MemorySection memorysection1014 = MemorySection.STOP_SECTION;
            MemorySection memorySection = memorysection1014;
            IBasicConfiguration ibasicconfiguration1115 = BasicConfiguration.Instance;
            String ibasicconfiguration1115_ModuleName = "Can";
            ibasicconfiguration1115.ModuleName = ibasicconfiguration1115_ModuleName;
            typeof(StructGenerationItem).GetProperty("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ibasicconfiguration1115);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            String string1317 = "";
            String includeMem = string1317;
            Dictionary<String, List<String>> dictionary1418 = new Dictionary<String, List<String>>();
            List<String> dictionary1418_STARTSECTION = new List<String>();
            String dictionary1418_STARTSECTION_0 = "can_gaa1";
            List<String> dictionary1418_STOPSECTION = new List<String>();
            String dictionary1418_STOPSECTION_0 = "can_gaa1";
            dictionary1418["START_SECTION"] = dictionary1418_STARTSECTION;
            dictionary1418_STARTSECTION.Add(dictionary1418_STARTSECTION_0);
            dictionary1418["STOP_SECTION"] = dictionary1418_STOPSECTION;
            dictionary1418_STOPSECTION.Add(dictionary1418_STOPSECTION_0);
            Dictionary<String, List<String>> MemorySectionMapping = dictionary1418;
            /* Act */
            List<BaseGenerationItem> actualResult = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetMethod("genMemorySection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(MemorySection), typeof(String), typeof(Dictionary<String, List<String>>), typeof(bool) }, null).Invoke(_target, new object[]{structName, memorySection, includeMem, MemorySectionMapping, false});
            /* Assert */
            Object actualResult_count_127 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_127);
        }
    }

    [TestMethod]
    public void genMemorySectionTest_79_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string919 = "can_gaa";
            String structName = string919;
            MemorySection memorysection1020 = MemorySection.START_SECTION;
            MemorySection memorySection = memorysection1020;
            IBasicConfiguration ibasicconfiguration1121 = BasicConfiguration.Instance;
            String ibasicconfiguration1121_ModuleName = "Can";
            ibasicconfiguration1121.ModuleName = ibasicconfiguration1121_ModuleName;
            typeof(StructGenerationItem).GetProperty("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ibasicconfiguration1121);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            String string1323 = "";
            String includeMem = string1323;
            Dictionary<String, List<String>> dictionary1424 = new Dictionary<String, List<String>>();
            List<String> dictionary1424_STARTSECTION = new List<String>();
            String dictionary1424_STARTSECTION_0 = "can_gaa1";
            List<String> dictionary1424_STOPSECTION = new List<String>();
            String dictionary1424_STOPSECTION_0 = "can_gaa1";
            dictionary1424["START_SECTION"] = dictionary1424_STARTSECTION;
            dictionary1424_STARTSECTION.Add(dictionary1424_STARTSECTION_0);
            dictionary1424["STOP_SECTION"] = dictionary1424_STOPSECTION;
            dictionary1424_STOPSECTION.Add(dictionary1424_STOPSECTION_0);
            Dictionary<String, List<String>> MemorySectionMapping = dictionary1424;
            /* Act */
            List<BaseGenerationItem> actualResult = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetMethod("genMemorySection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(MemorySection), typeof(String), typeof(Dictionary<String, List<String>>), typeof(bool) }, null).Invoke(_target, new object[]{structName, memorySection, includeMem, MemorySectionMapping, false});
            /* Assert */
            Object actualResult_count_128 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_128);
        }
    }
}