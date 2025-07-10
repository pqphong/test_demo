using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestBaseRegisterProcessing
{
    [TestMethod]
    public void SaveMacroAddressValueTest_54_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9179 = "dr7f701270_0_034.h dr7f701270_0_045.h";
            String filesInput = string9179;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean10180 = true;
                return boolean10180;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.ReadLinesStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                String[] string11181 = new String[4];
                String string11181_0 = "__IOREG";
                String string11181_1 = "__IOREG( PORTPMC1                                                       , 0xffc10054ul,  __READ_WRITE, u16_T);";
                String string11181_2 = "__IOREG( PORTPFC1                                                       , 0xffc10058ul,  __READ_WRITE, u16_T);";
                String string11181_3 = "__IOREG( PORTPFCE1                                                      , 0xffc1005cul,  __READ_WRITE, u16_T);";
                string11181[0] = string11181_0;
                string11181[1] = string11181_1;
                string11181[2] = string11181_2;
                string11181[3] = string11181_3;
                return string11181;
            }

            ;
            Int32 int3212182 = 0;
            Int32 errorCode1 = int3212182;
            var userinterface1518 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface1518.ErrorFileNotFoundString = (String fileName) =>
            {
                return;
            }

            ;
            userinterface1518.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface1518.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface1518);
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, new Dictionary<string,string>());
            
            /* Act */
            typeof(BaseRegisterProcessing).GetMethod("SaveMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{filesInput});
            /* Assert */
            Object macroaddressvalue1519 = typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object macroaddressvalue1519_count_1520 = macroaddressvalue1519.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(macroaddressvalue1519);
            Assert.AreEqual((Int32)0, (Int32)macroaddressvalue1519_count_1520);
            Assert.AreEqual((Int32)37, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void SaveMacroAddressValueTest_54_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9186 = "dr7f701270_0_034.h";
            String filesInput = string9186;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean10187 = true;
                return boolean10187;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.ReadLinesStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                String[] string11188 = new String[4];
                String string11188_0 = "__SUSU( PORTPM1                                                        , 0xffc10050ul,  __READ_WRITE, u16_T);";
                String string11188_1 = "__IOREG( PORTPMC1                                                       , 0xffc10054ul,  __READ_WRITE, u16_T);";
                String string11188_2 = "__IOREG( PORTPFC1                                                       , 0xffc10058ul,  __READ_WRITE, u16_T);";
                String string11188_3 = "__IOREG( PORTPFCE1                                                      , 0xffc1005cul,  __READ_WRITE, u16_T);";
                string11188[0] = string11188_0;
                string11188[1] = string11188_1;
                string11188[2] = string11188_2;
                string11188[3] = string11188_3;
                return string11188;
            }

            ;
            Int32 int3212189 = 0;
            Int32 errorCode1 = int3212189;
            var userinterface1521 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface1521.ErrorFileNotFoundString = (String fileName) =>
            {
                return;
            }

            ;
            userinterface1521.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface1521.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface1521);
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, new Dictionary<string, string>());
            /* Act */
            typeof(BaseRegisterProcessing).GetMethod("SaveMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{filesInput});
            /* Assert */
            Object macroaddressvalue1522 = typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object macroaddressvalue1522_count_1523 = macroaddressvalue1522.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(macroaddressvalue1522);
            Assert.AreEqual((Int32)3, (Int32)macroaddressvalue1522_count_1523);
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void SaveMacroAddressValueTest_54_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9193 = "dr7f701270_0_034.h";
            String filesInput = string9193;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean10194 = true;
                return boolean10194;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.ReadLinesStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                String[] string11195 = new String[3];
                String string11195_0 = "__IOREG();";
                String string11195_1 = "__IOREG( PORTPFC1                                                       ,   0xffc10058ul  ,  __READ_WRITE, u16_T);";
                String string11195_2 = "__IOREG( PORTPFCE1                                                      ,  0xffc1005cul   ,  __READ_WRITE, u16_T);";
                string11195[0] = string11195_0;
                string11195[1] = string11195_1;
                string11195[2] = string11195_2;
                return string11195;
            }

            ;
            Int32 int3212196 = 0;
            Int32 errorCode1 = int3212196;
            var userinterface1524 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface1524.ErrorFileNotFoundString = (String fileName) =>
            {
                return;
            }

            ;
            userinterface1524.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface1524.Exit = () =>
            {
                return;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface1524);
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, new Dictionary<string, string>());
            /* Act */
            typeof(BaseRegisterProcessing).GetMethod("SaveMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{filesInput});
            /* Assert */
            Object macroaddressvalue1525 = typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object macroaddressvalue1525_count_1526 = macroaddressvalue1525.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(macroaddressvalue1525);
            Assert.AreEqual((Int32)3, (Int32)macroaddressvalue1525_count_1526);
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }

    [TestMethod]
    public void SaveMacroAddressValueTest_54_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9200 = "dr7f701270_0_034.h";
            String filesInput = string9200;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean10201 = false;
                return boolean10201;
            }

            ;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.ReadLinesStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                String[] string11202 = new String[3];
                String string11202_0 = "__IOREG();";
                String string11202_1 = "__IOREG( PORTPFC1                                                       ,   0xffc10058ul  ,  __READ_WRITE, u16_T);";
                String string11202_2 = "__IOREG( PORTPFCE1                                                      ,  0xffc1005cul   ,  __READ_WRITE, u16_T);";
                string11202[0] = string11202_0;
                string11202[1] = string11202_1;
                string11202[2] = string11202_2;
                return string11202;
            }

            ;
            Int32 int3212203 = 0;
            Int32 errorCode1 = int3212203;
            var userinterface1527 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface1527.ErrorFileNotFoundString = (String fileName) =>
            {
                return;
            }

            ;
            userinterface1527.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCode1 = errorCode;
                ;
            }

            ;
            userinterface1527.Exit = () =>
            {
                throw new Exception();
                ;
            }

            ;
            typeof(BaseRegisterProcessing).GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface1527);
            typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(_target, new Dictionary<string, string>());
            /* Act */
            typeof(BaseRegisterProcessing).GetMethod("SaveMacroAddressValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{filesInput});
            /* Assert */
            Object macroaddressvalue1528 = typeof(BaseRegisterProcessing).GetField("macroAddressValue", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object macroaddressvalue1528_count_1529 = macroaddressvalue1528.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(macroaddressvalue1528);
            Assert.AreEqual((Int32)0, (Int32)macroaddressvalue1528_count_1529);
            Assert.AreEqual((Int32)0, (Int32)errorCode1);
        }
    }
}