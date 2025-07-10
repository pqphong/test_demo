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
    public void validateUserInputsTest_63_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput91 = null;
            CommandLineInput userInputs = commandlineinput91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkInvalidOptionCommandLineInput = (CommandLine instance, CommandLineInput _userInputs) =>
            {
                flag = 1;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateUserInputsTest_63_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput94 = new CommandLineInput();
            Dictionary<String, String> commandlineinput94_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput94_OptionsWithValues_h = "abc.cgxml";
            commandlineinput94.OptionsWithValues = commandlineinput94_OptionsWithValues;
            commandlineinput94_OptionsWithValues["-h"] = commandlineinput94_OptionsWithValues_h;
            CommandLineInput userInputs = commandlineinput94;
            Int32 int32105 = 0;
            Int32 flag = int32105;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkInvalidOptionCommandLineInput = (CommandLine instance, CommandLineInput _userInputs) =>
            {
                flag = 1;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateUserInputsTest_63_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput97 = new CommandLineInput();
            Dictionary<String, String> commandlineinput97_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput97_OptionsWithValues_h = null;
            commandlineinput97.OptionsWithValues = commandlineinput97_OptionsWithValues;
            commandlineinput97_OptionsWithValues["-h"] = commandlineinput97_OptionsWithValues_h;
            CommandLineInput userInputs = commandlineinput97;
            Int32 int32108 = 0;
            Int32 flag = int32108;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkInvalidOptionCommandLineInput = (CommandLine instance, CommandLineInput _userInputs) =>
            {
                flag = 1;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateUserInputsTest_63_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput910 = new CommandLineInput();
            Dictionary<String, String> commandlineinput910_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput910_OptionsWithValues_m = "";
            commandlineinput910.OptionsWithValues = commandlineinput910_OptionsWithValues;
            commandlineinput910_OptionsWithValues["-m"] = commandlineinput910_OptionsWithValues_m;
            CommandLineInput userInputs = commandlineinput910;
            Int32 int321011 = 0;
            Int32 flag = int321011;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkInvalidOptionCommandLineInput = (CommandLine instance, CommandLineInput _userInputs) =>
            {
                flag = 1;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateUserInputsTest_63_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput913 = new CommandLineInput();
            Dictionary<String, String> commandlineinput913_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput913_OptionsWithValues_ = "";
            commandlineinput913.OptionsWithValues = commandlineinput913_OptionsWithValues;
            commandlineinput913_OptionsWithValues[""] = commandlineinput913_OptionsWithValues_;
            CommandLineInput userInputs = commandlineinput913;
            Int32 int321014 = 0;
            Int32 flag = int321014;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.checkInvalidOptionCommandLineInput = (CommandLine instance, CommandLineInput _userInputs) =>
            {
                flag = 1;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("validateUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }
}