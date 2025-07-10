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

public partial class TestStructMemberGenerationItem
{
    [TestMethod]
    public void GenerateTest_98_1()
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
            String string102 = "";
            typeof(StructMemberGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string102);
            Int32 int32113 = -1;
            typeof(StructMemberGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32113);
            Boolean boolean124 = true;
            typeof(StructMemberGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean124);
            String string146 = "/* This is Pre-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string146);
            String string157 = "/* This is Post-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string157);
            Boolean boolean168 = false;
            typeof(StructMemberGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean168);
            Dictionary<string,string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(StructMemberGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Act */
            String actualResult = (String)typeof(StructMemberGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"/* This is Pre-Comment */\r\n/* This is Post-Comment */", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_98_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings910 = null;
            GenerationSettings genSettings = generationsettings910;
            String string1011 = "Icu_GaaConfiguration";
            typeof(StructMemberGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1011);
            Int32 int321112 = 0;
            typeof(StructMemberGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321112);
            Boolean boolean1213 = true;
            typeof(StructMemberGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1213);
            String string1415 = "/* This is Pre-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1415);
            String string1516 = "/* This is Post-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1516);
            Boolean boolean1617 = false;
            typeof(StructMemberGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1617);
            Dictionary<string, string> string1718 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(StructMemberGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1718);
            /* Act */
            String actualResult = (String)typeof(StructMemberGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"/* This is Pre-Comment */\r\nIcu_GaaConfiguration,                                                                                                   /* PRQA S 0123 # JV-01 */\r\n/* This is Post-Comment */", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_98_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings955 = new GenerationSettings();
            InstanceSetting generationsettings955_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings955_InstanceSetting_IsMultiInstance = true;
            generationsettings955.InstanceSetting = generationsettings955_InstanceSetting;
            generationsettings955_InstanceSetting.IsMultiInstance = generationsettings955_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings955;
            String string1056 = "Icu_GaaConfiguration";
            typeof(StructMemberGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1056);
            Int32 int321157 = 1;
            typeof(StructMemberGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321157);
            Boolean boolean1258 = true;
            typeof(StructMemberGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1258);
            Renesas.Generator.MCALConfGen.Business.Generation.Settings.Fakes.ShimInstanceSetting.AllInstances.AppendSuffixToMacroStringAppendType = (InstanceSetting instance, String macro, AppendType type) =>
            {
                String string1359 = "Icu_GaaConfiguration_0";
                return string1359;
            }

            ;
            String string1460 = "/* This is Pre-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1460);
            String string1561 = "/* This is Post-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1561);
            Boolean boolean1662 = true;
            typeof(StructMemberGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1662);
            Dictionary<String, String> string1763 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(StructMemberGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1763);
            /* Act */
            String actualResult = (String)typeof(StructMemberGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"  /* This is Pre-Comment */\r\n  Icu_GaaConfiguration_0                                                                                                /* PRQA S 0123 # JV-01 */\r\n  /* This is Post-Comment */", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_98_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings955 = new GenerationSettings();
            InstanceSetting generationsettings955_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings955_InstanceSetting_IsMultiInstance = true;
            generationsettings955.InstanceSetting = generationsettings955_InstanceSetting;
            generationsettings955_InstanceSetting.IsMultiInstance = generationsettings955_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings955;
            String string1056 = "Icu_GaaConfiguration";
            typeof(StructMemberGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1056);
            Int32 int321157 = 1;
            typeof(StructMemberGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321157);
            Boolean boolean1258 = true;
            typeof(StructMemberGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1258);
            Renesas.Generator.MCALConfGen.Business.Generation.Settings.Fakes.ShimInstanceSetting.AllInstances.AppendSuffixToMacroStringAppendType = (InstanceSetting instance, String macro, AppendType type) =>
            {
                String string1359 = "Icu_GaaConfiguration_0";
                return string1359;
            }

            ;
            String string1460 = "/* This is Pre-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1460);
            String string1561 = "/* This is Post-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1561);
            Boolean boolean1662 = true;
            typeof(StructMemberGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1662);
            Dictionary<String, String> string1763 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(StructMemberGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1763);
            /* Act */
            String actualResult = (String)typeof(StructMemberGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"  /* This is Pre-Comment */\r\n  Icu_GaaConfiguration_0                                                                                                /* PRQA S 0123 # JV-01 */\r\n  /* This is Post-Comment */", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_98_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings955 = new GenerationSettings();
            InstanceSetting generationsettings955_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings955_InstanceSetting_IsMultiInstance = true;
            generationsettings955.InstanceSetting = generationsettings955_InstanceSetting;
            generationsettings955_InstanceSetting.IsMultiInstance = generationsettings955_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings955;
            String string1056 = "Icu_GaaConfiguration";
            typeof(StructMemberGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1056);
            Int32 int321157 = 1;
            typeof(StructMemberGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321157);
            Boolean boolean1258 = true;
            typeof(StructMemberGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1258);
            Renesas.Generator.MCALConfGen.Business.Generation.Settings.Fakes.ShimInstanceSetting.AllInstances.AppendSuffixToMacroStringAppendType = (InstanceSetting instance, String macro, AppendType type) =>
            {
                String string1359 = "Icu_GaaConfiguration_0";
                return string1359;
            }

            ;
            String string1460 = "/* This is Pre-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1460);
            String string1561 = "/* This is Post-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1561);
            Boolean boolean1662 = true;
            typeof(StructMemberGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1662);
            Dictionary<String, String> string1763 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(StructMemberGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1763);
            /* Act */
            String actualResult = (String)typeof(StructMemberGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"  /* This is Pre-Comment */\r\n  Icu_GaaConfiguration_0                                                                                                /* PRQA S 0123 # JV-01 */\r\n  /* This is Post-Comment */", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_98_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings955 = new GenerationSettings();
            InstanceSetting generationsettings955_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings955_InstanceSetting_IsMultiInstance = true;
            generationsettings955.InstanceSetting = generationsettings955_InstanceSetting;
            generationsettings955_InstanceSetting.IsMultiInstance = generationsettings955_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings955;
            String string1056 = "Icu_GaaConfiguration";
            typeof(StructMemberGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1056);
            Int32 int321157 = 1;
            typeof(StructMemberGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321157);
            Boolean boolean1258 = true;
            typeof(StructMemberGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1258);
            Renesas.Generator.MCALConfGen.Business.Generation.Settings.Fakes.ShimInstanceSetting.AllInstances.AppendSuffixToMacroStringAppendType = (InstanceSetting instance, String macro, AppendType type) =>
            {
                String string1359 = "Icu_GaaConfiguration_0";
                return string1359;
            }

            ;
            String string1460 = "/* This is Pre-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PreComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1460);
            String string1561 = "/* This is Post-Comment */";
            typeof(StructMemberGenerationItem).GetProperty("PostComment", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1561);
            Boolean boolean1662 = true;
            typeof(StructMemberGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1662);
            Dictionary<String, String> string1763 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(StructMemberGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1763);
            /* Act */
            String actualResult = (String)typeof(StructMemberGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"  /* This is Pre-Comment */\r\n  Icu_GaaConfiguration_0                                                                                                /* PRQA S 0123 # JV-01 */\r\n  /* This is Post-Comment */", (String)actualResult);
        }
    }
}