using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using System.IO;

public partial class TestIOWrapper
{
    [TestMethod]
    public void StreamWriteTest_18_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String content = string91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui15 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui15.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui15);

            System.IO.Fakes.ShimStreamWriter.AllInstances.WriteString = (instance, str) =>
            {
                return;
            };
            StreamWriter stream = new StreamWriter("test.txt");
            /* Act */
            typeof(IOWrapper).GetMethod("StreamWrite", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(StreamWriter), typeof(String), typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{ stream, content, null, null});
            stream.Close();
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void StreamWriteTest_18_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String content = string91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui15 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui15.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui15);

            System.IO.Fakes.ShimStreamWriter.AllInstances.WriteString = (instance, str) =>
            {
                throw new IOException();
            };
            StreamWriter stream = new StreamWriter("test.txt");
            /* Act */
            typeof(IOWrapper).GetMethod("StreamWrite", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(StreamWriter), typeof(String), typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { stream, content, null, null });
            /* Assert */
            stream.Close();
            Assert.AreEqual((Int32)53, (Int32)flag);
        }
    }

}