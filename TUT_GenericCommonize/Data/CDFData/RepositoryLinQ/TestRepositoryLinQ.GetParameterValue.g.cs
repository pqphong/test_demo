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

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void GetParameterValueTest_17_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string988 = "Can";
            String moduleName = string988;
            String string1089 = "CanBusoffProcessing";
            String defName = string1089;
            string variantid = "";
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetParameterValuesStringStringString = (RepositoryLinQ instance, String _moduleName, String _defName, String variantID) =>
            {
                IList<ItemValue> ilist1190 = new List<ItemValue>();
                ItemValue ilist1190_0 = new ItemValue(null, null);
                String ilist1190_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing";
                Object ilist1190_0_value = "POLLING";
                ItemValue ilist1190_1 = new ItemValue(null, null);
                String ilist1190_1_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing";
                Object ilist1190_1_value = "INTERRUPT";
                ilist1190.Add(ilist1190_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_0, ilist1190_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_0, ilist1190_0_value);
                ilist1190.Add(ilist1190_1);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_1, ilist1190_1_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_1, ilist1190_1_value);
                return ilist1190;
            }

            ;
            /* Act */
            ItemValue actualResult = (ItemValue)typeof(RepositoryLinQ).GetMethod("GetParameterValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, defName, variantid });
            /* Assert */
            Object actualResult_definitionref_1436 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing", (String)actualResult_definitionref_1436);
            Object actualResult_value_1437 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((Object)"POLLING", (Object)actualResult_value_1437);
        }
    }

    [TestMethod]
    public void GetParameterValueTest_17_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string991 = "Can";
            String moduleName = string991;
            String string1092 = "CanBusoffProcessing";
            String defName = string1092;
            string variantid = "";
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetParameterValuesStringStringString = (RepositoryLinQ instance, String _moduleName, String _defName, String variantID) =>
            {
                IList<ItemValue> ilist1193 = new List<ItemValue>();
                ItemValue ilist1193_0 = new ItemValue(null, null);
                String ilist1193_0_definitionRef = null;
                Object ilist1193_0_value = null;
                ilist1193.Add(ilist1193_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1193_0, ilist1193_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1193_0, ilist1193_0_value);
                return ilist1193;
            }

            ;
            /* Act */
            ItemValue actualResult = (ItemValue)typeof(RepositoryLinQ).GetMethod("GetParameterValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, defName, variantid });
            /* Assert */
            Object actualResult_definitionref_1438 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)null, (String)actualResult_definitionref_1438);
            Object actualResult_value_1439 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((Object)null, (Object)actualResult_value_1439);
        }
    }
}