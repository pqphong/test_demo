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
    public void CheckVariantParameterSupportedTest_170_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "lin";
            String moduleName = string958;
            String string1059 = "LinChannelBaudRate";
            String defName = string1059;

            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetParameterValuesStringStringString = (RepositoryLinQ instance, String _moduleName, String _defName, String variantID) =>
            {
                IList<ItemValue> ilist1190 = new List<ItemValue>();
                ItemValue ilist1190_0 = new ItemValue(null, null, null);
                String ilist1190_0_definitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate";
                Object ilist1190_0_value = 12000;
                List<VariantItemValue> Lvariant = new List<VariantItemValue>();
                VariantItemValue varitem1 = new VariantItemValue("0", 9600);
                Lvariant.Add(varitem1);
                ilist1190.Add(ilist1190_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_0, ilist1190_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_0, ilist1190_0_value);
                typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_0, Lvariant);
                return ilist1190;
            }

            ;

            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("CheckVariantParameterSupported", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName });

            /* Assert */
            Assert.AreEqual((Object)true, (Object)actualResult);
        }
    }

    [TestMethod]
    public void CheckVariantParameterSupportedTest_170_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "lin";
            String moduleName = string958;
            String string1059 = "LinChannelBaudRate";
            String defName = string1059;

            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetParameterValuesStringStringString = (RepositoryLinQ instance, String _moduleName, String _defName, String variantID) =>
            {
                IList<ItemValue> ilist1190 = new List<ItemValue>();
                return ilist1190;
            }

            ;

            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("CheckVariantParameterSupported", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName });

            /* Assert */
            Assert.AreEqual((Object)false, (Object)actualResult);
        }
    }
	
	[TestMethod]
    public void CheckVariantParameterSupportedTest_170_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "lin";
            String moduleName = string958;
            String string1059 = "LinChannelBaudRate";
            String defName = string1059;

            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetParameterValuesStringStringString = (RepositoryLinQ instance, String _moduleName, String _defName, String variantID) =>
            {
                IList<ItemValue> ilist1190 = new List<ItemValue>();
                ItemValue ilist1190_0 = new ItemValue(null, null, null);
                String ilist1190_0_definitionRef = "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinChannelBaudRate";
                Object ilist1190_0_value = 12000;
                List<VariantItemValue> Lvariant = new List<VariantItemValue>();
                ilist1190.Add(ilist1190_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_0, ilist1190_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_0, ilist1190_0_value);
                typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist1190_0, Lvariant);
                return ilist1190;
            }

            ;

            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("CheckVariantParameterSupported", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, defName });

            /* Assert */
            Assert.AreEqual((Object)false, (Object)actualResult);
        }
    }
}