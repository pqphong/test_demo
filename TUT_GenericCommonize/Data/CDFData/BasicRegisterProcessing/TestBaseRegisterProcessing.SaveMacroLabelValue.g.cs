using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestBaseRegisterProcessing
{
    [TestMethod]
    public void SaveMacroLabelValueTest_55_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "E2M_translation.h";
            String fileName = string91;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean102 = true;
                return boolean102;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.ReadAllLinesStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                String[] string113 = new String[2];
                String string113_0 = "#define RENESAS_P0                                  PORT0P00";
                String string113_1 = "#define RENESAS_P0                                  PORT0P00";
                string113[0] = string113_0;
                string113[1] = string113_1;
                return string113;
            }

            ;
            Int32 int32124 = 0;
            Int32 errorCode1 = int32124;
            var userinterface129 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface129.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface129.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface129);
            typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, new Dictionary<string, string>());
            /* Act */
            typeof(BaseRegisterProcessing).GetMethod("SaveMacroLabelValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{fileName});
            /* Assert */
            Object macrolabelvalue130 = typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object macrolabelvalue130_count_131 = macrolabelvalue130.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(macrolabelvalue130);
            Assert.AreEqual((Int32)0, (Int32)macrolabelvalue130_count_131);
            Assert.AreEqual((Int32)20, (Int32)errorCode1);
        }
    }

    [TestMethod]
    [ExpectedException(typeof(TargetInvocationException))]
    public void SaveMacroLabelValueTest_55_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string98 = "E2M_translation.h";
            String fileName = string98;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean109 = false;
                return boolean109;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.ReadAllLinesStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                String[] string1110 = new String[2];
                String string1110_0 = "#define RENESAS_P0                                  PORT0P00";
                String string1110_1 = "#define RENESAS_PSR0                                    PORT0PSR00";
                string1110[0] = string1110_0;
                string1110[1] = string1110_1;
                return string1110;
            }

            ;
            Int32 int321211 = 0;
            Int32 errorCode1 = int321211;
            var userinterface132 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface132.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface132.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface132);
            /* Act */
            typeof(BaseRegisterProcessing).GetMethod("SaveMacroLabelValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{fileName});
            /* Assert */
            Object macrolabelvalue133 = typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object macrolabelvalue133_count_134 = macrolabelvalue133.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(macrolabelvalue133);
            Assert.AreEqual((Int32)0, (Int32)macrolabelvalue133_count_134);
            Assert.AreEqual((Int32)1, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void SaveMacroLabelValueTest_55_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string915 = "E2M_translation.h";
            String fileName = string915;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1016 = true;
                return boolean1016;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.ReadAllLinesStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                String[] string1117 = new String[2];
                String string1117_0 = "#define RENESAS_P0                                  PORT0P00";
                String string1117_1 = "#define RENESAS_PSR0                                    PORT0PSR00";
                string1117[0] = string1117_0;
                string1117[1] = string1117_1;
                return string1117;
            }

            ;
            Int32 int321218 = 0;
            Int32 errorCode1 = int321218;
            var userinterface135 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface135.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface135.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface135);
            /* Act */
            typeof(BaseRegisterProcessing).GetMethod("SaveMacroLabelValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{fileName});
            /* Assert */
            Object macrolabelvalue136 = typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object macrolabelvalue136_count_137 = macrolabelvalue136.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(macrolabelvalue136);
            Assert.AreEqual((Int32)2, (Int32)macrolabelvalue136_count_137);
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void SaveMacroLabelValueTest_55_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string922 = "E2M_translation.h";
            String fileName = string922;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1023 = true;
                return boolean1023;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.ReadAllLinesStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                String[] string1124 = new String[3];
                String string1124_0 = "//#define RENESAS_PSR0                                    PORT0PSR00";
                String string1124_1 = "/*#define RENESAS_PSR0                                    PORT0PSR00*/";
                String string1124_2 = "#define RENESAS_PSR0";
                string1124[0] = string1124_0;
                string1124[1] = string1124_1;
                string1124[2] = string1124_2;
                return string1124;
            }

            ;
            Int32 int321225 = 0;
            Int32 errorCode1 = int321225;
            var userinterface138 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface138.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface138.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface138);
            /* Act */
            typeof(BaseRegisterProcessing).GetMethod("SaveMacroLabelValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{fileName});
            /* Assert */
            Object macrolabelvalue139 = typeof(BaseRegisterProcessing).GetField("macroLabelValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object macrolabelvalue139_count_140 = macrolabelvalue139.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(macrolabelvalue139);
            Assert.AreEqual((Int32)1, (Int32)macrolabelvalue139_count_140);
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }
}