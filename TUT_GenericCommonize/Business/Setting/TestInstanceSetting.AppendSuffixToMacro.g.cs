using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestInstanceSetting
{
    [TestMethod]
    public void AppendSuffixToMacroTest_185_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var basicconfig17 = new Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.StubIBasicConfiguration();
            basicconfig17.AppendInstanceToMacroStringAppendType = (String _macro, AppendType _type) =>
            {
                String string91 = "Icu_59_Inst0_GaaConfiguration";
                return string91;
            }

            ;
            typeof(InstanceSetting).GetField("BasicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, basicconfig17);
            String string102 = "Icu_GaaConfiguration";
            String macro = string102;
            AppendType appendtype113 = AppendType.FULL_UPPER;
            AppendType type = appendtype113;
            /* Act */
            String actualResult = (String)typeof(InstanceSetting).GetMethod("AppendSuffixToMacro", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(AppendType)}, null).Invoke(_target, new object[]{macro, type});
            /* Assert */
            Assert.AreEqual((String)"Icu_59_Inst0_GaaConfiguration", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendSuffixToMacroTest_185_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var basicconfig18 = new Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.StubIBasicConfiguration();
            basicconfig18.AppendInstanceToMacroStringAppendType = (String _macro, AppendType _type) =>
            {
                String string94 = "Icu_GaaConfiguration";
                return string94;
            }

            ;
            typeof(InstanceSetting).GetField("BasicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, basicconfig18);
            String string105 = "Icu_GaaConfiguration";
            String macro = string105;
            AppendType appendtype116 = AppendType.FULL_UPPER;
            AppendType type = appendtype116;
            /* Act */
            String actualResult = (String)typeof(InstanceSetting).GetMethod("AppendSuffixToMacro", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(AppendType)}, null).Invoke(_target, new object[]{macro, type});
            /* Assert */
            Assert.AreEqual((String)"Icu_GaaConfiguration", (String)actualResult);
        }
    }
}