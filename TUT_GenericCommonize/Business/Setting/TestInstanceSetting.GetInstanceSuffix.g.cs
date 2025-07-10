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
    public void GetInstanceSuffixTest_182_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var basicconfig15 = new Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.StubIBasicConfiguration();
            basicconfig15.ToInstanceValueAppendType = (AppendType _type) =>
            {
                String string91 = "_0";
                return string91;
            }

            ;
            typeof(InstanceSetting).GetField("BasicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, basicconfig15);
            AppendType appendtype102 = AppendType.FULL_UPPER;
            AppendType type = appendtype102;
            /* Act */
            String actualResult = (String)typeof(InstanceSetting).GetMethod("GetInstanceSuffix", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(AppendType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((String)"_0", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetInstanceSuffixTest_182_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var basicconfig16 = new Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.StubIBasicConfiguration();
            basicconfig16.ToInstanceValueAppendType = (AppendType _type) =>
            {
                String string93 = "";
                return string93;
            }

            ;
            typeof(InstanceSetting).GetField("BasicConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, basicconfig16);
            AppendType appendtype104 = AppendType.FULL_UPPER;
            AppendType type = appendtype104;
            /* Act */
            String actualResult = (String)typeof(InstanceSetting).GetMethod("GetInstanceSuffix", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(AppendType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}