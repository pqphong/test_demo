using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using static Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.StructGenerationItem;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestStructGenerationItem
{
    [TestMethod]
    public void GenStructureTest_78_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Adc_Gaa";
            String structName = string91;
			Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            IBasicConfiguration ibasicconfiguration102 = BasicConfiguration.Instance;
            String ibasicconfiguration102_ModuleName = "Can";
            ibasicconfiguration102.ModuleName = ibasicconfiguration102_ModuleName;
            ibasicconfiguration102.VendorApiInfix = "int0";
            ibasicconfiguration102.VendorId = 59;
            typeof(StructGenerationItem).GetProperty("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ibasicconfiguration102);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.genMemorySectionStringStructGenerationItemMemorySectionStringDictionaryOfStringListOfStringBoolean = (StructGenerationItem instance, String _structName, MemorySection memorySection, String includeMem, Dictionary<String, List<String>> MemorySectionMapping, Boolean hasInstanceSetting) =>
            {
                List<BaseGenerationItem> list113 = new List<BaseGenerationItem>();
                BaseGenerationItem list113_0 = new BaseGenerationItem(null, null, null, null, null, null, 0, false, false, AppendType.FULL_UPPER);
                String list113_0_Name = "mem1";
                String list113_0_Value = "val1";
                list113.Add(list113_0);
                typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list113_0, list113_0_Name);
                typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list113_0, list113_0_Value);
                return list113;
            }

            ;
            Dictionary<String, String> dictionary124 = new Dictionary<String, String>();
            String dictionary124_AdcGaa = "precompile";
            dictionary124["Adc_Gaa"] = dictionary124_AdcGaa;
            typeof(StructGenerationItem).GetProperty("preCompileMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary124);
            Dictionary<String, List<String>> dictionary135 = new Dictionary<String, List<String>>();
            List<String> dictionary135_mem1 = new List<string>()
            {"Adc_Gaa"};
            dictionary135["mem1"] = dictionary135_mem1;
            typeof(StructGenerationItem).GetProperty("memorySectionMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary135);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.isMemmapInsidePreCompileString = (StructGenerationItem instance, String _structName) =>
            {
                Boolean boolean146 = true;
                return boolean146;
            }

            ;
            String string179 = "struct comment";
            String structComment = string179;
            String structItemNum = null;
            BaseIntermediateItem baseintermediateitem1911 = null;
            string qualifier = string.Empty;
            typeof(StructGenerationItem).GetProperty("data", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, baseintermediateitem1911);
			bool isArray = true;
            /* Act */
            List<BaseGenerationItem> actualResult = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetMethod("GenStructure", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(String), typeof(bool)}, null).Invoke(_target, new object[]{structName, qualifier, structComment, structItemNum, isArray});
            /* Assert */
            Object actualResult_count_145 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)6, (Int32)actualResult_count_145);
            Object actualResult_0_146 = ((List<BaseGenerationItem>)actualResult)[1];
            Object actualResult_0_146_name_247 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_146);
            Assert.AreEqual((String)"mem1", (String)actualResult_0_146_name_247);
        }
    }

    [TestMethod]
    public void GenStructureTest_78_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string912 = "Adc_Gaa";
            String structName = string912;
			Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            IBasicConfiguration ibasicconfiguration1013 = BasicConfiguration.Instance;
            String ibasicconfiguration1013_ModuleName = "Adc";
            ibasicconfiguration1013.ModuleName = ibasicconfiguration1013_ModuleName;
            ibasicconfiguration1013.VendorApiInfix = "int0";
            ibasicconfiguration1013.VendorId = 59;
            typeof(StructGenerationItem).GetProperty("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ibasicconfiguration1013);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.genMemorySectionStringStructGenerationItemMemorySectionStringDictionaryOfStringListOfStringBoolean = (StructGenerationItem instance, String _structName, MemorySection memorySection, String includeMem, Dictionary<String, List<String>> MemorySectionMapping, Boolean hasInstanceSetting) =>
            {
                List<BaseGenerationItem> list1114 = new List<BaseGenerationItem>();
                BaseGenerationItem list1114_0 = new BaseGenerationItem(null, null, null, null, null, null, 0, false, false, AppendType.FULL_UPPER);
                String list1114_0_Name = "mem2";
                String list1114_0_Value = "val2";
                list1114.Add(list1114_0);
                typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list1114_0, list1114_0_Name);
                typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list1114_0, list1114_0_Value);
                return list1114;
            }

            ;
            Dictionary<String, String> dictionary1215 = new Dictionary<String, String>();
            String dictionary1215_AdcGaa = "precompile";
            dictionary1215["Adc_Gaa"] = dictionary1215_AdcGaa;
            typeof(StructGenerationItem).GetProperty("preCompileMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary1215);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.isMemmapInsidePreCompileString = (StructGenerationItem instance, String _structName) =>
            {
                Boolean boolean1417 = false;
                return boolean1417;
            }

            ;
            Boolean boolean1518 = true;
            typeof(StructGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1518);
            String string1619 = "VAR_NO_INIT";
            typeof(StructGenerationItem).GetProperty("memClass", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1619);
            String string1720 = "";
            String structComment = string1720;
            String structItemNum = null;
            BaseIntermediateItem baseintermediateitem1922 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1922_Name = "LIN_CBK_C_AR_RELEASE_MAJOR_VERSION";
            String baseintermediateitem1922_Value = "4U";
            List<BaseIntermediateItem> baseintermediateitem1922_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem1922_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1922_Childs_0_Name = "LIN_CBK_C_SW_MAJOR_VERSION";
            String baseintermediateitem1922_Childs_0_Value = "1U";
            BaseIntermediateItem baseintermediateitem1922_Childs_1 = new BaseIntermediateItem(null, null);
            List<BaseIntermediateItem> baseintermediateitem1922_Childs_1_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem1922_Childs_1_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1922_Childs_1_Childs_0_Name = "LIN_CBK_C_SW_MAJOR_VERSION";
            String baseintermediateitem1922_Childs_1_Childs_0_Value = "1U";
            baseintermediateitem1922.Name = baseintermediateitem1922_Name;
            baseintermediateitem1922.Value = baseintermediateitem1922_Value;
            baseintermediateitem1922.Childs = baseintermediateitem1922_Childs;
            baseintermediateitem1922_Childs.Add(baseintermediateitem1922_Childs_0);
            baseintermediateitem1922_Childs_0.Name = baseintermediateitem1922_Childs_0_Name;
            baseintermediateitem1922_Childs_0.Value = baseintermediateitem1922_Childs_0_Value;
            baseintermediateitem1922_Childs.Add(baseintermediateitem1922_Childs_1);
            baseintermediateitem1922_Childs_1.Childs = baseintermediateitem1922_Childs_1_Childs;
            baseintermediateitem1922_Childs_1_Childs.Add(baseintermediateitem1922_Childs_1_Childs_0);
            baseintermediateitem1922_Childs_1_Childs_0.Name = baseintermediateitem1922_Childs_1_Childs_0_Name;
            baseintermediateitem1922_Childs_1_Childs_0.Value = baseintermediateitem1922_Childs_1_Childs_0_Value;
            string qualifier = string.Empty;
            typeof(StructGenerationItem).GetProperty("data", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, baseintermediateitem1922);
			bool isArray = true;
            /* Act */
            List<BaseGenerationItem> actualResult = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetMethod("GenStructure", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(String), typeof(bool)}, null).Invoke(_target, new object[]{structName, qualifier, structComment, structItemNum, isArray});
            /* Assert */
            Object actualResult_count_148 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)6, (Int32)actualResult_count_148);
            Object actualResult_0_149 = ((List<BaseGenerationItem>)actualResult)[0];
            Object actualResult_0_149_name_250 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_149);
            Assert.AreEqual((String)"mem2", (String)actualResult_0_149_name_250);
        }
    }

    [TestMethod]
    public void GenStructureTest_78_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string923 = "Adc_Gaa";
            String structName = string923;
			Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            IBasicConfiguration ibasicconfiguration1024 = BasicConfiguration.Instance;
            String ibasicconfiguration1024_ModuleName = "Can";
            ibasicconfiguration1024.ModuleName = ibasicconfiguration1024_ModuleName;
            typeof(StructGenerationItem).GetProperty("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ibasicconfiguration1024);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.genMemorySectionStringStructGenerationItemMemorySectionStringDictionaryOfStringListOfStringBoolean = (StructGenerationItem instance, String _structName, MemorySection memorySection, String includeMem, Dictionary<String, List<String>> MemorySectionMapping, Boolean hasInstanceSetting) =>
            {
                List<BaseGenerationItem> list1125 = new List<BaseGenerationItem>();
                BaseGenerationItem list1125_0 = new BaseGenerationItem(null, null, null, null, null, null, 0, false, false, AppendType.FULL_UPPER);
                String list1125_0_Name = "mem2";
                String list1125_0_Value = "val2";
                list1125.Add(list1125_0);
                typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list1125_0, list1125_0_Name);
                typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list1125_0, list1125_0_Value);
                return list1125;
            }

            ;
            Dictionary<String, String> dictionary1226 = new Dictionary<String, String>();
            String dictionary1226_AdcGaa = "";
            dictionary1226["Adc_Gaa"] = dictionary1226_AdcGaa;
            typeof(StructGenerationItem).GetProperty("preCompileMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary1226);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.isMemmapInsidePreCompileString = (StructGenerationItem instance, String _structName) =>
            {
                Boolean boolean1428 = false;
                return boolean1428;
            }

            ;
            Boolean boolean1529 = false;
            typeof(StructGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1529);
            String string1630 = "";
            typeof(StructGenerationItem).GetProperty("memClass", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1630);
            String string1731 = "";
            String structComment = string1731;
            String structItemNum = null;
            BaseIntermediateItem baseintermediateitem1933 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1933_Name = "LIN_CBK_C_AR_RELEASE_MAJOR_VERSION";
            String baseintermediateitem1933_Value = "4U";
            List<BaseIntermediateItem> baseintermediateitem1933_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem1933_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1933_Childs_0_Name = "LIN_CBK_C_SW_MAJOR_VERSION";
            String baseintermediateitem1933_Childs_0_Value = "1U";
            BaseIntermediateItem baseintermediateitem1933_Childs_1 = new BaseIntermediateItem(null, null);
            List<BaseIntermediateItem> baseintermediateitem1933_Childs_1_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem1933_Childs_1_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1933_Childs_1_Childs_0_Name = "LIN_CBK_C_SW_MAJOR_VERSION";
            String baseintermediateitem1933_Childs_1_Childs_0_Value = "1U";
            baseintermediateitem1933.Name = baseintermediateitem1933_Name;
            baseintermediateitem1933.Value = baseintermediateitem1933_Value;
            baseintermediateitem1933.Childs = baseintermediateitem1933_Childs;
            baseintermediateitem1933_Childs.Add(baseintermediateitem1933_Childs_0);
            baseintermediateitem1933_Childs_0.Name = baseintermediateitem1933_Childs_0_Name;
            baseintermediateitem1933_Childs_0.Value = baseintermediateitem1933_Childs_0_Value;
            baseintermediateitem1933_Childs.Add(baseintermediateitem1933_Childs_1);
            baseintermediateitem1933_Childs_1.Childs = baseintermediateitem1933_Childs_1_Childs;
            baseintermediateitem1933_Childs_1_Childs.Add(baseintermediateitem1933_Childs_1_Childs_0);
            baseintermediateitem1933_Childs_1_Childs_0.Name = baseintermediateitem1933_Childs_1_Childs_0_Name;
            baseintermediateitem1933_Childs_1_Childs_0.Value = baseintermediateitem1933_Childs_1_Childs_0_Value;
            string qualifier = string.Empty;
            typeof(StructGenerationItem).GetProperty("data", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, baseintermediateitem1933);
			bool isArray = true;
            /* Act */
            List<BaseGenerationItem> actualResult = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetMethod("GenStructure", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(String), typeof(bool)}, null).Invoke(_target, new object[]{structName, qualifier, structComment, structItemNum, isArray});
            /* Assert */
            Object actualResult_count_151 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)4, (Int32)actualResult_count_151);
            Object actualResult_0_152 = ((List<BaseGenerationItem>)actualResult)[0];
            Object actualResult_0_152_name_253 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_152);
            Assert.AreEqual((String)"mem2", (String)actualResult_0_152_name_253);
        }
    }

    [TestMethod]
    public void GenStructureTest_78_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string934 = "Adc_Gaa";
            String structName = string934;
			Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            IBasicConfiguration ibasicconfiguration1035 = BasicConfiguration.Instance;
            String ibasicconfiguration1035_ModuleName = "Can";
            ibasicconfiguration1035.ModuleName = ibasicconfiguration1035_ModuleName;
            typeof(StructGenerationItem).GetProperty("basicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ibasicconfiguration1035);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.genMemorySectionStringStructGenerationItemMemorySectionStringDictionaryOfStringListOfStringBoolean = (StructGenerationItem instance, String _structName, MemorySection memorySection, String includeMem, Dictionary<String, List<String>> MemorySectionMapping, Boolean hasInstanceSetting) =>
            {
                List<BaseGenerationItem> list1136 = new List<BaseGenerationItem>();
                BaseGenerationItem list1136_0 = new BaseGenerationItem(null, null, null, null, null, null, 0, false, false, AppendType.FULL_UPPER);
                String list1136_0_Name = "mem2";
                String list1136_0_Value = "val2";
                list1136.Add(list1136_0);
                typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list1136_0, list1136_0_Name);
                typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list1136_0, list1136_0_Value);
                return list1136;
            }

            ;
            Dictionary<String, String> dictionary1237 = new Dictionary<String, String>();
            String dictionary1237_AdcGaa = null;
            dictionary1237["Adc_Gaa1"] = dictionary1237_AdcGaa;
            typeof(StructGenerationItem).GetProperty("preCompileMapping", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, dictionary1237);
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.isMemmapInsidePreCompileString = (StructGenerationItem instance, String _structName) =>
            {
                Boolean boolean1439 = false;
                return boolean1439;
            }

            ;
            Boolean boolean1540 = false;
            typeof(StructGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1540);
            String string1641 = "VAR_NO_INIT";
            typeof(StructGenerationItem).GetProperty("memClass", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1641);
            String string1742 = "";
            String structComment = string1742;
            String structItemNum = null;
            BaseIntermediateItem baseintermediateitem1944 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1944_Name = "LIN_CBK_C_AR_RELEASE_MAJOR_VERSION";
            String baseintermediateitem1944_Value = "4U";
            List<BaseIntermediateItem> baseintermediateitem1944_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem1944_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1944_Childs_0_Name = "LIN_CBK_C_SW_MAJOR_VERSION";
            String baseintermediateitem1944_Childs_0_Value = "1U";
            BaseIntermediateItem baseintermediateitem1944_Childs_1 = new BaseIntermediateItem(null, null);
            List<BaseIntermediateItem> baseintermediateitem1944_Childs_1_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem1944_Childs_1_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1944_Childs_1_Childs_0_Name = "LIN_CBK_C_SW_MAJOR_VERSION";
            String baseintermediateitem1944_Childs_1_Childs_0_Value = "1U";
            baseintermediateitem1944.Name = baseintermediateitem1944_Name;
            baseintermediateitem1944.Value = baseintermediateitem1944_Value;
            baseintermediateitem1944.Childs = baseintermediateitem1944_Childs;
            baseintermediateitem1944_Childs.Add(baseintermediateitem1944_Childs_0);
            baseintermediateitem1944_Childs_0.Name = baseintermediateitem1944_Childs_0_Name;
            baseintermediateitem1944_Childs_0.Value = baseintermediateitem1944_Childs_0_Value;
            baseintermediateitem1944_Childs.Add(baseintermediateitem1944_Childs_1);
            baseintermediateitem1944_Childs_1.Childs = baseintermediateitem1944_Childs_1_Childs;
            baseintermediateitem1944_Childs_1_Childs.Add(baseintermediateitem1944_Childs_1_Childs_0);
            baseintermediateitem1944_Childs_1_Childs_0.Name = baseintermediateitem1944_Childs_1_Childs_0_Name;
            baseintermediateitem1944_Childs_1_Childs_0.Value = baseintermediateitem1944_Childs_1_Childs_0_Value;
            string qualifier = string.Empty;
            typeof(StructGenerationItem).GetProperty("data", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, baseintermediateitem1944);
			bool isArray = false;
            /* Act */
            List<BaseGenerationItem> actualResult = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetMethod("GenStructure", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(String), typeof(bool)}, null).Invoke(_target, new object[]{structName, qualifier, structComment, structItemNum, isArray});
            /* Assert */
            Object actualResult_count_154 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)4, (Int32)actualResult_count_154);
            Object actualResult_0_155 = ((List<BaseGenerationItem>)actualResult)[0];
            Object actualResult_0_155_name_256 = typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_155);
            Assert.AreEqual((String)"mem2", (String)actualResult_0_155_name_256);
        }
    }
}