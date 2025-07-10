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
    public void GetAndValidateModuleNameTest_49_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            Int32 flag = int3291;
            var userinterface110 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface110.ErrorModuleNotFound = () =>
            {
                flag = 1;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface110);
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {
                String[] string113 = new String[3];
                String string113_0 = "MCALConfGen.exe";
                String string113_1 = "-m";
                String string113_2 = "can";
                string113[0] = string113_0;
                string113[1] = string113_1;
                string113[2] = string113_2;
                return string113;
            }

            ;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("GetAndValidateModuleName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"CAN", (String)actualResult);
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void GetAndValidateModuleNameTest_49_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3294 = 0;
            Int32 flag = int3294;
            var userinterface111 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface111.ErrorModuleNotFound = () =>
            {
                flag = 1;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface111);
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {
                String[] string116 = new String[3];
                String string116_0 = "MCALConfGen.exe";
                String string116_1 = "-m";
                String string116_2 = "nosupport";
                string116[0] = string116_0;
                string116[1] = string116_1;
                string116[2] = string116_2;
                return string116;
            }

            ;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("GetAndValidateModuleName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)null, (String)actualResult);
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void GetAndValidateModuleNameTest_49_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3297 = 0;
            Int32 flag = int3297;
            var userinterface112 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface112.ErrorModuleNotFound = () =>
            {
                flag = 1;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface112);
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {
                String[] string119 = new String[5];
                String string119_0 = "MCALConfGen.exe";
                String string119_1 = "-o";
                String string119_2 = "output";
                String string119_3 = "-m";
                String string119_4 = "fls";
                string119[0] = string119_0;
                string119[1] = string119_1;
                string119[2] = string119_2;
                string119[3] = string119_3;
                string119[4] = string119_4;
                return string119;
            }

            ;
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("GetAndValidateModuleName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"FLS", (String)actualResult);
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}