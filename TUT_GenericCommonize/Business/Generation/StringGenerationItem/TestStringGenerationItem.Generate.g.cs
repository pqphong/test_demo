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

public partial class TestStringGenerationItem
{
    [TestMethod]
    public void GenerateTest_104_1()
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
            _target.GetType().GetProperty("Value", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, "STD_OFF");
            /* Act */
            String actualResult = (String)typeof(StringGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"STD_OFF\r\n", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_104_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings92 = new GenerationSettings();
            InstanceSetting generationsettings92_InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            Boolean generationsettings92_InstanceSetting_IsMultiInstance = false;
            generationsettings92.InstanceSetting = generationsettings92_InstanceSetting;
            generationsettings92_InstanceSetting.IsMultiInstance = generationsettings92_InstanceSetting_IsMultiInstance;
            GenerationSettings genSettings = generationsettings92;
            _target.GetType().GetProperty("Value",BindingFlags.NonPublic|BindingFlags.Instance).SetValue(_target, "STD_ON");
            /* Act */
            String actualResult = (String)typeof(StringGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"STD_ON\r\n", (String)actualResult);
        }
    }
}