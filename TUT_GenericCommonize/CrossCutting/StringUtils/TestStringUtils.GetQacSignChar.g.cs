using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;

public partial class TestStringUtils
{
    [TestMethod]
    public void GetQacSignCharTest_58_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list91 = null;
            List<String> defineList = list91;
            Dictionary<String, String> dictionary102 = new Dictionary<string, string>()
            {{"0791", "JV-01"}};
            Dictionary<String, String> qacMessage = dictionary102;
            /* Act */
            Dictionary<String, Dictionary<String, String>> actualResult = (Dictionary<String, Dictionary<String, String>>)typeof(StringUtils).GetMethod("GetQacSignChar", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(List<String>), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{defineList, qacMessage});
            /* Assert */
            Object actualResult_count_17 = typeof(Dictionary<String, Dictionary<String, String>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_17);
        }
    }

    [TestMethod]
    public void GetQacSignCharTest_58_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list95 = new List<String>();
            String list95_0 = "IcuConf_IcuChannel_IcuChannel";
            String list95_1 = "IcuConf_IcuChannel_IcuChannel";
            String list95_2 = "IcuConf_IcuChannel_IcuChannel_001";
            String list95_3 = "IcuConf_IcuChannel_IcuChannel_002";
            String list95_4 = "IcuConf_IcuChannel_IcuChannel_003";
            list95.Add(list95_0);
            list95.Add(list95_1);
            list95.Add(list95_2);
            list95.Add(list95_3);
            list95.Add(list95_4);
            List<String> defineList = list95;
            Dictionary<String, String> dictionary106 = new Dictionary<string, string>()
            {{"0791", "JV-01"}};
            Dictionary<String, String> qacMessage = dictionary106;
            /* Act */
            Dictionary<String, Dictionary<String, String>> actualResult = (Dictionary<String, Dictionary<String, String>>)typeof(StringUtils).GetMethod("GetQacSignChar", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(List<String>), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{defineList, qacMessage});
            /* Assert */
            Object actualResult_count_18 = typeof(Dictionary<String, Dictionary<String, String>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)4, (Int32)actualResult_count_18);
            Object actualResult_icuconficuchannelicuchannel_19 = ((Dictionary<String, Dictionary<String, String>>)actualResult)["IcuConf_IcuChannel_IcuChannel"];
            Assert.AreEqual((Dictionary<String, String>)null, (Dictionary<String, String>)actualResult_icuconficuchannelicuchannel_19);
            Object actualResult_icuconficuchannelicuchannel001_110 = ((Dictionary<String, Dictionary<String, String>>)actualResult)["IcuConf_IcuChannel_IcuChannel_001"];
            Assert.AreEqual((Dictionary<String, String>)null, (Dictionary<String, String>)actualResult_icuconficuchannelicuchannel001_110);
            Object actualResult_icuconficuchannelicuchannel002_111 = ((Dictionary<String, Dictionary<String, String>>)actualResult)["IcuConf_IcuChannel_IcuChannel_002"];
            Object actualResult_icuconficuchannelicuchannel002_111_0791_212 = ((Dictionary<String, String>)actualResult_icuconficuchannelicuchannel002_111)["0791"];
            Assert.AreEqual((String)"JV-01", (String)actualResult_icuconficuchannelicuchannel002_111_0791_212);
            Object actualResult_icuconficuchannelicuchannel003_113 = ((Dictionary<String, Dictionary<String, String>>)actualResult)["IcuConf_IcuChannel_IcuChannel_003"];
            Object actualResult_icuconficuchannelicuchannel003_113_0791_214 = ((Dictionary<String, String>)actualResult_icuconficuchannelicuchannel003_113)["0791"];
            Assert.AreEqual((String)"JV-01", (String)actualResult_icuconficuchannelicuchannel003_113_0791_214);
        }
    }

    [TestMethod]
    public void GetQacSignCharTest_58_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list95 = new List<String>();
            String list95_0 = "IcuConf_IcuChannel_IcuChannel";
            String list95_1 = "IcuConf_IcuChannel_IcuChannel";
            String list95_2 = "IcuConf_IcuChannel_IcuChannel_001";
            String list95_3 = "IcuConf_IcuChannel_IcuChannel_002";
            String list95_4 = "IcuConf_IcuChannel_IcuChannel_003";
            list95.Add(list95_0);
            list95.Add(list95_1);
            list95.Add(list95_2);
            list95.Add(list95_3);
            list95.Add(list95_4);
            List<String> defineList = list95;
            Dictionary<String, String> dictionary106 = new Dictionary<string, string>()
            {{"0791", "JV-01"}};
            Dictionary<String, String> qacMessage = dictionary106;
            /* Act */
            Dictionary<String, Dictionary<String, String>> actualResult = (Dictionary<String, Dictionary<String, String>>)typeof(StringUtils).GetMethod("GetQacSignChar", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(List<String>), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{defineList, qacMessage});
            /* Assert */
            Object actualResult_count_115 = typeof(Dictionary<String, Dictionary<String, String>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)4, (Int32)actualResult_count_115);
            Object actualResult_icuconficuchannelicuchannel_116 = ((Dictionary<String, Dictionary<String, String>>)actualResult)["IcuConf_IcuChannel_IcuChannel"];
            Assert.AreEqual((Dictionary<String, String>)null, (Dictionary<String, String>)actualResult_icuconficuchannelicuchannel_116);
            Object actualResult_icuconficuchannelicuchannel001_117 = ((Dictionary<String, Dictionary<String, String>>)actualResult)["IcuConf_IcuChannel_IcuChannel_001"];
            Assert.AreEqual((Dictionary<String, String>)null, (Dictionary<String, String>)actualResult_icuconficuchannelicuchannel001_117);
            Object actualResult_icuconficuchannelicuchannel002_118 = ((Dictionary<String, Dictionary<String, String>>)actualResult)["IcuConf_IcuChannel_IcuChannel_002"];
            Object actualResult_icuconficuchannelicuchannel002_118_0791_219 = ((Dictionary<String, String>)actualResult_icuconficuchannelicuchannel002_118)["0791"];
            Assert.AreEqual((String)"JV-01", (String)actualResult_icuconficuchannelicuchannel002_118_0791_219);
            Object actualResult_icuconficuchannelicuchannel003_120 = ((Dictionary<String, Dictionary<String, String>>)actualResult)["IcuConf_IcuChannel_IcuChannel_003"];
            Object actualResult_icuconficuchannelicuchannel003_120_0791_221 = ((Dictionary<String, String>)actualResult_icuconficuchannelicuchannel003_120)["0791"];
            Assert.AreEqual((String)"JV-01", (String)actualResult_icuconficuchannelicuchannel003_120_0791_221);
        }
    }
}