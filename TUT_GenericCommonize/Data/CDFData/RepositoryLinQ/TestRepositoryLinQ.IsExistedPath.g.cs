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
    public void IsExistedPathTest_15_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string982 = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanControllerPclkClockImmediateValue";
            String path = string982;
            String string1083 = "Can";
            String moduleName = string1083;
            var cdfdata1434 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1434.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1184 = new List<Container>();
                Container ilist1184_0 = new Container();
                String ilist1184_0_Path = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanControllerPclkClockImmediateValue";
                Container ilist1184_1 = new Container();
                String ilist1184_1_Path = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanControllerPplClockImmediateValue";
                ilist1184.Add(ilist1184_0);
                ilist1184_0.Path = ilist1184_0_Path;
                ilist1184.Add(ilist1184_1);
                ilist1184_1.Path = ilist1184_1_Path;
                return ilist1184;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1434);
            /* Act */
            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("IsExistedPath", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{path, moduleName});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsExistedPathTest_15_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string985 = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanControllerPclkClockImmediateValue_Invalid";
            String path = string985;
            String string1086 = "Can";
            String moduleName = string1086;
            var cdfdata1435 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1435.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1187 = new List<Container>();
                Container ilist1187_0 = new Container();
                String ilist1187_0_Path = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanControllerPclkClockImmediateValue";
                ilist1187.Add(ilist1187_0);
                ilist1187_0.Path = ilist1187_0_Path;
                return ilist1187;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1435);
            /* Act */
            Boolean actualResult = (Boolean)typeof(RepositoryLinQ).GetMethod("IsExistedPath", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{path, moduleName});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}