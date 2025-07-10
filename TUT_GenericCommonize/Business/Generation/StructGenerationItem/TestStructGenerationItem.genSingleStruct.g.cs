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
    public void genSingleStructTest_80_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem91 = new BaseIntermediateItem(null, null);
            String baseintermediateitem91_Name = "Lin_GaaConfiguration";
            String baseintermediateitem91_Value = "Lin_ConfigType";
            List<BaseIntermediateItem> baseintermediateitem91_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem91_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem91_Childs_0_Name = "EcuMConf_EcuMWakeupSource_EcuMWakeupSource";
            String baseintermediateitem91_Childs_0_Value = "";
            List<BaseIntermediateItem> baseintermediateitem91_Childs_0_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem91_Childs_0_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem91_Childs_0_Childs_0_Name = "LIN_NOWAKEUP";
            String baseintermediateitem91_Childs_0_Childs_0_Value = "";
            baseintermediateitem91.Name = baseintermediateitem91_Name;
            baseintermediateitem91.Value = baseintermediateitem91_Value;
            baseintermediateitem91.Childs = baseintermediateitem91_Childs;
            baseintermediateitem91_Childs.Add(baseintermediateitem91_Childs_0);
            baseintermediateitem91_Childs_0.Name = baseintermediateitem91_Childs_0_Name;
            baseintermediateitem91_Childs_0.Value = baseintermediateitem91_Childs_0_Value;
            baseintermediateitem91_Childs_0.Childs = baseintermediateitem91_Childs_0_Childs;
            baseintermediateitem91_Childs_0_Childs.Add(baseintermediateitem91_Childs_0_Childs_0);
            baseintermediateitem91_Childs_0_Childs_0.Name = baseintermediateitem91_Childs_0_Childs_0_Name;
            baseintermediateitem91_Childs_0_Childs_0.Value = baseintermediateitem91_Childs_0_Childs_0_Value;
            BaseIntermediateItem child = baseintermediateitem91;
            Int32 int32102 = 1;
            Int32 index = int32102;
            Dictionary<String, Dictionary<String, String>> dictionary113 = new Dictionary<String, Dictionary<String, String>>() 
            { {"Lin_GaaConfiguration", new Dictionary<string, string>(){{ "qac1", "JV-01"} } } };
            Dictionary<String, Dictionary<String, String>> qacMapping = dictionary113;
            /* Act */
            StructGenerationItem actualResult = (StructGenerationItem)typeof(StructGenerationItem).GetMethod("genSingleStruct", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BaseIntermediateItem), typeof(Int32), typeof(Dictionary<String, Dictionary<String, String>>)}, null).Invoke(_target, new object[]{child, index, qacMapping});
            /* Assert */
            List<BaseGenerationItem> actualResult_children_17 = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetField("children", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Object actualResult_children_17_count_28 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_children_17);
            Assert.AreEqual((Int32)1, (Int32)actualResult_children_17_count_28);
            
            Object preComment = typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance  | BindingFlags.NonPublic).GetValue(actualResult_children_17[0]);
            Assert.AreEqual("/* Index: 0 - EcuMConf_EcuMWakeupSource_EcuMWakeupSource */", preComment);

        }
    }

    [TestMethod]
    public void genSingleStructTest_80_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem94 = new BaseIntermediateItem(null, null);
            String baseintermediateitem94_Name = "Lin_GaaConfiguration";
            String baseintermediateitem94_Value = "Lin_ConfigType";
            List<BaseIntermediateItem> baseintermediateitem94_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem94_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem94_Childs_0_Name = "EcuMConf_EcuMWakeupSource_EcuMWakeupSource";
            String baseintermediateitem94_Childs_0_Value = "";
            BaseIntermediateItem baseintermediateitem94_Childs_1 = new BaseIntermediateItem(null, null);
            String baseintermediateitem94_Childs_1_Name = "(P2VAR(RLin3_UartRegs, TYPEDEF, REGSPACE))";
            String baseintermediateitem94_Childs_1_Value = "0xFFCE0001UL";
            baseintermediateitem94.Name = baseintermediateitem94_Name;
            baseintermediateitem94.Value = baseintermediateitem94_Value;
            baseintermediateitem94.Childs = baseintermediateitem94_Childs;
            baseintermediateitem94_Childs.Add(baseintermediateitem94_Childs_0);
            baseintermediateitem94_Childs_0.Name = baseintermediateitem94_Childs_0_Name;
            baseintermediateitem94_Childs_0.Value = baseintermediateitem94_Childs_0_Value;
            baseintermediateitem94_Childs.Add(baseintermediateitem94_Childs_1);
            baseintermediateitem94_Childs_1.Name = baseintermediateitem94_Childs_1_Name;
            baseintermediateitem94_Childs_1.Value = baseintermediateitem94_Childs_1_Value;
            BaseIntermediateItem child = baseintermediateitem94;
            Int32 int32105 = 0;
            Int32 index = int32105;
            Dictionary<String, Dictionary<String, String>> dictionary116 = new Dictionary<String, Dictionary<String, String>>()
            { {"Lin_GaaConfiguration", new Dictionary<string, string>(){{ "qac1", "JV-01"} } } };
            Dictionary<String, Dictionary<String, String>> qacMapping = dictionary116;
            /* Act */
            StructGenerationItem actualResult = (StructGenerationItem)typeof(StructGenerationItem).GetMethod("genSingleStruct", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BaseIntermediateItem), typeof(Int32), typeof(Dictionary<String, Dictionary<String, String>>)}, null).Invoke(_target, new object[]{child, index, qacMapping});
            /* Assert */
            List<BaseGenerationItem> actualResult_children_19 = (List<BaseGenerationItem>)typeof(StructGenerationItem).GetField("children", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Object actualResult_children_19_count_210 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_children_19);
            Assert.AreEqual((Int32)3, (Int32)actualResult_children_19_count_210);
            
            Object preComment1 = typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult_children_19[0]);
            Object preComment2 = typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult_children_19[1]);
            Object preComment3 = typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(actualResult_children_19[2]);
            Assert.AreEqual("", preComment1);
            Assert.AreEqual("", preComment2);
            Assert.AreEqual("/* (P2VAR(RLin3_UartRegs, TYPEDEF, REGSPACE)) */", preComment3);
        }
    }
}