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
    public void checkOutputDirectoryTest_50_1()
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
            var userinterface131 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface131.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 5)
                    flag = 1;
                else
                    flag = 2;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface131);
            Renesas.Generator.MCALConfGen.CrossCutting.Util.Fakes.ShimStringUtils.IsInvalidNameString = (String name) =>
            {
                Boolean boolean135 = false;
                return boolean135;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("checkOutputDirectory", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkOutputDirectoryTest_50_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput96 = new CommandLineInput();
            Dictionary<String, String> commandlineinput96_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput96_OptionsWithValues_o = "as";
            commandlineinput96.OptionsWithValues = commandlineinput96_OptionsWithValues;
            commandlineinput96_OptionsWithValues["-o"] = commandlineinput96_OptionsWithValues_o;
            CommandLineInput userInputs = commandlineinput96;
            Int32 int32107 = 0;
            Int32 flag = int32107;
            var userinterface132 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface132.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 5)
                    flag = 1;
                else
                    flag = 2;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface132);
            Renesas.Generator.MCALConfGen.CrossCutting.Util.Fakes.ShimStringUtils.IsInvalidNameString = (String name) =>
            {
                Boolean boolean1310 = false;
                return boolean1310;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("checkOutputDirectory", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkOutputDirectoryTest_50_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput911 = new CommandLineInput();
            Dictionary<String, String> commandlineinput911_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput911_OptionsWithValues_oinc = "";
            commandlineinput911.OptionsWithValues = commandlineinput911_OptionsWithValues;
            commandlineinput911_OptionsWithValues["-oinc"] = commandlineinput911_OptionsWithValues_oinc;
            CommandLineInput userInputs = commandlineinput911;
            Int32 int321012 = 0;
            Int32 flag = int321012;
            var userinterface133 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface133.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 5)
                    flag = 1;
                else
                    flag = 2;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface133);
            Renesas.Generator.MCALConfGen.CrossCutting.Util.Fakes.ShimStringUtils.IsInvalidNameString = (String name) =>
            {
                Boolean boolean1315 = false;
                return boolean1315;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("checkOutputDirectory", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkOutputDirectoryTest_50_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput916 = new CommandLineInput();
            Dictionary<String, String> commandlineinput916_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput916_OptionsWithValues_oinc = null;
            commandlineinput916.OptionsWithValues = commandlineinput916_OptionsWithValues;
            commandlineinput916_OptionsWithValues["-oinc"] = commandlineinput916_OptionsWithValues_oinc;
            CommandLineInput userInputs = commandlineinput916;
            Int32 int321017 = 0;
            Int32 flag = int321017;
            var userinterface134 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface134.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 5)
                    flag = 1;
                else
                    flag = 2;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface134);
            Renesas.Generator.MCALConfGen.CrossCutting.Util.Fakes.ShimStringUtils.IsInvalidNameString = (String name) =>
            {
                Boolean boolean1320 = false;
                return boolean1320;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("checkOutputDirectory", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkOutputDirectoryTest_50_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput921 = new CommandLineInput();
            Dictionary<String, String> commandlineinput921_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput921_OptionsWithValues_oinc = "\\as";
            commandlineinput921.OptionsWithValues = commandlineinput921_OptionsWithValues;
            commandlineinput921_OptionsWithValues["-oinc"] = commandlineinput921_OptionsWithValues_oinc;
            CommandLineInput userInputs = commandlineinput921;
            Int32 int321022 = 0;
            Int32 flag = int321022;
            var userinterface135 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface135.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 5)
                    flag = 1;
                else
                    flag = 2;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface135);
            Renesas.Generator.MCALConfGen.CrossCutting.Util.Fakes.ShimStringUtils.IsInvalidNameString = (String name) =>
            {
                Boolean boolean1325 = true;
                return boolean1325;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("checkOutputDirectory", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)2, (Int32)flag);
        }
    }

    [TestMethod]
    public void checkOutputDirectoryTest_50_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            CommandLineInput commandlineinput926 = new CommandLineInput();
            Dictionary<String, String> commandlineinput926_OptionsWithValues = new Dictionary<String, String>();
            String commandlineinput926_OptionsWithValues_oinc = null;
            commandlineinput926.OptionsWithValues = commandlineinput926_OptionsWithValues;
            commandlineinput926_OptionsWithValues["-oinc"] = commandlineinput926_OptionsWithValues_oinc;
            CommandLineInput userInputs = commandlineinput926;
            Int32 int321027 = 0;
            Int32 flag = int321027;
            var userinterface136 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface136.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                if (errorCode == 5)
                    flag = 1;
                else
                    flag = 2;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface136);
            Renesas.Generator.MCALConfGen.CrossCutting.Util.Fakes.ShimStringUtils.IsInvalidNameString = (String name) =>
            {
                Boolean boolean1330 = true;
                return boolean1330;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("checkOutputDirectory", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(CommandLineInput)}, null).Invoke(_target, new object[]{userInputs});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }
}