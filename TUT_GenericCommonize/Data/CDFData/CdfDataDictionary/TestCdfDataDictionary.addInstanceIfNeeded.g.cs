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
    public void addInstanceIfNeededTest_43_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin";
            String moduleName = string91;
            String string102 = "lin2";
            String instanceShortname = string102;
            Dictionary<String, List<String>> dictionary113 = new Dictionary<String, List<String>>();
            List<String> dictionary113_LIN = new List<String>();
            String dictionary113_LIN_0 = "lin0";
            String dictionary113_LIN_1 = "lin1";
            dictionary113["LIN"] = dictionary113_LIN;
            dictionary113_LIN.Add(dictionary113_LIN_0);
            dictionary113_LIN.Add(dictionary113_LIN_1);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary113);
            /* Act */
            _target.GetType().GetMethod("addInstanceIfNeeded", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, instanceShortname});
            /* Assert */
            Object moduleinstances110 = _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object moduleinstances110_lin_111 = ((Dictionary<String, List<String>>)moduleinstances110)["LIN"];
            Object moduleinstances110_lin_111_0_212 = ((List<String>)moduleinstances110_lin_111)[0];
            Assert.AreEqual((String)"lin0", (String)moduleinstances110_lin_111_0_212);
            Object moduleinstances110_lin_113 = ((Dictionary<String, List<String>>)moduleinstances110)["LIN"];
            Object moduleinstances110_lin_113_1_214 = ((List<String>)moduleinstances110_lin_113)[1];
            Assert.AreEqual((String)"lin1", (String)moduleinstances110_lin_113_1_214);
            Object moduleinstances110_lin_115 = ((Dictionary<String, List<String>>)moduleinstances110)["LIN"];
            Object moduleinstances110_lin_115_2_216 = ((List<String>)moduleinstances110_lin_115)[2];
            Assert.AreEqual((String)"lin2", (String)moduleinstances110_lin_115_2_216);
        }
    }

    [TestMethod]
    public void addInstanceIfNeededTest_43_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "lin";
            String moduleName = string94;
            String string105 = "lin1";
            String instanceShortname = string105;
            Dictionary<String, List<String>> dictionary116 = new Dictionary<String, List<String>>();
            List<String> dictionary116_LIN = new List<String>();
            String dictionary116_LIN_0 = "lin0";
            String dictionary116_LIN_1 = "lin1";
            dictionary116["LIN"] = dictionary116_LIN;
            dictionary116_LIN.Add(dictionary116_LIN_0);
            dictionary116_LIN.Add(dictionary116_LIN_1);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary116);
            /* Act */
            _target.GetType().GetMethod("addInstanceIfNeeded", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, instanceShortname});
            /* Assert */
            Object moduleinstances117 = _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object moduleinstances117_lin_118 = ((Dictionary<String, List<String>>)moduleinstances117)["LIN"];
            Object moduleinstances117_lin_118_0_219 = ((List<String>)moduleinstances117_lin_118)[0];
            Assert.AreEqual((String)"lin0", (String)moduleinstances117_lin_118_0_219);
            Object moduleinstances117_lin_120 = ((Dictionary<String, List<String>>)moduleinstances117)["LIN"];
            Object moduleinstances117_lin_120_1_221 = ((List<String>)moduleinstances117_lin_120)[1];
            Assert.AreEqual((String)"lin1", (String)moduleinstances117_lin_120_1_221);
        }
    }

    [TestMethod]
    public void addInstanceIfNeededTest_43_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "can";
            String moduleName = string97;
            String string108 = "lin1";
            String instanceShortname = string108;
            Dictionary<String, List<String>> dictionary119 = new Dictionary<String, List<String>>();
            List<String> dictionary119_LIN = new List<String>();
            String dictionary119_LIN_0 = "lin0";
            String dictionary119_LIN_1 = "lin1";
            dictionary119["LIN"] = dictionary119_LIN;
            dictionary119_LIN.Add(dictionary119_LIN_0);
            dictionary119_LIN.Add(dictionary119_LIN_1);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary119);
            /* Act */
            _target.GetType().GetMethod("addInstanceIfNeeded", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, instanceShortname});
            /* Assert */
            Object moduleinstances122 = _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object moduleinstances122_lin_123 = ((Dictionary<String, List<String>>)moduleinstances122)["LIN"];
            Object moduleinstances122_lin_123_0_224 = ((List<String>)moduleinstances122_lin_123)[0];
            Assert.AreEqual((String)"lin0", (String)moduleinstances122_lin_123_0_224);
            Object moduleinstances122_lin_125 = ((Dictionary<String, List<String>>)moduleinstances122)["LIN"];
            Object moduleinstances122_lin_125_1_226 = ((List<String>)moduleinstances122_lin_125)[1];
            Assert.AreEqual((String)"lin1", (String)moduleinstances122_lin_125_1_226);
        }
    }
}