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
    public void WarnTest_50_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            _target.GetType().GetField("warningCount", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int3291);
            Int32 int32102 = 122;
            Int32 moduleId = int32102;
            Int32 int32113 = 1;
            Int32 errorCode = int32113;
            String string124 = "";
            String message = string124;
            Object[] object135 = new Object[0];
            Object[] parameters = object135;
            String string146 = "";
            String msgTypeFlag = string146;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.reportInt32Int32StringStringObjectArray = (UserInterface instance, Int32 _moduleId, Int32 _errorCode, String msgType, String msg, Object[] _parameters) =>
            {
                msgTypeFlag = msgType;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("Warn", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32), typeof(Int32), typeof(String), typeof(Object[])}, null).Invoke(_target, new object[]{moduleId, errorCode, message, parameters});
            /* Assert */
            Object warningcount18 = _target.GetType().GetField("warningCount", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Assert.AreEqual((Int32)1, (Int32)warningcount18);
            Assert.AreEqual((String)"WRN", (String)msgTypeFlag);
        }
    }
}