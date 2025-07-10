using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;

public partial class TestCommandLine
{
    [TestMethod]
    public void validateXmlConfigTest_60_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = null;
            String xmlConfigFile = string91;
            CommandLineInput commandlineinput102 = new CommandLineInput();
            Dictionary<String, String> commandlineinput102_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput102_OptionsWithValues_h = "can.cfgxml";
            commandlineinput102.OptionsWithValues = commandlineinput102_OptionsWithValues;
            commandlineinput102_OptionsWithValues["-c"] = commandlineinput102_OptionsWithValues_h;
            CommandLineInput xmlConfig = commandlineinput102;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface126.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface126);
            /* Act */
            _target.GetType().GetMethod("validateXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{xmlConfigFile, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateXmlConfigTest_60_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = null;
            String xmlConfigFile = string96;
            CommandLineInput commandlineinput107 = new CommandLineInput();
            Dictionary<String, String> commandlineinput107_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput107_OptionsWithValues_o = "./";
            commandlineinput107.OptionsWithValues = commandlineinput107_OptionsWithValues;
            commandlineinput107_OptionsWithValues["-o"] = commandlineinput107_OptionsWithValues_o;
            CommandLineInput xmlConfig = commandlineinput107;
            Int32 int32118 = 0;
            Int32 flag = int32118;
            var userinterface127 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface127.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface127);
            /* Act */
            _target.GetType().GetMethod("validateXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{xmlConfigFile, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateXmlConfigTest_60_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = null;
            String xmlConfigFile = string911;
            CommandLineInput commandlineinput1012 = new CommandLineInput();
            Dictionary<String, String> commandlineinput1012_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput1012_OptionsWithValues_o = null;
            commandlineinput1012.OptionsWithValues = commandlineinput1012_OptionsWithValues;
            commandlineinput1012_OptionsWithValues["-o"] = commandlineinput1012_OptionsWithValues_o;
            CommandLineInput xmlConfig = commandlineinput1012;
            Int32 int321113 = 0;
            Int32 flag = int321113;
            var userinterface128 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface128.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface128);
            /* Act */
            _target.GetType().GetMethod("validateXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{xmlConfigFile, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateXmlConfigTest_60_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string916 = null;
            String xmlConfigFile = string916;
            CommandLineInput commandlineinput1017 = null;
            CommandLineInput xmlConfig = commandlineinput1017;
            Int32 int321118 = 0;
            Int32 flag = int321118;
            var userinterface129 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface129.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface129);
            /* Act */
            _target.GetType().GetMethod("validateXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{xmlConfigFile, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateXmlConfigTest_60_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string921 = "fasdf";
            String xmlConfigFile = string921;
            CommandLineInput commandlineinput1022 = new CommandLineInput();
            Dictionary<String, String> commandlineinput1022_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput1022_OptionsWithValues_h = "can.cfgxml";
            commandlineinput1022.OptionsWithValues = commandlineinput1022_OptionsWithValues;
            commandlineinput1022_OptionsWithValues["-c"] = commandlineinput1022_OptionsWithValues_h;
            CommandLineInput xmlConfig = commandlineinput1022;
            Int32 int321123 = 0;
            Int32 flag = int321123;
            var userinterface130 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface130.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface130);
            /* Act */
            _target.GetType().GetMethod("validateXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{xmlConfigFile, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}