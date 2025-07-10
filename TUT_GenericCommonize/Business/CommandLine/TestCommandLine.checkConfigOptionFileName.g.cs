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
    public void checkConfigOptionFileNameTest_65_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput91 = new CommandLineInput();
            Dictionary<String, String> commandlineinput91_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput91_OptionsWithValues_c = "abc.cgxml";
            commandlineinput91.OptionsWithValues = commandlineinput91_OptionsWithValues;
            commandlineinput91_OptionsWithValues["-c"] = commandlineinput91_OptionsWithValues_c;
            CommandLineInput userInputs = commandlineinput91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var userinterface121 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface121.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface121);
            /* Act */
            _target.GetType().GetMethod("checkConfigOptionFileName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkConfigOptionFileNameTest_65_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput95 = new CommandLineInput();
            Dictionary<String, String> commandlineinput95_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput95_OptionsWithValues_c = "";
            commandlineinput95.OptionsWithValues = commandlineinput95_OptionsWithValues;
            commandlineinput95_OptionsWithValues["-c"] = commandlineinput95_OptionsWithValues_c;
            CommandLineInput userInputs = commandlineinput95;
            Int32 int32106 = 0;
            Int32 flag = int32106;
            var userinterface122 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface122.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface122);
            /* Act */
            _target.GetType().GetMethod("checkConfigOptionFileName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkConfigOptionFileNameTest_65_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput99 = new CommandLineInput();
            Dictionary<String, String> commandlineinput99_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput99_OptionsWithValues_c = null;
            commandlineinput99.OptionsWithValues = commandlineinput99_OptionsWithValues;
            commandlineinput99_OptionsWithValues["-c"] = commandlineinput99_OptionsWithValues_c;
            CommandLineInput userInputs = commandlineinput99;
            Int32 int321010 = 0;
            Int32 flag = int321010;
            var userinterface123 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface123.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface123);
            /* Act */
            _target.GetType().GetMethod("checkConfigOptionFileName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkConfigOptionFileNameTest_65_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput913 = new CommandLineInput();
            Dictionary<String, String> commandlineinput913_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput913_OptionsWithValues_configfile = "abc.cgxml";
            commandlineinput913.OptionsWithValues = commandlineinput913_OptionsWithValues;
            commandlineinput913_OptionsWithValues["-configfile"] = commandlineinput913_OptionsWithValues_configfile;
            CommandLineInput userInputs = commandlineinput913;
            Int32 int321014 = 0;
            Int32 flag = int321014;
            var userinterface124 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface124.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface124);
            /* Act */
            _target.GetType().GetMethod("checkConfigOptionFileName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkConfigOptionFileNameTest_65_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput917 = new CommandLineInput();
            Dictionary<String, String> commandlineinput917_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput917_OptionsWithValues_configfile = null;
            commandlineinput917.OptionsWithValues = commandlineinput917_OptionsWithValues;
            commandlineinput917_OptionsWithValues["-configfile"] = commandlineinput917_OptionsWithValues_configfile;
            CommandLineInput userInputs = commandlineinput917;
            Int32 int321018 = 0;
            Int32 flag = int321018;
            var userinterface125 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface125.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface125);
            /* Act */
            _target.GetType().GetMethod("checkConfigOptionFileName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }
}