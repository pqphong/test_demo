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
    public void filterValueVendorNameTest_64_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput91 = new CommandLineInput();
            Dictionary<String, String> commandlineinput91_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput91_OptionsWithValues_m = "as";
            commandlineinput91.OptionsWithValues = commandlineinput91_OptionsWithValues;
            commandlineinput91_OptionsWithValues["-m"] = commandlineinput91_OptionsWithValues_m;
            CommandLineInput userInputs = commandlineinput91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var userinterface125 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface125.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 32)
                    flag = 1;
                
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface125);
            /* Act */
            _target.GetType().GetMethod("filterValueVendorName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void filterValueVendorNameTest_64_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput95 = new CommandLineInput();
            Dictionary<String, String> commandlineinput95_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput95_OptionsWithValues_fr = "as";
            commandlineinput95.OptionsWithValues = commandlineinput95_OptionsWithValues;
            commandlineinput95_OptionsWithValues["-fr"] = commandlineinput95_OptionsWithValues_fr;
            CommandLineInput userInputs = commandlineinput95;
            Int32 int32106 = 0;
            Int32 flag = int32106;
            var userinterface126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface126.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 32)
                    flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface126);
            /* Act */
            _target.GetType().GetMethod("filterValueVendorName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void filterValueVendorNameTest_64_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput99 = new CommandLineInput();
            Dictionary<String, String> commandlineinput99_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput99_OptionsWithValues_fr = null;
            commandlineinput99.OptionsWithValues = commandlineinput99_OptionsWithValues;
            commandlineinput99_OptionsWithValues["-fr"] = commandlineinput99_OptionsWithValues_fr;
            CommandLineInput userInputs = commandlineinput99;
            Int32 int321010 = 0;
            Int32 flag = int321010;
            var userinterface127 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface127.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 32)
                    flag = 1;
                
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface127);
            /* Act */
            _target.GetType().GetMethod("filterValueVendorName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void filterValueVendorNameTest_64_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput913 = new CommandLineInput();
            Dictionary<String, String> commandlineinput913_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput913_OptionsWithValues_fr = "";
            commandlineinput913.OptionsWithValues = commandlineinput913_OptionsWithValues;
            commandlineinput913_OptionsWithValues["-fr"] = commandlineinput913_OptionsWithValues_fr;
            CommandLineInput userInputs = commandlineinput913;
            Int32 int321014 = 0;
            Int32 flag = int321014;
            var userinterface128 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface128.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 32)
                    flag = 1;
               
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface128);
            /* Act */
            _target.GetType().GetMethod("filterValueVendorName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void filterValueVendorNameTest_64_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput917 = new CommandLineInput();
            Dictionary<String, String> commandlineinput917_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput917_OptionsWithValues_filter = "as @";
            commandlineinput917.OptionsWithValues = commandlineinput917_OptionsWithValues;
            commandlineinput917_OptionsWithValues["-filter"] = commandlineinput917_OptionsWithValues_filter;
            CommandLineInput userInputs = commandlineinput917;
            Int32 int321018 = 0;
            Int32 flag = int321018;
            var userinterface129 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface129.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 32)
                    flag = 1;
                
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface129);
            /* Act */
            _target.GetType().GetMethod("filterValueVendorName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void filterValueVendorNameTest_64_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput921 = new CommandLineInput();
            Dictionary<String, String> commandlineinput921_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput921_OptionsWithValues_m = "@";
            commandlineinput921.OptionsWithValues = commandlineinput921_OptionsWithValues;
            commandlineinput921_OptionsWithValues["-m"] = commandlineinput921_OptionsWithValues_m;
            CommandLineInput userInputs = commandlineinput921;
            Int32 int321022 = 0;
            Int32 flag = int321022;
            var userinterface130 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface130.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 32)
                    flag = 1;
                
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface130);
            /* Act */
            _target.GetType().GetMethod("filterValueVendorName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}