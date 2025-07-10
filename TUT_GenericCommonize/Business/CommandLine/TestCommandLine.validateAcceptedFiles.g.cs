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
    public void validateAcceptedFilesTest_62_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list91 = null;
            List<String> filePaths = list91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var userinterface116 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface116.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface116);
            /* Act */
            _target.GetType().GetMethod("validateAcceptedFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(List<String>)}, null).Invoke(_target, new object[]{filePaths});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateAcceptedFilesTest_62_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list94 = new List<String>();
            String list94_0 = "sdfds";
            list94.Add(list94_0);
            List<String> filePaths = list94;
            Int32 int32105 = 0;
            Int32 flag = int32105;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);
            /* Act */
            _target.GetType().GetMethod("validateAcceptedFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(List<String>)}, null).Invoke(_target, new object[]{filePaths});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateAcceptedFilesTest_62_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list97 = new List<String>();
            String list97_0 = "abc.arxml";
            list97.Add(list97_0);
            List<String> filePaths = list97;
            Int32 int32108 = 0;
            Int32 flag = int32108;
            var userinterface118 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface118.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface118);
            /* Act */
            _target.GetType().GetMethod("validateAcceptedFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(List<String>)}, null).Invoke(_target, new object[]{filePaths});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateAcceptedFilesTest_62_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list910 = new List<String>();
            String list910_0 = "abc.trxml";
            list910.Add(list910_0);
            List<String> filePaths = list910;
            Int32 int321011 = 0;
            Int32 flag = int321011;
            var userinterface119 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface119.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface119);
            /* Act */
            _target.GetType().GetMethod("validateAcceptedFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(List<String>)}, null).Invoke(_target, new object[]{filePaths});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void validateAcceptedFilesTest_62_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list913 = new List<String>();
            String list913_0 = "abc.trxml";
            String list913_1 = "safdsf.docx";
            list913.Add(list913_0);
            list913.Add(list913_1);
            List<String> filePaths = list913;
            Int32 int321014 = 0;
            Int32 flag = int321014;
            var userinterface120 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface120.WarnInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface120);
            /* Act */
            _target.GetType().GetMethod("validateAcceptedFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(List<String>)}, null).Invoke(_target, new object[]{filePaths});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }
}