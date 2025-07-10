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
    public void GetCurrentDirectoryTest_16_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            Int32 flag = int3291;
            var ui14 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui14.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui14);

            System.IO.Fakes.ShimDirectory.GetCurrentDirectory = () =>
            {

                throw new UnauthorizedAccessException();
            };


            /* Act */
            String actualResult = (String)typeof(IOWrapper).GetMethod("GetCurrentDirectory", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { null });
            /* Assert */
            Assert.AreEqual((Int32)50, (Int32)flag);
        }
    }

        [TestMethod]
    public void GetCurrentDirectoryTest_16_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            Int32 flag = int3291;
            var ui14 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui14.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui14);

            System.IO.Fakes.ShimDirectory.GetCurrentDirectory = () => {

                return "U:\\test";
            };


            /* Act */
            String actualResult = (String)typeof(IOWrapper).GetMethod("GetCurrentDirectory", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { null });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }
}