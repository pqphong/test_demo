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
    public void GetReferenceValueTest_116_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "PortPinInitialMode";
            String paramName = string91;
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
            typeof(Container).GetProperty("ReferenceValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, ilist102);
            /* Act */
            ItemValue actualResult = (ItemValue)typeof(Container).GetMethod("GetReferenceValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{paramName});
            /* Assert */
            Object actualResult_definitionref_13 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup19/PortPin2/PortPinInitialMode", (String)actualResult_definitionref_13);
            Object actualResult_value_14 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((Object)"MSPI4SC_ALT1_IN_OUT", (Object)actualResult_value_14);
        }
    }
}