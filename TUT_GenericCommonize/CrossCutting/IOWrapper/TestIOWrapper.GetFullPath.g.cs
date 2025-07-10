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
    public void GetFullPathTest_11_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String path = string91;
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

            System.IO.Fakes.ShimPath.GetFullPathString = (f) =>
            {

                throw new SecurityException();
            };


            /* Act */
            String actualResult = (String)typeof(IOWrapper).GetMethod("GetFullPath", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{path, null});
            /* Assert */
            Assert.AreEqual((Int32)50, (Int32)flag);
        }
    }

    [TestMethod]
    public void GetFullPathTest_11_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String path = string91;
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

            System.IO.Fakes.ShimPath.GetFullPathString = (f) =>
            {

                throw new PathTooLongException();
            };


            /* Act */
            String actualResult = (String)typeof(IOWrapper).GetMethod("GetFullPath", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { path, null });
            /* Assert */
            Assert.AreEqual((Int32)51, (Int32)flag);
        }
    }

    [TestMethod]
    public void GetFullPathTest_11_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "test";
            String path = string91;
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

            System.IO.Fakes.ShimPath.GetFullPathString = (f) =>
            {

                return "U:\\test";
            };


            /* Act */
            String actualResult = (String)typeof(IOWrapper).GetMethod("GetFullPath", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { path, null });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}