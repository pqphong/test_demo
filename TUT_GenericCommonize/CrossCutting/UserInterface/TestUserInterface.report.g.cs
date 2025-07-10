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
    public void reportTest_46_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 moduleId = 0;
            Int32 errorCode = 0;
            String string113 = "";
            String msgType = string113;
            String string124 = "";
            String msg = string124;
            Object[] object135 = new Object[0];
            Object[] parameters = object135;
            Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.ShimUserInterface.AllInstances.textWrapStringStringInt32 = (UserInterface instance, String prefix, String inputString, Int32 width) =>
            {
                String string146 = "outMessage";
                return string146;
            }

            ;
            String string157 = "";
            String outMessageFlag = string157;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimConsoleWrapper.WriteLineString = (String value) =>
            {
                outMessageFlag = value;
            }

            ;
            /* Act */
            _target.GetType().GetMethod("report", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Int32), typeof(Int32), typeof(String), typeof(String), typeof(Object[])}, null).Invoke(_target, new object[]{moduleId, errorCode, msgType, msg, parameters});
            /* Assert */
            Assert.AreEqual((String)"outMessage", (String)outMessageFlag);
        }
    }
}