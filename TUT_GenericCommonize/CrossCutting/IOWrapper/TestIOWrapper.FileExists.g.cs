using System;
using System.Collections.Generic;
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
    public void FileExistsTest_15_1()
    {
        using (ShimsContext.Create())
        {
            int flag = 0;
            var ui110 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui110.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;

            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui110);

            System.IO.Fakes.ShimFile.ExistsString = (f) =>
            {
                throw new SecurityException();

            };


            /* Arrange */
            String file = null;
            /* Act */
            Boolean actualResult = (Boolean)typeof(IOWrapper).GetMethod("FileExists", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{file, null});
            /* Assert */
            Assert.AreEqual(50, flag);
        }
    }

    private Exception SecurityException()
    {
        throw new NotImplementedException();
    }

    [TestMethod]
    public void FileExistsTest_15_2()
    {
        using (ShimsContext.Create())
        {
            int flag = 0;
            var ui110 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            ui110.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;

            typeof(IOWrapper).GetField("ui", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ui110);
            System.IO.Fakes.ShimFile.ExistsString = (f) =>
            {
                return true;

            };

            /* Arrange */
            String file = null;
            /* Act */
            Boolean actualResult = (Boolean)typeof(IOWrapper).GetMethod("FileExists", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Nullable<Int32>)}, null).Invoke(_target, new object[]{file, null});
            /* Assert */
            Assert.AreEqual(0, flag);
        }
    }
}