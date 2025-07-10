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
    public void ParseCDFsTest_6_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, XDocument> dictionary91 = new Dictionary<String, XDocument>();
            XDocument root = new XDocument();
            XElement AR_PACKAGES = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE = new XElement("AR-PACKAGE");
            XElement SHORT_NAME = new XElement("SHORT-NAME", "Lin");
            AR_PACKAGE.Add(SHORT_NAME);
            AR_PACKAGES.Add(AR_PACKAGE);

            XElement ELEMENTS = new XElement("ELEMENTS");
            AR_PACKAGE.Add(ELEMENTS);
            XElement ECUC_MODULE_CONFIGURATION_VALUES = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            ELEMENTS.Add(ECUC_MODULE_CONFIGURATION_VALUES);

            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(DEFINITION_REF);
            XElement MODULE_DESCRIPTION_REF = new XElement("MODULE-DESCRIPTION-REF", "/Renesas/EcucDefs_Lin/Lin_Impl");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(MODULE_DESCRIPTION_REF);

            XElement CONTAINERS = new XElement("CONTAINERS");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(CONTAINERS);

            ECUC_MODULE_CONFIGURATION_VALUES.Add(SHORT_NAME);

            XElement ECUC_CONTAINER_VALUE = new XElement("ECUC-CONTAINER-VALUE");
            XElement SHORT_NAME2 = new XElement("SHORT-NAME", "LinGeneral");
            XElement DEFINITION_REF2 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral");
            ECUC_CONTAINER_VALUE.Add(SHORT_NAME2);
            ECUC_CONTAINER_VALUE.Add(DEFINITION_REF2);

            XElement PARAMETER_VALUES = new XElement("PARAMETER-VALUES");
            ECUC_CONTAINER_VALUE.Add(PARAMETER_VALUES);

            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement DEFINITION_REF3 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules");
            DEFINITION_REF3.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            XElement VALUE1 = new XElement("VALUE", "true");
            ECUC_NUMERICAL_PARAM_VALUE.Add(DEFINITION_REF3);
            ECUC_NUMERICAL_PARAM_VALUE.Add(VALUE1);
            PARAMETER_VALUES.Add(ECUC_NUMERICAL_PARAM_VALUE);

            XElement REFERENCE_VALUES = new XElement("REFERENCE-VALUES");
            XElement ECUC_REFERENCE_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement DEFINITION_REF4 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            DEFINITION_REF4.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement VALUE2 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            ECUC_REFERENCE_VALUE.Add(DEFINITION_REF4);
            ECUC_REFERENCE_VALUE.Add(VALUE2);
            REFERENCE_VALUES.Add(ECUC_REFERENCE_VALUE);
            ECUC_CONTAINER_VALUE.Add(REFERENCE_VALUES);

            CONTAINERS.Add(ECUC_CONTAINER_VALUE);
            root.Add(AR_PACKAGES);

            dictionary91["lin"] = root;

            typeof(ParserXML).GetField("CdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseAndSaveCDFFileStringXDocument = (ParserXML instance, String path, XDocument file) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseAndSaveBswConfigurationXDocument = (ParserXML instance, XDocument bsw) =>
            {
                return;
            }

            ;

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ValidateBswConfigurationsGeneral = (ParserXML instance) =>
            {
                return;
            }

           ;
            Int32 int32135 = 0;
            Int32 flag = int32135;
            var userinterface18 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface18.ErrorInt32Int32StringObjectArray = (Int32 id, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface18.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface18);
            List<Tuple<string, ParseConfigStatus>> ParseConfigStatus =
                                                                       new List<Tuple<string, ParseConfigStatus>>();
            typeof(ParserXML).GetField("ParseConfigStatus", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, ParseConfigStatus);

            /* Act */
            typeof(ParserXML).GetMethod("ParseCDFs", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual(flag, 0);
        }
    }

    [TestMethod]
    public void ParseCDFsTest_6_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, XDocument> dictionary91 = new Dictionary<String, XDocument>();
            XElement document = new XElement("AR-PACKAGE");

            XElement root = new XElement("ELEMENTS");
            XElement BSW_MODULE_DESCRIPTION = new XElement("BSW-MODULE-DESCRIPTION");
            XElement short_name = new XElement("SHORT-NAME", "LinInternalBehavior");
            XElement moduleId = new XElement("MODULE-ID", "82");
            BSW_MODULE_DESCRIPTION.Add(short_name);
            BSW_MODULE_DESCRIPTION.Add(moduleId);
            BSW_MODULE_DESCRIPTION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));

            XElement BSW_IMPLEMENTATION = new XElement("BSW-IMPLEMENTATION");
            XElement shortName2 = new XElement("PROGRAMMING-LANGUAGE", "C");
            XElement SW_VERSION = new XElement("SW-VERSION", "1.2.10");
            XElement VENDOR_ID = new XElement("VENDOR-ID", "59");
            XElement AR_RELEASE_VERSION = new XElement("AR-RELEASE-VERSION", "4.2.2");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REFS = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REFS");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REF = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REF", "/Renesas/EcucDefs_Lin/Lin");
            BSW_IMPLEMENTATION.Add(shortName2);
            BSW_IMPLEMENTATION.Add(SW_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_ID);
            BSW_IMPLEMENTATION.Add(AR_RELEASE_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_SPECIFIC_MODULE_DEF_REFS);
            VENDOR_SPECIFIC_MODULE_DEF_REFS.Add(VENDOR_SPECIFIC_MODULE_DEF_REF);
            BSW_IMPLEMENTATION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));
            root.Add(BSW_IMPLEMENTATION);

            /* Arrange */
            XDocument temp = new XDocument();
            document.Add(root);
            temp.Add(document);

            dictionary91["lin"] = temp;

            typeof(ParserXML).GetField("CdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseAndSaveCDFFileStringXDocument = (ParserXML instance, String path, XDocument file) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseAndSaveBswConfigurationXDocument = (ParserXML instance, XDocument bsw) =>
            {
                return;
            }

            ;

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ValidateBswConfigurationsGeneral = (ParserXML instance) =>
            {
                return;
            }

           ;
            Int32 int32135 = 0;
            Int32 flag = int32135;
            var userinterface18 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface18.ErrorInt32Int32StringObjectArray = (Int32 id, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface18.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface18);
            List<Tuple<string, ParseConfigStatus>> ParseConfigStatus =
                                                                       new List<Tuple<string, ParseConfigStatus>>();
            typeof(ParserXML).GetField("ParseConfigStatus", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, ParseConfigStatus);

            /* Act */
            typeof(ParserXML).GetMethod("ParseCDFs", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual(flag, 0);
        }
    }

    [TestMethod]
    public void ParseCDFsTest_6_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, XDocument> dictionary91 = new Dictionary<String, XDocument>();
            XElement document = new XElement("AR-PACKAGE");

            XElement root = new XElement("ELEMENTS");
            XElement BSW_MODULE_DESCRIPTION = new XElement("BSW-MODULE-DESCRIPTION");
            XElement short_name = new XElement("SHORT-NAME", "LinInternalBehavior");
            XElement moduleId = new XElement("MODULE-ID", "82");
            BSW_MODULE_DESCRIPTION.Add(short_name);
            BSW_MODULE_DESCRIPTION.Add(moduleId);
            BSW_MODULE_DESCRIPTION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));

            XElement BSW_IMPLEMENTATION = new XElement("BSW-IMPLEMENTATION");
            XElement shortName2 = new XElement("PROGRAMMING-LANGUAGE", "C");
            XElement SW_VERSION = new XElement("SW-VERSION", "1.2.10");
            XElement VENDOR_ID = new XElement("VENDOR-ID", "59");
            XElement AR_RELEASE_VERSION = new XElement("AR-RELEASE-VERSION", "4.2.2");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REFS = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REFS");
            XElement VENDOR_SPECIFIC_MODULE_DEF_REF = new XElement("VENDOR-SPECIFIC-MODULE-DEF-REF", "/Renesas/EcucDefs_Lin/Lin");
            BSW_IMPLEMENTATION.Add(shortName2);
            BSW_IMPLEMENTATION.Add(SW_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_ID);
            BSW_IMPLEMENTATION.Add(AR_RELEASE_VERSION);
            BSW_IMPLEMENTATION.Add(VENDOR_SPECIFIC_MODULE_DEF_REFS);
            VENDOR_SPECIFIC_MODULE_DEF_REFS.Add(VENDOR_SPECIFIC_MODULE_DEF_REF);
            BSW_IMPLEMENTATION.Add(new XAttribute("UUID", "dc84b7f1-14cb-4499-a58e-6cd9a8a388f0"));
            root.Add(BSW_IMPLEMENTATION);

            /* Arrange */
            XDocument temp = new XDocument();
            document.Add(root);
            temp.Add(document);

            dictionary91["path1"] = temp;
            dictionary91["path2"] = temp;

            typeof(ParserXML).GetField("CdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseAndSaveCDFFileStringXDocument = (ParserXML instance, String path, XDocument file) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseAndSaveBswConfigurationXDocument = (ParserXML instance, XDocument bsw) =>
            {
                return;
            }

            ;

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ValidateBswConfigurationsGeneral = (ParserXML instance) =>
            {
                return;
            }

           ;
            Int32 int32135 = 0;
            Int32 flag = int32135;
            var userinterface18 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface18.ErrorInt32Int32StringObjectArray = (Int32 id, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface18.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface18);
            List<Tuple<string, ParseConfigStatus>> ParseConfigStatus =
                                                                       new List<Tuple<string, ParseConfigStatus>>();
            typeof(ParserXML).GetField("ParseConfigStatus", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, ParseConfigStatus);
            /* Act */
            typeof(ParserXML).GetMethod("ParseCDFs", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual(flag, 40);
        }
    }

    [TestMethod]
    public void ParseCDFsTest_6_4()
    {
        using (ShimsContext.Create())
        {
            XDocument root = new XDocument();
            XElement AR_PACKAGES = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE = new XElement("AR-PACKAGE");
            XElement SHORT_NAME = new XElement("SHORT-NAME", "Lin");
            AR_PACKAGE.Add(SHORT_NAME);
            AR_PACKAGES.Add(AR_PACKAGE);

            XElement ELEMENTS = new XElement("ELEMENTS");
            AR_PACKAGE.Add(ELEMENTS);
            XElement ECUC_MODULE_CONFIGURATION_VALUES = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            ELEMENTS.Add(ECUC_MODULE_CONFIGURATION_VALUES);

            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(DEFINITION_REF);
            XElement MODULE_DESCRIPTION_REF = new XElement("MODULE-DESCRIPTION-REF", "/Renesas/EcucDefs_Lin/Lin_Impl");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(MODULE_DESCRIPTION_REF);

            XElement CONTAINERS = new XElement("CONTAINERS");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(CONTAINERS);

            ECUC_MODULE_CONFIGURATION_VALUES.Add(SHORT_NAME);

            XElement ECUC_CONTAINER_VALUE = new XElement("ECUC-CONTAINER-VALUE");
            XElement SHORT_NAME2 = new XElement("SHORT-NAME", "LinGeneral");
            XElement DEFINITION_REF2 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral");
            ECUC_CONTAINER_VALUE.Add(SHORT_NAME2);
            ECUC_CONTAINER_VALUE.Add(DEFINITION_REF2);

            XElement PARAMETER_VALUES = new XElement("PARAMETER-VALUES");
            ECUC_CONTAINER_VALUE.Add(PARAMETER_VALUES);

            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement DEFINITION_REF3 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules");
            DEFINITION_REF3.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            XElement VALUE1 = new XElement("VALUE", "true");
            ECUC_NUMERICAL_PARAM_VALUE.Add(DEFINITION_REF3);
            ECUC_NUMERICAL_PARAM_VALUE.Add(VALUE1);
            PARAMETER_VALUES.Add(ECUC_NUMERICAL_PARAM_VALUE);

            XElement REFERENCE_VALUES = new XElement("REFERENCE-VALUES");
            XElement ECUC_REFERENCE_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement DEFINITION_REF4 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            DEFINITION_REF4.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement VALUE2 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            ECUC_REFERENCE_VALUE.Add(DEFINITION_REF4);
            ECUC_REFERENCE_VALUE.Add(VALUE2);
            REFERENCE_VALUES.Add(ECUC_REFERENCE_VALUE);
            ECUC_CONTAINER_VALUE.Add(REFERENCE_VALUES);

            root.Add(AR_PACKAGES);
            Dictionary<String, XDocument> dictionary91 = new Dictionary<String, XDocument>();
            dictionary91["lin"] = root;

            typeof(ParserXML).GetField("CdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary91);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseAndSaveCDFFileStringXDocument = (ParserXML instance, String path, XDocument file) =>
            {
                return;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ParseAndSaveBswConfigurationXDocument = (ParserXML instance, XDocument bsw) =>
            {
                return;
            }

            ;

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ValidateBswConfigurationsGeneral = (ParserXML instance) =>
            {
                return;
            }

           ;
            Int32 int32135 = 0;
            Int32 flag = int32135;
            var userinterface18 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface18.ErrorInt32Int32StringObjectArray = (Int32 id, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface18.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface18);
            List<Tuple<string, ParseConfigStatus>> ParseConfigStatus =
                                                                        new List<Tuple<string, ParseConfigStatus>>();
            Tuple<string, ParseConfigStatus> item = new Tuple<string, ParseConfigStatus>("item1",Renesas.Generator.MCALConfGen.Business.Parser.ParseConfigStatus.NoData);
            ParseConfigStatus.Add(item);
            typeof(ParserXML).GetField("ParseConfigStatus",BindingFlags.Instance|BindingFlags.NonPublic).SetValue(_target, ParseConfigStatus);     
            /* Act */
            typeof(ParserXML).GetMethod("ParseCDFs", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual(47, flag);

        }
    }

}