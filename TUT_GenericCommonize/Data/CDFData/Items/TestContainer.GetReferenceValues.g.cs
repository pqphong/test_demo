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
    public void GetReferenceValuesTest_114_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9304 = "PortPinInitialMode";
            String paramName = string9304;
            IList<ItemValue> ilist10305 = new List<ItemValue>();
            ItemValue ilist10305_0 = new ItemValue(null, null);
            String ilist10305_0_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortInputBufferControl";
            Object ilist10305_0_value = false;
            ItemValue ilist10305_1 = new ItemValue(null, null);
            String ilist10305_1_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist10305_1_value = "MSPI4SC_ALT1_IN_OUT";
            ItemValue ilist10305_2 = new ItemValue(null, null);
            String ilist10305_2_definitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode";
            Object ilist10305_2_value = "PWGC13O_ALT8_OUT";
            ilist10305.Add(ilist10305_0);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist10305_0, ilist10305_0_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist10305_0, ilist10305_0_value);
            ilist10305.Add(ilist10305_1);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist10305_1, ilist10305_1_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist10305_1, ilist10305_1_value);
            ilist10305.Add(ilist10305_2);
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist10305_2, ilist10305_2_definitionRef);
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist10305_2, ilist10305_2_value);
            typeof(Container).GetProperty("ReferenceValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist10305);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(Container).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{paramName});
            /* Assert */
            Object actualResult_0_1569 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_1569_definitionref_2570 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_1569);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_0_1569_definitionref_2570);
            Object actualResult_0_1571 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_1571_value_2572 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_1571);
            Assert.AreEqual((Object)"MSPI4SC_ALT1_IN_OUT", (Object)actualResult_0_1571_value_2572);
            Object actualResult_1_1573 = ((IList<ItemValue>)actualResult)[1];
            Object actualResult_1_1573_definitionref_2574 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_1_1573);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_1_1573_definitionref_2574);
            Object actualResult_1_1575 = ((IList<ItemValue>)actualResult)[1];
            Object actualResult_1_1575_value_2576 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_1_1575);
            Assert.AreEqual((Object)"PWGC13O_ALT8_OUT", (Object)actualResult_1_1575_value_2576);
        }
    }
}