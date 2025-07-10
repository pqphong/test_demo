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
    public void checkInvalidOptionTest_53_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput91 = new CommandLineInput();
            Dictionary<String, String> commandlineinput91_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput91_OptionsWithValues_m = "sdf";
            String commandlineinput91_OptionsWithValues_l = "sdf";
            commandlineinput91.OptionsWithValues = commandlineinput91_OptionsWithValues;
            commandlineinput91_OptionsWithValues["-m"] = commandlineinput91_OptionsWithValues_m;
            commandlineinput91_OptionsWithValues["-l"] = commandlineinput91_OptionsWithValues_l;
            CommandLineInput userInputs = commandlineinput91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var userinterface126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface126.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            userinterface126.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 2;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface126);
            /* Act */
            _target.GetType().GetMethod("checkInvalidOption", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkInvalidOptionTest_53_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput96 = new CommandLineInput();
            Dictionary<String, String> commandlineinput96_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput96_OptionsWithValues_m = "sdf";
            String commandlineinput96_OptionsWithValues_k = "sdf";
            commandlineinput96.OptionsWithValues = commandlineinput96_OptionsWithValues;
            commandlineinput96_OptionsWithValues["-m"] = commandlineinput96_OptionsWithValues_m;
            commandlineinput96_OptionsWithValues["-k"] = commandlineinput96_OptionsWithValues_k;
            CommandLineInput userInputs = commandlineinput96;
            Int32 int32107 = 0;
            Int32 flag = int32107;
            var userinterface127 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface127.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            userinterface127.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 2;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface127);
            /* Act */
            _target.GetType().GetMethod("checkInvalidOption", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkInvalidOptionTest_53_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput911 = new CommandLineInput();
            Dictionary<String, String> commandlineinput911_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput911_OptionsWithValues_m = "sdf";
            String commandlineinput911_OptionsWithValues_k = "sdf";
            String commandlineinput911_OptionsWithValues_l = "sdf";
            commandlineinput911.OptionsWithValues = commandlineinput911_OptionsWithValues;
            commandlineinput911_OptionsWithValues["-m"] = commandlineinput911_OptionsWithValues_m;
            commandlineinput911_OptionsWithValues["-k"] = commandlineinput911_OptionsWithValues_k;
            commandlineinput911_OptionsWithValues["-l"] = commandlineinput911_OptionsWithValues_l;
            CommandLineInput userInputs = commandlineinput911;
            Int32 int321012 = 0;
            Int32 flag = int321012;
            var userinterface128 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface128.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            userinterface128.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 2;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface128);
            /* Act */
            _target.GetType().GetMethod("checkInvalidOption", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkInvalidOptionTest_53_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput916 = new CommandLineInput();
            Dictionary<String, String> commandlineinput916_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput916_OptionsWithValues_m = "sdf";
            String commandlineinput916_OptionsWithValues_l = "sdf";
            Dictionary<String, Int32> commandlineinput916_OptionsAppearances = new Dictionary<String, Int32>();
            Int32 commandlineinput916_OptionsAppearances_1 = 1;
            Int32 commandlineinput916_OptionsAppearances_2 = 2;
            commandlineinput916.OptionsWithValues = commandlineinput916_OptionsWithValues;
            commandlineinput916_OptionsWithValues["-m"] = commandlineinput916_OptionsWithValues_m;
            commandlineinput916_OptionsWithValues["-l"] = commandlineinput916_OptionsWithValues_l;
            commandlineinput916.OptionsAppearances = commandlineinput916_OptionsAppearances;
            commandlineinput916_OptionsAppearances["1"] = commandlineinput916_OptionsAppearances_1;
            commandlineinput916_OptionsAppearances["2"] = commandlineinput916_OptionsAppearances_2;
            CommandLineInput userInputs = commandlineinput916;
            Int32 int321017 = 0;
            Int32 flag = int321017;
            var userinterface129 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface129.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            userinterface129.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 2;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface129);
            /* Act */
            _target.GetType().GetMethod("checkInvalidOption", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)2, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkInvalidOptionTest_53_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput921 = new CommandLineInput();
            Dictionary<String, String> commandlineinput921_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput921_OptionsWithValues_m = "sdf";
            String commandlineinput921_OptionsWithValues_n = "sdf";
            Dictionary<String, Int32> commandlineinput921_OptionsAppearances = new Dictionary<String, Int32>();
            Int32 commandlineinput921_OptionsAppearances_1 = 1;
            commandlineinput921.OptionsWithValues = commandlineinput921_OptionsWithValues;
            commandlineinput921_OptionsWithValues["-m"] = commandlineinput921_OptionsWithValues_m;
            commandlineinput921_OptionsWithValues["-n"] = commandlineinput921_OptionsWithValues_n;
            commandlineinput921.OptionsAppearances = commandlineinput921_OptionsAppearances;
            commandlineinput921_OptionsAppearances["1"] = commandlineinput921_OptionsAppearances_1;
            CommandLineInput userInputs = commandlineinput921;
            Int32 int321022 = 0;
            Int32 flag = int321022;
            var userinterface130 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface130.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            userinterface130.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 2;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface130);
            /* Act */
            _target.GetType().GetMethod("checkInvalidOption", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }
}