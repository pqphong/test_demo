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
    public void exitTest_20_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Nullable<Int32> nullable91 = null;
            Nullable<Int32> exitCode = nullable91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui19 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui19.Exit = () =>
            {
                flag = 1;
                ;
            }

            ;
            ui19.ExitInt32 = (code) =>
            {
                flag = 2;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui19);
            /* Act */
            typeof(IOWrapper).GetMethod("exit", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{exitCode});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }

    [TestMethod]
    public void exitTest_20_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Nullable<Int32> nullable95 = 1;
            Nullable<Int32> exitCode = nullable95;
            Int32 int32106 = 0;
            Int32 flag = int32106;
            var ui110 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui110.Exit = () =>
            {
                flag = 1;
                ;
            }

            ;
            ui110.ExitInt32 = (code) =>
            {
                flag = 2;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui110);
            /* Act */
            typeof(IOWrapper).GetMethod("exit", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{exitCode});
            /* Assert */
            Assert.AreEqual((Int32)2, (Int32)flag);
        }
    }
}