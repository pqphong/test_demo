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
    public void ParseTransFileSectionTest_8_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin/Sample_Application_D1x.trxml";
            String translationFilePath = string91;

            XElement transFileSection = new XElement("TRANSLATION-FILE-PATH");
            XElement R7F701401 = new XElement("R7F701401", "lin/D1x_translation_01_21.h");
            transFileSection.Add(R7F701401);
                       
            String string113 = "R7F701401";
            String deviceName = string113;
            Int32 int32124 = 0;
            Int32 flag = int32124;
            var UserInterface18 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            UserInterface18.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            UserInterface18.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, UserInterface18);
            var Register19 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            Register19.SaveMacroLabelValueString = (String fileName) =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("Register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, Register19);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ParseTransFileSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(XElement), typeof(String)}, null).Invoke(_target, new object[]{translationFilePath, transFileSection, deviceName});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
            Assert.AreEqual(true, actualResult);
        }
    }

    [TestMethod]
    public void ParseTransFileSectionTest_8_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin/Sample_Application_D1x.trxml";
            String translationFilePath = string91;

            XElement transFileSection = new XElement("TRANSLATION-FILE-PATH");

            String string113 = "R7F701401";
            String deviceName = string113;
            Int32 int32124 = 0;
            Int32 flag = int32124;
            var UserInterface18 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            UserInterface18.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            UserInterface18.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, UserInterface18);
            var Register19 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            Register19.SaveMacroLabelValueString = (String fileName) =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("Register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, Register19);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ParseTransFileSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XElement), typeof(String) }, null).Invoke(_target, new object[] { translationFilePath, transFileSection, deviceName });
            /* Assert */
            Assert.AreEqual((Int32)14, (Int32)flag);
        }
    }

    [TestMethod]
    public void ParseTransFileSectionTest_8_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin/Sample_Application_D1x.trxml";
            String translationFilePath = string91;

            XElement transFileSection = new XElement("TRANSLATION-FILE-PATH");
            XElement R7F701401 = new XElement("R7F701402", "lin/D1x_translation_01_21.h");
            transFileSection.Add(R7F701401);



            String string113 = "R7F701401";
            String deviceName = string113;
            Int32 int32124 = 0;
            Int32 flag = int32124;
            var UserInterface18 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            UserInterface18.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            UserInterface18.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, UserInterface18);
            var Register19 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRegisterProcessing();
            Register19.SaveMacroLabelValueString = (String fileName) =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("Register", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, Register19);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ParseTransFileSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XElement), typeof(String) }, null).Invoke(_target, new object[] { translationFilePath, transFileSection, deviceName });
            /* Assert */
            Assert.AreEqual((Int32)15, (Int32)flag);
        }
    }

    [TestMethod]
    public void ParseTransFileSectionTest_8_4()
    {
        using (ShimsContext.Create())
        {
        
            XElement transFileSection = null;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ParseTransFileSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XElement), typeof(String) }, null).Invoke(_target, new object[] { "", transFileSection, ""});
            /* Assert */
            Assert.AreEqual(false, actualResult);
        }
    }
}