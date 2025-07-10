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
    public void GetContainerByUUIDTest_34_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9127 = "can";
            String moduleName = string9127;
            String string10128 = "e7114b3e-1feb-4b39-84c1-1111111102";
            String uuid = string10128;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetAllInstanceContainersString = (CdfDataDictionary instance, String _moduleName) =>
            {
                Dictionary<String, IList<Container>> dictionary11129 = new Dictionary<String, IList<Container>>();
                IList<Container> dictionary11129_CanConfigSet = new List<Container>();
                Container dictionary11129_CanConfigSet_0 = new Container();
                String dictionary11129_CanConfigSet_0_Uuid = "e7114b3e-1feb-4b39-84c1-1111111101";
                String dictionary11129_CanConfigSet_0_ShortName = "CanConfigSet";
                IList<Container> dictionary11129_CanGeneral = new List<Container>();
                Container dictionary11129_CanGeneral_1 = new Container();
                String dictionary11129_CanGeneral_1_Uuid = "e7114b3e-1feb-4b39-84c1-1111111102";
                String dictionary11129_CanGeneral_1_ShortName = "CanGeneral";
                dictionary11129["CanConfigSet"] = dictionary11129_CanConfigSet;
                dictionary11129_CanConfigSet.Add(dictionary11129_CanConfigSet_0);
                dictionary11129_CanConfigSet_0.Uuid = dictionary11129_CanConfigSet_0_Uuid;
                dictionary11129_CanConfigSet_0.ShortName = dictionary11129_CanConfigSet_0_ShortName;
                dictionary11129["CanGeneral"] = dictionary11129_CanGeneral;
                dictionary11129_CanGeneral.Add(dictionary11129_CanGeneral_1);
                dictionary11129_CanGeneral_1.Uuid = dictionary11129_CanGeneral_1_Uuid;
                dictionary11129_CanGeneral_1.ShortName = dictionary11129_CanGeneral_1_ShortName;
                return dictionary11129;
            }

            ;
            /* Act */
            Container actualResult = (Container)_target.GetType().GetMethod("GetContainerByUUID", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, uuid});
            /* Assert */
            Object actualResult_shortname_1488 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CanGeneral", (String)actualResult_shortname_1488);
        }
    }

    [TestMethod]
    public void GetContainerByUUIDTest_34_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9130 = "can";
            String moduleName = string9130;
            String string10131 = "e7114b3e-1feb-4b39-84c1-1111111109";
            String uuid = string10131;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetAllInstanceContainersString = (CdfDataDictionary instance, String _moduleName) =>
            {
                Dictionary<String, IList<Container>> dictionary11132 = new Dictionary<String, IList<Container>>();
                IList<Container> dictionary11132_CanConfigSet = new List<Container>();
                Container dictionary11132_CanConfigSet_0 = new Container();
                String dictionary11132_CanConfigSet_0_Uuid = "e7114b3e-1feb-4b39-84c1-1111111101";
                String dictionary11132_CanConfigSet_0_ShortName = "CanConfigSet";
                IList<Container> dictionary11132_CanGeneral = new List<Container>();
                Container dictionary11132_CanGeneral_1 = new Container();
                String dictionary11132_CanGeneral_1_Uuid = "e7114b3e-1feb-4b39-84c1-1111111102";
                String dictionary11132_CanGeneral_1_ShortName = "CanGeneral";
                dictionary11132["CanConfigSet"] = dictionary11132_CanConfigSet;
                dictionary11132_CanConfigSet.Add(dictionary11132_CanConfigSet_0);
                dictionary11132_CanConfigSet_0.Uuid = dictionary11132_CanConfigSet_0_Uuid;
                dictionary11132_CanConfigSet_0.ShortName = dictionary11132_CanConfigSet_0_ShortName;
                dictionary11132["CanGeneral"] = dictionary11132_CanGeneral;
                dictionary11132_CanGeneral.Add(dictionary11132_CanGeneral_1);
                dictionary11132_CanGeneral_1.Uuid = dictionary11132_CanGeneral_1_Uuid;
                dictionary11132_CanGeneral_1.ShortName = dictionary11132_CanGeneral_1_ShortName;
                return dictionary11132;
            }

            ;
            /* Act */
            Container actualResult = (Container)_target.GetType().GetMethod("GetContainerByUUID", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, uuid});
            /* Assert */
            Assert.AreEqual((Container)null, (Container)actualResult);
        }
    }

    [TestMethod]
    public void GetContainerByUUIDTest_34_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9133 = "";
            String moduleName = string9133;
            String string10134 = null;
            String uuid = string10134;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetAllInstanceContainersString = (CdfDataDictionary instance, String _moduleName) =>
            {
                Dictionary<String, IList<Container>> dictionary11135 = new Dictionary<String, IList<Container>>();
                IList<Container> dictionary11135_CanConfigSet = new List<Container>();
                Container dictionary11135_CanConfigSet_0 = new Container();
                String dictionary11135_CanConfigSet_0_Uuid = "e7114b3e-1feb-4b39-84c1-1111111101";
                String dictionary11135_CanConfigSet_0_ShortName = "CanConfigSet";
                IList<Container> dictionary11135_CanGeneral = new List<Container>();
                Container dictionary11135_CanGeneral_1 = new Container();
                String dictionary11135_CanGeneral_1_Uuid = "e7114b3e-1feb-4b39-84c1-1111111102";
                String dictionary11135_CanGeneral_1_ShortName = "CanGeneral";
                dictionary11135["CanConfigSet"] = dictionary11135_CanConfigSet;
                dictionary11135_CanConfigSet.Add(dictionary11135_CanConfigSet_0);
                dictionary11135_CanConfigSet_0.Uuid = dictionary11135_CanConfigSet_0_Uuid;
                dictionary11135_CanConfigSet_0.ShortName = dictionary11135_CanConfigSet_0_ShortName;
                dictionary11135["CanGeneral"] = dictionary11135_CanGeneral;
                dictionary11135_CanGeneral.Add(dictionary11135_CanGeneral_1);
                dictionary11135_CanGeneral_1.Uuid = dictionary11135_CanGeneral_1_Uuid;
                dictionary11135_CanGeneral_1.ShortName = dictionary11135_CanGeneral_1_ShortName;
                return dictionary11135;
            }

            ;
            /* Act */
            Container actualResult = (Container)_target.GetType().GetMethod("GetContainerByUUID", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, uuid});
            /* Assert */
            Assert.AreEqual((Container)null, (Container)actualResult);
        }
    }
}