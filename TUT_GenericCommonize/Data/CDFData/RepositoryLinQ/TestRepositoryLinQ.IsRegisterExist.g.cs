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
    public void IsRegisterExistTest_22_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9106 = "InvalidMacro";
            String renesasMacroDefinition = string9106;
            var register1477 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            register1477.IsRegisterExistString = (String macroDefinition) =>
            {
                Boolean boolean10107 = false;
                return boolean10107;
            }

            ;
            typeof(RepositoryLinQ).GetField("register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, register1477);
            /* Act */
            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("IsRegisterExist", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{renesasMacroDefinition});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsRegisterExistTest_22_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9108 = "RENESAS_PPR0";
            String renesasMacroDefinition = string9108;
            var register1478 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            register1478.IsRegisterExistString = (String macroDefinition) =>
            {
                Boolean boolean10109 = true;
                return boolean10109;
            }

            ;
            typeof(RepositoryLinQ).GetField("register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, register1478);
            /* Act */
            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("IsRegisterExist", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{renesasMacroDefinition});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }
}