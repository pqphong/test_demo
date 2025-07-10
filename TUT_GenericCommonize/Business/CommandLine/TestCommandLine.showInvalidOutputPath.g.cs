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
    public void showInvalidOutputPathTest_57_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "asacsa";
            Object runtimeconfiguration143 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("FolderOutput", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration143, string91);
            String string102 = "csdf";
            Object runtimeconfiguration144 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("IncOutputDirectory", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration144, string102);
            String string113 = "asdsacv";
            Object runtimeconfiguration145 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("SrcOutputDirectory", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration145, string113);
            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface146 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface146.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface146);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean157 = false;
                return boolean157;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidOutputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void showInvalidOutputPathTest_57_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string98 = "asacsa";
            Object runtimeconfiguration147 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("FolderOutput", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration147, string98);
            String string109 = "csdf";
            Object runtimeconfiguration148 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("IncOutputDirectory", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration148, string109);
            String string1110 = "asdsacv";
            Object runtimeconfiguration149 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("SrcOutputDirectory", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration149, string1110);
            Int32 int321211 = 0;
            Int32 flag = int321211;
            var userinterface150 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface150.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface150);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1514 = true;
                return boolean1514;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidOutputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void showInvalidOutputPathTest_57_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string915 = null;
            Object runtimeconfiguration151 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("FolderOutput", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration151, string915);
            String string1016 = "dasda";
            Object runtimeconfiguration152 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("IncOutputDirectory", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration152, string1016);
            String string1117 = "asdsacv";
            Object runtimeconfiguration153 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("SrcOutputDirectory", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration153, string1117);
            Int32 int321218 = 0;
            Int32 flag = int321218;
            var userinterface154 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface154.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface154);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1521 = false;
                return boolean1521;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidOutputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void showInvalidOutputPathTest_57_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string922 = null;
            Object runtimeconfiguration155 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("FolderOutput", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration155, string922);
            String string1023 = "greg";
            Object runtimeconfiguration156 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("IncOutputDirectory", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration156, string1023);
            String string1124 = "asdsacv";
            Object runtimeconfiguration157 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("SrcOutputDirectory", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration157, string1124);
            Int32 int321225 = 0;
            Int32 flag = int321225;
            var userinterface158 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface158.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface158);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1528 = true;
                return boolean1528;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidOutputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void showInvalidOutputPathTest_57_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string929 = "asacsa";
            Object runtimeconfiguration159 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("FolderOutput", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration159, string929);
            Int32 int321232 = 0;
            Int32 flag = int321232;
            var userinterface160 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface160.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface160);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1535 = true;
                return boolean1535;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidOutputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void showInvalidOutputPathTest_57_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string936 = null;
            Object runtimeconfiguration161 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("FolderOutput", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration161, string936);
            Int32 int321239 = 0;
            Int32 flag = int321239;
            var userinterface162 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface162.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface162);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean1542 = true;
                return boolean1542;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("showInvalidOutputPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}