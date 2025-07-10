using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void GetCurrentInstanceConfigurationTest_42_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin";
            String moduleName = string91;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean102 = true;
                return boolean102;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.getCurrentInstanceKeyString = (CdfDataDictionary instance, String _moduleName) =>
            {
                String string113 = "lin0";
                return string113;
            }

            ;
            Dictionary<String, Configuration> dictionary124 = new Dictionary<String, Configuration>();
            Configuration dictionary124_lin0 = new Configuration();
            String dictionary124_lin0_ShortName = "lin0";
            String dictionary124_lin0_DefinitionRef = "/Renesas/Autosar/lin";
            dictionary124["lin0"] = dictionary124_lin0;
            dictionary124_lin0.ShortName = dictionary124_lin0_ShortName;
            dictionary124_lin0.DefinitionRef = dictionary124_lin0_DefinitionRef;
            _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary124);
            /* Act */
            Configuration actualResult = (Configuration)_target.GetType().GetMethod("GetCurrentInstanceConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_shortname_113 = typeof(Configuration).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"lin0", (String)actualResult_shortname_113);
            Object actualResult_definitionref_114 = typeof(Configuration).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/Autosar/lin", (String)actualResult_definitionref_114);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceConfigurationTest_42_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "";
            String moduleName = string95;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean106 = false;
                return boolean106;
            }

            ;
            /* Act */
            Configuration actualResult = (Configuration)_target.GetType().GetMethod("GetCurrentInstanceConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((Configuration)null, (Configuration)actualResult);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceConfigurationTest_42_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string99 = "lin";
            String moduleName = string99;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean1010 = true;
                return boolean1010;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.getCurrentInstanceKeyString = (CdfDataDictionary instance, String _moduleName) =>
            {
                String string1111 = "";
                return string1111;
            }

            ;
            /* Act */
            Configuration actualResult = (Configuration)_target.GetType().GetMethod("GetCurrentInstanceConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((Configuration)null, (Configuration)actualResult);
        }
    }
}