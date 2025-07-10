using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using System.Xml.Linq;

public partial class TestParserXML
{
    [TestMethod]
    public void ParseDeviceFileSectionTest_7_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement DEVICE_FILE_PATH = new XElement("DEVICE-FILE-PATH");

            XElement R7F701401 = new XElement("R7F701401", "lin/dr7f701401_0.h");
            DEVICE_FILE_PATH.Add(R7F701401);

            String string91 = "lin/Sample_Application_D1x.trxml";
            String translationFilePath = string91;
            String string113 = "R7F701401";
            String deviceName = string113;
            Int32 int32124 = 0;
            Int32 flag = int32124;
            var UserInterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            UserInterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, UserInterface17);
            var Register18 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            Register18.SaveMacroAddressValueString = (String fileName) =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("Register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, Register18);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ParseDeviceFileSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(XElement), typeof(String)}, null).Invoke(_target, new object[]{translationFilePath, DEVICE_FILE_PATH, deviceName});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void ParseDeviceFileSectionTest_7_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement DEVICE_FILE_PATH = new XElement("DEVICE-FILE-PATH");

            String string91 = "lin/Sample_Application_D1x.trxml";
            String translationFilePath = string91;
            String string113 = "R7F701401";
            String deviceName = string113;
            Int32 int32124 = 0;
            Int32 flag = int32124;
            var UserInterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            UserInterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, UserInterface17);
            var Register18 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            Register18.SaveMacroAddressValueString = (String fileName) =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("Register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, Register18);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ParseDeviceFileSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XElement), typeof(String) }, null).Invoke(_target, new object[] { translationFilePath, DEVICE_FILE_PATH, deviceName });
            /* Assert */
            Assert.AreEqual(16, flag);
            Assert.AreEqual(true, actualResult);

        }
    }

    [TestMethod]
    public void ParseDeviceFileSectionTest_7_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement DEVICE_FILE_PATH = new XElement("DEVICE-FILE-PATH");
            XElement R7F701401 = new XElement("R7F701402", "lin/dr7f701401_0.h");
            DEVICE_FILE_PATH.Add(R7F701401);
            String string91 = "lin/Sample_Application_D1x.trxml";
            String translationFilePath = string91;
            String string113 = "R7F701401";
            String deviceName = string113;
            Int32 int32124 = 0;
            Int32 flag = int32124;
            var UserInterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            UserInterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, UserInterface17);
            var Register18 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            Register18.SaveMacroAddressValueString = (String fileName) =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("Register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, Register18);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ParseDeviceFileSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XElement), typeof(String) }, null).Invoke(_target, new object[] { translationFilePath, DEVICE_FILE_PATH, deviceName });
            /* Assert */
            Assert.AreEqual(17, flag);

        }
    }

    [TestMethod]
    public void ParseDeviceFileSectionTest_7_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
           
            String string91 = "lin/Sample_Application_D1x.trxml";
            String translationFilePath = string91;
            String string113 = "R7F701401";
            String deviceName = string113;
            Int32 int32124 = 0;
            Int32 flag = int32124;
            var UserInterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            UserInterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, UserInterface17);
            var Register18 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            Register18.SaveMacroAddressValueString = (String fileName) =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("Register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, Register18);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ParseDeviceFileSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XElement), typeof(String) }, null).Invoke(_target, new object[] { translationFilePath, null, deviceName });
            /* Assert */
            Assert.AreEqual(false, actualResult);

        }
    }

}