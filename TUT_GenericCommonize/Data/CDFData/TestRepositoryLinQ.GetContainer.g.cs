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
    public void GetContainerTest_14_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string976 = "can";
            String moduleName = string976;
            String string1077 = "CanController";
            String shortName = string1077;
            var cdfdata1431 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1431.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1178 = new List<Container>();
                Container ilist1178_0 = new Container();
                String ilist1178_0_ShortName = "CanController";
                Container ilist1178_1 = new Container();
                String ilist1178_1_ShortName = "CanController_001";
                Container ilist1178_2 = new Container();
                String ilist1178_2_ShortName = "CanHardwareObject_002";
                ilist1178.Add(ilist1178_0);
                ilist1178_0.ShortName = ilist1178_0_ShortName;
                ilist1178.Add(ilist1178_1);
                ilist1178_1.ShortName = ilist1178_1_ShortName;
                ilist1178.Add(ilist1178_2);
                ilist1178_2.ShortName = ilist1178_2_ShortName;
                return ilist1178;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1431);
            /* Act */
            Container actualResult = (Container)typeof(RepositoryLinQ).GetMethod("GetContainer", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Object actualResult_shortname_1432 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CanController", (String)actualResult_shortname_1432);
        }
    }

    [TestMethod]
    public void GetContainerTest_14_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string979 = "can";
            String moduleName = string979;
            String string1080 = "CanController_002";
            String shortName = string1080;
            var cdfdata1433 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1433.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1181 = new List<Container>();
                Container ilist1181_0 = new Container();
                String ilist1181_0_ShortName = "CanController";
                Container ilist1181_1 = new Container();
                String ilist1181_1_ShortName = "CanController_001";
                Container ilist1181_2 = new Container();
                String ilist1181_2_ShortName = "CanHardwareObject_002";
                ilist1181.Add(ilist1181_0);
                ilist1181_0.ShortName = ilist1181_0_ShortName;
                ilist1181.Add(ilist1181_1);
                ilist1181_1.ShortName = ilist1181_1_ShortName;
                ilist1181.Add(ilist1181_2);
                ilist1181_2.ShortName = ilist1181_2_ShortName;
                return ilist1181;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1433);
            /* Act */
            Container actualResult = (Container)typeof(RepositoryLinQ).GetMethod("GetContainer", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Assert.AreEqual((Container)null, (Container)actualResult);
        }
    }
}