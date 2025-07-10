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
    public void GetParameterValuesTest_117_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "PortPinInitialMode";
            String paramName = string91;
            string variant = "";

            IList<ItemValue> ilist102 = new List<ItemValue>();
            ItemValue ilist102_0 = new ItemValue(null, null);
            String ilist102_0_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortInputBufferControl";
            Object ilist102_0_value = false;
            ItemValue ilist102_1 = new ItemValue(null, null);
            String ilist102_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_1_value = "MSPI4SC_ALT1_IN_OUT";
            ItemValue ilist102_2 = new ItemValue(null, null);
            String ilist102_2_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_2_value = "PWGC13O_ALT8_OUT";
            ilist102.Add(ilist102_0);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_value);
            ilist102.Add(ilist102_1);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_value);
            ilist102.Add(ilist102_2);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_value);
            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist102);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{paramName, variant});
            /* Assert */
            Object actualResult_0_13 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_13_definitionref_24 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_13);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_0_13_definitionref_24);
            Object actualResult_0_15 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_15_value_26 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_15);
            Assert.AreEqual((Object)"MSPI4SC_ALT1_IN_OUT", (Object)actualResult_0_15_value_26);
            Object actualResult_1_17 = ((IList<ItemValue>)actualResult)[1];
            Object actualResult_1_17_definitionref_28 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_1_17);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_1_17_definitionref_28);
            Object actualResult_1_19 = ((IList<ItemValue>)actualResult)[1];
            Object actualResult_1_19_value_210 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_1_19);
            Assert.AreEqual((Object)"PWGC13O_ALT8_OUT", (Object)actualResult_1_19_value_210);
        }
    }

    [TestMethod]
    public void GetParameterValuesTest_117_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "PortPinInitialMode";
            String paramName = string91;
            string variant = "0";

            IList<ItemValue> ilist102 = new List<ItemValue>();
            ItemValue ilist102_0 = new ItemValue(null, null);
            String ilist102_0_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortInputBufferControl";
            Object ilist102_0_value = false;
            ItemValue ilist102_1 = new ItemValue(null, null, null);
            String ilist102_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_1_value = "MSPI4SC_ALT1_IN_OUT";
            List<VariantItemValue> list1 = new List<VariantItemValue>();
            VariantItemValue varitem1 = new VariantItemValue("0", "MSPI4SC_ALT1_IN_OUT1");
            list1.Add(varitem1);

            ItemValue ilist102_2 = new ItemValue(null, null, null);
            String ilist102_2_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_2_value = "PWGC13O_ALT8_OUT";
            List<VariantItemValue> list2 = new List<VariantItemValue>();
            VariantItemValue varitem2 = new VariantItemValue("0", "MSPI4SC_ALT1_IN_OUT2");
            list2.Add(varitem2);

            ilist102.Add(ilist102_0);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_value);
            ilist102.Add(ilist102_1);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_value);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, list1);
            ilist102.Add(ilist102_2);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_value);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, list2);

            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist102);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variant });
            /* Assert */
            Object actualResult_0_13 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_13_definitionref_24 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_13);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_0_13_definitionref_24);
            Object actualResult_0_15 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_15_value_26 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_15);
            Assert.AreEqual((Object)"MSPI4SC_ALT1_IN_OUT1", (Object)actualResult_0_15_value_26);
            Object actualResult_1_17 = ((IList<ItemValue>)actualResult)[1];
            Object actualResult_1_17_definitionref_28 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_1_17);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_1_17_definitionref_28);
            Object actualResult_1_19 = ((IList<ItemValue>)actualResult)[1];
            Object actualResult_1_19_value_210 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_1_19);
            Assert.AreEqual((Object)"MSPI4SC_ALT1_IN_OUT2", (Object)actualResult_1_19_value_210);
        }
    }

    [TestMethod]
    public void GetParameterValuesTest_117_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "PortPinInitialMode";
            String paramName = string91;
            string variant = "1";

            IList<ItemValue> ilist102 = new List<ItemValue>();
            ItemValue ilist102_0 = new ItemValue(null, null);
            String ilist102_0_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortInputBufferControl";
            Object ilist102_0_value = false;
            ItemValue ilist102_1 = new ItemValue(null, null, null);
            String ilist102_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_1_value = "MSPI4SC_ALT1_IN_OUT";
            List<VariantItemValue> list1 = new List<VariantItemValue>();
            VariantItemValue varitem1 = new VariantItemValue("0", "MSPI4SC_ALT1_IN_OUT1");
            list1.Add(varitem1);

            ItemValue ilist102_2 = new ItemValue(null, null, null);
            String ilist102_2_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_2_value = "PWGC13O_ALT8_OUT";
            List<VariantItemValue> list2 = new List<VariantItemValue>();
            VariantItemValue varitem2 = new VariantItemValue("0", "MSPI4SC_ALT1_IN_OUT2");
            list2.Add(varitem2);

            ilist102.Add(ilist102_0);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_value);
            ilist102.Add(ilist102_1);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_value);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, list1);
            ilist102.Add(ilist102_2);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_value);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, list2);

            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist102);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variant });
            /* Assert */
            Assert.AreEqual((Object)0, (Object)actualResult.Count);
        }
    }
	
	[TestMethod]
    public void GetParameterValuesTest_117_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "PortPinInitialMode";
            String paramName = string91;
            string variant = "1";

            IList<ItemValue> ilist102 = new List<ItemValue>();
            ItemValue ilist102_0 = new ItemValue(null, null);
            String ilist102_0_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortInputBufferControl";
            Object ilist102_0_value = false;
            ItemValue ilist102_1 = new ItemValue(null, null, null);
            String ilist102_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_1_value = "MSPI4SC_ALT1_IN_OUT";
            List<VariantItemValue> list1 = new List<VariantItemValue>();

            ItemValue ilist102_2 = new ItemValue(null, null, null);
            String ilist102_2_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_2_value = "PWGC13O_ALT8_OUT";
            List<VariantItemValue> list2 = new List<VariantItemValue>();

            ilist102.Add(ilist102_0);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_value);
            ilist102.Add(ilist102_1);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_value);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, list1);
            ilist102.Add(ilist102_2);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_value);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, list2);

            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist102);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variant });
            /* Assert */
            Assert.AreEqual((Object)2, (Object)actualResult.Count);
        }
    }
	
	[TestMethod]
    public void GetParameterValuesTest_117_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "PortPinInitialMode";
            String paramName = string91;
            string variant = "1";

            IList<ItemValue> ilist102 = new List<ItemValue>();
            ItemValue ilist102_0 = new ItemValue(null, null);
            String ilist102_0_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortInputBufferControl";
            Object ilist102_0_value = false;
            ItemValue ilist102_1 = new ItemValue(null, null, null);
            String ilist102_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_1_value = "MSPI4SC_ALT1_IN_OUT";
            List<VariantItemValue> list1 = new List<VariantItemValue>();
			VariantItemValue varitem1 = new VariantItemValue("0", "MSPI4SC_ALT1_IN_OUT1");
            list1.Add(varitem1);

            ItemValue ilist102_2 = new ItemValue(null, null, null);
            String ilist102_2_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist102_2_value = "PWGC13O_ALT8_OUT";
            List<VariantItemValue> list2 = new List<VariantItemValue>();
			VariantItemValue varitem2 = new VariantItemValue("1", "MSPI4SC_ALT1_IN_OUT2");
			VariantItemValue varitem3 = new VariantItemValue("0", "MSPI4SC_ALT1_IN_OUT1");
            list2.Add(varitem2);
			list2.Add(varitem3);

            ilist102.Add(ilist102_0);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_0, ilist102_0_value);
            ilist102.Add(ilist102_1);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, ilist102_1_value);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_1, list1);
            ilist102.Add(ilist102_2);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, ilist102_2_value);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist102_2, list2);

            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist102);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variant });
            /* Assert */
            Assert.AreEqual((Object)1, (Object)actualResult.Count);
        }
    }
}