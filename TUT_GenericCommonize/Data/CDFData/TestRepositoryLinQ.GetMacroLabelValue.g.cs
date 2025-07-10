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
    public void GetMacroLabelValueTest_29_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9123 = "RENESAS_PCR0_12";
            String renesasMacroName = string9123;
            var register1486 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            register1486.GetMacroLabelValueString = (String macroDefinition) =>
            {
                String string10124 = "PORTPCR0_12";
                return string10124;
            }

            ;
            typeof(RepositoryLinQ).GetField("register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, register1486);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetMacroLabelValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{renesasMacroName});
            /* Assert */
            Assert.AreEqual((String)"PORTPCR0_12", (String)actualResult);
        }
    }
}