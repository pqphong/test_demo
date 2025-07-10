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
    public void GetShortNameVariantConfigTest_168_1()
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
                List<string> variant1 = new List<string>() {"0", "1"};
                con1.ListConfiguredVariantID = variant1;
                cons.Add(con1);

                Container con2 = new Container();
                List<string> variant2 = new List<string>() { "1" };
                con2.ListConfiguredVariantID = variant2;
                cons.Add(con2);

                Container con3 = new Container();
                string variant3 = "3";
                con2.VariantID = variant3;
                cons.Add(con3);
                return cons;
            }

            ;

            cdfdata0.GetEvaluatedVariantSet = () =>
            {
                Dictionary<string, string> variantset = new Dictionary<string, string>();
                variantset.Add("0", "Variant1");
                variantset.Add("1", "Variant2");
                variantset.Add("2", "Variant3");
                variantset.Add("3", "Variant4");
                variantset.Add("4", "Variant5");
                return variantset;
            }

            ;
            
			typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata0);
            Dictionary<string, string> actualResult = (Dictionary<string, string>)typeof(RepositoryLinQ).GetMethod("GetShortNameVariantConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { moduleName });

            /* Assert */
            Assert.AreEqual((Object)3, (Object)actualResult.Count);
            Assert.AreEqual((Object)"Variant1", (Object)actualResult["0"]);
            Assert.AreEqual((Object)"Variant2", (Object)actualResult["1"]);
            Assert.AreEqual((Object)"Variant4", (Object)actualResult["3"]);
        }
    }

    [TestMethod]
    public void GetShortNameVariantConfigTest_168_2()
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

                Container con2 = new Container();
                cons.Add(con2);

                Container con3 = new Container();
                cons.Add(con3);
                return cons;
            }

            ;

            cdfdata0.GetEvaluatedVariantSet = () =>
            {
                Dictionary<string, string> variantset = new Dictionary<string, string>();
                variantset.Add("0", "Variant1");
                variantset.Add("1", "Variant2");
                variantset.Add("2", "Variant3");
                variantset.Add("3", "Variant4");
                variantset.Add("4", "Variant5");
                return variantset;
            }

            ;
			
			typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata0);

            Dictionary<string, string> actualResult = (Dictionary<string, string>)typeof(RepositoryLinQ).GetMethod("GetShortNameVariantConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { moduleName });

            /* Assert */
            Assert.AreEqual((Object)1, (Object)actualResult.Count);
            Assert.AreEqual((Object)"", (Object)actualResult[""]);
        }
    }
}