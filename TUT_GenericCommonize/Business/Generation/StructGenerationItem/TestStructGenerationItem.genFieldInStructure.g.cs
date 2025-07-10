using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestStructGenerationItem
{
    [TestMethod]
    public void genFieldInStructureTest_81_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem91 = new BaseIntermediateItem(null, null);
            String baseintermediateitem91_Name = "LIN_PBCFG_C_SW_MAJOR_VERSION";
            String baseintermediateitem91_Value = "1U";
            baseintermediateitem91.Name = baseintermediateitem91_Name;
            baseintermediateitem91.Value = baseintermediateitem91_Value;
            BaseIntermediateItem item = baseintermediateitem91;
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            Dictionary<String, Dictionary<String, String>> dictionary113 = null;
            Dictionary<String, Dictionary<String, String>> qacMapping = dictionary113;
            /* Act */
            BaseGenerationItem actualResult = (BaseGenerationItem)typeof(StructGenerationItem).GetMethod("genFieldInStructure", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BaseIntermediateItem), typeof(Dictionary<String, Dictionary<String, String>>) }, null).Invoke(_target, new object[] { item, qacMapping });
            /* Assert */
            Object actualResult_precomment_110 = typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"/* LIN_PBCFG_C_SW_MAJOR_VERSION */", (String)actualResult_precomment_110);
            Object actualResult_value_111 = typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"1U", (String)actualResult_value_111);
            Object actualResult_startqac_112 = typeof(BaseGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Dictionary<string, string> actualDict = (Dictionary<string, string>)actualResult_startqac_112;
            Assert.AreEqual((int)1, actualDict.Count);
        }
    }

    [TestMethod]
    public void genFieldInStructureTest_81_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem94 = new BaseIntermediateItem(null, null);
            String baseintermediateitem94_Name = "";
            String baseintermediateitem94_Value = "";
            baseintermediateitem94.Name = baseintermediateitem94_Name;
            baseintermediateitem94.Value = baseintermediateitem94_Value;
            BaseIntermediateItem item = baseintermediateitem94;
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            Dictionary<String, Dictionary<String, String>> dictionary116 = null;
            Dictionary<String, Dictionary<String, String>> qacMapping = dictionary116;
            /* Act */
            BaseGenerationItem actualResult = (BaseGenerationItem)typeof(StructGenerationItem).GetMethod("genFieldInStructure", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BaseIntermediateItem), typeof(Dictionary<String, Dictionary<String, String>>) }, null).Invoke(_target, new object[] { item, qacMapping });
            /* Assert */
            Object actualResult_precomment_116 = typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"", (String)actualResult_precomment_116);
            Object actualResult_value_117 = typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"", (String)actualResult_value_117);
            Object actualResult_startqac_112 = typeof(BaseGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Dictionary<string, string> actualDict = (Dictionary<string, string>)actualResult_startqac_112;
            Assert.AreEqual(null, actualDict);
        }
    }

    [TestMethod]
    public void genFieldInStructureTest_81_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem97 = new BaseIntermediateItem(null, null);
            String baseintermediateitem97_Name = "LIN_PBCFG_C_SW_MAJOR_VERSION";
            String baseintermediateitem97_Value = "NULL_PTR";
            baseintermediateitem97.Name = baseintermediateitem97_Name;
            baseintermediateitem97.Value = baseintermediateitem97_Value;
            BaseIntermediateItem item = baseintermediateitem97;
            Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems.Fakes.ShimStructGenerationItem.AllInstances.getQacMessageStringDictionaryOfStringDictionaryOfStringString = (StructGenerationItem instance, String param, Dictionary<String, Dictionary<String, String>> _qacMapping) =>
            {
                return new Dictionary<string, string>() { { "0123", "JV-01" } };
            }

            ;
            Dictionary<String, Dictionary<String, String>> dictionary119 = null;
            Dictionary<String, Dictionary<String, String>> qacMapping = dictionary119;
            /* Act */
            BaseGenerationItem actualResult = (BaseGenerationItem)typeof(StructGenerationItem).GetMethod("genFieldInStructure", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BaseIntermediateItem), typeof(Dictionary<String, Dictionary<String, String>>) }, null).Invoke(_target, new object[] { item, qacMapping });
            /* Assert */
            Object actualResult_precomment_122 = typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"/* LIN_PBCFG_C_SW_MAJOR_VERSION */", (String)actualResult_precomment_122);
            Object actualResult_value_123 = typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"NULL_PTR", (String)actualResult_value_123);
            Object actualResult_startqac_112 = typeof(BaseGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Dictionary<string, string> actualDict = (Dictionary<string, string>)actualResult_startqac_112;
            Assert.AreEqual(null, actualDict);
        }
    }
}