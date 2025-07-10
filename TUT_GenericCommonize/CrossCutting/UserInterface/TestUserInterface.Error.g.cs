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
    public void ErrorTest_52_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 122;
            Int32 moduleId = int3291;
            Int32 int32102 = 1;
            Int32 errorCode = int32102;
            String string113 = "";
            String message = string113;
            Object[] object124 = new Object[0];
            Object[] parameters = object124;
            Int32 int32135 = 0;
            _target.GetType().GetField("errorCount", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, int32135);
            String string146 = "";
            String msgTypeFlag = string146;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.reportInt32Int32StringStringObjectArray = (UserInterface instance, Int32 _moduleId, Int32 _errorCode, String msgType, String msg, Object[] _parameters) =>
            {
                msgTypeFlag = msgType;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("Error", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32), typeof(Int32), typeof(String), typeof(Object[])}, null).Invoke(_target, new object[]{moduleId, errorCode, message, parameters});
            /* Assert */
            Object errorcount18 = _target.GetType().GetField("errorCount", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Assert.AreEqual((Int32)1, (Int32)errorcount18);
            Assert.AreEqual((String)"ERR", (String)msgTypeFlag);
        }
    }
}