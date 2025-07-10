using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using static Renesas.Generator.MCALConfGen.Business.Validation.ValidationResult;

public partial class TestBaseValidation
{
    [TestMethod]
    public void exitWithTypeTest_119_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            MessageType messagetype91 = 0;
            MessageType type = messagetype91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var userinterface113 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface113.ExitInt32 = (exitCode) =>
            {
                flag = exitCode;
                ;
            }

            ;
            typeof(BaseValidation).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface113);
            /* Act */
            typeof(BaseValidation).GetMethod("exitWithType", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(MessageType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void exitWithTypeTest_119_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            MessageType messagetype94 = MessageType.ERROR;
            MessageType type = messagetype94;
            Int32 int32105 = 0;
            Int32 flag = int32105;
            var userinterface114 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface114.ExitInt32 = (exitCode) =>
            {
                flag = exitCode;
                ;
            }

            ;
            typeof(BaseValidation).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface114);
            /* Act */
            typeof(BaseValidation).GetMethod("exitWithType", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(MessageType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((Int32)2, (Int32)flag);
        }
    }

    [TestMethod]
    public void exitWithTypeTest_119_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            MessageType messagetype97 = MessageType.WARN;
            MessageType type = messagetype97;
            Int32 int32108 = 0;
            Int32 flag = int32108;
            var userinterface115 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface115.ExitInt32 = (exitCode) =>
            {
                flag = exitCode;
                ;
            }

            ;
            typeof(BaseValidation).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface115);
            /* Act */
            typeof(BaseValidation).GetMethod("exitWithType", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(MessageType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void exitWithTypeTest_119_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            MessageType messagetype910 = MessageType.INFO;
            MessageType type = messagetype910;
            Int32 int321011 = 0;
            Int32 flag = int321011;
            var userinterface116 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface116.ExitInt32 = (exitCode) =>
            {
                flag = exitCode;
                ;
            }

            ;
            typeof(BaseValidation).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface116);
            /* Act */
            typeof(BaseValidation).GetMethod("exitWithType", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(MessageType)}, null).Invoke(_target, new object[]{type});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}