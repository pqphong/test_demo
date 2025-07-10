using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;

public partial class TestConsoleWrapper
{
    [TestMethod]
    public void WriteLineTest_24_1()
    {
        using (ShimsContext.Create())
        {
            System.Fakes.ShimConsole.WriteLineString = (v) => {

                throw new IOException();
            };

            /* Arrange */
            String string91 = "test";
            String value = string91;
            /* Act */
            typeof(ConsoleWrapper).GetMethod("WriteLine", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
        /* Assert */
        }
    }

    [TestMethod]
    public void WriteLineTest_24_2()
    {

        using (ShimsContext.Create())
        {
            string flag = "";
            System.Fakes.ShimConsole.WriteLineString = (v) => {

                flag = v;
            };

            /* Arrange */
            String string91 = "test";
            String value = string91;
            /* Act */
            typeof(ConsoleWrapper).GetMethod("WriteLine", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { value });
            /* Assert */
            Assert.AreEqual(flag, value);
        }
    }
}