using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using System.Collections;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestBaseValidation
{
    [TestMethod]
    public void CheckForMandatoryParametersTest_107_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Icu";
            String moduleName = string91;
            Hashtable hashtable102 = null;
            Hashtable mandatoryParams = hashtable102;
            var repository129 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();

            repository129.GetShortNameVariantConfigString = (String _moduleName) =>
            {
                Dictionary<string, string> variants = new Dictionary<string, string>();
                variants.Add("0", "Variant_1");
                return variants;
            };

            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository129);
            IList<String> mandatoryContainers = null;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.addErrorMessageStringStringStringStringString = (BaseValidation instance, String _moduleName, String param, String defName, String path, String variantID) =>
            {
                String string157 = "";
                return string157;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckForMandatoryParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(Hashtable), typeof(IList<String>) }, null).Invoke(_target, new object[] { moduleName, mandatoryParams, mandatoryContainers });
            /* Assert */
            Object actualResult_count_130 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_130);
        }
    }

    [TestMethod]
    public void CheckForMandatoryParametersTest_107_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string98 = "Icu";
            String moduleName = string98;
            Hashtable hashtable109 = new Hashtable()
            {{"Container", "Parameter"}, {"Container1", new List<string>{"Parameter10", "Parameter11"}}, {"Container2", new List<string>{"Parameter20", "Parameter21", "Parameter22"}}};
            Hashtable mandatoryParams = hashtable109;
            var repository131 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();

            repository131.GetShortNameVariantConfigString = (String _moduleName) =>
            {
                Dictionary<string, string> variants = new Dictionary<string, string>();
                variants.Add("0", "Variant_1");
                return variants;
            };

            repository131.GetContainersByDefNameStringStringInt32String = (String _moduleName, String defName, Int32 sortOption, String variantID) =>
            {
                IList<Container> ilist1110 = new List<Container>();
                return ilist1110;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository131);
            IList<String> ilist1211 = new List<String>();
            String ilist1211_0 = "Container1";
            String ilist1211_1 = "Container4";
            ilist1211.Add(ilist1211_0);
            ilist1211.Add(ilist1211_1);
            IList<String> mandatoryContainers = ilist1211;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.isMissingContainerStringStringIListOfStringString = (BaseValidation instance, String _moduleName, String containerName, IList<String> _mandatoryContainers, String variantID) =>
            {
                if (containerName == "Container2")
                {
                    Boolean boolean1312 = true;
                    return boolean1312;
                }
                else
                {
                    Boolean boolean1312 = false;
                    return boolean1312;
                }
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (String path, Nullable<Int32> exitCode) =>
            {
                String string1413 = "/Path/to/CdfFile";
                return string1413;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.addErrorMessageStringStringStringStringString = (BaseValidation instance, String _moduleName, String param, String defName, String path, String variantID) =>
            {
                String string1514 = "";
                return string1514;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckForMandatoryParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(Hashtable), typeof(IList<String>) }, null).Invoke(_target, new object[] { moduleName, mandatoryParams, mandatoryContainers });
            /* Assert */
            Assert.AreEqual(actualResult.Count, 3);
        }
    }

    [TestMethod]
    public void CheckForMandatoryParametersTest_107_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string915 = "Icu";
            String moduleName = string915;
            Hashtable hashtable1016 = new Hashtable()
            {{"Container", "Parameter"}, {"Container1", new List<string>{"Parameter10", "Reference11"}}, {"Container2", new List<string>{"Parameter20", "Reference21", "Reference22"}}};
            Hashtable mandatoryParams = hashtable1016;
            var repository136 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();

            repository136.GetShortNameVariantConfigString = (String _moduleName) =>
            {
                Dictionary<string, string> variants = new Dictionary<string, string>();
                variants.Add("0", "Variant_1");
                return variants;
            };

            repository136.GetContainersByDefNameStringStringInt32String = (String _moduleName, String defName, Int32 sortOption, String variantID) =>
            {
                if (defName == "Container1")
                {
                    IList<Container> ilist1117 = new List<Container>();
                    Container ilist1117_0 = new Container();
                    String ilist1117_0_Path = "/Containet1";
                    IList<ItemValue> ilist1117_0_ParameterValues = new List<ItemValue>();
                    ItemValue ilist1117_0_ParameterValues_0 = new ItemValue(null, null);
                    String ilist1117_0_ParameterValues_0_definitionRef = "/Parameter10";
                    Object ilist1117_0_ParameterValues_0_value = "Parameter10Value";
                    IList<ItemValue> ilist1117_0_ReferenceValues = new List<ItemValue>();
                    ItemValue ilist1117_0_ReferenceValues_0 = new ItemValue(null, null);
                    String ilist1117_0_ReferenceValues_0_definitionRef = "/Reference11";
                    Object ilist1117_0_ReferenceValues_0_value = "Reference11Value";
                    ilist1117.Add(ilist1117_0);
                    ilist1117_0.Path = ilist1117_0_Path;
                    ilist1117_0.ParameterValues = ilist1117_0_ParameterValues;
                    ilist1117_0_ParameterValues.Add(ilist1117_0_ParameterValues_0);
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1117_0_ParameterValues_0, ilist1117_0_ParameterValues_0_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1117_0_ParameterValues_0, ilist1117_0_ParameterValues_0_value);
                    ilist1117_0.ReferenceValues = ilist1117_0_ReferenceValues;
                    ilist1117_0_ReferenceValues.Add(ilist1117_0_ReferenceValues_0);
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1117_0_ReferenceValues_0, ilist1117_0_ReferenceValues_0_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1117_0_ReferenceValues_0, ilist1117_0_ReferenceValues_0_value);
                    return ilist1117;
                }
                else
                {
                    IList<Container> ilist1117 = new List<Container>();
                    Container ilist1117_0 = new Container();
                    String ilist1117_0_Path = "/Containet2";
                    IList<ItemValue> ilist1117_0_ParameterValues = new List<ItemValue>();
                    ItemValue ilist1117_0_ParameterValues_0 = new ItemValue(null, null);
                    String ilist1117_0_ParameterValues_0_definitionRef = "/Parameter20";
                    Object ilist1117_0_ParameterValues_0_value = "Parameter20Value";
                    ilist1117.Add(ilist1117_0);
                    ilist1117_0.Path = ilist1117_0_Path;
                    ilist1117_0.ParameterValues = ilist1117_0_ParameterValues;
                    ilist1117_0_ParameterValues.Add(ilist1117_0_ParameterValues_0);
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1117_0_ParameterValues_0, ilist1117_0_ParameterValues_0_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1117_0_ParameterValues_0, ilist1117_0_ParameterValues_0_value);
                    return ilist1117;
                }
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository136);
            IList<String> mandatoryContainers = null;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (String path, Nullable<Int32> exitCode) =>
            {
                String string1420 = "/Path/to/CdfFile";
                return string1420;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.addErrorMessageStringStringStringStringString = (BaseValidation instance, String _moduleName, String param, String defName, String path, String variantID) =>
            {
                String string1521 = "";
                return string1521;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckForMandatoryParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(Hashtable), typeof(IList<String>) }, null).Invoke(_target, new object[] { moduleName, mandatoryParams, mandatoryContainers });
            /* Assert */
            Assert.AreEqual(actualResult.Count, 2);
        }
    }

    [TestMethod]
    public void CheckForMandatoryParametersTest_107_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string922 = "Icu";
            String moduleName = string922;
            Hashtable hashtable1023 = new Hashtable()
            {{"Container", "Parameter"}, {"Container1", new List<string>{"Parameter10", "Reference11"}}, {"Container2", new List<string>{"Reference20", "Parameter21", "Parameter22"}}};
            Hashtable mandatoryParams = hashtable1023;
            var repository140 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();

            repository140.GetShortNameVariantConfigString = (String _moduleName) =>
            {
                Dictionary<string, string> variants = new Dictionary<string, string>();
                variants.Add("0", "Variant_1");
                return variants;
            };

            repository140.GetContainersByDefNameStringStringInt32String = (String _moduleName, String defName, Int32 sortOption, String variantID) =>
            {
                if (defName == "Container1")
                {
                    IList<Container> ilist1124 = new List<Container>();
                    Container ilist1124_0 = new Container();
                    String ilist1124_0_Path = "/Containet1";
                    IList<ItemValue> ilist1124_0_ParameterValues = new List<ItemValue>();
                    ItemValue ilist1124_0_ParameterValues_0 = new ItemValue(null, null);
                    String ilist1124_0_ParameterValues_0_definitionRef = "/Parameter10";
                    Object ilist1124_0_ParameterValues_0_value = "Parameter10Value";
                    IList<ItemValue> ilist1124_0_ReferenceValues = new List<ItemValue>();
                    ItemValue ilist1124_0_ReferenceValues_0 = new ItemValue(null, null);
                    String ilist1124_0_ReferenceValues_0_definitionRef = "/Reference11";
                    Object ilist1124_0_ReferenceValues_0_value = "Reference11Value";
                    ilist1124.Add(ilist1124_0);
                    ilist1124_0.Path = ilist1124_0_Path;
                    ilist1124_0.ParameterValues = ilist1124_0_ParameterValues;
                    ilist1124_0_ParameterValues.Add(ilist1124_0_ParameterValues_0);
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1124_0_ParameterValues_0, ilist1124_0_ParameterValues_0_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1124_0_ParameterValues_0, ilist1124_0_ParameterValues_0_value);
                    ilist1124_0.ReferenceValues = ilist1124_0_ReferenceValues;
                    ilist1124_0_ReferenceValues.Add(ilist1124_0_ReferenceValues_0);
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1124_0_ReferenceValues_0, ilist1124_0_ReferenceValues_0_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1124_0_ReferenceValues_0, ilist1124_0_ReferenceValues_0_value);
                    return ilist1124;
                }
                else
                {
                    IList<Container> ilist1124 = new List<Container>();
                    Container ilist1124_0 = new Container();
                    String ilist1124_0_Path = "/Containet2";
                    IList<ItemValue> ilist1124_0_ReferenceValues = new List<ItemValue>();
                    ItemValue ilist1124_0_ReferenceValues_0 = new ItemValue(null, null);
                    String ilist1124_0_ReferenceValues_0_definitionRef = "/Reference20";
                    Object ilist1124_0_ReferenceValues_0_value = "Reference20Value";
                    ilist1124.Add(ilist1124_0);
                    ilist1124_0.Path = ilist1124_0_Path;
                    ilist1124_0.ReferenceValues = ilist1124_0_ReferenceValues;
                    ilist1124_0_ReferenceValues.Add(ilist1124_0_ReferenceValues_0);
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1124_0_ReferenceValues_0, ilist1124_0_ReferenceValues_0_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1124_0_ReferenceValues_0, ilist1124_0_ReferenceValues_0_value);
                    return ilist1124;
                }
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, repository140);
            IList<String> mandatoryContainers = null;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (String path, Nullable<Int32> exitCode) =>
            {
                String string1427 = "/Path/to/CdfFile";
                return string1427;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.addErrorMessageStringStringStringStringString = (BaseValidation instance, String _moduleName, String param, String defName, String path, String variantID) =>
            {
                String string1528 = "";
                return string1528;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckForMandatoryParameters", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(Hashtable), typeof(IList<String>) }, null).Invoke(_target, new object[] { moduleName, mandatoryParams, mandatoryContainers });
            /* Assert */
            Assert.AreEqual(actualResult.Count, 2);
        }
    }
}