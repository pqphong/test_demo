using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestContainer
{
    [TestMethod]
    public void GetReferenceValuesTest_114_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9306 = "LinClockRef";
            String paramName = string9306;
            String variantID = "";

            IList<ItemValue> ilist10307 = new List<ItemValue>();
            List<VariantItemValue> Lvariant = new List<VariantItemValue>();
            String ilist10307_1_definitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef";
            Object ilist10307_1_value = "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint";
            ItemValue item1 = new ItemValue(ilist10307_1_definitionRef, ilist10307_1_value, Lvariant);
            ilist10307.Add(item1);

            typeof(Container).GetProperty("ReferenceValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10307);

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variantID });
            /* Assert */
            Object actualResult_definitionref_1577 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef", (String)actualResult_definitionref_1577);
            Object actualResult_value_1578 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((Object)"/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint", (Object)actualResult_value_1578);
        }
    }

    [TestMethod]
    public void GetReferenceValuesTest_114_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9306 = "LinClockRef";
            String paramName = string9306;
            String variantID = "0";

            IList<ItemValue> ilist10307 = new List<ItemValue>();
            List<VariantItemValue> Lvariant = new List<VariantItemValue>();
            String ilist10307_1_definitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef";
            Object ilist10307_1_value = "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint";
            ItemValue item1 = new ItemValue(ilist10307_1_definitionRef, ilist10307_1_value, Lvariant);
            ilist10307.Add(item1);

            typeof(Container).GetProperty("ReferenceValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10307);

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variantID });
            /* Assert */
            Object actualResult_definitionref_1577 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef", (String)actualResult_definitionref_1577);
            Object actualResult_value_1578 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((Object)"/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint", (Object)actualResult_value_1578);
        }
    }

    [TestMethod]
    public void GetReferenceValuesTest_114_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9306 = "LinClockRef";
            String paramName = string9306;
            String variantID = "0";

            IList<ItemValue> ilist10307 = new List<ItemValue>();
            List<VariantItemValue> Lvariant = new List<VariantItemValue>();
		    VariantItemValue var1 = new VariantItemValue("0", "abc");
			Lvariant.Add(var1);
            String ilist10307_1_definitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef";
            Object ilist10307_1_value = "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint";
            ItemValue item1 = new ItemValue(ilist10307_1_definitionRef, ilist10307_1_value, Lvariant);
            ilist10307.Add(item1);

            typeof(Container).GetProperty("ReferenceValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10307);

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variantID });
            /* Assert */
            Object actualResult_definitionref_1577 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef", (String)actualResult_definitionref_1577);
            Object actualResult_value_1578 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((Object)"abc", (Object)actualResult_value_1578);
        }
    }

    [TestMethod]
    public void GetReferenceValuesTest_114_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9306 = "LinClockRef";
            String paramName = string9306;
            String variantID = "0";

            IList<ItemValue> ilist10307 = new List<ItemValue>();
            List<VariantItemValue> Lvariant = new List<VariantItemValue>();
		    VariantItemValue var1 = new VariantItemValue("1", "abc");
			Lvariant.Add(var1);
            String ilist10307_1_definitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef";
            Object ilist10307_1_value = "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint";
            ItemValue item1 = new ItemValue(ilist10307_1_definitionRef, ilist10307_1_value, Lvariant);
            ilist10307.Add(item1);

            typeof(Container).GetProperty("ReferenceValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10307);

            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variantID });
            /* Assert */
            Assert.AreEqual(0, actualResult.Count);
        }
    }
}