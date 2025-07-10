using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestParserXML
{
    [TestMethod]
    public void ParseTranslationFileTest_5_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin/Sample_Application_D1x.trxml";
            Object runtimeconfiguration17 = typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration17, string91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (ParserXML instance) =>
            {
                String string102 = "R7F701401";
                return string102;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
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
           
            System.Xml.Linq.Fakes.ShimXDocument.LoadString = (file) =>
            {
                XDocument document = new XDocument();
                XElement element = new XElement("PATH-DETAILS");
                XElement translationFile = null;
                XElement deviceFile = new XElement("DEVICE-FILE-PATH");
                XElement t2 = new XElement("R7F701401", "lin/dr7f701401_0.h");
                document.Add(element);
                deviceFile.Add(t2);
                element.Add(translationFile);
                element.Add(deviceFile);
                return document;

            };

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseTransFileSectionStringXElementString = (ParserXML instance, String translationFilePath, XElement transFileSection, String deviceName) =>
            {
                Boolean boolean157 = false;
                return boolean157;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseDeviceFileSectionStringXElementString = (ParserXML instance, String translationFilePath, XElement deviceFileSection, String deviceName) =>
            {
                Boolean boolean168 = false;
                return boolean168;
            }

            ;
            ObjectFactory.SupportedVariants.Add("X2x", new List<string>() { "R7F701401" });
            /* Act */
            typeof(ParserXML).GetMethod("ParseTranslationFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)13, (Int32)flag);
            ObjectFactory.SupportedVariants.Clear();
        }
    }

    [TestMethod]
    public void ParseTranslationFileTest_5_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin/Sample_Application_D1x.trxml";
            Object runtimeconfiguration17 = typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration17, string91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (ParserXML instance) =>
            {
                String string102 = "R7F701401";
                return string102;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
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
            System.Xml.Linq.Fakes.ShimXDocument.LoadString = (file) =>
            {
                XDocument document = new XDocument();
                XElement element = new XElement("PATH-DETAILS");
                XElement translationFile = null;
                XElement deviceFile = new XElement("DEVICE-FILE-PATH");
                XElement t2 = new XElement("R7F701401", "lin/dr7f701401_0.h");
                document.Add(element);
                deviceFile.Add(t2);
                element.Add(translationFile);
                element.Add(deviceFile);
                return document;

            };

            ;

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseTransFileSectionStringXElementString = (ParserXML instance, String translationFilePath, XElement transFileSection, String deviceName) =>
            {
                Boolean boolean157 = true;
                return boolean157;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseDeviceFileSectionStringXElementString = (ParserXML instance, String translationFilePath, XElement deviceFileSection, String deviceName) =>
            {
                Boolean boolean168 = true;
                return boolean168;
            }

            ;
            ObjectFactory.SupportedVariants.Add("X2x", new List<string>() { "R7F701401" });
            /* Act */
            typeof(ParserXML).GetMethod("ParseTranslationFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
            ObjectFactory.SupportedVariants.Clear();
        }
    }

    [TestMethod]
    public void ParseTranslationFileTest_5_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin/Sample_Application_D1x.trxml";
            Object runtimeconfiguration17 = typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration17, string91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (ParserXML instance) =>
            {
                String string102 = "";
                return string102;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
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
            System.Xml.Linq.Fakes.ShimXDocument.LoadString = (file) =>
            {
                XDocument document = new XDocument();
                XElement element = new XElement("PATH-DETAILS");
                XElement translationFile = null;
                XElement deviceFile = new XElement("DEVICE-FILE-PATH");
                XElement t2 = new XElement("R7F701401", "lin/dr7f701401_0.h");
                document.Add(element);
                deviceFile.Add(t2);
                element.Add(translationFile);
                element.Add(deviceFile);
                return document;

            };

            ;

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseTransFileSectionStringXElementString = (ParserXML instance, String translationFilePath, XElement transFileSection, String deviceName) =>
            {
                Boolean boolean157 = true;
                return boolean157;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseDeviceFileSectionStringXElementString = (ParserXML instance, String translationFilePath, XElement deviceFileSection, String deviceName) =>
            {
                Boolean boolean168 = true;
                return boolean168;
            }

            ;
            ObjectFactory.SupportedVariants.Add("X2x", new List<string>() { "" });
            /* Act */
            typeof(ParserXML).GetMethod("ParseTranslationFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)39, (Int32)flag);
            ObjectFactory.SupportedVariants.Clear();
        }
    }

    [TestMethod]
    public void ParseTranslationFileTest_5_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin/Sample_Application_D1x.trxml";
            Object runtimeconfiguration17 = typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration17, string91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.GetDeviceName = (ParserXML instance) =>
            {
                String string102 = "R7F701410";
                return string102;
            }

            ;
            Int32 int32113 = 0;
            Int32 flag = int32113;
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
            System.Xml.Linq.Fakes.ShimXDocument.LoadString = (file) =>
            {
                XDocument document = new XDocument();
                XElement element = new XElement("PATH-DETAILS");
                XElement translationFile = null;
                XElement deviceFile = new XElement("DEVICE-FILE-PATH");
                XElement t2 = new XElement("R7F701401", "lin/dr7f701401_0.h");
                document.Add(element);
                deviceFile.Add(t2);
                element.Add(translationFile);
                element.Add(deviceFile);
                return document;

            };

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseTransFileSectionStringXElementString = (ParserXML instance, String translationFilePath, XElement transFileSection, String deviceName) =>
            {
                Boolean boolean157 = true;
                return boolean157;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseDeviceFileSectionStringXElementString = (ParserXML instance, String translationFilePath, XElement deviceFileSection, String deviceName) =>
            {
                Boolean boolean168 = true;
                return boolean168;
            }

            ;
            ObjectFactory.SupportedVariants.Add("X2x", new List<string>() { "R7F701402" });
            /* Act */
            typeof(ParserXML).GetMethod("ParseTranslationFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((Int32)46, (Int32)flag);
            ObjectFactory.SupportedVariants.Clear();
        }
    }

    

}

