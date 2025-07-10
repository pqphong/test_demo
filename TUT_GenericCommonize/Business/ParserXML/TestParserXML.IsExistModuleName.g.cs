using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestParserXML
{
    [TestMethod]
    public void isExistModuleNameTest_30_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "ValidModule";
            String moduleName = string91;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetModules = (CdfDataDictionary instance) =>
            {
                IList<String> ilist102 = new List<String>();
                String ilist102_0 = "MCU";
                ilist102.Add(ilist102_0);
                return ilist102;
            }

            ;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("isExistModuleName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isExistModuleNameTest_30_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "MCU";
            String moduleName = string93;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetModules = (CdfDataDictionary instance) =>
            {
                IList<String> ilist104 = new List<String>();
                String ilist104_0 = "MCU";
                ilist104.Add(ilist104_0);
                return ilist104;
            }

            ;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("isExistModuleName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isExistModuleNameTest_30_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "FLS";
            String moduleName = string95;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetModules = (CdfDataDictionary instance) =>
            {
                IList<String> ilist106 = new List<String>();
                String ilist106_0 = "MCU";
                String ilist106_1 = "LIN";
                String ilist106_2 = "FLS";
                ilist106.Add(ilist106_0);
                ilist106.Add(ilist106_1);
                ilist106.Add(ilist106_2);
                return ilist106;
            }

            ;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("isExistModuleName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void isExistModuleNameTest_30_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "";
            String moduleName = string97;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetModules = (CdfDataDictionary instance) =>
            {
                IList<String> ilist108 = new List<String>();
                String ilist108_0 = "MCU";
                ilist108.Add(ilist108_0);
                return ilist108;
            }

            ;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("isExistModuleName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}