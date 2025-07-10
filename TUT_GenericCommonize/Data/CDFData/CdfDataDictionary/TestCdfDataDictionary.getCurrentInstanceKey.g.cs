using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void getCurrentInstanceKeyTest_37_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin";
            String moduleName = string91;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean102 = true;
                return boolean102;
            }

            ;
            Dictionary<String, List<String>> dictionary113 = new Dictionary<String, List<String>>();
            List<String> dictionary113_LIN = new List<String>();
            String dictionary113_LIN_0 = "lin0";
            dictionary113["LIN"] = dictionary113_LIN;
            dictionary113_LIN.Add(dictionary113_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary113);
            Int32 int32124 = 0;
            _target.GetType().GetField("currentInstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32124);
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("getCurrentInstanceKey", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((String)"lin0", (String)actualResult);
        }
    }

    [TestMethod]
    public void getCurrentInstanceKeyTest_37_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "lin";
            String moduleName = string95;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean106 = true;
                return boolean106;
            }

            ;
            Dictionary<String, List<String>> dictionary117 = new Dictionary<String, List<String>>();
            List<String> dictionary117_LIN = new List<String>();
            String dictionary117_LIN_0 = "lin0";
            dictionary117["LIN"] = dictionary117_LIN;
            dictionary117_LIN.Add(dictionary117_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary117);
            Int32 int32128 = 1;
            _target.GetType().GetField("currentInstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32128);
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("getCurrentInstanceKey", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((String)"lin0", (String)actualResult);
        }
    }

    [TestMethod]
    public void getCurrentInstanceKeyTest_37_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string99 = "";
            String moduleName = string99;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean1010 = false;
                return boolean1010;
            }

            ;
            Dictionary<String, List<String>> dictionary1111 = new Dictionary<String, List<String>>();
            List<String> dictionary1111_LIN = new List<String>();
            String dictionary1111_LIN_0 = "lin0";
            dictionary1111["LIN"] = dictionary1111_LIN;
            dictionary1111_LIN.Add(dictionary1111_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1111);
            Int32 int321212 = 0;
            _target.GetType().GetField("currentInstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321212);
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("getCurrentInstanceKey", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((String)null, (String)actualResult);
        }
    }

    [TestMethod]
    public void getCurrentInstanceKeyTest_37_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string913 = "lin";
            String moduleName = string913;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean1014 = true;
                return boolean1014;
            }

            ;
            Dictionary<String, List<String>> dictionary1115 = new Dictionary<String, List<String>>();
            List<String> dictionary1115_LIN = null;
            dictionary1115["LIN"] = dictionary1115_LIN;
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1115);
            Int32 int321216 = 0;
            _target.GetType().GetField("currentInstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321216);
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("getCurrentInstanceKey", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((String)null, (String)actualResult);
        }
    }

    [TestMethod]
    public void getCurrentInstanceKeyTest_37_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string917 = "can";
            String moduleName = string917;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean1018 = true;
                return boolean1018;
            }

            ;
            Dictionary<String, List<String>> dictionary1119 = new Dictionary<String, List<String>>();
            List<String> dictionary1119_LIN = null;
            dictionary1119["LIN"] = dictionary1119_LIN;
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1119);
            Int32 int321220 = 0;
            _target.GetType().GetField("currentInstanceIndex", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321220);
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("getCurrentInstanceKey", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((String)null, (String)actualResult);
        }
    }
}