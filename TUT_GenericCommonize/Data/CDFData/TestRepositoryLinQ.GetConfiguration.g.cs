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
    public void GetConfigurationTest_20_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9102 = "can";
            String moduleName = string9102;
            var cdfdata1472 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1472.GetCurrentInstanceConfigurationString = (String _moduleName) =>
            {
                Configuration configuration10103 = new Configuration();
                String configuration10103_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
                String configuration10103_ShortName = "CanConfigSet0";
                String configuration10103_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
                configuration10103.Uuid = configuration10103_Uuid;
                configuration10103.ShortName = configuration10103_ShortName;
                configuration10103.DefinitionRef = configuration10103_DefinitionRef;
                return configuration10103;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1472);
            /* Act */
            Configuration actualResult = (Configuration)typeof(RepositoryLinQ).GetMethod("GetConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_uuid_1473 = typeof(Configuration).GetProperty("Uuid", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"f35faedc-bb22-4614-8a30-4654716b411c", (String)actualResult_uuid_1473);
            Object actualResult_shortname_1474 = typeof(Configuration).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CanConfigSet0", (String)actualResult_shortname_1474);
            Object actualResult_definitionref_1475 = typeof(Configuration).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet", (String)actualResult_definitionref_1475);
        }
    }
}