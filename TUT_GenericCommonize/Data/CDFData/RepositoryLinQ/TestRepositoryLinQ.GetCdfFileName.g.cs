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
    public void GetCdfFileNameTest_23_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata15 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata15.GetCdfFileString = (String _shortName) =>
            {
                String string91 = "";
                return string91;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata15);
            String string102 = "";
            String shortName = string102;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetCdfFileName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{shortName});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetCdfFileNameTest_23_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata16.GetCdfFileString = (String _shortName) =>
            {
                String string93 = "can.arxml";
                return string93;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);
            String string104 = "can";
            String shortName = string104;
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetCdfFileName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{shortName});
            /* Assert */
            Assert.AreEqual((String)"can.arxml", (String)actualResult);
        }
    }
}