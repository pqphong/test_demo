using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;

public partial class TestIOWrapper
{
    [TestMethod]
    public void ReadLinesTest_59_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String file = null;
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


            System.IO.Fakes.ShimFile.ReadLinesString = (f) =>
            {

                return new List<string> { };
            };


            /* Act */
            IEnumerable<string> actualResult = (IEnumerable<string>)typeof(IOWrapper).GetMethod("ReadLines", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{file, null});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void ReadLinesTest_59_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String file = null;
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


            System.IO.Fakes.ShimFile.ReadLinesString = (f) =>
            {
                throw new UnauthorizedAccessException();
            };


            /* Act */
            IEnumerable<string> actualResult = (IEnumerable<string>)typeof(IOWrapper).GetMethod("ReadLines", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { file, null });
            /* Assert */
            Assert.AreEqual((Int32)50, (Int32)flag);
        }
    }

    [TestMethod]
    public void ReadLinesTest_59_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String file = null;
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


            System.IO.Fakes.ShimFile.ReadLinesString = (f) =>
            {
                throw new SecurityException();
            };


            /* Act */
            IEnumerable<string> actualResult = (IEnumerable<string>)typeof(IOWrapper).GetMethod("ReadLines", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { file, null });
            /* Assert */
            Assert.AreEqual((Int32)50, (Int32)flag);
        }
    }

    [TestMethod]
    public void ReadLinesTest_59_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String file = null;
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


            System.IO.Fakes.ShimFile.ReadLinesString = (f) =>
            {
                throw new IOException();
            };


            /* Act */
            IEnumerable<string> actualResult = (IEnumerable<string>)typeof(IOWrapper).GetMethod("ReadLines", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { file, null });
            /* Assert */
            Assert.AreEqual((Int32)53, (Int32)flag);
        }
    }
}