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
    public void GetAddressByMacroDefinitionTest_11_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string964 = "RENESAS_PCR0_12";
            String renesasMacroName = string964;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetMacroLabelValueString = (RepositoryLinQ instance, String _renesasMacroName) =>
            {
                String string1065 = "PORTPCR0_12";
                return string1065;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetMacroAddressValueString = (RepositoryLinQ instance, String macroValue) =>
            {
                String string1166 = "0xffc12030ul";
                return string1166;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetAddressByMacroDefinition", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{renesasMacroName});
            /* Assert */
            Assert.AreEqual((String)"0xffc12030ul", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetAddressByMacroDefinitionTest_11_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string967 = "RENESAS_PCR0_12";
            String renesasMacroName = string967;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetMacroLabelValueString = (RepositoryLinQ instance, String _renesasMacroName) =>
            {
                String string1068 = "";
                return string1068;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetMacroAddressValueString = (RepositoryLinQ instance, String macroValue) =>
            {
                String string1169 = "";
                return string1169;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetAddressByMacroDefinition", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{renesasMacroName});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}