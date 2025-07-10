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
    public void GetAllVariantConfigurationTest_169_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "lin";
            String moduleName = string958;

            var cdfdata0 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata0.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> cons = new List<Container>();
                Container con1 = new Container();
                List<string> variants = new List<string>() {"0", "1"};
                con1.ListConfiguredVariantID = variants;
                cons.Add(con1);
                return cons;
            }

            ;
			typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata0);

            List<string> actualResult = (List<string>)typeof(RepositoryLinQ).GetMethod("GetAllVariantConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { moduleName });

            /* Assert */
            Assert.AreEqual((Object)2, (Object)actualResult.Count);
            Assert.AreEqual((Object)"0", (Object)actualResult[0]);
            Assert.AreEqual((Object)"1", (Object)actualResult[1]);
        }
    }
    [TestMethod]
    public void GetAllVariantConfigurationTest_169_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string958 = "lin";
            String moduleName = string958;

            var cdfdata0 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata0.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> cons = new List<Container>();
                Container con1 = new Container();
                cons.Add(con1);
                return cons;
            }

            ;
			
			typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata0);

            List<string> actualResult = (List<string>)typeof(RepositoryLinQ).GetMethod("GetAllVariantConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { moduleName });

            /* Assert */
            Assert.AreEqual((Object)1, (Object)actualResult.Count);
            Assert.AreEqual((Object)"", (Object)actualResult[0]);
        }
    }
}