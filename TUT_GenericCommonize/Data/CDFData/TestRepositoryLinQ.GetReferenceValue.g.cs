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
    public void GetReferenceValueTest_8_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string952 = "can";
            String moduleName = string952;
            String string1053 = "CanControllerRef";
            String defName = string1053;
            var cdfdata1416 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1416.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1154 = new List<Container>();
                Container ilist1154_0 = new Container();
                IList<ItemValue> ilist1154_0_ReferenceValues = new List<ItemValue>();
                ItemValue ilist1154_0_ReferenceValues_0 = new ItemValue(null, null);
                String ilist1154_0_ReferenceValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanHardwareObject/CanControllerRef";
                Object ilist1154_0_ReferenceValues_0_value = "/ActiveEcuC/Can/CanConfigSet/CanController";
                ilist1154.Add(ilist1154_0);
                ilist1154_0.ReferenceValues = ilist1154_0_ReferenceValues;
                ilist1154_0_ReferenceValues.Add(ilist1154_0_ReferenceValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, ilist1154_0_ReferenceValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, ilist1154_0_ReferenceValues_0_value);
                return ilist1154;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1416);
            /* Act */
            ItemValue actualResult = (ItemValue)typeof(RepositoryLinQ).GetMethod("GetReferenceValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, defName});
            /* Assert */
            Object actualResult_definitionref_1417 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanHardwareObject/CanControllerRef", (String)actualResult_definitionref_1417);
            Object actualResult_value_1418 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult);
            Assert.AreEqual((Object)"/ActiveEcuC/Can/CanConfigSet/CanController", (Object)actualResult_value_1418);
        }
    }

    [TestMethod]
    public void GetReferenceValueTest_8_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string955 = "can";
            String moduleName = string955;
            String string1056 = "CanOsCounterRef";
            String defName = string1056;
            var cdfdata1419 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1419.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1157 = new List<Container>();
                Container ilist1157_0 = new Container();
                IList<ItemValue> ilist1157_0_ReferenceValues = new List<ItemValue>();
                ItemValue ilist1157_0_ReferenceValues_0 = new ItemValue(null, null);
                String ilist1157_0_ReferenceValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanHardwareObject/CanControllerRef";
                Object ilist1157_0_ReferenceValues_0_value = "/ActiveEcuC/Can/CanConfigSet/CanController";
                ilist1157.Add(ilist1157_0);
                ilist1157_0.ReferenceValues = ilist1157_0_ReferenceValues;
                ilist1157_0_ReferenceValues.Add(ilist1157_0_ReferenceValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1157_0_ReferenceValues_0, ilist1157_0_ReferenceValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1157_0_ReferenceValues_0, ilist1157_0_ReferenceValues_0_value);
                return ilist1157;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1419);
            /* Act */
            ItemValue actualResult = (ItemValue)typeof(RepositoryLinQ).GetMethod("GetReferenceValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, defName});
            /* Assert */
            Assert.AreEqual((ItemValue)null, (ItemValue)actualResult);
        }
    }
}