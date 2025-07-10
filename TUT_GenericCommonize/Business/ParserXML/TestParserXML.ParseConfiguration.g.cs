using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using System.Xml.Linq;
using static Renesas.Generator.MCALConfGen.Business.Parser.ParserXML;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestParserXML
{
    public class ParserXMLTest : ParserXML
    {
        public ParseConfigStatus ParseConfigurationTest(XElement element, ref Configuration con)
        {
            return ParseConfiguration(element,ref con);
        }
    }
    [TestMethod]
    public void ParseConfigurationTest_3_1()
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
            ECUC_MODULE_CONFIGURATION_VALUES.Add(new XAttribute("UUID", "7fdb4340-43f0-4b76-b8bb-8a1ed5cb0e20"));
            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(DEFINITION_REF);
            XElement MODULE_DESCRIPTION_REF = new XElement("MODULE-DESCRIPTION-REF", "/Bosch/EcucDefs_Lin/Lin_Impl");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(MODULE_DESCRIPTION_REF);

            XElement ADMIN_DATA = new XElement("ADMIN-DATA");
            XElement SDGS = new XElement("SDGS");
            XElement SDG = new XElement("SDG");
            SDG.Add(new XAttribute("GID", "DV:CfgPostBuild"));
            XElement SD = new XElement("SD", "false");
            SD.Add(new XAttribute("GID", "DV:postBuildVariantSupport"));
            SDG.Add(SD);
            SDGS.Add(SDG);
            ADMIN_DATA.Add(SDGS);
            ECUC_MODULE_CONFIGURATION_VALUES.Add(ADMIN_DATA);

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

            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            basicConfiguration.ModuleName = "Lin";
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, basicConfiguration);

            /* Arrange */
            Configuration status = new Configuration();
            /* Act */
            ParserXMLTest test = new ParserXMLTest();
            ParseConfigStatus actualResult = test.ParseConfigurationTest(ECUC_MODULE_CONFIGURATION_VALUES, ref status);
            /* Assert */
            Assert.AreEqual("Lin", status.ShortName);
            Assert.AreEqual("/Bosch/EcucDefs_Lin/Lin", status.DefinitionRef);
            Assert.AreEqual("/Bosch/EcucDefs_Lin/Lin_Impl", status.ModuleDescriptionRef);
            Assert.AreEqual("false", status.postBuildVariantSupport);
        }
    }

    [TestMethod]
    public void ParseConfigurationTest_3_2()
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

            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "/Bosch/EcucDefs_Lin/Lin");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(DEFINITION_REF);
            XElement MODULE_DESCRIPTION_REF = new XElement("MODULE-DESCRIPTION-REF", "/Bosch/EcucDefs_Lin/Lin_Impl");
            ECUC_MODULE_CONFIGURATION_VALUES.Add(MODULE_DESCRIPTION_REF);

            XElement ADMIN_DATA = new XElement("ADMIN-DATA");
            XElement SDGS = new XElement("SDGS");
            XElement SDG = new XElement("SDG");
            SDG.Add(new XAttribute("GID", "DV:CfgPostBuild"));
            XElement SD = new XElement("SD", "true");
            SD.Add(new XAttribute("GID", "DV:postBuildVariantSupport"));
            SDG.Add(SD);
            SDGS.Add(SDG);
            ADMIN_DATA.Add(SDGS);
            ECUC_MODULE_CONFIGURATION_VALUES.Add(ADMIN_DATA);

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
            Configuration status = new Configuration();
            /* Act */
            ParserXMLTest test = new ParserXMLTest();
            ParseConfigStatus actualResult = test.ParseConfigurationTest(ECUC_MODULE_CONFIGURATION_VALUES, ref status);
            /* Assert */
            Assert.AreEqual("Lin", status.ShortName);
            Assert.AreEqual("/Bosch/EcucDefs_Lin/Lin", status.DefinitionRef);
            Assert.AreEqual("/Bosch/EcucDefs_Lin/Lin_Impl", status.ModuleDescriptionRef);
            Assert.AreEqual("true", status.postBuildVariantSupport);
        }
    }
    
}