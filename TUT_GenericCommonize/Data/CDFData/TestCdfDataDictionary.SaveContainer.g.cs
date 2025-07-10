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
    public void SaveContainerTest_40_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9148 = "can";
            String moduleName = string9148;
            String string10149 = "CanConfigSet";
            String key = string10149;
            Container container11150 = new Container();
            String container11150_ShortName = "CanHardwareObject";
            container11150.ShortName = container11150_ShortName;
            Container container = container11150;
            Dictionary<String, Dictionary<String, Container>> dictionary12151 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary12151_CanConfigSet = new Dictionary<String, Container>();
            Container dictionary12151_CanConfigSet_CanController = new Container();
            String dictionary12151_CanConfigSet_CanController_ShortName = "CanController";
            dictionary12151["CanConfigSet"] = dictionary12151_CanConfigSet;
            dictionary12151_CanConfigSet["CanController"] = dictionary12151_CanConfigSet_CanController;
            dictionary12151_CanConfigSet_CanController.ShortName = dictionary12151_CanConfigSet_CanController_ShortName;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary12151);
            /* Act */
            _target.GetType().GetMethod("SaveContainer", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(Container)}, null).Invoke(_target, new object[]{moduleName, key, container});
            /* Assert */
            Object datacontext1495 = _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object datacontext1495_count_1496 = typeof(Dictionary<String, Dictionary<String, Container>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(datacontext1495);
            Assert.AreEqual((Int32)1, (Int32)datacontext1495_count_1496);
            Object datacontext1495_canconfigset_1497 = ((Dictionary<String, Dictionary<String, Container>>)datacontext1495)["CanConfigSet"];
            Object datacontext1495_canconfigset_1497_count_2498 = typeof(Dictionary<String, Container>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(datacontext1495_canconfigset_1497);
            Assert.AreEqual((Int32)2, (Int32)datacontext1495_canconfigset_1497_count_2498);
        }
    }

    [TestMethod]
    public void SaveContainerTest_40_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9152 = "can";
            String moduleName = string9152;
            String string10153 = "CanConfigSet";
            String key = string10153;
            Container container11154 = new Container();
            String container11154_ShortName = "CanController";
            container11154.ShortName = container11154_ShortName;
            Container container = container11154;
            Dictionary<String, Dictionary<String, Container>> dictionary12155 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary12155_CanConfigSet = new Dictionary<String, Container>();
            Container dictionary12155_CanConfigSet_CanController = new Container();
            String dictionary12155_CanConfigSet_CanController_ShortName = "CanController";
            dictionary12155["CanConfigSet"] = dictionary12155_CanConfigSet;
            dictionary12155_CanConfigSet["CanController"] = dictionary12155_CanConfigSet_CanController;
            dictionary12155_CanConfigSet_CanController.ShortName = dictionary12155_CanConfigSet_CanController_ShortName;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary12155);
            /* Act */
            _target.GetType().GetMethod("SaveContainer", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(Container)}, null).Invoke(_target, new object[]{moduleName, key, container});
            /* Assert */
            Object datacontext1499 = _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object datacontext1499_count_1500 = typeof(Dictionary<String, Dictionary<String, Container>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(datacontext1499);
            Assert.AreEqual((Int32)1, (Int32)datacontext1499_count_1500);
            Object datacontext1499_canconfigset_1501 = ((Dictionary<String, Dictionary<String, Container>>)datacontext1499)["CanConfigSet"];
            Object datacontext1499_canconfigset_1501_count_2502 = typeof(Dictionary<String, Container>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(datacontext1499_canconfigset_1501);
            Assert.AreEqual((Int32)1, (Int32)datacontext1499_canconfigset_1501_count_2502);
        }
    }

    [TestMethod]
    public void SaveContainerTest_40_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9156 = "can";
            String moduleName = string9156;
            String string10157 = "CanGeneral";
            String key = string10157;
            Container container11158 = new Container();
            String container11158_ShortName = "CanMainFunctionRWPeriods";
            container11158.ShortName = container11158_ShortName;
            Container container = container11158;
            Dictionary<String, Dictionary<String, Container>> dictionary12159 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary12159_CanConfigSet = new Dictionary<String, Container>();
            Container dictionary12159_CanConfigSet_CanController = new Container();
            String dictionary12159_CanConfigSet_CanController_ShortName = "CanController";
            dictionary12159["CanConfigSet"] = dictionary12159_CanConfigSet;
            dictionary12159_CanConfigSet["CanController"] = dictionary12159_CanConfigSet_CanController;
            dictionary12159_CanConfigSet_CanController.ShortName = dictionary12159_CanConfigSet_CanController_ShortName;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary12159);
            /* Act */
            _target.GetType().GetMethod("SaveContainer", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(Container)}, null).Invoke(_target, new object[]{moduleName, key, container});
            /* Assert */
            Object datacontext1503 = _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object datacontext1503_count_1504 = typeof(Dictionary<String, Dictionary<String, Container>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(datacontext1503);
            Assert.AreEqual((Int32)2, (Int32)datacontext1503_count_1504);
            Object datacontext1503_canconfigset_1505 = ((Dictionary<String, Dictionary<String, Container>>)datacontext1503)["CanConfigSet"];
            Object datacontext1503_canconfigset_1505_count_2506 = typeof(Dictionary<String, Container>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(datacontext1503_canconfigset_1505);
            Assert.AreEqual((Int32)1, (Int32)datacontext1503_canconfigset_1505_count_2506);
            Object datacontext1503_cangeneral_1507 = ((Dictionary<String, Dictionary<String, Container>>)datacontext1503)["CanGeneral"];
            Object datacontext1503_cangeneral_1507_count_2508 = typeof(Dictionary<String, Container>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(datacontext1503_cangeneral_1507);
            Assert.AreEqual((Int32)1, (Int32)datacontext1503_cangeneral_1507_count_2508);
        }
    }

    [TestMethod]
    public void SaveContainerTest_40_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9160 = "";
            String moduleName = string9160;
            String string10161 = "";
            String key = string10161;
            Container container11162 = new Container();
            String container11162_ShortName = null;
            container11162.ShortName = container11162_ShortName;
            Container container = container11162;
            Dictionary<String, Dictionary<String, Container>> dictionary12163 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary12163_CanConfigSet = new Dictionary<String, Container>();
            Container dictionary12163_CanConfigSet_CanController = new Container();
            String dictionary12163_CanConfigSet_CanController_ShortName = "CanController";
            dictionary12163["CanConfigSet"] = dictionary12163_CanConfigSet;
            dictionary12163_CanConfigSet["CanController"] = dictionary12163_CanConfigSet_CanController;
            dictionary12163_CanConfigSet_CanController.ShortName = dictionary12163_CanConfigSet_CanController_ShortName;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary12163);
            /* Act */
            _target.GetType().GetMethod("SaveContainer", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(Container)}, null).Invoke(_target, new object[]{moduleName, key, container});
            /* Assert */
            Object datacontext1509 = _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object datacontext1509_count_1510 = typeof(Dictionary<String, Dictionary<String, Container>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(datacontext1509);
            Assert.AreEqual((Int32)1, (Int32)datacontext1509_count_1510);
        }
    }
}