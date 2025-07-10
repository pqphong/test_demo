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
    public void GetFilesTest_9_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            Int32 flag = int3291;
            var ui110 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui110.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;

            System.IO.Fakes.ShimDirectory.GetFilesStringStringSearchOption = (f1, f2, f3) => {
                throw new UnauthorizedAccessException();

            };

            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui110);
            /* Act */
            String[] actualResult = (String[])typeof(IOWrapper).GetMethod("GetFiles", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(SearchOption), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{null, null, null, null});
            /* Assert */
            Assert.AreEqual((Int32)50, (Int32)flag);
        }
    }

    [TestMethod]
    public void GetFilesTest_9_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3294 = 0;
            Int32 flag = int3294;
            var ui111 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui111.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui111);
            System.IO.Fakes.ShimDirectory.GetFilesStringStringSearchOption = (f1, f2, f3) => {
                throw new PathTooLongException();

            };

            /* Act */
            String[] actualResult = (String[])typeof(IOWrapper).GetMethod("GetFiles", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(SearchOption), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{null, null, null, null });
            /* Assert */
            Assert.AreEqual((Int32)51, (Int32)flag);
        }
    }

    [TestMethod]
    public void GetFilesTest_9_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3297 = 0;
            Int32 flag = int3297;
            var ui112 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui112.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui112);

            System.IO.Fakes.ShimDirectory.GetFilesStringStringSearchOption = (f1, f2, f3) => {
                throw new IOException();

            };

            /* Act */
            String[] actualResult = (String[])typeof(IOWrapper).GetMethod("GetFiles", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(SearchOption), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{ null, null, null, null });
            /* Assert */
            Assert.AreEqual((Int32)53, (Int32)flag);
        }
    }

    [TestMethod]
    public void GetFilesTest_9_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3297 = 0;
            Int32 flag = int3297;
            var ui112 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui112.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui112);

            System.IO.Fakes.ShimDirectory.GetFilesStringStringSearchOption = (f1, f2, f3) => {

                return new string[] { };
            };

            /* Act */
            String[] actualResult = (String[])typeof(IOWrapper).GetMethod("GetFiles", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(SearchOption), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { null, null, null, null });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}