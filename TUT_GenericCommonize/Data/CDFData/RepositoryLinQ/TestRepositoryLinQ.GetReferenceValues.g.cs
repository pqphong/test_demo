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
    public void GetReferenceValuesTest_25_1()
    {
        using (ShimsContext.Create())
        {
            String string952 = "can";
            String moduleName = string952;
            String string1053 = "CanControllerRef";
            String defName = string1053;
            string variant = "";
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
            List<ItemValue> actualResult = (List<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { defName, moduleName, variant });
            /* Assert */
            Assert.AreEqual((List<ItemValue>)null, (List<ItemValue>)actualResult);
        }
    }

    [TestMethod]
    public void GetReferenceValuesTest_25_2()
    {
        using (ShimsContext.Create())
        {
            String string952 = "";
            String moduleName = string952;
            String string1053 = "CanControllerRef";
            String defName = string1053;
            string variant = "1";
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
            List<ItemValue> actualResult = (List<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { defName, moduleName, variant });
            /* Assert */
            Assert.AreEqual((List<ItemValue>)null, (List<ItemValue>)actualResult);
        }
    }

    [TestMethod]
    public void GetReferenceValuesTest_25_3()
    {
        using (ShimsContext.Create())
        {
            String string952 = "can";
            String moduleName = string952;
            String string1053 = "CanControllerRef";
            String defName = string1053;
            string variant = "0";
            var cdfdata1416 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1416.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1154 = new List<Container>();
                Container ilist1154_0 = new Container();
                IList<ItemValue> ilist1154_0_ReferenceValues = new List<ItemValue>();
                ItemValue ilist1154_0_ReferenceValues_0 = new ItemValue(null, null, null);
                String ilist1154_0_ReferenceValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanHardwareObject/CanControllerRef";
                Object ilist1154_0_ReferenceValues_0_value = "/ActiveEcuC/Can/CanConfigSet/CanController";
                List<VariantItemValue> LvarItem = new List<VariantItemValue>();
                VariantItemValue varitem1 = new VariantItemValue("0", "/ActiveEcuC/Can/CanConfigSet/CanController1");
                LvarItem.Add(varitem1);
                ilist1154.Add(ilist1154_0);
                ilist1154_0.ReferenceValues = ilist1154_0_ReferenceValues;
                ilist1154_0_ReferenceValues.Add(ilist1154_0_ReferenceValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, ilist1154_0_ReferenceValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, ilist1154_0_ReferenceValues_0_value);
                typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, LvarItem);
                return ilist1154;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1416);
            /* Act */
            List<ItemValue> actualResult = (List<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { defName, moduleName, variant });
            /* Assert */
            Object actualResult_definitionref_1417 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanHardwareObject/CanControllerRef", (String)actualResult_definitionref_1417);
            Object actualResult_value_1418 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((Object)"/ActiveEcuC/Can/CanConfigSet/CanController1", (Object)actualResult_value_1418);
        }
    }

    [TestMethod]
    public void GetReferenceValuesTest_25_4()
    {
        using (ShimsContext.Create())
        {
            String string952 = "can";
            String moduleName = string952;
            String string1053 = "CanControllerRef";
            String defName = string1053;
            string variant = "0";
            var cdfdata1416 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1416.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1154 = new List<Container>();
                Container ilist1154_0 = new Container();
                IList<ItemValue> ilist1154_0_ReferenceValues = new List<ItemValue>();
                ItemValue ilist1154_0_ReferenceValues_0 = new ItemValue(null, null, null);
                String ilist1154_0_ReferenceValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanHardwareObject/CanControllerRef";
                Object ilist1154_0_ReferenceValues_0_value = "/ActiveEcuC/Can/CanConfigSet/CanController";
                List<VariantItemValue> LvarItem = new List<VariantItemValue>();
                VariantItemValue varitem1 = new VariantItemValue("1", "/ActiveEcuC/Can/CanConfigSet/CanController1");
                LvarItem.Add(varitem1);
                ilist1154.Add(ilist1154_0);
                ilist1154_0.ReferenceValues = ilist1154_0_ReferenceValues;
                ilist1154_0_ReferenceValues.Add(ilist1154_0_ReferenceValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, ilist1154_0_ReferenceValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, ilist1154_0_ReferenceValues_0_value);
                typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, LvarItem);
                return ilist1154;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1416);
            /* Act */
            List<ItemValue> actualResult = (List<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { defName, moduleName, variant });
            /* Assert */
            Assert.AreEqual((List<ItemValue>)null, (List<ItemValue>)actualResult);
        }
    }

    [TestMethod]
    public void GetReferenceValuesTest_25_5()
    {
        using (ShimsContext.Create())
        {
            String string952 = "can";
            String moduleName = string952;
            String string1053 = "CanControllerRef";
            String defName = string1053;
            string variant = "0";
            var cdfdata1416 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1416.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1154 = new List<Container>();
                Container ilist1154_0 = new Container();
                IList<ItemValue> ilist1154_0_ReferenceValues = new List<ItemValue>();
                ItemValue ilist1154_0_ReferenceValues_0 = new ItemValue(null, null, null);
                String ilist1154_0_ReferenceValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanHardwareObject/CanControllerRef";
                Object ilist1154_0_ReferenceValues_0_value = "/ActiveEcuC/Can/CanConfigSet/CanController";
                List<VariantItemValue> LvarItem = new List<VariantItemValue>();
                ilist1154.Add(ilist1154_0);
                ilist1154_0.ReferenceValues = ilist1154_0_ReferenceValues;
                ilist1154_0_ReferenceValues.Add(ilist1154_0_ReferenceValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, ilist1154_0_ReferenceValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, ilist1154_0_ReferenceValues_0_value);
                typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1154_0_ReferenceValues_0, LvarItem);
                return ilist1154;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1416);
            /* Act */
            List<ItemValue> actualResult = (List<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetReferenceValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { defName, moduleName, variant });
            /* Assert */
            Object actualResult_definitionref_1417 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanHardwareObject/CanControllerRef", (String)actualResult_definitionref_1417);
            Object actualResult_value_1418 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((Object)"/ActiveEcuC/Can/CanConfigSet/CanController", (Object)actualResult_value_1418);
        }
    }
}