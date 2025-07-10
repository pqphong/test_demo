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

public partial class TestDefineGenerationItem
{
    [TestMethod]
    public void GenerateTest_93_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings91 = new GenerationSettings();
            InstanceSetting generationsettings91_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings91_InstanceSetting_IsMultiInstance = true;
            generationsettings91.InstanceSetting = generationsettings91_InstanceSetting;
            generationsettings91_InstanceSetting.IsMultiInstance = generationsettings91_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings91;
            String string102 = "ICU_PBCFG_C_SW_MAJOR_VERSION";
            typeof(DefineGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string102);
            String string113 = "1";
            typeof(DefineGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string113);
            Boolean boolean124 = true;
            typeof(DefineGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean124);
            Boolean boolean135 = false;
            typeof(DefineGenerationItem).GetField("HasValueInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean135);
            Renesas.Generator.MCALConfGen.Business.Generation.Settings.Fakes.ShimInstanceSetting.AllInstances.AppendSuffixToMacroStringAppendType = (InstanceSetting instance, String macro, AppendType type) =>
            {
                String string146 = "ICU_PBCFG_C_SW_MAJOR_VERSION_0";
                return string146;
            }

            ;
            String string157 = "/* This is Pre-Comment */";
            typeof(DefineGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string157);
            String string168 = "/* This is Post-Comment */";
            typeof(DefineGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string168);
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"/* This is Pre-Comment */\r\n#define ICU_PBCFG_C_SW_MAJOR_VERSION_0                                          1                                       /* PRQA S 0123 # JV-01 */\r\n/* This is Post-Comment */", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_93_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings910 = new GenerationSettings();
            InstanceSetting generationsettings910_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings910_InstanceSetting_IsMultiInstance = true;
            generationsettings910.InstanceSetting = generationsettings910_InstanceSetting;
            generationsettings910_InstanceSetting.IsMultiInstance = generationsettings910_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings910;
            String string1011 = "ICU_PBCFG_C_SW_MAJOR_VERSION";
            typeof(DefineGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1011);
            String string1112 = "1";
            typeof(DefineGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1112);
            Boolean boolean1213 = false;
            typeof(DefineGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1213);
            Boolean boolean1314 = true;
            typeof(DefineGenerationItem).GetField("HasValueInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1314);
            Renesas.Generator.MCALConfGen.Business.Generation.Settings.Fakes.ShimInstanceSetting.AllInstances.AppendSuffixToMacroStringAppendType = (InstanceSetting instance, String macro, AppendType type) =>
            {
                String string1415 = "1_0";
                return string1415;
            }

            ;
            String string1516 = "/* This is Pre-Comment */";
            typeof(DefineGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1516);
            String string1617 = "/* This is Post-Comment */";
            typeof(DefineGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1617);
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"/* This is Pre-Comment */\r\n#define ICU_PBCFG_C_SW_MAJOR_VERSION                                            1_0                                     /* PRQA S 0123 # JV-01 */\r\n/* This is Post-Comment */", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_93_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings919 = new GenerationSettings();
            InstanceSetting generationsettings919_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings919_InstanceSetting_IsMultiInstance = false;
            generationsettings919.InstanceSetting = generationsettings919_InstanceSetting;
            generationsettings919_InstanceSetting.IsMultiInstance = generationsettings919_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings919;
            String string1020 = "ICU_PBCFG_C_SW_MAJOR_VERSION";
            typeof(DefineGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1020);
            String string1121 = "1";
            typeof(DefineGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1121);
            Boolean boolean1222 = true;
            typeof(DefineGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1222);
            Boolean boolean1323 = true;
            typeof(DefineGenerationItem).GetField("HasValueInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1323);
            String string1525 = "/* This is Pre-Comment */";
            typeof(DefineGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1525);
            String string1626 = "/* This is Post-Comment */";
            typeof(DefineGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1626);
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"/* This is Pre-Comment */\r\n#define ICU_PBCFG_C_SW_MAJOR_VERSION                                            1                                       /* PRQA S 0123 # JV-01 */\r\n/* This is Post-Comment */", (String)actualResult);
        }
    }   

    [TestMethod]
    public void GenerateTest_93_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings946 = null;
            GenerationSettings genSettings = generationsettings946;
            String string1047 = "ICU_PBCFG_C_SW_MAJOR_VERSION";
            typeof(DefineGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1047);
            String string1148 = "1";
            typeof(DefineGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1148);
            Boolean boolean1249 = true;
            typeof(DefineGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1249);
            Boolean boolean1350 = true;
            typeof(DefineGenerationItem).GetField("HasValueInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1350);
            String string1552 = "/* This is Pre-Comment */";
            typeof(DefineGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1552);
            String string1653 = "/* This is Post-Comment */";
            typeof(DefineGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1653);
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"/* This is Pre-Comment */\r\n#define ICU_PBCFG_C_SW_MAJOR_VERSION                                            1                                       /* PRQA S 0123 # JV-01 */\r\n/* This is Post-Comment */", (String)actualResult);
        }
    }
}