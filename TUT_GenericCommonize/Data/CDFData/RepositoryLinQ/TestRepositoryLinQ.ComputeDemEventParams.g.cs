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
    public void ComputeDemEventParamsTest_6_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary91 = new Dictionary<String, String>();
            String dictionary91_dem1 = "DemParam1";
            dictionary91["dem1"] = dictionary91_dem1;
            Dictionary<String, String> demEventParamsGroup = dictionary91;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetReferenceValueStringStringString = (RepositoryLinQ instance, String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue102 = new ItemValue(null, null);
                String itemvalue102_definitionRef = "/dem1";
                Object itemvalue102_value = "/Refs_01";
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue102, itemvalue102_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue102, itemvalue102_value);
                return itemvalue102;
            }

            ;
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("ComputeDemEventParams", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{demEventParamsGroup});
            /* Assert */
            Object actualResult_0_112 = ((BaseIntermediateItem)actualResult);
            Object actualResult_0_112_name_213 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_112);
            Assert.AreEqual((String)"DemEventParams", (String)actualResult_0_112_name_213);
            Object actualResult_0_114 = ((BaseIntermediateItem)actualResult);
            Object actualResult_0_114_value_215 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_114);
            Assert.AreEqual((String)"", (String)actualResult_0_114_value_215);
            Assert.AreEqual(1, actualResult.Childs.Count);
        }
    }

    [TestMethod]
    public void ComputeDemEventParamsTest_6_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary93 = new Dictionary<String, String>();
            String dictionary93_dem1 = "DemParam1";
            String dictionary93_dem2 = "DemParam2";
            dictionary93["dem1"] = dictionary93_dem1;
            dictionary93["dem2"] = dictionary93_dem2;
            Dictionary<String, String> demEventParamsGroup = dictionary93;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetReferenceValueStringStringString = (RepositoryLinQ instance, String moduleName, String defName, String variantID) =>
            {
                if (defName == "dem1")
                {
                    ItemValue itemvalue104 = new ItemValue(null, null);
                    String itemvalue104_definitionRef = "/dem1";
                    Object itemvalue104_value = "/Refs_01";
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue104, itemvalue104_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue104, itemvalue104_value);
                    return itemvalue104;
                }
                else
                {
                    if (defName == "dem2")
                    {
                        ItemValue itemvalue104 = new ItemValue(null, null);
                        String itemvalue104_definitionRef = "/dem2";
                        Object itemvalue104_value = "/Refs_02";
                        typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue104, itemvalue104_definitionRef);
                        typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue104, itemvalue104_value);
                        return itemvalue104;
                    }
                    else
                    {
                        ItemValue itemvalue104 = null;
                        return itemvalue104;
                    }
                }
            }

            ;
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("ComputeDemEventParams", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{demEventParamsGroup});
            /* Assert */
            Object actualResult_0_117 = ((BaseIntermediateItem)actualResult);
            Object actualResult_0_117_name_218 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_117);
            Assert.AreEqual((String)"DemEventParams", (String)actualResult_0_117_name_218);
            Object actualResult_0_119 = ((BaseIntermediateItem)actualResult);
            Object actualResult_0_119_value_220 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_119);
            Assert.AreEqual((String)"", (String)actualResult_0_119_value_220);
            Assert.AreEqual(2, actualResult.Childs.Count);
        }
    }

    [TestMethod]
    public void ComputeDemEventParamsTest_6_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary95 = new Dictionary<String, String>();
            String dictionary95_dem1 = "DemParam1";
            String dictionary95_dem2 = "DemParam2";
            dictionary95["dem1"] = dictionary95_dem1;
            dictionary95["dem2"] = dictionary95_dem2;
            Dictionary<String, String> demEventParamsGroup = dictionary95;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetReferenceValueStringStringString = (RepositoryLinQ instance, String moduleName, String defName, String variantID) =>
            {
                if (defName == "dem1")
                {
                    ItemValue itemvalue106 = new ItemValue(null, null);
                    String itemvalue106_definitionRef = "/dem1";
                    Object itemvalue106_value = "";
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue106, itemvalue106_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue106, itemvalue106_value);
                    return itemvalue106;
                }
                else
                {
                    if (defName == "dem2")
                    {
                        ItemValue itemvalue106 = new ItemValue(null, null);
                        String itemvalue106_definitionRef = "/dem2";
                        Object itemvalue106_value = "/Refs_02";
                        typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue106, itemvalue106_definitionRef);
                        typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue106, itemvalue106_value);
                        return itemvalue106;
                    }
                    else
                    {
                        ItemValue itemvalue106 = null;
                        return itemvalue106;
                    }
                }
            }

            ;
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("ComputeDemEventParams", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{demEventParamsGroup});
            /* Assert */
            Object actualResult_0_126 = ((BaseIntermediateItem)actualResult);
            Object actualResult_0_126_name_227 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_126);
            Assert.AreEqual((String)"DemEventParams", (String)actualResult_0_126_name_227);
            Object actualResult_0_128 = ((BaseIntermediateItem)actualResult);
            Object actualResult_0_128_value_229 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_128);
            Assert.AreEqual((String)"", (String)actualResult_0_128_value_229);
            Assert.AreEqual(1, actualResult.Childs.Count);
        }
    }

    [TestMethod]
    public void ComputeDemEventParamsTest_6_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary97 = new Dictionary<String, String>();
            String dictionary97_dem1 = "DemParam1";
            String dictionary97_dem2 = "DemParam2";
            dictionary97["dem1"] = dictionary97_dem1;
            dictionary97["dem2"] = dictionary97_dem2;
            Dictionary<String, String> demEventParamsGroup = dictionary97;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetReferenceValueStringStringString = (RepositoryLinQ instance, String moduleName, String defName, String variantID) =>
            {
                if (defName == "dem1")
                {
                    ItemValue itemvalue108 = new ItemValue(null, null);
                    String itemvalue108_definitionRef = "/dem1";
                    Object itemvalue108_value = "";
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue108, itemvalue108_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue108, itemvalue108_value);
                    return itemvalue108;
                }
                else
                {
                    if (defName == "dem2")
                    {
                        ItemValue itemvalue108 = new ItemValue(null, null);
                        String itemvalue108_definitionRef = "/dem2";
                        Object itemvalue108_value = null;
                        typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue108, itemvalue108_definitionRef);
                        typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue108, itemvalue108_value);
                        return itemvalue108;
                    }
                    else
                    {
                        ItemValue itemvalue108 = null;
                        return itemvalue108;
                    }
                }
            }

            ;
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("ComputeDemEventParams", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{demEventParamsGroup});
            /* Assert */
            Assert.AreEqual("DemEventParams", actualResult.Name);
            Assert.AreEqual(0, actualResult.Childs.Count);
        }
    }

    [TestMethod]
    public void ComputeDemEventParamsTest_6_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary99 = new Dictionary<String, String>();
            String dictionary99_dem1 = "DemParam1";
            dictionary99["dem1"] = dictionary99_dem1;
            Dictionary<String, String> demEventParamsGroup = dictionary99;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetReferenceValueStringStringString = (RepositoryLinQ instance, String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue1010 = null;
                return itemvalue1010;
            }

            ;
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("ComputeDemEventParams", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{demEventParamsGroup});
            /* Assert */
            Assert.AreEqual("DemEventParams", actualResult.Name);
            Assert.AreEqual(0, actualResult.Childs.Count);
        }
    }
}