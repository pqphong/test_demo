using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void GetAddressTypeByMacroDefinitionTest_9_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "RENESAS_ICRLIN30UR0";
            String renesasMacroName = string91;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetMacroLabelValueString = (RepositoryLinQ instance, String _renesasMacroName) =>
            {
                String string102 = "INTC2EIC83";
                return string102;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetAddressTypeString = (RepositoryLinQ instance, String macroValue) =>
            {
                String string113 = "u16_T";
                return string113;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetAddressTypeByMacroDefinition", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{renesasMacroName});
            /* Assert */
            Assert.AreEqual((String)"uint16", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetAddressTypeByMacroDefinitionTest_9_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "RENESAS_ICRLIN33UR0";
            String renesasMacroName = string94;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetMacroLabelValueString = (RepositoryLinQ instance, String _renesasMacroName) =>
            {
                String string105 = "INTC2EIC220";
                return string105;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetAddressTypeString = (RepositoryLinQ instance, String macroValue) =>
            {
                String string116 = "u08_T";
                return string116;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetAddressTypeByMacroDefinition", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{renesasMacroName});
            /* Assert */
            Assert.AreEqual((String)"uint8", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetAddressTypeByMacroDefinitionTest_9_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "RENESAS_ICRLIN33UR0";
            String renesasMacroName = string94;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetMacroLabelValueString = (RepositoryLinQ instance, String _renesasMacroName) =>
            {
                String string105 = "INTC2EIC220";
                return string105;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetAddressTypeString = (RepositoryLinQ instance, String macroValue) =>
            {
                String string116 = null;
                return string116;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetAddressTypeByMacroDefinition", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { renesasMacroName });
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}