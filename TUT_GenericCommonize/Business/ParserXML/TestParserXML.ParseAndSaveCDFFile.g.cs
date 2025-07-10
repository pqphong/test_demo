using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using System.Xml.Linq;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestParserXML
{
    [TestMethod]
    public void ParseAndSaveCDFFileTest_2_1()
    {
        using (ShimsContext.Create())
        {
            // Init
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

            /* Arrange */
            String string113 = "LIN";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string113);

            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface17);

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildAndSaveContainerTreeXDocumentXElementConfiguration = (instance,a,b,c) =>
            {
                // do nothing

            };


            String string91 = "";
            String path = string91;
            /* Act */
            typeof(ParserXML).GetMethod("ParseAndSaveCDFFile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(XDocument)}, null).Invoke(_target, new object[]{path, root});
            /* Assert */
            Assert.AreEqual(0,flag);
        }
    }

    [TestMethod]
    public void ParseAndSaveCDFFileTest_2_2()
    {
        using (ShimsContext.Create())
        {
            // Init
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
            XElement MODULE_DESCRIPTION_REF = new XElement("MODULE-DESCRIPTION-REF", "");
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

            /* Arrange */
            String string113 = "LIN";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string113);

            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface17);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildAndSaveContainerTreeXDocumentXElementConfiguration = (instance, a, b, c) =>
            {
                // do nothing

            };

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ShouldFilterOutConfigurationConfiguration = (instance, config) =>
            {
                return false;
            };


            String string91 = "";
            String path = string91;
            /* Act */
            typeof(ParserXML).GetMethod("ParseAndSaveCDFFile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XDocument) }, null).Invoke(_target, new object[] { path, root });
            /* Assert */
            Assert.AreEqual(28, flag);
        }
    }

    [TestMethod]
    public void ParseAndSaveCDFFileTest_2_3()
    {
        using (ShimsContext.Create())
        {
            // Init
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

            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(DEFINITION_REF);
            XElement MODULE_DESCRIPTION_REF = new XElement("MODULE-DESCRIPTION-REF", "");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(MODULE_DESCRIPTION_REF);

            XElement CONTAINERS = new XElement("CONTAINERS");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(CONTAINERS);

            ECUC_MODULE_CONFIGURATION_VALUES.Add(SHORT_NAME);

            XElement ECUC_CONTAINER_VALUE = new XElement("ECUC-CONTAINER-VALUE");
            XElement SHORT_NAME2 = new XElement("SHORT-NAME", "LinGeneral");
            XElement DEFINITION_REF2 = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin/LinGeneral");
            ECUC_CONTAINER_VALUE.Add(SHORT_NAME2);
            ECUC_CONTAINER_VALUE.Add(DEFINITION_REF2);

            XElement PARAMETER_VALUES = new XElement("PARAMETER-VALUES");
            ECUC_CONTAINER_VALUE.Add(PARAMETER_VALUES);

            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement DEFINITION_REF3 = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules");
            DEFINITION_REF3.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            XElement VALUE1 = new XElement("VALUE", "true");
            ECUC_NUMERICAL_PARAM_VALUE.Add(DEFINITION_REF3);
            ECUC_NUMERICAL_PARAM_VALUE.Add(VALUE1);
            PARAMETER_VALUES.Add(ECUC_NUMERICAL_PARAM_VALUE);

            XElement REFERENCE_VALUES = new XElement("REFERENCE-VALUES");
            XElement ECUC_REFERENCE_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement DEFINITION_REF4 = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            DEFINITION_REF4.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement VALUE2 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            ECUC_REFERENCE_VALUE.Add(DEFINITION_REF4);
            ECUC_REFERENCE_VALUE.Add(VALUE2);
            REFERENCE_VALUES.Add(ECUC_REFERENCE_VALUE);
            ECUC_CONTAINER_VALUE.Add(REFERENCE_VALUES);

            CONTAINERS.Add(ECUC_CONTAINER_VALUE);
            root.Add(AR_PACKAGES);

            /* Arrange */
            String string113 = "LIN";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string113);

            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface17);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildAndSaveContainerTreeXDocumentXElementConfiguration = (instance, a, b, c) =>
            {
                // do nothing

            };

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.ShouldFilterOutConfigurationConfiguration = (instance, config) =>
            {
                return true;
            };

            String string91 = "";
            String path = string91;
            /* Act */
            typeof(ParserXML).GetMethod("ParseAndSaveCDFFile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XDocument) }, null).Invoke(_target, new object[] { path, root });
            /* Assert */
            Assert.AreEqual(0, flag);
        }
    }

    [TestMethod]
    public void ParseAndSaveCDFFileTest_2_4()
    {
        using (ShimsContext.Create())
        {
            // Init
            XDocument root = new XDocument();
            XElement AR_PACKAGES = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE = new XElement("AR-PACKAGE");
            XElement SHORT_NAME = new XElement("SHORT-NAME", "Spi");
            AR_PACKAGE.Add(SHORT_NAME);
            AR_PACKAGES.Add(AR_PACKAGE);

            XElement ELEMENTS = new XElement("ELEMENTS");
            AR_PACKAGE.Add(ELEMENTS);
            XElement ECUC_MODULE_CONFIGURATION_VALUES = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            ELEMENTS.Add(ECUC_MODULE_CONFIGURATION_VALUES);

            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Spi/Spi");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(DEFINITION_REF);
            XElement MODULE_DESCRIPTION_REF = new XElement("MODULE-DESCRIPTION-REF", "/Bosch/EcucDefs_Spi/Spi_Impl");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(MODULE_DESCRIPTION_REF);

            XElement CONTAINERS = new XElement("CONTAINERS");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(CONTAINERS);

            ECUC_MODULE_CONFIGURATION_VALUES.Add(SHORT_NAME);

            XElement ECUC_CONTAINER_VALUE = new XElement("ECUC-CONTAINER-VALUE");
            XElement SHORT_NAME2 = new XElement("SHORT-NAME", "LinGeneral");
            XElement DEFINITION_REF2 = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin/LinGeneral");
            ECUC_CONTAINER_VALUE.Add(SHORT_NAME2);
            ECUC_CONTAINER_VALUE.Add(DEFINITION_REF2);

            XElement PARAMETER_VALUES = new XElement("PARAMETER-VALUES");
            ECUC_CONTAINER_VALUE.Add(PARAMETER_VALUES);

            XElement ECUC_NUMERICAL_PARAM_VALUE = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement DEFINITION_REF3 = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules");
            DEFINITION_REF3.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            XElement VALUE1 = new XElement("VALUE", "true");
            ECUC_NUMERICAL_PARAM_VALUE.Add(DEFINITION_REF3);
            ECUC_NUMERICAL_PARAM_VALUE.Add(VALUE1);
            PARAMETER_VALUES.Add(ECUC_NUMERICAL_PARAM_VALUE);

            XElement REFERENCE_VALUES = new XElement("REFERENCE-VALUES");
            XElement ECUC_REFERENCE_VALUE = new XElement("ECUC-REFERENCE-VALUE");
            XElement DEFINITION_REF4 = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel/LinClockRef");
            DEFINITION_REF4.Add(new XAttribute("DEST", "ECUC-REFERENCE-DEF"));
            XElement VALUE2 = new XElement("VALUE-REF", "/ActiveEcuC/Mcu/McuModuleConfiguration/McuClockSettingConfig/McuClockReferencePoint");
            ECUC_REFERENCE_VALUE.Add(DEFINITION_REF4);
            ECUC_REFERENCE_VALUE.Add(VALUE2);
            REFERENCE_VALUES.Add(ECUC_REFERENCE_VALUE);
            ECUC_CONTAINER_VALUE.Add(REFERENCE_VALUES);

            CONTAINERS.Add(ECUC_CONTAINER_VALUE);
            root.Add(AR_PACKAGES);

            /* Arrange */
            String string113 = "Spi";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string113);

            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface17);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildAndSaveContainerTreeXDocumentXElementConfiguration = (instance, a, b, c) =>
            {
                // do nothing

            };
            String string91 = "";
            String path = string91;
            /* Act */
            typeof(ParserXML).GetMethod("ParseAndSaveCDFFile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XDocument) }, null).Invoke(_target, new object[] { path, root });
            /* Assert */
            Assert.AreEqual(0, flag);
        }
    }

    [TestMethod]
    public void ParseAndSaveCDFFileTest_2_5()
    {
        using (ShimsContext.Create())
        {
            // Init
            XDocument root = new XDocument();
            XElement AR_PACKAGES = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE = new XElement("AR-PACKAGE");
            XElement SHORT_NAME = new XElement("SHORT-NAME", "Spi");
            AR_PACKAGE.Add(SHORT_NAME);
            AR_PACKAGES.Add(AR_PACKAGE);

            XElement ELEMENTS = new XElement("ELEMENTS");
            AR_PACKAGE.Add(ELEMENTS);
            XElement ECUC_MODULE_CONFIGURATION_VALUES = new XElement("ECUC-VALUE-COLLECTION");
            ELEMENTS.Add(ECUC_MODULE_CONFIGURATION_VALUES);

            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Spi/Spi");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(DEFINITION_REF);
            XElement MODULE_DESCRIPTION_REF = new XElement("MODULE-DESCRIPTION-REF", "/Renesas/EcucDefs_Spi/Spi_Impl");
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

            /* Arrange */
            String string113 = "LIN";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string113);

            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface17);
            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildAndSaveContainerTreeXDocumentXElementConfiguration = (instance, a, b, c) =>
            {
                // do nothing

            };
            String string91 = "";
            String path = string91;
            /* Act */
            typeof(ParserXML).GetMethod("ParseAndSaveCDFFile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XDocument) }, null).Invoke(_target, new object[] { path, root });
            /* Assert */
            Assert.AreEqual(0, flag);
        }
    }

    [TestMethod]
    public void ParseAndSaveCDFFileTest_2_6()
    {
        using (ShimsContext.Create())
        {
            // Init
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
                        
            root.Add(AR_PACKAGES);

            /* Arrange */
            String string113 = "Spi";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string113);

            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface17);

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildAndSaveContainerTreeXDocumentXElementConfiguration = (instance, a, b, c) =>
            {
                // do nothing

            };


            String string91 = "";
            String path = string91;
            /* Act */
            typeof(ParserXML).GetMethod("ParseAndSaveCDFFile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XDocument) }, null).Invoke(_target, new object[] { path, root });
            /* Assert */
            Assert.AreEqual(0, flag);
        }
    }

    [TestMethod]
    public void ParseAndSaveCDFFileTest_2_7()
    {
        using (ShimsContext.Create())
        {
            // Init
            XDocument root = new XDocument();
            XElement AR_PACKAGES = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE = new XElement("AR-PACKAGE");
            XElement SHORT_NAME = new XElement("SHORT-NAME", "VariantDefinition");
            AR_PACKAGE.Add(SHORT_NAME);
            AR_PACKAGES.Add(AR_PACKAGE);

            XElement ELEMENTS = new XElement("ELEMENTS");
            AR_PACKAGE.Add(ELEMENTS);
            XElement EVALUATED_VARIANT_SET = new XElement("EVALUATED-VARIANT-SET");
            ELEMENTS.Add(EVALUATED_VARIANT_SET);

            XElement SHORTNAME1 = new XElement("SHORT-NAME", "EvaluatedVariantSet");
            EVALUATED_VARIANT_SET.Add(SHORTNAME1);

            XElement EVALUATED_VARIANT_REFS = new XElement("EVALUATED-VARIANT-REFS");
            XElement EVALUATED_VARIANT_REF = new XElement("EVALUATED-VARIANT-REF", "/VariantDefinition/Variant/Variant_1");
            EVALUATED_VARIANT_REF.Add(new XAttribute("DEST", "PREDEFINED-VARIANT"));
            EVALUATED_VARIANT_REFS.Add(EVALUATED_VARIANT_REF);
            EVALUATED_VARIANT_SET.Add(EVALUATED_VARIANT_REFS);

            XElement AR_PACKAGES2 = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE2 = new XElement("AR-PACKAGE");
            XElement SHORT_NAME2 = new XElement("SHORT-NAME", "Variant");
            AR_PACKAGE2.Add(SHORT_NAME2);
            AR_PACKAGES2.Add(AR_PACKAGE2);
            AR_PACKAGE.Add(AR_PACKAGES2);

            XElement AR_PACKAGES3 = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE3 = new XElement("AR-PACKAGE");
            XElement SHORT_NAME3 = new XElement("SHORT-NAME", "CriterionValueSet");
            AR_PACKAGE3.Add(SHORT_NAME3);
            AR_PACKAGES3.Add(AR_PACKAGE3);
            AR_PACKAGE2.Add(AR_PACKAGES3);

            XElement ELEMENTS3 = new XElement("ELEMENTS");
            AR_PACKAGE3.Add(ELEMENTS3);
            XElement POST_BUILD_VARIANT_CRITERION_VALUE_SET = new XElement("POST-BUILD-VARIANT-CRITERION-VALUE-SET");
            ELEMENTS3.Add(POST_BUILD_VARIANT_CRITERION_VALUE_SET);

            XElement SHORTNAME3 = new XElement("SHORT-NAME", "Variant_1");
            POST_BUILD_VARIANT_CRITERION_VALUE_SET.Add(SHORTNAME3);


            XElement POST_BUILD_VARIANT_CRITERION_VALUES = new XElement("POST-BUILD-VARIANT-CRITERION-VALUES");
            XElement POST_BUILD_VARIANT_CRITERION_VALUE = new XElement("POST_BUILD_VARIANT_CRITERION_VALUE");
            XElement VARIANT_CRITERION_REF = new XElement("VARIANT-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            VARIANT_CRITERION_REF.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement VALUE = new XElement("VALUE", "0");
            POST_BUILD_VARIANT_CRITERION_VALUE.Add(VARIANT_CRITERION_REF);
            POST_BUILD_VARIANT_CRITERION_VALUE.Add(VALUE);
            POST_BUILD_VARIANT_CRITERION_VALUES.Add(POST_BUILD_VARIANT_CRITERION_VALUE);
            POST_BUILD_VARIANT_CRITERION_VALUE_SET.Add(POST_BUILD_VARIANT_CRITERION_VALUES);

            XElement AR_PACKAGE4 = new XElement("AR-PACKAGE");
            XElement SHORT_NAME4 = new XElement("SHORT-NAME", "Criterion");
            XElement ELEMENTS4 = new XElement("ELEMENTS");
            XElement POST_BUILD_VARIANT_CRITERION = new XElement("POST-BUILD-VARIANT-CRITERION");
            XElement SHORT_NAME5 = new XElement("SHORT-NAME", "Criterion_1");
            XElement COMPU_METHOD_REF = new XElement("COMPU-METHOD-REF", "/VariantDefinition/Criterion/Value/Criterion_1");
            COMPU_METHOD_REF.Add(new XAttribute("DEST", "COMPU-METHOD"));
            POST_BUILD_VARIANT_CRITERION.Add(SHORT_NAME5);
            POST_BUILD_VARIANT_CRITERION.Add(COMPU_METHOD_REF);
            ELEMENTS4.Add(POST_BUILD_VARIANT_CRITERION);
            AR_PACKAGE4.Add(SHORT_NAME4);
            AR_PACKAGE4.Add(ELEMENTS4);
            AR_PACKAGES2.Add(AR_PACKAGE4);

            root.Add(AR_PACKAGES);

            /* Arrange */
            String string113 = "Spi";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string113);

            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetVariantCriterionSet = (CdfDataDictionary instance) =>
            {
                return null;
            }
            ;

            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface17);

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildAndSaveContainerTreeXDocumentXElementConfiguration = (instance, a, b, c) =>
            {
                // do nothing

            };


            String string91 = "";
            String path = string91;
            /* Act */
            typeof(ParserXML).GetMethod("ParseAndSaveCDFFile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XDocument) }, null).Invoke(_target, new object[] { path, root });
            /* Assert */
            Assert.AreEqual(0, flag);
        }
    }

    [TestMethod]
    public void ParseAndSaveCDFFileTest_2_8()
    {
        using (ShimsContext.Create())
        {
            // Init
            XDocument root = new XDocument();
            XElement AR_PACKAGES = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE = new XElement("AR-PACKAGE");
            XElement SHORT_NAME = new XElement("SHORT-NAME", "VariantDefinition");
            AR_PACKAGE.Add(SHORT_NAME);
            AR_PACKAGES.Add(AR_PACKAGE);

            XElement ELEMENTS = new XElement("ELEMENTS");
            AR_PACKAGE.Add(ELEMENTS);
            XElement EVALUATED_VARIANT_SET = new XElement("EVALUATED-VARIANT-SET");
            ELEMENTS.Add(EVALUATED_VARIANT_SET);

            XElement SHORTNAME1 = new XElement("SHORT-NAME", "EvaluatedVariantSet");
            EVALUATED_VARIANT_SET.Add(SHORTNAME1);

            XElement EVALUATED_VARIANT_REFS = new XElement("EVALUATED-VARIANT-REFS");
            XElement EVALUATED_VARIANT_REF = new XElement("EVALUATED-VARIANT-REF", "/VariantDefinition/Variant/Variant_1");
            EVALUATED_VARIANT_REF.Add(new XAttribute("DEST", "PREDEFINED-VARIANT"));
            EVALUATED_VARIANT_REFS.Add(EVALUATED_VARIANT_REF);
            EVALUATED_VARIANT_SET.Add(EVALUATED_VARIANT_REFS);

            XElement AR_PACKAGES2 = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE2 = new XElement("AR-PACKAGE");
            XElement SHORT_NAME2 = new XElement("SHORT-NAME", "Variant");
            AR_PACKAGE2.Add(SHORT_NAME2);
            AR_PACKAGES2.Add(AR_PACKAGE2);
            AR_PACKAGE.Add(AR_PACKAGES2);

            XElement AR_PACKAGES3 = new XElement("AR-PACKAGES");
            XElement AR_PACKAGE3 = new XElement("AR-PACKAGE");
            XElement SHORT_NAME3 = new XElement("SHORT-NAME", "CriterionValueSet");
            AR_PACKAGE3.Add(SHORT_NAME3);
            AR_PACKAGES3.Add(AR_PACKAGE3);
            AR_PACKAGE2.Add(AR_PACKAGES3);

            XElement ELEMENTS3 = new XElement("ELEMENTS");
            AR_PACKAGE3.Add(ELEMENTS3);
            XElement POST_BUILD_VARIANT_CRITERION_VALUE_SET = new XElement("POST-BUILD-VARIANT-CRITERION-VALUE-SET");
            ELEMENTS3.Add(POST_BUILD_VARIANT_CRITERION_VALUE_SET);

            XElement SHORTNAME3 = new XElement("SHORT-NAME", "Variant_1");
            POST_BUILD_VARIANT_CRITERION_VALUE_SET.Add(SHORTNAME3);


            XElement POST_BUILD_VARIANT_CRITERION_VALUES = new XElement("POST-BUILD-VARIANT-CRITERION-VALUES");
            XElement POST_BUILD_VARIANT_CRITERION_VALUE = new XElement("POST_BUILD_VARIANT_CRITERION_VALUE");
            XElement VARIANT_CRITERION_REF = new XElement("VARIANT-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            VARIANT_CRITERION_REF.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement VALUE = new XElement("VALUE", "0");
            POST_BUILD_VARIANT_CRITERION_VALUE.Add(VARIANT_CRITERION_REF);
            POST_BUILD_VARIANT_CRITERION_VALUE.Add(VALUE);
            POST_BUILD_VARIANT_CRITERION_VALUES.Add(POST_BUILD_VARIANT_CRITERION_VALUE);
            POST_BUILD_VARIANT_CRITERION_VALUE_SET.Add(POST_BUILD_VARIANT_CRITERION_VALUES);

            XElement AR_PACKAGE4 = new XElement("AR-PACKAGE");
            XElement SHORT_NAME4 = new XElement("SHORT-NAME", "Criterion");
            XElement ELEMENTS4 = new XElement("ELEMENTS");
            XElement POST_BUILD_VARIANT_CRITERION = new XElement("POST-BUILD-VARIANT-CRITERION");
            XElement SHORT_NAME5 = new XElement("SHORT-NAME", "Criterion_1");
            XElement COMPU_METHOD_REF = new XElement("COMPU-METHOD-REF", "/VariantDefinition/Criterion/Value/Criterion_1");
            COMPU_METHOD_REF.Add(new XAttribute("DEST", "COMPU-METHOD"));
            POST_BUILD_VARIANT_CRITERION.Add(SHORT_NAME5);
            POST_BUILD_VARIANT_CRITERION.Add(COMPU_METHOD_REF);
            ELEMENTS4.Add(POST_BUILD_VARIANT_CRITERION);
            AR_PACKAGE4.Add(SHORT_NAME4);
            AR_PACKAGE4.Add(ELEMENTS4);
            AR_PACKAGES2.Add(AR_PACKAGE4);

            root.Add(AR_PACKAGES);

            /* Arrange */
            String string113 = "Spi";
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration14, string113);

            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetVariantCriterionSet = (CdfDataDictionary instance) =>
            {
                String output = "criterion2";
                return output;
            }
            ;

            Int32 int32124 = 0;
            Int32 flag = int32124;
            var userinterface17 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface17.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface17);

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildAndSaveContainerTreeXDocumentXElementConfiguration = (instance, a, b, c) =>
            {
                // do nothing

            };


            String string91 = "";
            String path = string91;
            /* Act */
            typeof(ParserXML).GetMethod("ParseAndSaveCDFFile", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(XDocument) }, null).Invoke(_target, new object[] { path, root });
            /* Assert */
            Assert.AreEqual(60, flag);
        }
    }
}
