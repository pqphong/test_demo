using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using System.Text;

public partial class TestCommandLine
{
    [TestMethod]
    public void checkExplicitOptionsTest_51_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput91 = new CommandLineInput();
            Dictionary<String, String> commandlineinput91_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput91_OptionsWithValues_h = "abc.cgxml";
            commandlineinput91.OptionsWithValues = commandlineinput91_OptionsWithValues;
            commandlineinput91_OptionsWithValues["-h"] = commandlineinput91_OptionsWithValues_h;
            CommandLineInput userInput = commandlineinput91;
            CommandLineInput commandlineinput102 = new CommandLineInput();
            Dictionary<String, String> commandlineinput102_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput102_OptionsWithValues_h = "abc.cgxml";
            commandlineinput102.OptionsWithValues = commandlineinput102_OptionsWithValues;
            commandlineinput102_OptionsWithValues["-h"] = commandlineinput102_OptionsWithValues_h;
            CommandLineInput xmlConfig = commandlineinput102;
            /* Act */
            StringBuilder actualResult = (StringBuilder)_target.GetType().GetMethod("checkExplicitOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Object actualResult_length_111 = typeof(StringBuilder).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)6, (Int32)actualResult_length_111);
        }
    }

    [TestMethod]
    public void checkExplicitOptionsTest_51_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput93 = new CommandLineInput();
            Dictionary<String, String> commandlineinput93_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput93_OptionsWithValues_h = "abc.cgxml";
            commandlineinput93.OptionsWithValues = commandlineinput93_OptionsWithValues;
            commandlineinput93_OptionsWithValues["-h"] = commandlineinput93_OptionsWithValues_h;
            CommandLineInput userInput = commandlineinput93;
            CommandLineInput commandlineinput104 = new CommandLineInput();
            Dictionary<String, String> commandlineinput104_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput104_OptionsWithValues_l = "abc.cgxml";
            commandlineinput104.OptionsWithValues = commandlineinput104_OptionsWithValues;
            commandlineinput104_OptionsWithValues["-l"] = commandlineinput104_OptionsWithValues_l;
            CommandLineInput xmlConfig = commandlineinput104;
            /* Act */
            StringBuilder actualResult = (StringBuilder)_target.GetType().GetMethod("checkExplicitOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Object actualResult_length_112 = typeof(StringBuilder).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_length_112);
        }
    }

    [TestMethod]
    public void checkExplicitOptionsTest_51_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput95 = new CommandLineInput();
            Dictionary<String, String> commandlineinput95_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput95_OptionsWithValues_h = "abc.cgxml";
            commandlineinput95.OptionsWithValues = commandlineinput95_OptionsWithValues;
            commandlineinput95_OptionsWithValues["-h"] = commandlineinput95_OptionsWithValues_h;
            CommandLineInput userInput = commandlineinput95;
            CommandLineInput commandlineinput106 = new CommandLineInput();
            Dictionary<String, String> commandlineinput106_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput106_OptionsWithValues_d = "abc.cgxml";
            commandlineinput106.OptionsWithValues = commandlineinput106_OptionsWithValues;
            commandlineinput106_OptionsWithValues["-d"] = commandlineinput106_OptionsWithValues_d;
            CommandLineInput xmlConfig = commandlineinput106;
            /* Act */
            StringBuilder actualResult = (StringBuilder)_target.GetType().GetMethod("checkExplicitOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Object actualResult_length_113 = typeof(StringBuilder).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_length_113);
        }
    }

    [TestMethod]
    public void checkExplicitOptionsTest_51_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput97 = new CommandLineInput();
            Dictionary<String, String> commandlineinput97_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput97_OptionsWithValues_ = null;
            commandlineinput97.OptionsWithValues = commandlineinput97_OptionsWithValues;
            commandlineinput97_OptionsWithValues[""] = commandlineinput97_OptionsWithValues_;
            CommandLineInput userInput = commandlineinput97;
            CommandLineInput commandlineinput108 = new CommandLineInput();
            Dictionary<String, String> commandlineinput108_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput108_OptionsWithValues_ = null;
            commandlineinput108.OptionsWithValues = commandlineinput108_OptionsWithValues;
            commandlineinput108_OptionsWithValues[""] = commandlineinput108_OptionsWithValues_;
            CommandLineInput xmlConfig = commandlineinput108;
            /* Act */
            StringBuilder actualResult = (StringBuilder)_target.GetType().GetMethod("checkExplicitOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Object actualResult_length_114 = typeof(StringBuilder).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)10, (Int32)actualResult_length_114);
        }
    }

    [TestMethod]
    public void checkExplicitOptionsTest_51_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput userInput = null;
            CommandLineInput xmlConfig = null;
            /* Act */
            StringBuilder actualResult = (StringBuilder)_target.GetType().GetMethod("checkExplicitOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Object actualResult_length_115 = typeof(StringBuilder).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_length_115);
        }
    }
}