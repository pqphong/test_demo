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
    public void parseUserInputsTest_46_1()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe",
                     "-m",
                    "fls",
                    "-o",
                    "/",
                    "cdf/fls.arxml",
                    "cdf/mcu.arxml",
                    "-h",
                    "-fr",
                    "renesas  ",
                    "-c",
                    "-config",
                    "-o",
                    "/"
                };
            };
            /* Arrange */
            IRuntimeConfiguration iruntimeconfiguration91 = RuntimeConfiguration.Instance;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration91);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFileNameStringNullableOfInt32 = (String fileName, Nullable<Int32> exitCode) =>
            {
                String string102 = "fls.arxml";
                return string102;
            }

            ;
            /* Act */
            CommandLineInput actualResult = (CommandLineInput)_target.GetType().GetMethod("parseUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Object actualResult_optionswithvalues_111 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_111_o_212 = ((Dictionary<String, String>)actualResult_optionswithvalues_111)["-o"];
            Assert.AreEqual((String)"/", (String)actualResult_optionswithvalues_111_o_212);
        }
    }

    [TestMethod]
    public void parseUserInputsTest_46_2()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe",
                     "-m",
                    "fls",
                    "-o",
                    "/",
                    "cdf/fls",
                    "cdf/mcu.arxml",
                    "-o",
                    "-c"
                };
            };
            /* Arrange */
            IRuntimeConfiguration iruntimeconfiguration93 = RuntimeConfiguration.Instance;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration93);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFileNameStringNullableOfInt32 = (String fileName, Nullable<Int32> exitCode) =>
            {
                String string104 = "";
                return string104;
            }

            ;
            /* Act */
            CommandLineInput actualResult = (CommandLineInput)_target.GetType().GetMethod("parseUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Object actualResult_optionswithvalues_113 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_113_m_214 = ((Dictionary<String, String>)actualResult_optionswithvalues_113)["-m"];
            Assert.AreEqual((String)"fls", (String)actualResult_optionswithvalues_113_m_214);
        }
    }

    [TestMethod]
    public void parseUserInputsTest_46_3()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe",
                     "-m",
                    "fls",
                    "-o",
                    "/",
                    "cdf/fls.arxml",
                    "cdf/mcu.arxml",
                    "cdf/fls.arxml",
                    "cdf/fls_2.arxml",
                    "-o"

                };
            };
            /* Arrange */
            IRuntimeConfiguration iruntimeconfiguration95 = RuntimeConfiguration.Instance;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration95);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFileNameStringNullableOfInt32 = (String fileName, Nullable<Int32> exitCode) =>
            {
                String string106 = "fls.arxml";
                return string106;
            }

            ;
            /* Act */
            CommandLineInput actualResult = (CommandLineInput)_target.GetType().GetMethod("parseUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Object actualResult_optionswithvalues_115 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_115_m_216 = ((Dictionary<String, String>)actualResult_optionswithvalues_115)["-m"];
            Assert.AreEqual((String)"fls", (String)actualResult_optionswithvalues_115_m_216);
        }
    }

    [TestMethod]
    public void parseUserInputsTest_46_4()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe"
                };
            };
            /* Arrange */
            IRuntimeConfiguration iruntimeconfiguration97 = RuntimeConfiguration.Instance;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration97);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFileNameStringNullableOfInt32 = (String fileName, Nullable<Int32> exitCode) =>
            {
                String string108 = "fls.arxml";
                return string108;
            }

            ;
            /* Act */
            CommandLineInput actualResult = (CommandLineInput)_target.GetType().GetMethod("parseUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreNotEqual(null, actualResult);
        }
    }

    [TestMethod]
    public void parseUserInputsTest_46_5()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimEnvironment.GetCommandLineArgs = () =>
            {

                return new string[] {
                    "MCALConfgen.exe",
                     "-m",
                    "fls",
                    "-o",
                    "/",
                    "cdf/fls.arxml",
                    "cdf/mcu.arxml",
                    "cdf/fls.arxml",
                    "cdf/fls_2.arxml",
                    "-module",
                    "can"
                };
            };
            /* Arrange */
            IRuntimeConfiguration iruntimeconfiguration99 = RuntimeConfiguration.Instance;
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration99);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFileNameStringNullableOfInt32 = (String fileName, Nullable<Int32> exitCode) =>
            {
                String string1010 = "fls.arxml";
                return string1010;
            }

            ;
            /* Act */
            CommandLineInput actualResult = (CommandLineInput)_target.GetType().GetMethod("parseUserInputs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Object actualResult_optionswithvalues_117 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_117_m_218 = ((Dictionary<String, String>)actualResult_optionswithvalues_117)["-m"];
            Assert.AreEqual((String)"fls", (String)actualResult_optionswithvalues_117_m_218);
        }
    }
}