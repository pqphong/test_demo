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

public partial class TestVariableGenerationItem
{
    [TestMethod]
    public void GenerateTest_96_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings91 = new GenerationSettings();
            BasicConfiguration basicConfig = BasicConfiguration.Instance;
            basicConfig.HasInstanceSetting = true;
            basicConfig.ModuleName = "Lin";
            basicConfig.VendorId = 59;
            basicConfig.VendorApiInfix = "Inst0";
            InstanceSetting generationsettings91_InstanceSetting = new InstanceSetting(basicConfig);
            Boolean generationsettings91_InstanceSetting_IsMultiInstance = true;
            generationsettings91.InstanceSetting = generationsettings91_InstanceSetting;
            generationsettings91_InstanceSetting.IsMultiInstance = generationsettings91_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings91;
            Boolean boolean102 = true;
            typeof(VariableGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean102);
            Boolean boolean113 = true;
            typeof(VariableGenerationItem).GetField("HasValueInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean113);
            String string124 = "Lin_GaaRLIN3Properties";
            typeof(VariableGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string124);
            String string135 = "Lin_GaaRLIN3Properties";
            typeof(VariableGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, true);
            typeof(VariableGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string135);
            /* Act */
            String actualResult = (String)typeof(VariableGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual("Lin_59_Inst0_GaaRLIN3Properties = Lin_59_Inst0_GaaRLIN3Properties;", actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_96_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings96 = new GenerationSettings();
            BasicConfiguration basicConfig = BasicConfiguration.Instance;
            basicConfig.ModuleName = "Lin";
            InstanceSetting generationsettings96_InstanceSetting = new InstanceSetting(basicConfig);
            Boolean generationsettings96_InstanceSetting_IsMultiInstance = false;
            generationsettings96.InstanceSetting = generationsettings96_InstanceSetting;
            generationsettings96_InstanceSetting.IsMultiInstance = generationsettings96_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings96;
            Boolean boolean107 = false;
            typeof(VariableGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean107);
            Boolean boolean118 = false;
            typeof(VariableGenerationItem).GetField("HasValueInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean118);
            String string129 = "$$$";
            typeof(VariableGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, false);
            typeof(VariableGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string129);
            String string1310 = "$$$";
            typeof(VariableGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1310);
            /* Act */
            String actualResult = (String)typeof(VariableGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual("$$$ = $$$;", actualResult, true);
        }
    }

    [TestMethod]
    public void GenerateTest_96_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings911 = null;
            GenerationSettings genSettings = generationsettings911;
            /* Act */
            String actualResult = (String)typeof(VariableGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual(";", actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_96_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings916 = new GenerationSettings();
            BasicConfiguration basicConfig = BasicConfiguration.Instance;
            basicConfig.ModuleName = "Lin";
            InstanceSetting generationsettings916_InstanceSetting = new InstanceSetting(basicConfig);
            Boolean generationsettings916_InstanceSetting_IsMultiInstance = true;
            generationsettings916.InstanceSetting = generationsettings916_InstanceSetting;
            generationsettings916_InstanceSetting.IsMultiInstance = generationsettings916_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings916;
            Boolean boolean1017 = true;
            typeof(VariableGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1017);
            Boolean boolean1118 = true;
            typeof(VariableGenerationItem).GetField("HasValueInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, boolean1118);
            String string1219 = "$$$";
            typeof(VariableGenerationItem).GetField("HasNameInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, false);
            typeof(VariableGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1219);
            String string1320 = "$$$";
            typeof(VariableGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string1320);
            /* Act */
            String actualResult = (String)typeof(VariableGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual("$$$ = $$$;", actualResult,true);
        }
    }
}