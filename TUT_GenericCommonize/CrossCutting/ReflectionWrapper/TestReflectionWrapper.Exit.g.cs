using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;

public partial class TestReflectionWrapper
{
    [TestMethod]
    public void exitTest_23_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Nullable<Int32> nullable91 = null;
            Nullable<Int32> exitCode = nullable91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui17.ExitInt32 = (code) =>
            {
                flag = code;
                ;
            }

            ;
            typeof(ReflectionWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui17);
            /* Act */
            typeof(ReflectionWrapper).GetMethod("exit", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{exitCode});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void exitTest_23_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Nullable<Int32> nullable94 = 2;
            Nullable<Int32> exitCode = nullable94;
            Int32 int32105 = 0;
            Int32 flag = int32105;
            var ui18 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui18.ExitInt32 = (code) =>
            {
                flag = code;
                ;
            }

            ;
            typeof(ReflectionWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui18);
            /* Act */
            typeof(ReflectionWrapper).GetMethod("exit", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{exitCode});
            /* Assert */
            Assert.AreEqual((Int32)2, (Int32)flag);
        }
    }
}