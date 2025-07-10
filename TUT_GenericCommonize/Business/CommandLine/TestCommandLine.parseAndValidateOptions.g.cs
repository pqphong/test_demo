using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestCommandLine
{
    [TestMethod]
    public void parseAndValidateOptionsTest_47_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var runtimeconfiguration119 = new Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.StubIRuntimeConfiguration();
            runtimeconfiguration119.SetDefaultOptionsValueIBasicConfiguration = (IBasicConfiguration basicConfiguration) =>
            {
                return;
            }

            ;
            runtimeconfiguration119.OverrideCurrentConfigsByDictionaryOfStringStringListOfString = (Dictionary<String, String> options, List<String> filePaths) =>
            {
                return;
            }

            ;
            runtimeconfiguration119.OverrideCurrentConfigsByDictionaryOfStringStringListOfString = (Dictionary<String, String> options, List<String> filePaths) =>
            {
                return;
            }

            ;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, runtimeconfiguration119);
            IRuntimeConfiguration iruntimeconfiguration102 = RuntimeConfiguration.Instance;
            Boolean iruntimeconfiguration102_PrintHelp = false;
            iruntimeconfiguration102.PrintHelp = iruntimeconfiguration102_PrintHelp;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration102);
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.parseUserInputs = (CommandLine instance) =>
            {
                CommandLineInput commandlineinput113 = new CommandLineInput();
                Dictionary<String, String> commandlineinput113_OptionsWithValues = new Dictionary<String, String>();
                String commandlineinput113_OptionsWithValues_c = "not empty";
                String commandlineinput113_OptionsWithValues_o = "not empty";
                commandlineinput113.OptionsWithValues = commandlineinput113_OptionsWithValues;
                commandlineinput113_OptionsWithValues["-c"] = commandlineinput113_OptionsWithValues_c;
                commandlineinput113_OptionsWithValues["-o"] = commandlineinput113_OptionsWithValues_o;
                return commandlineinput113;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.validateUserInputsCommandLineInput = (CommandLine instance, CommandLineInput userInputs) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.validateXmlConfigStringCommandLineInput = (CommandLine instance, String xmlConfigFile, CommandLineInput xmlConfig) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.parseXmlConfigString = (CommandLine instance, String path) =>
            {
                CommandLineInput commandlineinput146 = new CommandLineInput();
                Dictionary<String, String> commandlineinput146_OptionsWithValues = new Dictionary<String, String>();
                String commandlineinput146_OptionsWithValues_c = "not empty";
                String commandlineinput146_OptionsWithValues_o = "not empty";
                String commandlineinput146_OptionsWithValues_h = "TRUE";
                commandlineinput146.OptionsWithValues = commandlineinput146_OptionsWithValues;
                commandlineinput146_OptionsWithValues["-c"] = commandlineinput146_OptionsWithValues_c;
                commandlineinput146_OptionsWithValues["-o"] = commandlineinput146_OptionsWithValues_o;
                commandlineinput146_OptionsWithValues["-h"] = commandlineinput146_OptionsWithValues_h;
                return commandlineinput146;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.validateBothUserAndXmlInputsCommandLineInputCommandLineInput = (CommandLine instance, CommandLineInput userInput, CommandLineInput xmlConfig) =>
            {
                return;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("parseAndValidateOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object runtimeconfiguration120 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object runtimeconfiguration120_printhelp_121 = typeof(IRuntimeConfiguration).GetProperty("PrintHelp", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(runtimeconfiguration120);
            Assert.AreEqual((Boolean)true, (Boolean)runtimeconfiguration120_printhelp_121);
        }
    }

    [TestMethod]
    public void parseAndValidateOptionsTest_47_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var runtimeconfiguration122 = new Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.StubIRuntimeConfiguration();
            runtimeconfiguration122.SetDefaultOptionsValueIBasicConfiguration = (IBasicConfiguration basicConfiguration) =>
            {
                return;
            }

            ;
            runtimeconfiguration122.OverrideCurrentConfigsByDictionaryOfStringStringListOfString = (Dictionary<String, String> options, List<String> filePaths) =>
            {
                return;
            }

            ;
            runtimeconfiguration122.OverrideCurrentConfigsByDictionaryOfStringStringListOfString = (Dictionary<String, String> options, List<String> filePaths) =>
            {
                return;
            }

            ;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, runtimeconfiguration122);
            IRuntimeConfiguration iruntimeconfiguration1011 = RuntimeConfiguration.Instance;
            Boolean iruntimeconfiguration1011_PrintHelp = false;
            iruntimeconfiguration1011.PrintHelp = iruntimeconfiguration1011_PrintHelp;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration1011);
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.parseUserInputs = (CommandLine instance) =>
            {
                CommandLineInput commandlineinput1112 = new CommandLineInput();
                Dictionary<String, String> commandlineinput1112_OptionsWithValues = new Dictionary<String, String>();
                String commandlineinput1112_OptionsWithValues_c = "";
                String commandlineinput1112_OptionsWithValues_o = "";
                commandlineinput1112.OptionsWithValues = commandlineinput1112_OptionsWithValues;
                commandlineinput1112_OptionsWithValues["-c"] = commandlineinput1112_OptionsWithValues_c;
                commandlineinput1112_OptionsWithValues["-o"] = commandlineinput1112_OptionsWithValues_o;
                return commandlineinput1112;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.validateUserInputsCommandLineInput = (CommandLine instance, CommandLineInput userInputs) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.validateXmlConfigStringCommandLineInput = (CommandLine instance, String xmlConfigFile, CommandLineInput xmlConfig) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.parseXmlConfigString = (CommandLine instance, String path) =>
            {
                CommandLineInput commandlineinput1415 = new CommandLineInput();
                Dictionary<String, String> commandlineinput1415_OptionsWithValues = new Dictionary<String, String>();
                String commandlineinput1415_OptionsWithValues_c = "";
                String commandlineinput1415_OptionsWithValues_o = "";
                String commandlineinput1415_OptionsWithValues_h = "FALSE";
                commandlineinput1415.OptionsWithValues = commandlineinput1415_OptionsWithValues;
                commandlineinput1415_OptionsWithValues["-c"] = commandlineinput1415_OptionsWithValues_c;
                commandlineinput1415_OptionsWithValues["-o"] = commandlineinput1415_OptionsWithValues_o;
                commandlineinput1415_OptionsWithValues["-h"] = commandlineinput1415_OptionsWithValues_h;
                return commandlineinput1415;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.validateBothUserAndXmlInputsCommandLineInputCommandLineInput = (CommandLine instance, CommandLineInput userInput, CommandLineInput xmlConfig) =>
            {
                return;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("parseAndValidateOptions", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object runtimeconfiguration123 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object runtimeconfiguration123_printhelp_124 = typeof(IRuntimeConfiguration).GetProperty("PrintHelp", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(runtimeconfiguration123);
            Assert.AreEqual((Boolean)false, (Boolean)runtimeconfiguration123_printhelp_124);
        }
    }
}