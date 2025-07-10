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
    public void ComputeOnOffParamsTest_7_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary91 = new Dictionary<String, String>();
            String dictionary91_InputParam1 = "TargetParam1";
            dictionary91["InputParam1"] = dictionary91_InputParam1;
            Dictionary<String, String> onOffParamsGroup = dictionary91;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetParameterValueStringStringString = (RepositoryLinQ instance, String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue102 = new ItemValue(null, null);
                String itemvalue102_definitionRef = "/InputParam1";
                Object itemvalue102_value = true;
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue102, itemvalue102_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue102, itemvalue102_value);
                return itemvalue102;
            }

            ;
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("ComputeOnOffParams", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{onOffParamsGroup});
            /* Assert */
            Assert.AreEqual((String)"TargetParam1", (String)actualResult.Childs[0].Name);
            Assert.AreEqual((String)"STD_ON", (String)actualResult.Childs[0].Value);
        }
    }

    [TestMethod]
    public void ComputeOnOffParamsTest_7_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary93 = new Dictionary<String, String>();
            String dictionary93_InputParam1 = "TargetParam1";
            String dictionary93_InputParam2 = "TargetParam2";
            dictionary93["InputParam1"] = dictionary93_InputParam1;
            dictionary93["InputParam2"] = dictionary93_InputParam2;
            Dictionary<String, String> onOffParamsGroup = dictionary93;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetParameterValueStringStringString = (RepositoryLinQ instance, String moduleName, String defName, String variantID) =>
            {
                if (defName == "InputParam1")
                {
                    ItemValue itemvalue104 = new ItemValue(null, null);
                    String itemvalue104_definitionRef = "/InputParam1";
                    Object itemvalue104_value = true;
                    typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue104, itemvalue104_definitionRef);
                    typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue104, itemvalue104_value);
                    return itemvalue104;
                }
                else
                {
                    if (defName == "InputParam2")
                    {
                        ItemValue itemvalue104 = new ItemValue(null, null);
                        String itemvalue104_definitionRef = "/InputParam2";
                        Object itemvalue104_value = false;
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
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("ComputeOnOffParams", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{onOffParamsGroup});
            /* Assert */
            Assert.AreEqual((String)"TargetParam1", (String)actualResult.Childs[0].Name);
            Assert.AreEqual((String)"STD_ON", (String)actualResult.Childs[0].Value);
           
        }
    }

    [TestMethod]
    public void ComputeOnOffParamsTest_7_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary95 = new Dictionary<String, String>();
            String dictionary95_InputParam1 = "TargetParam1";
            String dictionary95_InputParam2 = "TargetParam2";
            dictionary95["InputParam1"] = dictionary95_InputParam1;
            dictionary95["InputParam2"] = dictionary95_InputParam2;
            Dictionary<String, String> onOffParamsGroup = dictionary95;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetParameterValueStringStringString = (RepositoryLinQ instance, String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue106 = null;
                return itemvalue106;
            }

            ;
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("ComputeOnOffParams", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{onOffParamsGroup});
            /* Assert */
            Assert.AreEqual((String)"OnOffParams", (String)actualResult.Name);
            Assert.AreEqual(2, actualResult.Childs.Count);
            
        }
    }
}