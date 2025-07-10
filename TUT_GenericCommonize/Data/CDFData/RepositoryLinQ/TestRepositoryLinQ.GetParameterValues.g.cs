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
    public void GetParameterValuesTest_10_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "can";
            String moduleName = string958;
            String string1059 = "CanBusoffProcessing";
            String defName = string1059;
            string variant = "";
            var cdfdata1420 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1420.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1160 = new List<Container>();
                Container ilist1160_0 = new Container();
                IList<ItemValue> ilist1160_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist1160_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist1160_0_ParameterValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing";
                Object ilist1160_0_ParameterValues_0_value = "POLLING";
                ilist1160.Add(ilist1160_0);
                ilist1160_0.ParameterValues = ilist1160_0_ParameterValues;
                ilist1160_0_ParameterValues.Add(ilist1160_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1160_0_ParameterValues_0, ilist1160_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1160_0_ParameterValues_0, ilist1160_0_ParameterValues_0_value);
                return ilist1160;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1420);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, defName, variant});
            /* Assert */
            Object actualResult_count_1421 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_1421);
            Object actualResult_0_1422 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_1422_definitionref_2423 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_1422);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing", (String)actualResult_0_1422_definitionref_2423);
            Object actualResult_0_1424 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_1424_value_2425 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_1424);
            Assert.AreEqual((Object)"POLLING", (Object)actualResult_0_1424_value_2425);
        }
    }

    [TestMethod]
    public void GetParameterValuesTest_10_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string961 = "can";
            String moduleName = string961;
            String string1062 = "CanBusoffProcessing";
            String defName = string1062;
            String variant = "";
            var cdfdata1426 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1426.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1163 = new List<Container>();
                Container ilist1163_0 = new Container();
                IList<ItemValue> ilist1163_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist1163_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist1163_0_ParameterValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanRxProcessing";
                Object ilist1163_0_ParameterValues_0_value = "POLLING";
                ilist1163.Add(ilist1163_0);
                ilist1163_0.ParameterValues = ilist1163_0_ParameterValues;
                ilist1163_0_ParameterValues.Add(ilist1163_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, ilist1163_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, ilist1163_0_ParameterValues_0_value);
                return ilist1163;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1426);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, defName, variant});
            /* Assert */
            Object actualResult_count_1427 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_1427);
        }
    }

    [TestMethod]
    public void GetParameterValuesTest_10_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string961 = "can";
            String moduleName = string961;
            String string1062 = "CanBusoffProcessing";
            String defName = string1062;
            String variant = "0";
            var cdfdata1426 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1426.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1163 = new List<Container>();
                Container ilist1163_0 = new Container();
                IList<ItemValue> ilist1163_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist1163_0_ParameterValues_0 = new ItemValue(null, null, null);
                String ilist1163_0_ParameterValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing";
                List<VariantItemValue> Lvaritem = new List<VariantItemValue>();
                VariantItemValue varitem1 = new VariantItemValue("0", "POLLING");
                Lvaritem.Add(varitem1);
                ilist1163.Add(ilist1163_0);
                ilist1163_0.ParameterValues = ilist1163_0_ParameterValues;
                ilist1163_0_ParameterValues.Add(ilist1163_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, ilist1163_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, Lvaritem);
                return ilist1163;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1426);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName, variant });
            /* Assert */
            Object actualResult_count_1427 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_1427);
            Object actualResult_0_1422 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_1422_definitionref_2423 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_1422);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing", (String)actualResult_0_1422_definitionref_2423);
            Object actualResult_0_1424 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_1424_value_2425 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_1424);
            Assert.AreEqual((Object)"POLLING", (Object)actualResult_0_1424_value_2425);
        }
    }

    [TestMethod]
    public void GetParameterValuesTest_10_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string961 = "can";
            String moduleName = string961;
            String string1062 = "CanBusoffProcessing";
            String defName = string1062;
            String variant = "0";
            var cdfdata1426 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1426.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1163 = new List<Container>();
                Container ilist1163_0 = new Container();
                IList<ItemValue> ilist1163_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist1163_0_ParameterValues_0 = new ItemValue(null, null, null);
                String ilist1163_0_ParameterValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing";
                Object ilist1160_0_ParameterValues_0_value = "INTERRUPT";
                List<VariantItemValue> Lvaritem = new List<VariantItemValue>();
                ilist1163.Add(ilist1163_0);
                ilist1163_0.ParameterValues = ilist1163_0_ParameterValues;
                ilist1163_0_ParameterValues.Add(ilist1163_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, ilist1163_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, ilist1160_0_ParameterValues_0_value);
                typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, Lvaritem);
                return ilist1163;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1426);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName, variant });
            /* Assert */
            Object actualResult_count_1427 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_1427);
            Object actualResult_0_1422 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_1422_definitionref_2423 = typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_1422);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing", (String)actualResult_0_1422_definitionref_2423);
            Object actualResult_0_1424 = ((IList<ItemValue>)actualResult)[0];
            Object actualResult_0_1424_value_2425 = typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_1424);
            Assert.AreEqual((Object)"INTERRUPT", (Object)actualResult_0_1424_value_2425);
        }
    }

    [TestMethod]
    public void GetParameterValuesTest_10_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string961 = "can";
            String moduleName = string961;
            String string1062 = "CanBusoffProcessing";
            String defName = string1062;
            String variant = "0";
            var cdfdata1426 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1426.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1163 = new List<Container>();
                Container ilist1163_0 = new Container();
                IList<ItemValue> ilist1163_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist1163_0_ParameterValues_0 = new ItemValue(null, null, null);
                String ilist1163_0_ParameterValues_0_definitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing";
                Object ilist1160_0_ParameterValues_0_value = "INTERRUPT";
                List<VariantItemValue> Lvaritem = new List<VariantItemValue>();
                VariantItemValue varitem1 = new VariantItemValue("1", "POLLING");
                Lvaritem.Add(varitem1);
                ilist1163.Add(ilist1163_0);
                ilist1163_0.ParameterValues = ilist1163_0_ParameterValues;
                ilist1163_0_ParameterValues.Add(ilist1163_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, ilist1163_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, ilist1160_0_ParameterValues_0_value);
                typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1163_0_ParameterValues_0, Lvaritem);
                return ilist1163;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1426);
            /* Act */
            IList<ItemValue> actualResult = (IList<ItemValue>)typeof(RepositoryLinQ).GetMethod("GetParameterValues", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName, variant });
            /* Assert */
            Object actualResult_count_1427 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_1427);
        }
    }
}