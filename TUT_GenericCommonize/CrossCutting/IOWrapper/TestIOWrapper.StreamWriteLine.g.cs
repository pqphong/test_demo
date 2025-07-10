using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

public partial class TestIOWrapper
{
    [TestMethod]
    public void StreamWriteLineTest_19_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String content = string91;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var ui19 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui19.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui19);

            System.IO.Fakes.ShimTextWriter.AllInstances.WriteLine = (instance) =>
            {
                return;
            };

            StreamWriter stream = new StreamWriter("test.txt");
            /* Act */
            typeof(IOWrapper).GetMethod("StreamWriteLine", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(StreamWriter), typeof(String), typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{ stream, content, null, null});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
            stream.Close();
        }
    }

    [TestMethod]
    public void StreamWriteLineTest_19_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "test";
            String content = string95;
            Int32 int32106 = 0;
            Int32 flag = int32106;
            var ui110 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui110.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui110);
            /* Act */
            System.IO.Fakes.ShimTextWriter.AllInstances.WriteLineString =
                    (TextWriter textWriter, string value)
                    =>
                    {
                          throw new IOException("IOException");
                    };

            MemoryStream memoryStream;
            StreamWriter streamWriter;
            byte[] bs = new byte[0];
            memoryStream = new MemoryStream(bs, true);
            streamWriter = new StreamWriter((Stream)memoryStream);

            typeof(IOWrapper).GetMethod("StreamWriteLine", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(StreamWriter), typeof(String), typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{ streamWriter, content, null, null});
            /* Assert */
            Assert.AreEqual((Int32)53, (Int32)flag);

        }
    }
}