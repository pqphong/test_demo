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
    public void InfoTest_54_1()
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
            String string135 = "";
            String msgTypeFlag = string135;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.reportInt32Int32StringStringObjectArray = (UserInterface instance, Int32 _moduleId, Int32 _errorCode, String msgType, String msg, Object[] _parameters) =>
            {
                msgTypeFlag = msgType;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("Info", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32), typeof(Int32), typeof(String), typeof(Object[])}, null).Invoke(_target, new object[]{moduleId, errorCode, message, parameters});
            /* Assert */
            Assert.AreEqual((String)"INF", (String)msgTypeFlag);
        }
    }
}