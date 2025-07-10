using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;

public partial class TestUserInterface
{
    [TestMethod]
    public void InfoErrorCodeTest_42_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = -1;
            Int32 errorcode = int3291;
            Int32 int32102 = 0;
            Int32 errorCodeFlag = int32102;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)8, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3295 = 0;
            Int32 errorcode = int3295;
            Int32 int32106 = 0;
            Int32 errorCodeFlag = int32106;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            Int32 int32128 = 0;
            _target.GetType().GetField("warningCount", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32128);
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)6, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3299 = 1;
            Int32 errorcode = int3299;
            Int32 int321010 = 0;
            Int32 errorCodeFlag = int321010;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            Int32 int321212 = 1;
            _target.GetType().GetField("warningCount", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int321212);
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)7, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int32913 = 2;
            Int32 errorcode = int32913;
            Int32 int321014 = 0;
            Int32 errorCodeFlag = int321014;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)9, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int32917 = 3;
            Int32 errorcode = int32917;
            Int32 int321018 = 0;
            Int32 errorCodeFlag = int321018;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)10, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int32921 = 4;
            Int32 errorcode = int32921;
            Int32 int321022 = 0;
            Int32 errorCodeFlag = int321022;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)11, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_7()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int32925 = 5;
            Int32 errorcode = int32925;
            Int32 int321026 = 0;
            Int32 errorCodeFlag = int321026;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)12, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_8()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int32929 = 7;
            Int32 errorcode = int32929;
            Int32 int321030 = 0;
            Int32 errorCodeFlag = int321030;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)14, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_9()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int32933 = 6;
            Int32 errorcode = int32933;
            Int32 int321034 = 0;
            Int32 errorCodeFlag = int321034;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)errorCodeFlag);
        }
    }

    [TestMethod]
    public void InfoErrorCodeTest_42_10()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int32937 = 8;
            Int32 errorcode = int32937;
            Int32 int321038 = 0;
            Int32 errorCodeFlag = int321038;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.InfoInt32Int32StringObjectArray = (UserInterface instance, Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                errorCodeFlag = errorCode;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("InfoErrorCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{errorcode});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)errorCodeFlag);
        }
    }
}