using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestContainer
{
    [TestMethod]
    public void GetParameterValueTest_115_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9306 = "PortPinInitialMode";
            String paramName = string9306;
            String variantID = "";

            IList<ItemValue> ilist10307 = new List<ItemValue>();
            List<VariantItemValue> Lvariant = new List<VariantItemValue>();
            String ilist10307_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist10307_1_value = "MSPI4SC_ALT1_IN_OUT";
            ItemValue item1 = new ItemValue(ilist10307_1_definitionRef, ilist10307_1_value, Lvariant);
            ilist10307.Add(item1);

            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10307);

            /* Act */
            ItemValue actualResult = (ItemValue)typeof(Container).GetMethod("GetParameterValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variantID });
            /* Assert */
            Object actualResult_definitionref_1577 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_definitionref_1577);
            Object actualResult_value_1578 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((Object)"MSPI4SC_ALT1_IN_OUT", (Object)actualResult_value_1578);
        }
    }

    [TestMethod]
    public void GetParameterValueTest_115_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9306 = "PortPinInitialMode";
            String paramName = string9306;
            String variantID = "0";

            IList<ItemValue> ilist10307 = new List<ItemValue>();
            List<VariantItemValue> Lvariant = new List<VariantItemValue>();
            VariantItemValue varitem1 = new VariantItemValue("0", "MSPI4SC_ALT1_IN_OUT");
            Lvariant.Add(varitem1);
            String ilist10307_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist10307_1_value = null;
            ItemValue item1 = new ItemValue(ilist10307_1_definitionRef, ilist10307_1_value, Lvariant);
            ilist10307.Add(item1);

            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10307);

            /* Act */
            ItemValue actualResult = (ItemValue)typeof(Container).GetMethod("GetParameterValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{paramName, variantID});
            /* Assert */
            Object actualResult_definitionref_1577 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_definitionref_1577);
            Object actualResult_value_1578 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((Object)"MSPI4SC_ALT1_IN_OUT", (Object)actualResult_value_1578);
        }
    }

    [TestMethod]
    public void GetParameterValueTest_115_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9306 = "PortPinInitialMode";
            String paramName = string9306;
            String variantID = "0";

            IList<ItemValue> ilist10307 = new List<ItemValue>();
            List<VariantItemValue> Lvariant = new List<VariantItemValue>();
            String ilist10307_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist10307_1_value = "MSPI4SC_ALT1_IN_OUT";
            ItemValue item1 = new ItemValue(ilist10307_1_definitionRef, ilist10307_1_value, Lvariant);
            ilist10307.Add(item1);

            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10307);

            /* Act */
            ItemValue actualResult = (ItemValue)typeof(Container).GetMethod("GetParameterValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variantID });
            /* Assert */
            Object actualResult_definitionref_1577 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_definitionref_1577);
            Object actualResult_value_1578 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((Object)"MSPI4SC_ALT1_IN_OUT", (Object)actualResult_value_1578);
        }
    }

    [TestMethod]
    public void GetParameterValueTest_115_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9306 = "PortPinInitialMode";
            String paramName = string9306;
            String variantID = "0";

            IList<ItemValue> ilist10307 = new List<ItemValue>();
            List<VariantItemValue> Lvariant = new List<VariantItemValue>();
            VariantItemValue varitem1 = new VariantItemValue("1", "MSPI4SC_ALT1_IN_OUT");
            Lvariant.Add(varitem1);
            String ilist10307_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist10307_1_value = "MSPI4SC_ALT1_IN_OUT";
            ItemValue item1 = new ItemValue(ilist10307_1_definitionRef, ilist10307_1_value, Lvariant);
            ilist10307.Add(item1);

            typeof(Container).GetProperty("ParameterValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10307);

            /* Act */
            ItemValue actualResult = (ItemValue)typeof(Container).GetMethod("GetParameterValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { paramName, variantID });
            /* Assert */
            Assert.AreEqual((Object)null, (Object)actualResult);
        }
    }
}