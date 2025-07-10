using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestBaseGenerationItem
{
    [TestMethod]
    public void GenerateTest_90_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings genSettings = new GenerationSettings();
            genSettings.InstanceSetting = new InstanceSetting(ObjectFactory.GetInstance<IBasicConfiguration>());
            genSettings.InstanceSetting.IsMultiInstance = true;
            genSettings.InstanceSetting.InstanceIndex= 0;

            BaseGenerationItem[] items = new BaseGenerationItem[2];
            items[0] = new BaseGenerationItem(null, null, null, "LIN_VERSION_CHECK_EXT_MODULES", null, "STD_ON");
            items[1] = null;

            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.Static| BindingFlags.NonPublic, null, new Type[]{typeof(BaseGenerationItem[]), typeof(GenerationSettings)}, null).Invoke(_target, new object[]{ items, genSettings });
            /* Assert */
            Assert.AreEqual((String)"\r\n", (String)actualResult);
        }
    }
}