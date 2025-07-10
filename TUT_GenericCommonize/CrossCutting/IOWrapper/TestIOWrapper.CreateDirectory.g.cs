using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;

public partial class TestIOWrapper
{
    [TestMethod]
    public void CreateDirectoryTest_10_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String path = null;
            Nullable<Int32> nullable102 = 1;
            Nullable<Int32> exitCode = nullable102;
            Int32 int32113 = 0;
            Int32 code = int32113;
            var ui125 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui125.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui125);
            /* Act */
            typeof(IOWrapper).GetMethod("CreateDirectory", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{path, exitCode});
            /* Assert */
            Assert.AreEqual((Int32)18, (Int32)code);
        }
    }

    [TestMethod]
    public void CreateDirectoryTest_10_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "IOException";
            String path = string95;
            Nullable<Int32> nullable106 = 1;
            Nullable<Int32> exitCode = nullable106;
            Int32 int32117 = 0;
            Int32 code = int32117;
            var ui126 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui126.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui126);
            /* Act */
            typeof(IOWrapper).GetMethod("CreateDirectory", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{path, exitCode});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)code);
        }
    }

    [TestMethod]
    public void CreateDirectoryTest_10_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string99 = "ArgumentException";
            String path = string99;
            Nullable<Int32> nullable1010 = 1;
            Nullable<Int32> exitCode = nullable1010;
            Int32 int321111 = 0;
            Int32 code = int321111;

            System.IO.Fakes.ShimDirectory.CreateDirectoryString = (folder) =>
            {
                throw new UnauthorizedAccessException();
            };

            var ui127 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui127.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui127);
            /* Act */
            typeof(IOWrapper).GetMethod("CreateDirectory", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{path, exitCode});
            /* Assert */
            Assert.AreEqual((Int32)50, (Int32)code);
        }
    }

    [TestMethod]
    public void CreateDirectoryTest_10_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string913 = "L:\\test";
            String path = string913;
            Nullable<Int32> nullable1014 = 1;
            Nullable<Int32> exitCode = nullable1014;
            Int32 int321115 = 0;
            Int32 code = int321115;
            var ui128 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui128.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui128);
            /* Act */
            typeof(IOWrapper).GetMethod("CreateDirectory", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{path, exitCode});
            /* Assert */
            Assert.AreEqual((Int32)18, (Int32)code);
        }
    }

    [TestMethod]
    public void CreateDirectoryTest_10_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string917 = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string917 += "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string917 += "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            String path = string917;
            Nullable<Int32> nullable1018 = 1;
            Nullable<Int32> exitCode = nullable1018;
            Int32 int321119 = 0;
            Int32 code = int321119;
            var ui129 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui129.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui129);
            /* Act */
            typeof(IOWrapper).GetMethod("CreateDirectory", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{path, exitCode});
            /* Assert */
            Assert.AreEqual((Int32)51, (Int32)code);
        }
    }

    
}