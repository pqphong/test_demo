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
    public void PrintToolInfoTest_54_1()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe",
                    "-h",
                    "-v",
                    "-o",
                    "/",
                    "-m",
                    "can",
                    ""
                };
            };
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.displayToolVersion = (CommandLine instance) =>
            {

            };
            /* Arrange */
            Boolean boolean91 = true;
            Object runtimeconfiguration111 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("PrintHelp", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration111, boolean91);
            typeof(IRuntimeConfiguration).GetProperty("PrintToolVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration111, boolean91);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimConsoleWrapper.WriteLineString = (String value) =>
            {
                return;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface112 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface112.InfoErrorCodeInt32 = (Int32 errorcode) =>
            {
                return;
            }

            ;
            userinterface112.ExitInt32 = (code) =>
            {
                flag = 1;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface112);
            /* Act */
            _target.GetType().GetMethod("PrintToolInfo", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void PrintToolInfoTest_54_2()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe",
                    "-o",
                    "/",
                    "-m",
                    "can",
                    "-h",
                    "-v"
                };
            };
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.displayToolVersion = (CommandLine instance) =>
            {

            };
            /* Arrange */
            Boolean boolean96 = false;
            Object runtimeconfiguration113 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("PrintHelp", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration113, boolean96);
            typeof(IRuntimeConfiguration).GetProperty("PrintToolVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration113, boolean96);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimConsoleWrapper.WriteLineString = (String value) =>
            {
                return;
            }

            ;
            Int32 int32118 = 0;
            Int32 flag = int32118;
            var userinterface114 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface114.InfoErrorCodeInt32 = (Int32 errorcode) =>
            {
                return;
            }

            ;
            userinterface114.Exit = () =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface114);
            /* Act */
            _target.GetType().GetMethod("PrintToolInfo", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
        [TestMethod]
    public void PrintToolInfoTest_54_3()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe",
                    "-help",
                    "-version",
                    "-o",
                    "/",
                    "-m",
                    "can"
                };
            };
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.displayToolVersion = (CommandLine instance) =>
            {

            };
            /* Arrange */
            Boolean boolean91 = false;
            Object runtimeconfiguration111 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("PrintHelp", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration111, boolean91);
            typeof(IRuntimeConfiguration).GetProperty("PrintToolVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration111, boolean91);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimConsoleWrapper.WriteLineString = (String value) =>
            {
                return;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface112 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface112.InfoErrorCodeInt32 = (Int32 errorcode) =>
            {
                return;
            }

            ;
            userinterface112.ExitInt32 = (code) =>
            {
                flag = 1;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface112);
            /* Act */
            _target.GetType().GetMethod("PrintToolInfo", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void PrintToolInfoTest_54_4()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe",
                    "-o",
                    "/",
                    "-m",
                    "can"
                };
            };
            /* Arrange */
            Boolean boolean91 = false;
            Object runtimeconfiguration111 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("PrintHelp", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration111, boolean91);
            typeof(IRuntimeConfiguration).GetProperty("PrintToolVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration111, boolean91);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimConsoleWrapper.WriteLineString = (String value) =>
            {
                return;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface112 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface112.InfoErrorCodeInt32 = (Int32 errorcode) =>
            {
                return;
            }

            ;
            userinterface112.ExitInt32 = (code) =>
            {
                flag = 1;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface112);
            /* Act */
            _target.GetType().GetMethod("PrintToolInfo", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
    [TestMethod]
    public void PrintToolInfoTest_54_5()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe"
                };
            };
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.displayToolVersion = (CommandLine instance) =>
            {

            };
            /* Arrange */
            Boolean boolean91 = false;
            Object runtimeconfiguration111 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("PrintHelp", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration111, boolean91);
            typeof(IRuntimeConfiguration).GetProperty("PrintToolVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration111, boolean91);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimConsoleWrapper.WriteLineString = (String value) =>
            {
                return;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface112 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface112.InfoErrorCodeInt32 = (Int32 errorcode) =>
            {
                return;
            }

            ;
            userinterface112.ExitInt32 = (code) =>
            {
                flag = 1;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface112);
            /* Act */
            _target.GetType().GetMethod("PrintToolInfo", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }
}
