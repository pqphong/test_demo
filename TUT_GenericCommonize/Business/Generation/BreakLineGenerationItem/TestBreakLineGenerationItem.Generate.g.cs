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

public partial class TestBreakLineGenerationItem
{
    [TestMethod]
    public void GenerateTest_102_1()
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
            Int32 int32102 = 2;
            typeof(BreakLineGenerationItem).GetField("numberOfLines", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32102);
            /* Act */
            String actualResult = (String)typeof(BreakLineGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"\r\n", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_102_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings93 = new GenerationSettings();
            InstanceSetting generationsettings93_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings93_InstanceSetting_IsMultiInstance = false;
            generationsettings93.InstanceSetting = generationsettings93_InstanceSetting;
            generationsettings93_InstanceSetting.IsMultiInstance = generationsettings93_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings93;
            Int32 int32104 = 0;
            typeof(BreakLineGenerationItem).GetField("numberOfLines", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32104);
            /* Act */
            String actualResult = (String)typeof(BreakLineGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}