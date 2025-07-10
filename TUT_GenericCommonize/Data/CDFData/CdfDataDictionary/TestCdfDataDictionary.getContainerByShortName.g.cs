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

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void getContainerByShortNameTest_48_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9168 = "can";
            String moduleName = string9168;
            String string10169 = "CanConfigSet";
            String shortName = string10169;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceContainersString = (CdfDataDictionary instance, String _moduleName) =>
            {
                IList<Container> ilist11170 = new List<Container>();
                Container ilist11170_0 = new Container();
                String ilist11170_0_ShortName = "CanConfigSet";
                Container ilist11170_1 = new Container();
                String ilist11170_1_ShortName = "CanGeneral";
                ilist11170.Add(ilist11170_0);
                ilist11170_0.ShortName = ilist11170_0_ShortName;
                ilist11170.Add(ilist11170_1);
                ilist11170_1.ShortName = ilist11170_1_ShortName;
                return ilist11170;
            }

            ;
            /* Act */
            Container actualResult = (Container)_target.GetType().GetMethod("getContainerByShortName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Object actualResult_shortname_1513 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CanConfigSet", (String)actualResult_shortname_1513);
        }
    }

    [TestMethod]
    public void getContainerByShortNameTest_48_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9171 = "can";
            String moduleName = string9171;
            String string10172 = "CanGeneral";
            String shortName = string10172;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceContainersString = (CdfDataDictionary instance, String _moduleName) =>
            {
                IList<Container> ilist11173 = new List<Container>();
                Container ilist11173_0 = new Container();
                String ilist11173_0_ShortName = "CanConfigSet";
                Container ilist11173_1 = new Container();
                String ilist11173_1_ShortName = "CanGeneral";
                ilist11173.Add(ilist11173_0);
                ilist11173_0.ShortName = ilist11173_0_ShortName;
                ilist11173.Add(ilist11173_1);
                ilist11173_1.ShortName = ilist11173_1_ShortName;
                return ilist11173;
            }

            ;
            /* Act */
            Container actualResult = (Container)_target.GetType().GetMethod("getContainerByShortName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Object actualResult_shortname_1514 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CanGeneral", (String)actualResult_shortname_1514);
        }
    }

    [TestMethod]
    public void getContainerByShortNameTest_48_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9174 = "can";
            String moduleName = string9174;
            String string10175 = "CanDemEventParameterRefs";
            String shortName = string10175;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceContainersString = (CdfDataDictionary instance, String _moduleName) =>
            {
                IList<Container> ilist11176 = new List<Container>();
                Container ilist11176_0 = new Container();
                String ilist11176_0_ShortName = "CanConfigSet";
                Container ilist11176_1 = new Container();
                String ilist11176_1_ShortName = "CanGeneral";
                ilist11176.Add(ilist11176_0);
                ilist11176_0.ShortName = ilist11176_0_ShortName;
                ilist11176.Add(ilist11176_1);
                ilist11176_1.ShortName = ilist11176_1_ShortName;
                return ilist11176;
            }

            ;
            /* Act */
            Container actualResult = (Container)_target.GetType().GetMethod("getContainerByShortName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Assert.AreEqual((Container)null, (Container)actualResult);
        }
    }
}