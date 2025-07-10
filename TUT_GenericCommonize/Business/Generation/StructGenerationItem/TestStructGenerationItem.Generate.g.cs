using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestStructGenerationItem
{
    [TestMethod]
    public void GenerateTest_76_1()
    {
        using (ShimsContext.Create())
        {
            IBasicConfiguration basicconfig = ObjectFactory.GetInstance<IBasicConfiguration>();
            basicconfig.ModuleName = "Lin";
            /* Arrange */
            List<BaseGenerationItem> list91 = new List<BaseGenerationItem>();
            BaseGenerationItem list91_0 = new BaseGenerationItem(null, null, null, null, null);
            String list91_0_PreComment = "MISRA Violation: START Msg(4:0306)-1";
            String list91_0_PostComment = "END Msg(4:0306)-1";
            String list91_0_Name = "(P2VAR(RLin3_UartRegs, TYPEDEF, REGSPACE))";
            String list91_0_Value = "0xFFCE0001UL";
            BaseGenerationItem list91_1 = new BaseGenerationItem(null, null, null, null, null);
            String list91_1_PreComment = "MISRA Violation: START Msg(4:0306)-1";
            String list91_1_PostComment = "END Msg(4:0306)-1";
            String list91_1_Name = "(P2VAR(uint16, TYPEDEF, REGSPACE))";
            String list91_1_Value = "0xFFFFB0A6UL";
            list91.Add(list91_0);
            typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_0, list91_0_PreComment);
            typeof(BaseGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_0, list91_0_PostComment);
            typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_0, list91_0_Name);
            typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_0, list91_0_Value);
            list91.Add(list91_1);
            typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_1, list91_1_PreComment);
            typeof(BaseGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_1, list91_1_PostComment);
            typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_1, list91_1_Name);
            typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_1, list91_1_Value);
            typeof(StructGenerationItem).GetField("children", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, list91);
            Int32 int32102 = 1;
            typeof(StructGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32102);
            String string113 = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACONST";
            typeof(StructGenerationItem).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string113);
            String string124 = "Lin_GaaRLIN3Properties";
            typeof(StructGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string124);
            Boolean boolean135 = true;
            typeof(StructGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean135);
            typeof(StructGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, true);
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            GenerationSettings generationSettings = new GenerationSettings();
            generationSettings.InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            generationSettings.InstanceSetting.IsMultiInstance = true;
            /* Act */
            String actualResult = (String)typeof(StructGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings) }, null).Invoke(_target, new object[]{ generationSettings });
            /* Assert */
            Assert.IsTrue(actualResult.Contains("CONST"));
        }
    }

    [TestMethod]
    public void GenerateTest_76_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<BaseGenerationItem> list96 = new List<BaseGenerationItem>();
            BaseGenerationItem list96_0 = new BaseGenerationItem(null, null, null, null, null);
            String list96_0_PreComment = "MISRA Violation: START Msg(4:0306)-1";
            String list96_0_PostComment = "END Msg(4:0306)-1";
            String list96_0_Name = "(P2VAR(RLin3_UartRegs, TYPEDEF, REGSPACE))";
            String list96_0_Value = "0xFFCE0001UL";
            BaseGenerationItem list96_1 = new BaseGenerationItem(null, null, null, null, null);
            String list96_1_PreComment = "MISRA Violation: START Msg(4:0306)-1";
            String list96_1_PostComment = "END Msg(4:0306)-1";
            String list96_1_Name = "(P2VAR(uint16, TYPEDEF, REGSPACE))";
            String list96_1_Value = "0xFFFFB0A6UL";
            list96.Add(list96_0);
            typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list96_0, list96_0_PreComment);
            typeof(BaseGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list96_0, list96_0_PostComment);
            typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list96_0, list96_0_Name);
            typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list96_0, list96_0_Value);
            list96.Add(list96_1);
            typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list96_1, list96_1_PreComment);
            typeof(BaseGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list96_1, list96_1_PostComment);
            typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list96_1, list96_1_Name);
            typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list96_1, list96_1_Value);
            typeof(StructGenerationItem).GetField("children", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, list96);
            Int32 int32107 = 0;
            typeof(StructGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32107);
            String string118 = "";
            typeof(StructGenerationItem).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string118);
            String string129 = "";
            typeof(StructGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string129);
            typeof(StructGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, false);
            Boolean boolean1310 = false;
            typeof(StructGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1310);
            /* Act */
            GenerationSettings generationSettings = new GenerationSettings();
            generationSettings.InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            generationSettings.InstanceSetting.IsMultiInstance = false;

            String actualResult = (String)typeof(StructGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings) }, null).Invoke(_target, new object[]{ generationSettings });
            /* Assert */
            Assert.IsTrue(!actualResult.Contains("CONST Lin_GaaRLIN3Properties"));
        }
    }

    [TestMethod]
    public void GenerateTest_76_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<BaseGenerationItem> list911 = new List<BaseGenerationItem>();
            BaseGenerationItem list911_0 = new BaseGenerationItem(null, null, null, null, null);
            String list911_0_PreComment = "MISRA Violation: START Msg(4:0306)-1";
            String list911_0_PostComment = "END Msg(4:0306)-1";
            String list911_0_Name = "(P2VAR(RLin3_UartRegs, TYPEDEF, REGSPACE))";
            String list911_0_Value = "0xFFCE0001UL";
            BaseGenerationItem list911_1 = new BaseGenerationItem(null, null, null, null, null);
            String list911_1_PreComment = "MISRA Violation: START Msg(4:0306)-1";
            String list911_1_PostComment = "END Msg(4:0306)-1";
            String list911_1_Name = "(P2VAR(uint16, TYPEDEF, REGSPACE))";
            String list911_1_Value = "0xFFFFB0A6UL";
            list911.Add(list911_0);
            typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list911_0, list911_0_PreComment);
            typeof(BaseGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list911_0, list911_0_PostComment);
            typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list911_0, list911_0_Name);
            typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list911_0, list911_0_Value);
            list911.Add(list911_1);
            typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list911_1, list911_1_PreComment);
            typeof(BaseGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list911_1, list911_1_PostComment);
            typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list911_1, list911_1_Name);
            typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list911_1, list911_1_Value);
            typeof(StructGenerationItem).GetField("children", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, list911);
            Int32 int321012 = 1;
            typeof(StructGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321012);
            String string1113 = "CONST";
            typeof(StructGenerationItem).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1113);
            String string1214 = "Lin_GaaRLIN3Properties";
            typeof(StructGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1214);
            typeof(StructGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, false);
            Boolean boolean1315 = false;
            typeof(StructGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1315);
            /* Act */
          
            String actualResult = (String)typeof(StructGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings) }, null).Invoke(_target, new object[]{ null });
            /* Assert */
            Assert.IsTrue(actualResult.Contains("Lin_GaaRLIN3Properties"));
        }
    }

    [TestMethod]
    public void GenerateTest_76_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<BaseGenerationItem> list91 = new List<BaseGenerationItem>();
            BaseGenerationItem list91_0 = new BaseGenerationItem(null, null, null, null, null);
            String list91_0_PreComment = "MISRA Violation: START Msg(4:0306)-1";
            String list91_0_PostComment = "END Msg(4:0306)-1";
            String list91_0_Name = "(P2VAR(RLin3_UartRegs, TYPEDEF, REGSPACE))";
            String list91_0_Value = "0xFFCE0001UL";
            BaseGenerationItem list91_1 = new BaseGenerationItem(null, null, null, null, null);
            String list91_1_PreComment = "MISRA Violation: START Msg(4:0306)-1";
            String list91_1_PostComment = "END Msg(4:0306)-1";
            String list91_1_Name = "(P2VAR(uint16, TYPEDEF, REGSPACE))";
            String list91_1_Value = "0xFFFFB0A6UL";
            list91.Add(list91_0);
            typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_0, list91_0_PreComment);
            typeof(BaseGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_0, list91_0_PostComment);
            typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_0, list91_0_Name);
            typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_0, list91_0_Value);
            list91.Add(list91_1);
            typeof(BaseGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_1, list91_1_PreComment);
            typeof(BaseGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_1, list91_1_PostComment);
            typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_1, list91_1_Name);
            typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(list91_1, list91_1_Value);
            typeof(StructGenerationItem).GetField("children", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, list91);
            Int32 int32102 = 1;
            typeof(StructGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32102);
            String string113 = "CONST";
            typeof(StructGenerationItem).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string113);
            String string124 = "$$$";
            typeof(StructGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string124);
            Boolean boolean135 = true;
            typeof(StructGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean135);
            GenerationSettings generationSettings = new GenerationSettings();
            typeof(StructGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, false);
            generationSettings.InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            generationSettings.InstanceSetting.IsMultiInstance = true;
            /* Act */
            String actualResult = (String)typeof(StructGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(GenerationSettings) }, null).Invoke(_target, new object[] { generationSettings });
            /* Assert */
            Assert.IsTrue(actualResult.Contains(""));
        }
    }

}