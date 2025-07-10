using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using System.Xml.Linq;

public partial class TestIOWrapper
{
    [TestMethod]
    public void LoadXMLTest_12_1()
    {
        using (ShimsContext.Create())
        {
         
            System.Xml.Linq.Fakes.ShimXDocument.LoadString = (f) =>
            {
                return new XDocument();
            };

            /* Arrange */
            String string91 = "";
            String file = string91;
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
            /* Act */
            XDocument actualResult = (XDocument)typeof(IOWrapper).GetMethod("LoadXML", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { file, null });
            /* Assert */
            Assert.AreEqual(0, flag);
        }
    }

    [TestMethod]
    public void LoadXMLTest_12_2()
    {
        using (ShimsContext.Create())
        {

            System.Xml.Linq.Fakes.ShimXDocument.LoadString = (f) =>
            {
                throw new FormatException();
            };

            /* Arrange */
            String string91 = "";
            String file = string91;
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
            /* Act */
            XDocument actualResult = (XDocument)typeof(IOWrapper).GetMethod("LoadXML", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { file, null });
            /* Assert */
            Assert.AreEqual(12, flag);
        }
    }

    [TestMethod]
    public void LoadXMLTest_12_3()
    {
        using (ShimsContext.Create())
        {

            System.Xml.Linq.Fakes.ShimXDocument.LoadString = (f) =>
            {
                throw new UnauthorizedAccessException();
            };

            /* Arrange */
            String string91 = "";
            String file = string91;
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
            /* Act */
            XDocument actualResult = (XDocument)typeof(IOWrapper).GetMethod("LoadXML", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String), typeof(Nullable<Int32>) }, null).Invoke(_target, new object[] { file, null });
            /* Assert */
            Assert.AreEqual(50, flag);
        }
    }
}