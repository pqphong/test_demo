using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestCommandLine
{
    [TestMethod]
    public void showInvalidInputPathTest_56_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list91 = new List<String>();
            Object runtimeconfiguration125 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("CDFFilePaths", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration125, list91);
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var userinterface126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface126.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            userinterface126.Exit = () =>
            {
                return;
            }

            ;
            userinterface126.ErrorFileNotFoundString = (String fileName) =>
            {
                flag = 2;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface126);
            String string135 = "can.cfgxml";
            Object runtimeconfiguration127 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("ConfigFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration127, string135);
            String string146 = "can.trxml";
            Object runtimeconfiguration128 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration128, string146);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean157 = true;
                return boolean157;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidInputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void showInvalidInputPathTest_56_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list99 = new List<String>();
            String list99_0 = "cdf1.arxml";
            String list99_1 = "cdf2.arxml";
            list99.Add(list99_0);
            list99.Add(list99_1);
            Object runtimeconfiguration129 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("CDFFilePaths", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration129, list99);
            Int32 int321010 = 0;
            Int32 flag = int321010;
            var userinterface130 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface130.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            userinterface130.Exit = () =>
            {
                return;
            }

            ;
            userinterface130.ErrorFileNotFoundString = (String fileName) =>
            {
                flag = 2;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface130);
            String string1313 = "can.cfgxml";
            Object runtimeconfiguration131 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("ConfigFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration131, string1313);
            String string1414 = "can.trxml";
            Object runtimeconfiguration132 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration132, string1414);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1515 = false;
                return boolean1515;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidInputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)2, (Int32)flag);
        }
    }

    [TestMethod]
    public void showInvalidInputPathTest_56_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list917 = new List<String>();
            String list917_0 = "cdf1.arxml";
            String list917_1 = "cdf2.arxml";
            list917.Add(list917_0);
            list917.Add(list917_1);
            Object runtimeconfiguration133 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("CDFFilePaths", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration133, list917);
            Int32 int321018 = 0;
            Int32 flag = int321018;
            var userinterface134 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface134.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            userinterface134.Exit = () =>
            {
                return;
            }

            ;
            userinterface134.ErrorFileNotFoundString = (String fileName) =>
            {
                flag = 2;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface134);
            String string1321 = "can.cfgxml";
            Object runtimeconfiguration135 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("ConfigFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration135, string1321);
            String string1422 = "can.trxml";
            Object runtimeconfiguration136 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration136, string1422);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1523 = true;
                return boolean1523;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidInputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}