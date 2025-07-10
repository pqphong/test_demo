using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;

public partial class TestCommandLine
{
    [TestMethod]
    public void validateBothUserAndXmlInputsTest_52_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput91 = null;
            CommandLineInput userInput = commandlineinput91;
            CommandLineInput commandlineinput102 = null;
            CommandLineInput xmlConfig = commandlineinput102;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface129 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface129.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            userinterface129.InfoInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            userinterface129.Exit = () =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface129);
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkExplicitOptionsCommandLineInputCommandLineInput = (CommandLine instance, CommandLineInput _userInput, CommandLineInput _xmlConfig) =>
            {
                return new StringBuilder("");
                ;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateBothUserAndXmlInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateBothUserAndXmlInputsTest_52_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput98 = new CommandLineInput();
            Dictionary<String, String> commandlineinput98_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput98_OptionsWithValues_m = "can";
            String commandlineinput98_OptionsWithValues_o = "/";
            List<String> commandlineinput98_Files = new List<String>();
            commandlineinput98.OptionsWithValues = commandlineinput98_OptionsWithValues;
            commandlineinput98_OptionsWithValues["-m"] = commandlineinput98_OptionsWithValues_m;
            commandlineinput98_OptionsWithValues["-o"] = commandlineinput98_OptionsWithValues_o;
            commandlineinput98.Files = commandlineinput98_Files;
            CommandLineInput userInput = commandlineinput98;
            CommandLineInput commandlineinput109 = new CommandLineInput();
            Dictionary<String, String> commandlineinput109_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput109_OptionsWithValues_m = "/";
            String commandlineinput109_OptionsWithValues_c = "can.cfgxml";
            List<String> commandlineinput109_Files = new List<String>();
            commandlineinput109.OptionsWithValues = commandlineinput109_OptionsWithValues;
            commandlineinput109_OptionsWithValues["-m"] = commandlineinput109_OptionsWithValues_m;
            commandlineinput109_OptionsWithValues["-c"] = commandlineinput109_OptionsWithValues_c;
            commandlineinput109.Files = commandlineinput109_Files;
            CommandLineInput xmlConfig = commandlineinput109;
            Int32 int321110 = 0;
            Int32 flag = int321110;
            var userinterface130 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface130.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            userinterface130.InfoInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            userinterface130.Exit = () =>
            {
                return;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface130);
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkExplicitOptionsCommandLineInputCommandLineInput = (CommandLine instance, CommandLineInput _userInput, CommandLineInput _xmlConfig) =>
            {
                return new StringBuilder("Options <-h> should be set explicitly by command line options and configuration file.");
                ;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateBothUserAndXmlInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateBothUserAndXmlInputsTest_52_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput915 = new CommandLineInput();
            Dictionary<String, String> commandlineinput915_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput915_OptionsWithValues_module = "can";
            String commandlineinput915_OptionsWithValues_o = "/";
            List<String> commandlineinput915_Files = new List<String>();
            String commandlineinput915_Files_0 = null;
            commandlineinput915.OptionsWithValues = commandlineinput915_OptionsWithValues;
            commandlineinput915_OptionsWithValues["-module"] = commandlineinput915_OptionsWithValues_module;
            commandlineinput915_OptionsWithValues["-o"] = commandlineinput915_OptionsWithValues_o;
            commandlineinput915.Files = commandlineinput915_Files;
            commandlineinput915_Files.Add(commandlineinput915_Files_0);
            CommandLineInput userInput = commandlineinput915;
            CommandLineInput commandlineinput1016 = new CommandLineInput();
            Dictionary<String, String> commandlineinput1016_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput1016_OptionsWithValues_module = "can";
            String commandlineinput1016_OptionsWithValues_c = "can.cfgxml";
            List<String> commandlineinput1016_Files = new List<String>();
            String commandlineinput1016_Files_0 = null;
            commandlineinput1016.OptionsWithValues = commandlineinput1016_OptionsWithValues;
            commandlineinput1016_OptionsWithValues["-module"] = commandlineinput1016_OptionsWithValues_module;
            commandlineinput1016_OptionsWithValues["-c"] = commandlineinput1016_OptionsWithValues_c;
            commandlineinput1016.Files = commandlineinput1016_Files;
            commandlineinput1016_Files.Add(commandlineinput1016_Files_0);
            CommandLineInput xmlConfig = commandlineinput1016;
            Int32 int321117 = 0;
            Int32 flag = int321117;
            var userinterface131 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface131.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            userinterface131.InfoInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            userinterface131.Exit = () =>
            {
                return;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface131);
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkExplicitOptionsCommandLineInputCommandLineInput = (CommandLine instance, CommandLineInput _userInput, CommandLineInput _xmlConfig) =>
            {
                return new StringBuilder("Options <-h> should be set explicitly by command line options and configuration file.");
                ;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateBothUserAndXmlInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateBothUserAndXmlInputsTest_52_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput922 = new CommandLineInput();
            List<String> commandlineinput922_Files = new List<String>();
            String commandlineinput922_Files_0 = null;
            commandlineinput922.Files = commandlineinput922_Files;
            commandlineinput922_Files.Add(commandlineinput922_Files_0);
            CommandLineInput userInput = commandlineinput922;
            CommandLineInput commandlineinput1023 = new CommandLineInput();
            List<String> commandlineinput1023_Files = new List<String>();
            String commandlineinput1023_Files_0 = null;
            commandlineinput1023.Files = commandlineinput1023_Files;
            commandlineinput1023_Files.Add(commandlineinput1023_Files_0);
            CommandLineInput xmlConfig = commandlineinput1023;
            Int32 int321124 = 0;
            Int32 flag = int321124;
            var userinterface132 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface132.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            userinterface132.InfoInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                return;
            }

            ;
            userinterface132.Exit = () =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface132);
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkExplicitOptionsCommandLineInputCommandLineInput = (CommandLine instance, CommandLineInput _userInput, CommandLineInput _xmlConfig) =>
            {
                return new StringBuilder("");
                ;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateBothUserAndXmlInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput), typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInput, xmlConfig});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}