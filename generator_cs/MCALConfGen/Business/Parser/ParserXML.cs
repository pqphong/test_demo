/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = ParserXML.cs                                                                                        */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2024 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains ParserXML class that parses CDF, BSW, translation and device files                     */
/*                                                                                                                    */
/*====================================================================================================================*/
/*                                                                                                                    */
/* Unless otherwise agreed upon in writing between your company and Renesas Electronics Corporation the following     */
/* shall apply!                                                                                                       */
/*                                                                                                                    */
/* Warranty Disclaimer                                                                                                */
/*                                                                                                                    */
/* There is no warranty of any kind whatsoever granted by Renesas. Any warranty is expressly disclaimed and excluded  */
/* by Renesas, either expressed or implied, including but not limited to those for non-infringement of intellectual   */
/* property, merchantability and/or fitness for the particular purpose.                                               */
/*                                                                                                                    */
/* Renesas shall not have any obligation to maintain, service or provide bug fixes for the supplied Product(s) and/or */
/* the Application.                                                                                                   */
/*                                                                                                                    */
/* Each User is solely responsible for determining the appropriateness of using the Product(s) and assumes all risks  */
/* associated with its exercise of rights under this Agreement, including, but not limited to the risks and costs of  */
/* program errors, compliance with applicable laws, damage to or loss of data, programs or equipment, and             */
/* unavailability or interruption of operations.                                                                      */
/*                                                                                                                    */
/* Limitation of Liability                                                                                            */
/*                                                                                                                    */
/* In no event shall Renesas be liable to the User for any incidental, consequential, indirect, or punitive damage    */
/* (including but not limited to lost profits) regardless of whether such liability is based on breach of contract,   */
/* tort, strict liability, breach of warranties, failure of essential purpose or otherwise and even if advised of the */
/* possibility of such damages. Renesas shall not be liable for any services or products provided by third party      */
/* vendors, developers or consultants identified or referred to the User by Renesas in connection with the Product(s) */
/* and/or the Application.                                                                                            */
/*                                                                                                                    */
/*====================================================================================================================*/
/* Environment:                                                                                                       */
/*              Devices:       X2x                                                                                    */
/*====================================================================================================================*/
/* Classes      : This file contains the following class                                                              */
/*              : class ParserXML                                                                                     */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            18/02/2019 :    Handle ILC findings to improve GenTool. Apply template method pattern for Parser module */
/* 1.0.2:     30/12/2019 :    Support new devices and support AR431                                                   */
/*            07/02/2020 :    Fix Gentool Unit test issue #249320, #249222, #249724, #249823                          */
/*            13/02/2020 :    Fix GetRootPath to return correct path in case exist multiple AR-PACKAGE or             */
/*                             multiple ECUC-MODULE-CONFIGURATION-VALUES                                              */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.1.1:     20/08/2020 :    As per ARDAACJ-59, modified method convertToDouble                                      */
/* 1.2.0:     24/08/2020 :    No change code, only increase version.                                                  */
/* 1.2.1:     04/05/2021 :    Update filter condition of ShouldFilterOutConfiguration for stub module                 */
/*                            following STUB tag                                                                      */
/*            05/05/2021 :    Change handler SupportVariants in method: CheckAutosarVersion, ParseTranslationFile,    */
/*                                                                                   UpdateBasicConfigurationIfNeeded */
/*                            Remove method getAllSupportedVariant                                                    */
/*            02/07/2021 :    Update ParseAndSaveBswConfiguration, CheckERR000025, ParseSubElement,                   */
/*                            ValidateBswConfigurationsGeneral, GetRootPath                                           */
/*                            Add new method GetMultiInstanceInformation, GetMultiBswmdtInformation,                  */
/*                            NeedVerifyVendorApiInfix, ParseBswPackage                                               */
/*            16/07/2021 :    Update pseudo code for ParseBswPackage and ID for GetMultiInstanceInformation           */
/* 1.2.2:     25/08/2021 :    Update ValidateBswConfigurationDetail, ValidateBswConfigurationGeneral to check Equals  */
/*            30/08/2021 :    Remove GetMultiBswmdtInformation. Update condition in NeedVerifyVendorApiInfix          */
/*            08/11/2021 :    Update method CheckAutosarVersion                                                       */
/* 1.2.3:     13/09/2022 :    Add new constant U2CX_VARIANT, update method CheckAutosarVersion                        */
/* 1.2.4:     30/03/2023 :    Update method CheckAutosarVersion                                                       */
/* 1.2.5:     21/04/2023 :    Update method CheckAutosarVersion                                                       */
/* 1.2.6:     21/09/2023 :    Replace AR21-11 by AR22-11 in GENERIC_TUD_CLS_025_016                                   */
/* 1.2.7:     02/03/2024 :    Update ParseAndSaveCDFFile, ParseConfiguration, ConvertToContainer, ParseThruParameters,*/
/*                            ParseThruReferences, convertValueFromString, ParseCDFs                                  */
/*                            Add ParseThruVariantPoint, ParseContainerVariantItemValue, ParseVariantItemValue,       */
/*                            CheckVariantPostBuildCDF                                                                */
/*                            Add U2BxE to CheckAutosarVersion                                                        */
/* 1.2.8:     26/03/2924 :    Update CheckVariantPostBuildCDF, ParseThruReferences                                    */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Properties;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using System.Globalization;

namespace Renesas.Generator.MCALConfGen.Business.Parser
{
    /// <summary>
    /// This enum is used to evaluate status after parser parse configuration from CDF.
    /// </summary>
    public enum ParseConfigStatus
    {
        Success,
        NoData
    }
    // Implementation: CMN_TUD_DTT_004

    /// <summary>
    /// "ParserXML" class that parses CDF, BSW, translation and device files
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    public class ParserXML : Parser
    {
        /// <summary>
        /// "ParserXML" instance used by ObjectFactory to get a new ParserXML object
        /// </summary>
        public static readonly ParserXML Instance = new ParserXML();
        // Implementation: GENERIC_TUD_CLS_025_001

        /// <summary>
        /// To save and retrive infomration of CDF files.
        /// </summary>
        protected ICdfData CdfData = null;
        // Implementation: GENERIC_TUD_CLS_025_002

        /// <summary>
        /// To define information processed by command line.
        /// </summary>
        protected IRuntimeConfiguration RuntimeConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_025_003

        /// <summary>
        /// To store basic information of Gentool.
        /// </summary>
        protected IBasicConfiguration BasicConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_025_004

        /// <summary>
        /// To record Error, Warning,Info information and exit Gentool.
        /// </summary>
        protected IUserInterface UserInterface = null;
        // Implementation: GENERIC_TUD_CLS_025_005

        /// <summary>
        /// CDF files
        /// </summary>
        protected Dictionary<string, XDocument> CdfFiles = null;
        // Implementation: GENERIC_TUD_CLS_025_006

        /// <summary>
        /// To parses and stores information of translation and device header files.
        /// </summary>
        protected IRegisterProcessing Register = null;
        // Implementation: GENERIC_TUD_CLS_025_007

        /// <summary>
        /// To evaluate status after parser parse configuration from CDF.
        /// </summary>
        protected List<Tuple<string, ParseConfigStatus>> ParseConfigStatus =
        // Implementation: GENERIC_TUD_CLS_025_008
                                                                        new List<Tuple<string, ParseConfigStatus>>();

        /// <summary>
        /// Store tag name and related field for bswmdt parsing
        /// </summary>
        protected Dictionary<string, string> tagNameToField = new Dictionary<string, string>()
                    {
                        { "IMPLEMENT-SHORT-NAME", "ImplementSortName" },
                        { "IMPLEMENT-PROGRAMMING-LANGUAGE", "ProgrammingLanguage" },
                        { "IMPLEMENT-SW-VERSION", "SwVersion" },
                        { "IMPLEMENT-VENDOR-ID", "VendorId" },
                        { "IMPLEMENT-AR-RELEASE-VERSION", "ArReleaseVersion" },
                        { "IMPLEMENT-VENDOR-API-INFIX", "VendorApiInfix" },
                        { "IMPLEMENT-BEHAVIOR-REF", "BehaviorRef" },
                        { "IMPLEMENT-UUID", "ImplementUuid" },
                        { "DESCRIPTION-SHORT-NAME", "DescriptionShortName" },
                        { "DESCRIPTION-MODULE-ID", "ModuleId" },
                        { "DESCRIPTION-UUID", "DescriptionUuid" },
                        { "IMPLEMENT-VENDOR-SPECIFIC-MODULE-DEF-REFS","VendorSpecificModuleDefRef"}
                    };
        // Implementation: GENERIC_TUD_CLS_025_047

        /// <summary>
        /// To initialize a new ParserXML instance.
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Init component
        /// </algorithm>
        protected ParserXML() : this
        (
            ObjectFactory.GetInstance<ICdfData>(),
            ObjectFactory.GetInstance<IRuntimeConfiguration>(),
            ObjectFactory.GetInstance<IBasicConfiguration>(),
            ObjectFactory.GetInstance<IRegisterProcessing>(),
            ObjectFactory.GetInstance<IUserInterface>()
        )
        {
        }
        // Implementation: GENERIC_TUD_CLS_025_032

        /// <summary>
        /// This is constructor of ParserXML.
        /// </summary>
        /// <param name="cdfData">Cdf data <range>None</range></param>
        /// <param name="runtimeConfiguration">Runtime configuration <range>None</range></param>
        /// <param name="basicConfiguration">Basic configuration <range>None</range></param>
        /// <param name="register">Register <range>None</range></param>
        /// <param name="userInterface">User interface <range>None</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Contructor with:
        ///                 - CdfData
        ///                 - RuntimeConfiguration
        ///                 - BasicConfiguration
        ///                 - Register
        ///                 - UserInterface
        /// </algorithm>
        protected ParserXML
        (
            ICdfData cdfData,
            IRuntimeConfiguration runtimeConfiguration,
            IBasicConfiguration basicConfiguration,
            IRegisterProcessing register,
            IUserInterface userInterface
        )
        {
            this.CdfData = cdfData;
            this.RuntimeConfiguration = runtimeConfiguration;
            this.BasicConfiguration = basicConfiguration;
            this.Register = register;
            this.UserInterface = userInterface;
        }
        // Implementation: GENERIC_TUD_CLS_025_033

        /// <summary>
        /// To get the device's name.
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>The device name</desc>
        ///         <range>null/string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET result = null.
        /// LET Get all instance Containers in CDF data.
        /// FOREACH container in each instance
        ///     IF the value of deviveName is not null or not empty string THEN
        ///         LET result = deviveName.
        ///         break.
        /// RETURN result.
        /// </algorithm>
        protected string GetDeviceName()
        {
            string result = null;
            Dictionary<string, IList<Container>> instanceContainers =
                                                       CdfData.GetAllInstanceContainers(BasicConfiguration.ModuleName);

            // Consider each instance in CDFs
            foreach (IList<Container> eachInstance in instanceContainers.Values)
            {
                foreach (Container container in eachInstance)
                {
                    // Search parameter '<Msn>DeviceName' that contain device name in CDF
                    IList<ItemValue> parameters = container.ParameterValues;
                    string deviveName = parameters
                        .Where(x => x.DefinitionRef().Contains("DeviceName"))
                        .Select(i => i.Value<string>())
                        .FirstOrDefault();
                    // Return first DeviceName value found in each instance
                    if (false == String.IsNullOrEmpty(deviveName))
                    {
                        result = deviveName;
                        break;
                    }
                    else
                    {
                        // Not required
                    }
                } // End of foreach (Container container in containerList).
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_025_021

        /// <summary>
        /// To parse and save CDF file into cdfData.
        /// </summary>
        /// <param name="path">CDF file path <range>!empty</range></param>
        /// <param name="file">CDF file in XDocument <range>!null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_028
		/// CMN_TAD_ERR_060
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET modules = return value by CALL Descendants by file.
		/// LET isEvaluatedVariantfile = false
		/// IF in modules have Name.Local.Name equal to EVALUATED_VARIANT_SET
	    ///	LET isEvaluatedVariantfile = true
        /// ELSE
        ///   Do nothing
        /// FOREACH module in modules, which is wrapped in tag ELEMENTS
        ///	  IF isEvaluatedVariantfile is true
	    ///	    IF module.Name.LocalName == Constant.POST_BUILD_VARIANT_CRITERION_VALUE_SET
	    ///		  LET variantname is empty
	    ///		  FOREACH XElement varelement in module.Elements()
	    ///			IF LocalName of varelement equal to SHORT-NAME
	    ///			  LET variantname = varelement.Value
        ///         ELSE
        ///           Do nothing
	    ///			FOREACH XElement varelement1 in varelement.Elements()
	    ///			  FOREACH XElement varelement2 in varelement1.Elements()
	    ///				IF LocalName of varelement2 equal to VALUE
	    ///				  IF CdfData.GetVariantCriterionSet() is not null or empty
	    ///					LET record ERR000060
	    ///				  ELSE
	    ///				    Save evaluated variant set with varelement2.Value and variantname to CdfData
        ///             ELSE
        ///                 Do nothing
	    ///		ELSE IF Name.LocalName of Module equal to POST_BUILD_VARIANT_CRITERION
	    ///		  FOREACH XElement varelement in module.Elements()
	    ///		    IF Name.LocalName of varelement equal to SHORT_NAME
	   	///			  Save evaluated variant set with varelement.Value and variantname to CdfData
	   	///         ELSE
	   	///             Do nothing
        ///     ELSE
        ///         Do nothing
        ///   ELSE
        ///     	LET config = initialize a Configuration.
        ///     	LET status = return value by CALL ParseConfiguration WITH element is module and config is config.
        ///     	IF the value of status is success in ParseConfigStatus THEN
        ///         	LET moduleName = return value by CALL GetElementLastInArray WITH path is DefinitionRef.
        ///         	IF the MODULE-DESCRIPTION-REF element is not present module specific description file.
        ///             	LET record error ERR000028.
        ///         	ELSE
        ///             	LET Save mapping module short name - CDF file path into cdfData
        ///             	LET CALL method buildAndSaveContainerTree to build a container tree of this module and
        ///                                                                                      save into cdfData
        /// </algorithm>
        protected void ParseAndSaveCDFFile(string path, XDocument file)
        {
            // Ref: GENERIC_TUM_U2x_GT_ERR_028 GENERIC_TUM_U2x_GT_ECU_002
            IEnumerable<XElement> modules = file.Descendants()
                .Where(x => x.Name.LocalName.Contains(Constant.ELEMENTS))
                .Elements();

            bool isEvaluatedVariantfile = false;

            if(modules.Any(x => x.Name.LocalName.Equals(Constant.EVALUATED_VARIANT_SET)))
            {
                isEvaluatedVariantfile = true;
            }
            else
            {
              // Do nothing
            }

            // For each module found in file (module is wrapped in tag ELEMENTS)
            foreach (XElement module in modules.Where(x => !x.Name.LocalName.Equals(Constant.ECUC_VALUE_COLLECTION)))
            {
                // Parse data on configuration in CDF file, it is on tags: DEFINITION-REF, MODULE-DESCRIPTION-REF,
                // SHORT-NAME

                if (isEvaluatedVariantfile)
                {
                    if (module.Name.LocalName == Constant.POST_BUILD_VARIANT_CRITERION_VALUE_SET)
                    {
                        string variantname = "";
                        foreach(XElement varelement in module.Elements())
                        {
                            if(varelement.Name.LocalName == Constant.SHORT_NAME)
                            {
                                variantname = varelement.Value;
                            }
                            else
                            {
                              // Do nothing
                            }
                            foreach(XElement varelement1 in varelement.Elements())
                            {
                                foreach(XElement varelement2 in varelement1.Elements())
                                {
                                    if(varelement2.Name.LocalName == Constant.VALUE)
                                    {
                                        if (!string.IsNullOrEmpty(CdfData.GetVariantCriterionSet()))
                                        {
                                            UserInterface.Error(0, 60, Resources.ERR000060);
                                            UserInterface.Exit();
                                        }
                                        else
                                        {
                                            CdfData.SaveEvaluatedVariantSet(varelement2.Value, variantname);
                                        }
                                    }
                                    else
                                    {
                                      // Do nothing
                                    }
                                }
                            }
                        }
                        
                    }
                    else if(module.Name.LocalName == Constant.POST_BUILD_VARIANT_CRITERION)
                    {
                        foreach(XElement varelement in module.Elements())
                        {
                            if(varelement.Name.LocalName == Constant.SHORT_NAME)
                            {
                                CdfData.SaveVariantCriterionSet(varelement.Value);
                            }
                            else
                            {
                              // Do nothing
                            }
                        }
                    }
                    else
                    {
                      // Do nothing
                    }
                }
                else
                {
                    Configuration config = new Configuration();
                    ParseConfigStatus status = ParseConfiguration(module, ref config);
                    if (status == Business.Parser.ParseConfigStatus.Success)
                    {
                        string moduleName = StringUtils.GetElementLastInArray(config.DefinitionRef);
                        // Handler of ERR000028
                        // Report error if module description reference is missing in cdfs
                        if (BasicConfiguration.ModuleName.Equals(moduleName, StringComparison.OrdinalIgnoreCase) &&
                            string.IsNullOrEmpty(config.ModuleDescriptionRef))
                        {
                            UserInterface.Error(0, 28, Resources.ERR000028, moduleName);
                            UserInterface.Exit();
                        }
                        else
                        {
                            // Save CDF file that is belong to module name and short name in case multi-instance module
                            CdfData.SaveCdfFiles(moduleName, config.ShortName, path);
                            // Parse XML and build object tree in memory
                            BuildAndSaveContainerTree(file, module, config);
                        }
                    } // End of if (status == ParseConfigStatus.Success)
                    else
                    {
                        // Not required
                    }
                    // Save status each config for module MCAL
                    if (BasicConfiguration.ModuleName.Equals(StringUtils.GetElementLastInArray(config.DefinitionRef),
                                                                StringComparison.OrdinalIgnoreCase))
                    {
                        ParseConfigStatus.Add(
                            new Tuple<string, ParseConfigStatus>(StringUtils.GetElementLastInArray(config.DefinitionRef),
                                                                 status));
                    }
                    else
                    {
                        // Not required
                    }
                }
            } // End of foreach (XElement module in modules).

        }
        // Implementation: GENERIC_TUD_CLS_025_024

        /// <summary>
        /// To parse the configuration from CDF files.
        /// </summary>
        /// <param name="element">Element <range>!Null</range></param>
        /// <param name="config">Configuration <range>!Null</range></param>
        /// <returns>
        ///     <para>ParseConfigStatus
        ///         <desc>The Parse configuration</desc>
        ///         <range>null/enum ParseConfigStatus value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_SAMPUSG_013
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET Parse an XElement into a Configuration instance WITH mapping
        ///     - UUID attribute to Uuid field
        ///     - SHORT-NAME tag to ShortName field
        ///     - DEFINITION-REF tag to DefinitionRef field
        ///     - MODULE-DESCRIPTION-REF tag to ModuleDescriptionRef field
        ///		- ADMIN-DATA tag for postBuildVariantSupport
        /// LET CALL shouldFilterOutConfiguration to check Configuration instance should be filtered out
        /// IF not true THEN
        ///     LET Save Configuration instance into cdfData
        ///     RETURN Configuration instance
        /// ELSE
        ///     RETURN null
        /// </algorithm>
        protected ParseConfigStatus ParseConfiguration(XElement element, ref Configuration config)
        {
            ParseConfigStatus status = Business.Parser.ParseConfigStatus.Success;
            config = new Configuration();

            XAttribute attribute = element.Attribute(Constant.UUID);
            // Parse an XElement into a Configuration instance with mapping
            foreach (XElement subElement in element.Elements())
            {
                switch (subElement.Name.LocalName)
                {
                    case Constant.SHORT_NAME:
                        // SHORT-NAME tag to ShortName field
                        config.ShortName = subElement.Value;
                        break;
                    case Constant.DEFINITION_REF:
                        // DEFINITION-REF tag to DefinitionRef field
                        config.DefinitionRef = subElement.Value;
                        break;
                    case Constant.MODULE_DESCRIPTION_REF:
                        // MODULE-DESCRIPTION-REF tag to ModuleDescriptionRef field
                        config.ModuleDescriptionRef = subElement.Value;
                        break;
                    case Constant.ADMIN_DATA:
                        // ADMIN_DATA tag for postBuildVariantSupport 
                        config.postBuildVariantSupport = subElement.Value;
                        break;
                    default:
                        break;
                } // End of switch (subElement.Name.LocalName).
            }// End of foreach (XElement subElement in element.Elements()).

            if (null != attribute)
            {
                // UUID attribute to Uuid field
                config.Uuid = attribute.Value;
            }
            else
            {
                // Not required
            }


            // Invoke shouldFilterOutConfiguration to check Configuration instance should be filtered out
            if (ShouldFilterOutConfiguration(config))
            {
                status = Business.Parser.ParseConfigStatus.NoData;
            }
            else
            {
                // Save Configuration instance into cdfData
                CdfData.SaveConfiguration(config.ShortName, config);
            }

            return status;
        }
        // Implementation: GENERIC_TUD_CLS_025_025

        /// <summary>
        /// This method is used to filter vendor in MCAL modules based on -fr option from user input.
        /// </summary>
        /// <param name="config">Config <range>null/!null</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>true: Ignore data from vendor
        ///               false: Get data from vendor</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_USG_010
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET result = true
        /// IF configuration should be filtered by conditions
        /// - moduleName extracted from config.DefinitionRef is NOT one of MCAL modules and listed in STUBS tag
        /// - moduleName is one of MCAL module and vendor name is equal to runtimeConfiguration.VendorFilter
        /// THEN
        ///     result = false
        /// RETURN result
        /// </algorithm>
        protected bool ShouldFilterOutConfiguration(Configuration config)
        {
            bool result = true;

            if ((null != config) && (false == String.IsNullOrEmpty(config.DefinitionRef)))
            {
                string moduleName = StringUtils.GetElementLastInArray(config.DefinitionRef);
                // Condition to filter out configuration:
                // - moduleName extracted from config.DefinitionRef is NOT one of MCAL modules
                // - DefinitionRef value of configuration is NOT started with "/" + runtimeConfiguration.VendorFilter
                if (((false == moduleName.Equals(BasicConfiguration.ModuleName, StringComparison.OrdinalIgnoreCase)) &&
                 RuntimeConfiguration.StubsFilter.Any(x => x.Equals(moduleName, StringComparison.OrdinalIgnoreCase))) ||
                   ((true == moduleName.Equals(BasicConfiguration.ModuleName, StringComparison.OrdinalIgnoreCase)) &&
                    config.DefinitionRef.Split('/')[1].Equals(RuntimeConfiguration.VendorFilter,
                                                                                   StringComparison.OrdinalIgnoreCase)))
                {
                    result = false;
                }
                else
                {
                    // Not required
                }
            } // End of if ((null != config) && (false == String.IsNullOrEmpty(config.DefinitionRef))).
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_025_034

        /// <summary>
        /// Build a containers tree of a module and save in cdfData
        /// </summary>
        /// <param name="file">CDF file in XDocument <range>None</range></param>
        /// <param name="module">Module in XElement <range>None</range></param>
        /// <param name="config">Configuration of module <range>None</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET get all containers in module by getting all elements inside tag CONTAINERS
        /// FOREACH element in container
        ///     LET recursively build a container tree where this container is root and all of its children
        ///     LET add container short name and container tree to cdfData
        /// </algorithm>
        protected void BuildAndSaveContainerTree(XDocument file, XElement module, Configuration config)
        {
            // Use stack to replace recursive process.
            Stack<XElement> stack = new Stack<XElement>();
            IEnumerable<XElement> containers = module.Descendants()
                .Where(x => x.Name.LocalName == Constant.CONTAINERS)
                .Elements();
            string root = GetRootPath(file, module);
            string moduleName = StringUtils.GetElementLastInArray(config.DefinitionRef);

            // Store all element inside tag CONTAINERS into CDF data
            foreach (XElement element in containers)
            {
                Container container = ConvertToContainer(element);
                stack.Push(element);
                container.Path = root + config.ShortName + "/" + container.ShortName;
                CdfData.SaveContainer(moduleName, config.ShortName, container);
            }

            // Elements has unpredictable deep level in CDFs, so loop will finish when stack is empty
            while (Constant.INT_ZERO < stack.Count)
            {
                XElement element = stack.Pop();

                string uuid = element.Attribute(Constant.UUID).Value;
                // Get container data by UUID
                Container container = CdfData.GetContainerByUUID(moduleName, uuid);
                // Scan all sub-container inside container
                XElement sub_container = element.Descendants()
                    .Where(x => x.Name.LocalName == Constant.SUB_CONTAINERS)
                    .FirstOrDefault();

                // Recursively build a container tree where this container is root and all of its children
                // Add container short name and container tree to cdfData
                if (null != container && null != sub_container)
                {
                    BuildSubContainers(ref stack, container, sub_container);
                } // End of if ((null != container) && (null != sub_container)).
                else
                {
                    // Not required
                }
            } // End of while (0 < stack.Count).
        }
        // Implementation: GENERIC_TUD_CLS_025_014

        /// <summary>
        /// Build the sub containers
        /// </summary>
        /// <param name="stack">CDF element tags in XElement <range>!null</range></param>
        /// <param name="container">Parent Container<range>!null</range></param>
        /// <param name="sub_container">Sub Container<range>!null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET get all containers in module by getting all elements inside tag CONTAINERS
        /// FOREACH element container
        ///     LET recursively build a container tree where this container is root and all of its children
        ///     LET add container short name and container tree to cdfData
        /// </algorithm>
        protected void BuildSubContainers(ref Stack<XElement> stack, Container container, XElement sub_container)
        {
            IEnumerable<XElement> elements = sub_container.Elements()
                            .Where(x => x.Name.LocalName == Constant.ECUC_CONTAINER_VALUE);
            // Build a container tree where this container is root and all of its children in CDF data
            foreach (XElement subElement in elements)
            {
                Container subContainer = ConvertToContainer(subElement);
                stack.Push(subElement);
                subContainer.Parent = container;
                subContainer.Path = container.Path + "/" + subContainer.ShortName;
                container.Childs.Add(subContainer);
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_015

        /// <summary>
        /// Convert XElement into a Container instance
        /// </summary>
        /// <param name="elements">Element tag <range>Null/!Null</range></param>
        /// <returns>
        ///     <para>Container
        ///         <desc>Container with converted data</desc>
        ///         <range>Null/!Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// Generate new uuid by Guid.NewGuid() to replace uuid attribute of elements
        /// Convert XElement into a Container instance with mapping
        ///     - UUID attribute to Uuid field
        ///     - SHORT-NAME tag to ShortName field
        ///     - PARAMETER-VALUES tag to ParameterValues field by calling method parseThruParameters
        ///     - REFERENCE-VALUES tag to ReferenceValues field by calling method parseThruReferences
		///		- VARIATION-POINT tag to VariantID field by calling method ParseThruVariantPoint
        /// </algorithm>
        protected Container ConvertToContainer(XElement elements)
        {
            Container container = new Container();
            XAttribute attribute = elements.Attribute(Constant.UUID);
            string uuid = System.Guid.NewGuid().ToString();
            // In case CDF absent value UUID attribute, use generated UUID system
            // In case CDF absent UUID attribute, use generated UUID system and add UUID attribute
            if (null != attribute)
            {
                elements.Attribute(Constant.UUID).SetValue(uuid);
            }
            else
            {
                elements.Add(new XAttribute(Constant.UUID, uuid));
            }
            container.Uuid = elements.Attribute(Constant.UUID).Value;
            // Parse tags corresponding to container as short name, definition ref, parameter values,
            // referncen values
            foreach (XElement element in elements.Elements())
            {
                switch (element.Name.LocalName)
                {
                    case Constant.SHORT_NAME:
                        container.ShortName = element.Value.ToString();
                        break;
                    case Constant.DEFINITION_REF:
                        container.DefinitionRef = element.Value.ToString();
                        break;
                    case Constant.PARAMETER_VALUES:
                        container.ParameterValues = ParseThruParameters(container, element);
                        break;
                    case Constant.REFERENCE_VALUES:
                        container.ReferenceValues = ParseThruReferences(container, element);
                        break;
                    case Constant.VARIATION_POINT:
                        container.VariantID = ParseThruVariantPoint(element);
                        break;
                } // End of switch (element.Name.LocalName).
            } // End of foreach (XElement element in elements.Elements()).

            return container;
        }
        // Implementation: GENERIC_TUD_CLS_025_020

        /// <summary>
        /// Check autosar version of BSWMDT File and Module Description File.
        /// </summary>
        /// <param name="bswConfig">Basic software configuration <range>null/!null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_029
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     CdfFiles, UserInterface
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// Get Variant from SupportedVariants
        /// FOREACH file in CdfFiles.Values
        ///     LET isAutoSar = checking AR version between CDF data and BSW file
        ///     IF isAutoSar is true and bswConfig.ArReleaseVersion is not null and
        ///                            bswConfig.ArReleaseVersion is not 4.2.2 or 4.3.1 or 4.8.0
        ///         THEN LET raise error ERR000029
        /// </algorithm>
        protected void CheckAutosarVersion(BswConfig bswConfig)
        {
            // Define supported Autosar Version each Device variant
            Dictionary<string, string> arDeviceVersion = new Dictionary<string, string>() {
                { Constant.E2X_VARIANT, Constant.AR_VERSION_4_2_2 },
                { Constant.U2AX_VARIANT, Constant.AR_VERSION_22_11 },
                { Constant.U2BX_VARIANT, Constant.AR_VERSION_22_11 },
                { Constant.U2CX_VARIANT, Constant.AR_VERSION_22_11 },
                { Constant.U2BXE_VARIANT, Constant.AR_VERSION_22_11 },
            };

            // Get valid device variant
            string device = GetDeviceName();

            Dictionary<string, List<string>> devicesVar = ObjectFactory.SupportedVariants;
            string variant = String.Empty;
            foreach (string key in devicesVar.Keys)
            {
                if (devicesVar[key].Contains(device))
                {
                    variant = key;
                    break;
                }
                else
                {
                    // nothing
                }
            }

            //Handle ERR000029 by checking AR version between CDF data and BSW file
            foreach (XDocument file in CdfFiles.Values)
            {
                bool isAutoSar = file.Descendants()
                    .Where(x => x.Name.LocalName.Equals(Constant.AR_PACKAGES)).Elements()
                    .Where(x => x.Name.LocalName.Equals(Constant.AR_PACKAGE)).Any();

                // If any inconsistence in AR version, report error
                if (isAutoSar &&
                    !String.IsNullOrEmpty(bswConfig.ArReleaseVersion) &&
                    !String.IsNullOrEmpty(variant) &&
                    !arDeviceVersion[variant].Equals(bswConfig.ArReleaseVersion))
                {
                    UserInterface.Error(0, 29,  Resources.ERR000029, bswConfig.ArReleaseVersion, variant);
                    UserInterface.Exit();
                }
                else
                {
                    // Not required
                }
            } // End of foreach (XDocument file in cdfFiles).
        }
        // Implementation: GENERIC_TUD_CLS_025_016

        /// <summary>
        /// Check required parameter in bsw file.
        /// </summary>
        /// <param name="bswConfig">Basic software configuration <range>None</range></param>
        /// <param name="requiredFields">Required fields <range>None</range></param>
        /// <param name="tagNameToField">Mapping from tag names to fields <range>None</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_030,
        /// CMN_TAD_BSW_001
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        ///
        /// FOREACH parameter is required in bsw file
        ///     IF have any value absence THEN
        ///         LET raise error ERR000030
        /// </algorithm>
        protected void CheckParamConfig(BswConfig bswConfig,
            string[] requiredFields,
            Dictionary<string, string> tagNameToField)
        {
            Dictionary<string, string> fieldToTagName = tagNameToField.ToDictionary(e => e.Value, e => e.Key);

            // Handle ERR000030 by checking each field in all required fields of BSW file
            foreach (string field in requiredFields)
            {
                // Scan all required parapemer in bsw object
                PropertyInfo property = bswConfig.GetType().GetProperty(field);
                string value = property.GetValue(bswConfig, null) as string;

                // If any required field missing, report error
                if (String.IsNullOrEmpty(value))
                {
                    string tag = fieldToTagName[field];
                    tag = String.Join("-", tag.Split('-').Skip(Constant.INT_ONE));
                    UserInterface.Error(0, 30, Resources.ERR000030, tag);
                }
                else
                {
                    // Not required
                }
            } // End of foreach (string field in requiredFields).

            if (0 < UserInterface.ErrorCount)
            {
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_018

        /// <summary>
        /// Parse BSW configuration and save into cdfData
        /// Tags need parse:
        ///  IMPLEMENT-SHORT-NAME
        ///  IMPLEMENT-PROGRAMMING-LANGUAGE
        ///  IMPLEMENT-SW-VERSION
        ///  IMPLEMENT-VENDOR-ID
        ///  IMPLEMENT-AR-RELEASE-VERSION
        ///  IMPLEMENT-VENDOR-API-INFIX
        ///  IMPLEMENT-BEHAVIOR-REF
        ///  IMPLEMENT-UUID
        ///  DESCRIPTION-SHORT-NAME
        ///  DESCRIPTION-MODULE-ID
        ///  DESCRIPTION-UUID
        ///  IMPLEMENT-VENDOR-SPECIFIC-MODULE-DEF-REFS
        /// </summary>
        /// <param name="bsw">Bsw XDocument<range>!Null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_025, CMN_TAD_ERR_026, CMN_TAD_ERR_029, CMN_TAD_ERR_030, CMN_TAD_ERR_048
        /// </ref>
        /// <algorithm>
        /// Parse bsw configuration, raise ERR000025, ERR000026, ERR000029, ERR000048 or ERR000030 if any
        /// </algorithm>
        protected void ParseAndSaveBswConfiguration(XDocument bsw) 
        {
            XElement basePackages = bsw.Descendants().Where(x => Constant.AR_PACKAGES.Equals(x.Name.LocalName, 
                                                                StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            foreach (XElement basePackage in basePackages.Elements().Where(x => Constant.AR_PACKAGE.Equals(
                                                                x.Name.LocalName,StringComparison.OrdinalIgnoreCase)))
            {
                ParseBswPackage(basePackage, Constant.PATH_SEPARATOR);
            }            

            string[] requiredFields = Resources.RequiredBswFields.Split(Constant.COMMA_CHAR).Select(
                                                                                               x => x.Trim()).ToArray();

            List<BswConfig> allBswConfigs = CdfData.GetBswConfigurations().ToList();

            // Check error 25
            CheckERR000025(allBswConfigs);

            foreach (BswConfig bswConfig in allBswConfigs)
            {
                //Check error 29
                CheckAutosarVersion(bswConfig);

                // Check error 30
                if (true == needVerifyVendorApiInfix(bswConfig))
                {
                    requiredFields = (Resources.RequiredBswFields + Constant.COMMA_CHAR + Constant.VendorApiInfix)
                                                            .Split(Constant.COMMA_CHAR).Select(x => x.Trim()).ToArray();
                }
                else
                {
                    //Do nothing
                }
                CheckParamConfig(bswConfig, requiredFields, tagNameToField);
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_023

        /// <summary>
        /// This method check path in bsw mdt with path that defined by Configuration in CDF file
        /// </summary>
        /// <param name="bsw">BSW Document - XML<range>None</range></param>
        /// <param name="configs">List of configurations<range>None</range></param>
        /// <param name="bswConfig">Information of bsw mdt <range>!null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_025
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     UserInterface
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET get path1 in bsw mdt
        /// LET get path2 in ModuleDescriptionRef cdf file
        /// IF path1 not equals path2 THEN
        ///     LET raise error ERR000025
        /// IF path2 is not unique
        ///     LET raise error ERR000025
        /// </algorithm>
        protected virtual void CheckERR000025(List<BswConfig> bswConfigs)
        {
            // Get Instance configurations from CDF data.
            IList<Configuration> configs = CdfData.GetAllInstanceConfigurations(BasicConfiguration.ModuleName);
            List<string> uniqueModuleDescriptionRef = new List<string>() { };
            foreach (Configuration config in configs.Where(x => null != x))
            {
                // if any inconsistence path between bsw and cdf, report error
                if (!bswConfigs.Where(x => null != x).Any(y =>
                        y.ImplementRootPath.Equals(config.ModuleDescriptionRef)))
                {
                    UserInterface.Error(0, 25, Resources.ERR000025_INCORRECT, config.ModuleDescriptionRef);
                    UserInterface.Exit();
                }
                else
                {
                    // Not required
                }

                if (uniqueModuleDescriptionRef.Contains(config.ModuleDescriptionRef))
                {
                    UserInterface.Error(0, 25, Resources.ERR000025_DUPPLICATED, config.ModuleDescriptionRef);
                    UserInterface.Exit();
                }
                else
                {
                    uniqueModuleDescriptionRef.Add(config.ModuleDescriptionRef);
                }
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_017

        /// <summary>
        /// This method check relation between BSW and CDF files.
        /// It raise error ERR000048 if not any relation between BSW and CDF
        /// </summary>
        /// <param name="bswConfig">Information of bsw mdt <range>Null/!Null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_048, CMN_TAD_ERR_049
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     CdfData, UserInterface
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET cdfConfig = CALL CdfData.GetAllInstanceConfigurations WITH BasicConfiguration.ModuleName
        /// IF bswConfig.VendorSpecificModuleDefRef is null THEN
        ///     LET raise error ERR000049
        /// ELSE IF cdfConfig is not null and cdfConfig.DefinitionRef not equals bswConfig.VendorSpecificModuleDefRef THEN
        ///     LET raise error ERR000048
        /// </algorithm>
        protected virtual void CheckRelationBswmdtAndCdf(BswConfig bswConfig)
        {
            Configuration cdfConfig = CdfData.GetAllInstanceConfigurations(BasicConfiguration.ModuleName)
                                                                                .FirstOrDefault();
            // Handle ERR000049 if required VendorSpecificModuleDefRef tag is absence in bsw file
            if (string.IsNullOrEmpty(bswConfig.VendorSpecificModuleDefRef))
            {
                UserInterface.Error(0, 49, Resources.ERR000049);
                UserInterface.Exit();
            }
            // Handle ERR000048 if value of required VendorSpecificModuleDefRef tag is inconsistent
            // with value of DefinitionRef in cdf
            else if (null != cdfConfig && !cdfConfig.DefinitionRef.Equals(bswConfig.VendorSpecificModuleDefRef,
                                                StringComparison.OrdinalIgnoreCase))
            {
                UserInterface.Error(0, 48, Resources.ERR000048, bswConfig.VendorSpecificModuleDefRef,
                                                                            cdfConfig.DefinitionRef);
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_019
        /// <summary>
        /// Parse the sub-element
        /// </summary>
        /// <param name="element">Target XElement to parse <range>Null/!Null XElement</range></param>
        /// <param name="requiredFields">Target Required Fields  <range>null/list string</range></param>
        /// <param name="tagNameToField">Convert to field <range>Fixed Dictionary</range></param>
        /// <param name="ref bswConfig">Basic software configuration Out<range>BswConfig</range></param>
        /// <param name="ref name">Short Name sub elements<range>emptu/!empty</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// FOREACH subElement in element.Elements
        ///     LET implement = Parse for Bsw implementation that is in BSW-IMPLEMENTATION tag
        ///     LET description = Parse for Bsw Module Description that is in BSW-MODULE-DESCRIPTION tag
        ///     IF subElement.Name.LocalName is not null and subElement.Name.LocalName is SHORT-NAME THEN
        ///         LET name = subElement.Value
        ///     LET parse values from tags in BSW-IMPLEMENTATION tag
        ///     LET parse values from tags in BSW-MODULE-DESCRIPTION tag
        /// </algorithm>
        protected void ParseSubElement(
            XElement element,
            string[] requiredFields,
            Dictionary<string, string> tagNameToField,
            ref BswConfig bswConfig)
        {
            // Parse for Bsw implementation that is in BSW-IMPLEMENTATION tag
            XElement implement = element.Elements()
                .Where(x => Constant.BSW_IMPLEMENTATION == x.Name.LocalName)
                .FirstOrDefault();
            // Parse for Bsw Module Description that is in BSW-MODULE-DESCRIPTION tag
            XElement description = element.Elements()
                .Where(x => Constant.BSW_MODULE_DESCRIPTION == x.Name.LocalName)
                .FirstOrDefault();
            //Parse values from tags in BSW-IMPLEMENTATION tag
            parseContent(implement, requiredFields, tagNameToField, Constant.IMPLEMENT_PREFIX, ref bswConfig);
            //Parse values from tags in BSW-MODULE-DESCRIPTION tag
            parseContent(description, requiredFields, tagNameToField, Constant.DESCRIPTION_PREFIX, ref bswConfig);
        }
        // Implementation: GENERIC_TUD_CLS_025_028

        /// <summary>
        /// Parse content in bsw file.
        /// </summary>
        /// <param name="element">Target XElement to parse <range>Null/!Null XElement</range></param>
        /// <param name="requiredFields">Target Required Fields  <range>null/list string</range></param>
        /// <param name="tagNameToField">Convert to field <range>Fixed Dictionary</range></param>
        /// <param name="prefixTag">Keywork to split string<range>Fixed string</range></param>
        /// <param name="ref bswConfig">Basic software configuration Out<range>BswConfig</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     BasicConfiguration
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// IF element is not Null THEN
        ///     LET attribute = return value by CALL Attribute WITH name is UUID.
        ///     FOEACH e in element of element
        ///         LET field = null.
        ///         IF the return value by CALL tagNameToField.TryGetValue WITH
        ///                                  "prefixTag + LocalName of e" and field THEN
        ///             LET property = return value by CALL GetProperty of GetType of bswConfig.
        ///     IF attribute is not null THEN
        ///         IF prefixTag is IMPLEMENT_PREFIX THEN
        ///             LET ImplementUuid of bswConfig = value of attribute
        ///         ELSE
        ///             LET DescriptionUuid of bswConfig = value of attribute
        /// </algorithm>
        private void parseContent(XElement element,
            string[] requiredFields,
            Dictionary<string, string> tagNameToField,
            string prefixTag,
            ref BswConfig bswConfig)
        {
            if (null != element)
            {
                XAttribute attribute = element.Attribute(Constant.UUID);

                // For each element in BSW file
                //     Recursively build a required field value
                foreach (XElement e in element.Elements())
                {
                    string field = null;
                    // Scan tags in bsw file and parse value to BswConfig.
                    if (true == tagNameToField.TryGetValue(
                            String.Concat(prefixTag, e.Name.LocalName),
                            out field))
                    {
                        PropertyInfo property = bswConfig.GetType().GetProperty(field);
                        property.SetValue(bswConfig, e.Value.ToString());
                    }
                    else
                    {
                        // Not required
                    }
                } // End of foreach (XElement implementElement in implement.Elements()).

                // Store element UUID attribute
                if (null != attribute)
                {
                    if (prefixTag.Equals(Constant.IMPLEMENT_PREFIX))
                    {
                        bswConfig.ImplementUuid = attribute.Value;
                    }
                    else
                    {
                        bswConfig.DescriptionUuid = attribute.Value;
                    }

                }
                else
                {
                    // Not required
                }
            } // End of if (null != implement).
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_043

        /// <summary>
        /// Validate detail of basic software configuration
        /// </summary>
        /// <param name="bswConfig">Bsw configuration <range>BswConfig null/!null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_026
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     BasicConfiguration
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// IF (1) bswConfig.DescriptionShortName is null or
        ///    (2) bswConfig.DescriptionShortName NOT Equals basicConfiguration.ModuleName THEN
        ///    LET Record error ERR000026 and exit
        /// </algorithm>
        protected void ValidateBswConfigurationDetail(BswConfig bswConfig)
        {
            // Check error 26
            if ((null != bswConfig) &&
                ((null == bswConfig.DescriptionShortName) ||
                 (!bswConfig.DescriptionShortName.Equals(BasicConfiguration.ModuleName,
                                                            StringComparison.OrdinalIgnoreCase))))
            {
                UserInterface.Error(0, 26, Resources.ERR000026, BasicConfiguration.ModuleName);
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_035

        /// <summary>
        /// Validate rules required for all BSW configuration
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_036
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     CdfData, BasicConfiguration
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET BswConfigurations from CdfData WITH DescriptionShortName it not null and DescriptionShortName
        ///     Equal ModuleName
        /// IF BswConfigurations is null THEN
        ///         LET raise error ERR000036 and exit
        /// </algorithm>
        protected void ValidateBswConfigurationsGeneral()
        {
            // Report error ERR000036 If have any absence bsw in module.
            List<BswConfig> bswConfig = new List<BswConfig>();
            foreach (BswConfig each in CdfData.GetBswConfigurations().Where(x => (null != x.DescriptionShortName) &&
                                                                     (x.DescriptionShortName
                                                                     .Equals(BasicConfiguration.ModuleName,
                                                                        StringComparison.OrdinalIgnoreCase))))
            {
                bswConfig.Add(each);
            }

            if (0 == bswConfig.Count)
            {
                UserInterface.Error(0, 36, Resources.ERR000036, BasicConfiguration.ModuleName);
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_036

        /// <summary>
        /// Parse XElement and return a list of parameters
        /// </summary>
        /// <param name="container">Elements <range>Null/!Null</range></param>
        /// <param name="elements">Elements <range>Null/!Null</range></param>
        /// <returns>
        ///     <para>IList<ItemValue>
        ///         <desc>The value references from CDF</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// FOREACH child item in element
        ///     LET Create new ItemValue with fields' value WITH
        ///     - DefinitionRef = DEFINITION-REF tag
        ///     - Value = VALUE tag
	    ///		LET variantPoint = get all containers in module by getting all elements inside tag Elements
	   	///		IF variantPoint is not null and item is not null
	   	///			LET postbuidCDF = the first element in variantPoint with LocalName == POST_BUILD_VARIANT_CONDITION
	   	///				IF postbuidCDF is not null
	   	///					LET itemVariantValue = create object VariantItemValue from item and postbuildCDF
	   	///					IF itemVariantValue is not null
	   	///						ADD Variant into variant field of ItemValue
	   	///						STORE all the configured variantID into container
	   	///						IF (ItemValue) temp if parameter have been defined once
	   	///						    ADD Variant value to temp
	   	///                     ELSE
	   	///                         Do nothing
	   	///					ELSE
        ///                    Do nothing
        ///             ELSE
        ///                 Do nothing
	   	///		ELSE
        ///		    Do nothing
        /// RETURN paramValues
        /// </algorithm>
        protected IList<ItemValue> ParseThruParameters(Container container, XElement element)
        {
            IList<ItemValue> paramValues = new List<ItemValue>();
            IEnumerable<XElement> parameters = element.Elements();
            // Parse parameter values in container in CDFs.
            foreach (XElement param in parameters)
            {
                ItemValue item = ParseItemValue(param, Constant.DEFINITION_REF, Constant.VALUE);

                XElement variantPoint = param.Elements().
                        Where(x => x.Name.LocalName == Constant.VARIATION_POINT).FirstOrDefault();

                if ((null != variantPoint) && (null != item))
                {
                    XElement postbuidCDF = variantPoint.Elements()
                        .Where(x => x.Name.LocalName == Constant.POST_BUILD_VARIANT_CONDITIONS).Elements()
                        .Where(x => x.Name.LocalName == Constant.POST_BUILD_VARIANT_CONDITION).FirstOrDefault();

                    if (null != postbuidCDF)
                    {
                        VariantItemValue itemVariantValue = 
                            ParseVariantItemValue(item, postbuidCDF, Constant.MATCHING_CRITERION_REF, Constant.VALUE);

                        if (null != itemVariantValue)
                        {
                            // If itemValue of variant have been defined then add Variant into variant field of ItemValue
                            item.addVariantValue(itemVariantValue);

                            // Store all the configured variantID into container
                            if (!container.ListConfiguredVariantID.Contains(itemVariantValue.VariantID()))
                            {
                                container.ListConfiguredVariantID.Add(itemVariantValue.VariantID());
                            }
                            else
                            {
                                // Do nothing
                            }

                            // Check (ItemValue) temp if parameter have been defined once
                            ItemValue temp = paramValues.Where(x => x.DefinitionRef() == item.DefinitionRef())
                                .FirstOrDefault();

                            // Check if the parameter have been found.
                            if (null != temp)
                            {
                                temp.addVariantValue(itemVariantValue);
                                item = null;
                            }
                            else
                            {
                                // Do nothing
                            }
                        }
                        else
                        {
                            // Do nothing
                        }
                    }
                    else
                    {
                        // Do nothing
                    }
                }
                else
                {
                    // Do nothing
                }

                if (item != null)
                {
                    paramValues.Add(item);
                }
                else
                {
                    // Not required
                }
            } // End of foreach (XElement param in parameters).
            return paramValues;
        }
        // Implementation: GENERIC_TUD_CLS_025_029

        /// <summary>
        /// Parse through References
        /// </summary>
        /// <param name="container">Elements <range>Null/!Null</range></param>
        /// <param name="elements">Elements <range>Null/!Null</range></param>
        /// <returns>
        ///     <para>IList<ItemValue>
        ///         <desc>The value references from CDF</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///	LET referenceValues = new List<ItemValue>()
	    ///	LET parameters = element.Elements()
        /// FOREACH child item in element
        ///     LET Create new ItemValue with fields' value WITH
        ///     - DefinitionRef = DEFINITION-REF tag
        ///     - Value = VALUE-REF tag
	    ///		LET variantPoint = get all containers in module by getting all elements inside tag Elements
	   	///		IF variantPoint is not null and refer is not null
	   	///		  LET postbuidCDF = the first element in variantPoint with LocalName == POST_BUILD_VARIANT_CONDITION
	   	///		  IF postbuidCDF is not null
	   	///			LET itemVariantValue = Variant value from refer and postbuildCDF
	   	///			IF itemVariantValue is not null
	   	///			  ADD Variant into variant field of ItemValue
	   	///			  STORE all the configured variantID into container
	   	///			  IF (ItemValue) temp if parameter have been defined once
	   	///			    LET refer = null
	  	///			  ELSE
	   	///             Do nothing
	   	///		    ELSE
	   	///           Do nothing
	   	///		ELSE
	   	///       Do nothing
        ///     IF refer is not null
        ///     	LET add refer into collection referenceValues
	   	///     ELSE
	   	///         Do nothing
        /// RETURN referenceValues
        /// </algorithm>
        protected IList<ItemValue> ParseThruReferences(Container container, XElement element)
        {
            IList<ItemValue> referenceValues = new List<ItemValue>();
            IEnumerable<XElement> parameters = element.Elements();

            foreach (XElement param in parameters)
            {
                ItemValue refer = ParseItemValue(param, Constant.DEFINITION_REF, Constant.VALUE_REF);

                XElement variantPoint = param.Elements().
                        Where(x => x.Name.LocalName == Constant.VARIATION_POINT).FirstOrDefault();

                if ((null != variantPoint) && (null != refer))
                {
                    XElement postbuidCDF = variantPoint.Elements()
                        .Where(x => x.Name.LocalName == Constant.POST_BUILD_VARIANT_CONDITIONS).Elements()
                        .Where(x => x.Name.LocalName == Constant.POST_BUILD_VARIANT_CONDITION).FirstOrDefault();

                    if (null != postbuidCDF)
                    {
                        VariantItemValue itemVariantValue = 
                            ParseVariantItemValue(refer, postbuidCDF, Constant.MATCHING_CRITERION_REF, Constant.VALUE);

                        if (null != itemVariantValue)
                        {
                            // If itemValue of variant have been defined then add Variant into variant field of ItemValue
                            refer.addVariantValue(itemVariantValue);

                            if (!container.ListConfiguredVariantID.Contains(itemVariantValue.VariantID()))
                            {
                                container.ListConfiguredVariantID.Add(itemVariantValue.VariantID());
                            }
                            else
                            {
                                // Do nothing
                            }

                            // Check in list of reference Values if any reference Value have been defined once
                            ItemValue temp = referenceValues.Where(x => x.DefinitionRef() == refer.DefinitionRef())
                                .Where(x => (x.getVariantIDs().Count != 0 && refer.getVariantIDs().Count != 0))
                                .Where(x => (null != x.getVariantIDs().FirstOrDefault() &&
                                                                        null != refer.getVariantIDs().FirstOrDefault()))
                                .Where(x => (x.getVariantIDs().FirstOrDefault().InternalValue().Equals(
                                                                    refer.getVariantIDs().FirstOrDefault().InternalValue())))
                                .FirstOrDefault();

                            // Check if the reference have been found
                            if (temp != null)
                            {
                                temp.addVariantValue(itemVariantValue);
                                refer = null;
                            }
                            else
                            {
                                // Do nothing
                            }
                        }
                        else
                        {
                            // Do nothing
                        }
                    }
                    else
                    {
                        // Do nothing
                    }
                }
                else
                {
                    // Do nothing
                }

                if (refer != null)
                {
                    referenceValues.Add(refer);
                }
                else
                {
                    // Not required
                }
            } // End of foreach (XElement param in parameters).

            return referenceValues;
        }
        // Implementation: GENERIC_TUD_CLS_025_030

        /// <summary>
        /// Parse through VariantPoint
        /// </summary>
        /// <param name="elements">Elements <range>Null/!Null</range></param>
        /// <returns>
        ///     <para>IList<ItemValue>
        ///         <desc>The value references from CDF</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET parameters = element.Elements()
        /// LET ret = empty string
        /// LET postbuidCDF = the first element in variantPoint with LocalName == POST_BUILD_VARIANT_CONDITION
        /// IF postbuildCDF is not null
        /// 	LET itemVariantValue = Created object from postbuildCDF
		///		LET ret = itemVariantValue
		///	ELSE
        ///     Do nothing   
		/// RETURN ret
        /// </algorithm>
        protected string ParseThruVariantPoint(XElement element)
        {
            //List<VariantItemValue> referenceValues = new List<VariantItemValue>();
            IEnumerable<XElement> parameters = element.Elements();

            string ret = string.Empty;

            XElement postbuidCDF = element.Elements().Elements()
                        .Where(x => x.Name.LocalName == Constant.POST_BUILD_VARIANT_CONDITION).FirstOrDefault();

            if (null != postbuidCDF)
            {
                string itemVariantValue = 
                    ParseContainerVariantItemValue(postbuidCDF, Constant.MATCHING_CRITERION_REF, Constant.VALUE);

                ret = itemVariantValue;
            }
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_025_049

        /// <summary>
        /// Parse container variant itemValue
        /// </summary>
        /// <param name="elements">Elements <range>Null/!Null</range></param>
        /// <param name="definitionKey">Definition key <range>!empty</range></param>
        /// <param name="valueKey">Value key <range>!empty</range></param>
        /// <returns>
        ///     <para>ItemValue
        ///         <desc>The value from CDF</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET result = string.Empty
	   	///	LET definitionRef = the first element with LocalName == definitionKey
    	///	LET definitionRef = the first element with LocalName == valueKey
	 	///	IF definitionRef, value is not null
	    ///		IF definitionRef.Value, value.Value is not null or empty
	    ///			LET dataValue = value.Value.Trim()
	    ///			LET result = dataValue
	    ///			STORE values with definitionRef.Value into CdfData
	    ///		ELSE
	    ///       Do nothing
	    ///	ELSE
	    ///     Do nothing
		///	RETURN result
        /// </algorithm>
        protected string ParseContainerVariantItemValue(XElement element, string definitionKey, string valueKey)
        {
            string result = string.Empty;

            XElement definitionRef = element.Elements()
                .Where(x => x.Name.LocalName == definitionKey).FirstOrDefault();

            XElement value = element.Elements()
                .Where(x => x.Name.LocalName == valueKey).FirstOrDefault();

            // Update to get below elements: VARIATION-POINT
            if (null != definitionRef && null != value)
            {
                if (!string.IsNullOrEmpty(definitionRef.Value) && !string.IsNullOrEmpty(value.Value))
                {
                    string dataValue = value.Value.Trim();

                    result = dataValue;

                    CdfData.SaveVariantCriterionModuleConfig(definitionRef.Value.Split('/').Last());
                }
                else
                {
                    // Not required
                }
            }
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_025_050

        /// <summary>
        /// Parse item value from XElement.
        /// </summary>
        /// <param name="elements">Elements <range>Null/!Null</range></param>
        /// <param name="definitionKey">Definition key <range>!empty</range></param>
        /// <param name="valueKey">Value key <range>!empty</range></param>
        /// <returns>
        ///     <para>ItemValue
        ///         <desc>The value from CDF</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET Get value from CDF and convert to value that has corresponding data type
        /// LET Convert and RETURN value to corresponding data type
        /// </algorithm>
        protected ItemValue ParseItemValue(XElement element, string definitionKey, string valueKey)
        {
            ItemValue result = null;
            XElement definitionRef = element.Elements()
                .Where(x => x.Name.LocalName == definitionKey).FirstOrDefault();
            XElement value = element.Elements()
                .Where(x => x.Name.LocalName == valueKey).FirstOrDefault();
            if (null != definitionRef && null != value)
            {
                if (!string.IsNullOrEmpty(definitionRef.Value) && !string.IsNullOrEmpty(value.Value))
                {
                    // Get value from CDF and convert to value that has corresponding data type
                    string dataRef = definitionRef.Value.Trim();
                    string dataType = definitionRef.Attribute(Constant.DEST).Value.Trim();
                    string dataValue = value.Value.Trim();
                    // Convert and return value to corresponding data type
                    result = new ItemValue(dataRef, convertValueFromString(dataType, dataValue));
                }
                else
                {
                    // Not required
                }
            }
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_025_027


        /// <summary>
        /// Parse Variant ItemValue
        /// </summary>
        /// <param name="itemValue">ItemValue <range>Null/!Null</range></param>
        /// <param name="elements">Elements <range>Null/!Null</range></param>
        /// <param name="definitionKey">Definition key <range>!empty</range></param>
        /// <param name="valueKey">Value key <range>!empty</range></param>
        /// <returns>
        ///     <para>ItemValue
        ///         <desc>The value from CDF</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        /// LET result = null
	    ///	LET definitionRef = the first element with LocalName == definitionKey
	    ///	LET definitionRef = the first element with LocalName == valueKey
	    ///	IF definitionRef, value is not null
    	///		IF definitionRef.Value, value.Value is not null or empty
	    ///			LET dataValue = value.Value.Trim()
	    ///			LET result = dataValue
	    ///		    STORE values with definitionRef.Value into CdfData
	    ///		ELSE
	    ///       Do nothing
	    ///	ELSE
	    ///     Do nothing
	    ///	RETURN result
        /// </algorithm>
        protected VariantItemValue ParseVariantItemValue(ItemValue itemValue, XElement element, 
            string definitionKey, string valueKey)
        {
            VariantItemValue result = null;

            XElement definitionRef = element.Elements()
                .Where(x => x.Name.LocalName == definitionKey).FirstOrDefault();

            XElement value = element.Elements()
                .Where(x => x.Name.LocalName == valueKey).FirstOrDefault();

            if (null != definitionRef && null != value)
            {
                if (!string.IsNullOrEmpty(definitionRef.Value) && !string.IsNullOrEmpty(value.Value))
                {
                    string dataValue = value.Value.Trim();

                    // Convert and return value to corresponding data type
                    result = new VariantItemValue(dataValue, itemValue.InternalValue());

                    CdfData.SaveVariantCriterionModuleConfig(definitionRef.Value.Split('/').Last());
                }
                else
                {
                    // Not required
                }
            }
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_025_051

        /// <summary>
        /// Parse translation file section defined by tag TRANSLATION-FILE-PATH
        /// </summary>
        /// <param name="translationFilePath">Translation file path <range>!empty</range></param>
        /// <param name="transFileSection">Section TRANSLATION-FILE-PATH <range>Null/!Null</range></param>
        /// <param name="deviceName">Device name <range>!empty</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>To check device name should be present in translation file section</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_014, CMN_TAD_ERR_015,
        /// CMN_TAD_SAMPUSG_012
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// IF transFileSection is null THEN
        ///     RETURN false
        /// Try to get translation header file path from deviceName tag which is a child of transFileSection
        ///     LET Record error ERR000014 if there are NO children of transFileSection and exit
        ///     LET Record error ERR000015 if there are NO deviceName tag in transFileSection and exit
        /// IF no any error found THEN
        ///     CALL register.SaveMacroLabelValue to save all define macro in translation header file
        /// RETURN true
        /// </algorithm>
        protected bool ParseTransFileSection(string translationFilePath, XElement transFileSection, string deviceName)
        {
            bool result = false;

            if (null != transFileSection)
            {
                // Report error if not exists content in translation file.
                if (false == transFileSection.Descendants().Any())
                {
                    UserInterface.Error(0, 14, Resources.ERR000014, translationFilePath);
                    UserInterface.Exit();
                }
                else
                {
                    bool isExist = false;
                    // To check device name should be present in translation file path
                    foreach (XElement element in transFileSection.Elements())
                    {
                        if (element.Name.LocalName.Equals(deviceName))
                        {
                            // If device name is presented, store content macro values.
                            Register.SaveMacroLabelValue(element.Value.ToString());
                            isExist = true;
                            break;
                        }
                        else
                        {
                            // Not required
                        }
                    } // End of foreach (XElement element in transFilePath.Elements()).

                    if (false == isExist)
                    {
                        // Report eror if the device name tag should not present
                        // as child of DEVICE FILE PATH tag in File Name
                        UserInterface.Error(0, 15, Resources.ERR000015, deviceName, translationFilePath);
                        UserInterface.Exit();
                    }
                    else
                    {
                        // Not required
                    }
                } // End of if (false == transFilePath.Descendants().Any()).

                result = true;
            } // End of if (null != transFilePath).
            else
            {
                // can not found <TRANSLATION-FILE-PATH> Tag
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_025_031

        /// <summary>
        /// Parse device file section defined by tag DEVICE-FILE-PATH
        /// </summary>
        /// <param name="translationFilePath">Translation file path <range>!empty</range></param>
        /// <param name="deviceFileSection">Section DEVICE-FILE-PATH <range>null/!null</range></param>
        /// <param name="deviceName">Device name <range>!empty</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>To check device name should be present in device file section</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_016, CMN_TAD_ERR_017
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// IF deviceFileSection is null THEN
        ///     RETURN false
        /// Try to get device header file path from deviceName tag which is a child of deviceFileSection
        ///     LET Record error ERR000016 if there are NO children of deviceFileSection and exit
        ///     LET Record error ERR000017 if there are NO deviceName tag in deviceFileSection and exit
        /// IF no any error found THEN
        ///     CALL register.SaveMacroAddressValue to save all define macro in device header file
        /// RETURN true
        /// </algorithm>
        protected bool ParseDeviceFileSection(string translationFilePath, XElement deviceFileSection,
                                                                                                    string deviceName)
        {
            bool result = false;

            if (null != deviceFileSection)
            {
                if (false == deviceFileSection.Descendants().Any())
                {
                    // Can not found DEVICE-FILE-PATH tag
                    UserInterface.Error(0, 16, Resources.ERR000016, translationFilePath);
                    UserInterface.Exit();
                }
                else
                {
                    bool isExist = false;
                    // To check device name should be present in translation file path
                    foreach (XElement element in deviceFileSection.Elements())
                    {

                        if (element.Name.LocalName.Equals(deviceName))
                        {
                            // If device name is presented, store address value of macro.
                            Register.SaveMacroAddressValue(element.Value.ToString());
                            isExist = true;
                            break;
                        }
                        else
                        {
                            // Not required
                        }
                    } // End of foreach (XElement element in deviceFilePath.Elements()).

                    if (false == isExist)
                    {
                        // The device name tag should be present as child of DEVICE FILE PATH tag in File Name
                        UserInterface.Error(0, 17, Resources.ERR000017, deviceName, translationFilePath);
                        UserInterface.Exit();
                    }
                    else
                    {
                        // Not required
                    }
                } // End of if (false == deviceFilePath.Descendants().Any()).

                result = true;
            } // End of if (null != deviceFilePath).
            else
            {
                // Can not found DEVICE-FILE-PATH tag
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_025_026

        /// <summary>
        /// Get root path of a CDF/BSW file
        /// </summary>
        /// <param name="xmlDoc">Xml doc <range>Null/!Null</range></param>
        /// <param name="module">Optional target XElement<range>Null/!Null</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The root path of xmlDoc</desc>
        ///         <range>!empty</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET get all inner elements of "xmlDoc" that have name AR-PACKAGE and have inner tag is AR-PACKAGES or ELEMENTS
        /// LET set root path by comparing DEFINITION_REF value
        ///     each inner tag ECUC_MODULE_CONFIGURATION_VALUES under ELEMENTS with target Element "module"
        /// RETURN root path by concatenating their short name by "/" separator
        /// </algorithm>
        protected string GetRootPath(XDocument xmlDoc, XElement module = null)
        {
            IEnumerable<XElement> elements =
                xmlDoc.Descendants().Where(x => x.Name.LocalName.Equals(Constant.AR_PACKAGE));
            StringBuilder stringBuilder = new StringBuilder("/");

            if (null != module)
            {
                XElement defElement = module.Elements().Where(x =>
                    x.Name.LocalName.Equals(Constant.DEFINITION_REF)).SingleOrDefault();
                string defRefModule = defElement != null ? defElement.Value : null;

                foreach (XElement element in elements)
                {

                    // Parse if existed multiple ECUC_MODULE_CONFIGURATION_VALUES under ELEMENTS
                    IEnumerable<XElement> listModules = element.Descendants()
                        .Where(x => x.Name.LocalName.Contains(Constant.ELEMENTS))
                        .Elements();

                    List<XElement> defRef = listModules.Elements().Where(x =>
                        x.Name.LocalName.Equals(Constant.DEFINITION_REF)).ToList();
                    List<string> defRefCurrent = defRef.Where(x => x != null).Select(y => y.Value).ToList();


                    // In case exists template as autosar <AR-PACKAGES> -> <AR-PACKAGE>
                    if (element.Descendants().Where(x => x.Name.LocalName.Equals(Constant.AR_PACKAGES)).Any() ||
                        element.Descendants().Where(x => x.Name.LocalName.Equals(Constant.ELEMENTS)).Any())
                    {
                        // get short name and use it to build root path.
                        XElement shortName = element.Elements()
                            .Where(x => x.Name.LocalName.Contains(Constant.SHORT_NAME)).SingleOrDefault();
                        // Create root path
                        if (null != shortName && null != defRefModule
                            && defRefCurrent.Any(x => x.Equals(defRefModule)))
                        {
                            stringBuilder.Append(shortName.Value + "/");
                        }
                        else
                        {
                            // Not required
                        }
                    } // End of if (element.Descendants().Where(x => x.Name.LocalName.Equals(Constant.ArPackages)).Any() ||
                      //            element.Descendants().Where(x => x.Name.LocalName.Equals(Constant.Elements)).Any())
                    else
                    {
                        // Not required
                    }
                } // End of foreach (XElement element in elements).
            }
            else
            {
                // Do nothing
            }
            return stringBuilder.ToString();
        }
        // Implementation: GENERIC_TUD_CLS_025_022



        /// <summary>
        /// Convert value of tags in CDF to value that has corresponding data type
        /// </summary>
        /// <param name="dataType">Data type <range>valid string</range></param>
        /// <param name="dataValue">Data value <range>valid string</range></param>
        /// <returns>
        ///     <para>object
        ///         <desc>The number have been converted</desc>
        ///         <range>Null/!Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET convertMap = dictionary WITH key is Type and value is Func<>
        /// IF convertMap containsKey dataType THEN
        ///     RETURN value of dataType in convertMap
        /// ELSE
        ///     RETURN dataValue
        /// Convert to value that has corresponding data type
        /// </algorithm>
        private object convertValueFromString(string dataType, string dataValue)
        {
            Dictionary<string, Func<string, object>> convertMap = new Dictionary<string, Func<string, object>>
            {
                { Constant.ECUC_BOOLEAN_PARAM_DEF, value => { return convertToBool(value); } },
                { Constant.ECUC_INTEGER_PARAM_DEF, value => { return convertToLong(value); } },
                { Constant.ECUC_FLOAT_PARAM_DEF, value => { return convertToDouble(value); } },
                { Constant.ECUC_STRING_PARAM_DEF, value => { return value; } },
                { Constant.ECUC_LINKER_SYMBOL_DEF, value => { return value; } },
                { Constant.ECUC_FUNCTION_NAME_DEF, value => { return value; } },
                { Constant.ECUC_ENUMERATION_PARAM_DEF, value => { return value; } },
                { Constant.ECUC_ENUMERATION_LITERAL_DEF, value => { return value; } },
                { Constant.ECUC_SYMBOLIC_NAME_REFERENCE_DEF, value => { return value; } },
                { Constant.ECUC_URI_REFERENCE_DEF, value => { return value; } },
                { Constant.ECUC_ADD_INFO_PARAM_DEF, value => { return value; } },
                { Constant.POST_BUILD_VARIANT_CONDITION, value => {return value; } }
            };
            // Get value corresponding to proper data type in CDFs
            if (convertMap.ContainsKey(dataType))
            {
                return convertMap[dataType](dataValue);
            }
            else
            {
                return dataValue;
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_040

        /// <summary>
        /// Convert value string to value that has bool data type
        /// </summary>
        /// <param name="value">String value<range>TRUE/FALSE/0/1</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The boolean value had been converted</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET convert values such as: 0 -> false, 1 -> true
        /// </algorithm>
        private bool convertToBool(string value)
        {
            string[] trueValues = { Constant.ONE, Constant.TRUE };
            string[] falseValues = { Constant.ZERO, Constant.FALSE };
            return trueValues.Contains(value, StringComparer.OrdinalIgnoreCase);
        }
        // Implementation: GENERIC_TUD_CLS_025_037

        /// <summary>
        /// Convert value string to value that has long data type
        /// </summary>
        /// <param name="value">String Value <range>Integer format</range></param>
        /// <returns>
        ///     <para>object
        ///         <desc>The Long value had been converted</desc>
        ///         <range>Int64.MinValue..Int64.MaxValue</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET convert values such as:
        ///     [+|-]?[1-9][0-9]*
        ///     0x[0-9a-f]+
        ///     0[0-7]*
        ///     0b[0-1]+
        /// </algorithm>
        private object convertToLong(string value)
        {
            Dictionary<Func<string, bool>, int> baseIdentifier = new Dictionary<Func<string, bool>, int>
            {
                // mapping number format with hexa = 16, binary = 2, oct = 8
                { input => { return input.StartsWith("0x", StringComparison.OrdinalIgnoreCase); }, 16 },
                { input => { return input.StartsWith("0b", StringComparison.OrdinalIgnoreCase); }, 2 },
                { input => { return input.StartsWith("0", StringComparison.OrdinalIgnoreCase); }, 8 }
            };
            // interger 64 bit
            Func<UInt64, object> toInt64IfNeeded = x =>
            {
                if (x <= Int64.MaxValue)
                {
                    return (Int64)x;
                }
                else
                {
                    return x;
                }
            };

            // Hex, Oct, Bin format
            foreach (var func in baseIdentifier.Keys.Where(f => (true == f(value))))
            {
                string val = string.Empty;
                if (value.StartsWith("0b"))
                {
                    val = value.Substring(2);
                }
                else
                {
                    val = value;
                }
                UInt64 uvalue = Convert.ToUInt64(val, baseIdentifier[func]);
                return toInt64IfNeeded(uvalue);
            }

            // Decimal format
            if (value.StartsWith("-"))
            {
                return Convert.ToInt64(value);
            }
            else
            {
                UInt64 uvalue = Convert.ToUInt64(value);
                return toInt64IfNeeded(uvalue);
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_039

        /// <summary>
        /// Convert value string to value that has double data type and ignore CultureInfo
        /// </summary>
        /// <param name="value">String Value <range>Float format</range></param>
        /// <returns>
        ///     <para>double
        ///         <desc>The double value had been converted</desc>
        ///         <range>double.MinValue..double.MaxValue</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET convert values such as: NAN, -INF, INF to double and ignore CultureInfo.
        /// </algorithm>
        private double convertToDouble(string value)
        {
            Dictionary<string, Func<string, double>> convertMap = new Dictionary<string, Func<string, double>>
            {
                // mapping double values such as Nan, -INF, INF that is define in Autosar
                { Constant.NAN, input => { return double.NaN; } },
                { Constant.DOUBLE_MIN_VALUE, input => { return double.MinValue; } },
                { Constant.DOUBLE_MAX_VALUE, input => { return double.MaxValue; } },
            };

            value = value.ToUpper();

            return (convertMap.ContainsKey(value)) ? convertMap[value](value) :
                Convert.ToDouble(value, CultureInfo.InvariantCulture);
        }
        // Implementation: GENERIC_TUD_CLS_025_038

        /// <summary>
        /// Parse CDF and BSW files
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_047, CMN_TAD_ERR_040
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// FOREACH file in cdfFiles
        ///     IF file is CDF file THEN
        ///         LET CALL method parseAndSaveCDFFile to parse all CDF file and save a tree of containers to cdfDatas
        ///	LET CALL CheckVariantPostBuildCDF to check validation of CDF
		/// LET After process CDF files, call method parseAndSaveBswConfiguration to parse BSW configuration file
        /// LET CALL method validateBswConfigurationsGeneral to validate parsed BSW configuration file
        /// </algorithm>
        public override void ParseCDFs()
        {
            XDocument bswConfigFile = null;

            foreach (string path in CdfFiles.Keys)
            {
                XDocument file = CdfFiles[path];
                // Check if it's BSW files
                // Keep information and parse BSW file after CDF files
                if (file.Descendants().Any(x => x.Name.LocalName.Equals(Constant.BSW_IMPLEMENTATION)))
                {
                    // More than 1 BSW file, report error message
                    if (null != bswConfigFile)
                    {
                        UserInterface.Error(0, 40, Resources.ERR000040);
                        UserInterface.Exit();
                    }
                    else
                    {
                        bswConfigFile = file;
                    }
                }
                else
                {
                    // Parse CDF file
                    ParseAndSaveCDFFile(path, file);
                }
            } // End of foreach (string fileName in cdfFiles.Keys)
            
            // // Check for variant point
            CheckVariantPostBuildCDF();

            // If module is exists and no any config is parsed due to vendor filter. Raise error ERR000047
            bool checkVendorExists = ParseConfigStatus.Any() &&
                                                        ParseConfigStatus.All((Tuple<string, ParseConfigStatus> x) =>
                                                        Business.Parser.ParseConfigStatus.NoData == x.Item2);
            if (checkVendorExists)
            {
                // print error ERR000047
                UserInterface.Error(0, 47, Resources.ERR000047);
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }

            //Get multi instance information
            GetMultiInstanceInformation();

            // Parse BSW file
            if (null != bswConfigFile)
            {
                ParseAndSaveBswConfiguration(bswConfigFile);
            }
            else
            {
                // Not required
            }

            // Rules to validate BWS configuration
            ValidateBswConfigurationsGeneral();
        }
        // Implementation: GENERIC_TUD_CLS_025_011

        /// <summary>
        /// Parse translation file
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_013, CMN_TAD_ERR_039, CMN_TAD_ERR_046
        /// CMN_TAD_TR_006, CMN_TAD_USG_012
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     RuntimeConfiguration, UserInterface, ObjectFactory
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET Read translation file from runtimeConfiguration.TranslationFilePath
        /// IF file NOT found or invalid XML format THEN
        ///     LET Record error ERR000003 and exit
        /// LET GET device name configured in containers of current module (specfied by basicConfiguration.ModuleName)
        /// IF device name is null or empty THEN
        ///     LET Record error ERR000039 and exit
        /// IF device name is not in supported devices list get from SupportedVariants
        ///     LET CALL ERR000046
        /// LET CAll method parseTransFileSection to parse TRANSLATION-FILE-PATH section
        /// LET CAll method parseDeviceFileSection to parse DEVICE-FILE-PATH section
        ///
        /// IF result of parseTransFileSection or parseDeviceFileSection is FALSE THEN
        ///     LET Record error ERR000013 and exit
        /// </algorithm>
        public override void ParseTranslationFile()
        {
            string translationFilePath = RuntimeConfiguration.TranslationFilePath;

            // try to parse translation file xml
            XDocument document = IOWrapper.LoadXML(translationFilePath);

            //Parse file E2XTranslation.h
            XElement transFileSection = document.Descendants()
                .Where(x => x.Name.LocalName.Equals(Constant.TRANSLATION_FILE_PATH))
                .SingleOrDefault();
            // Parse file devide header
            XElement deviceFileSection = document.Descendants()
                .Where(x => x.Name.LocalName.Equals(Constant.DEVICE_FILE_PATH))
                .SingleOrDefault();

            // Get device name
            string deviceName = GetDeviceName();

            // Error Handling
            if (String.IsNullOrEmpty(deviceName))
            {
                UserInterface.Error(0, 39, Resources.ERR000039);
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }

            // Check device name is supported or not
            List<string> supportedDevices = ObjectFactory.SupportedVariants.SelectMany(x => x.Value).ToList();

            if (!supportedDevices.Any(x => x.Equals(deviceName)))
            {
                UserInterface.Error(0, 46, Resources.ERR000046, deviceName, string.Join(", ",  supportedDevices));
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }

            // If parse TRANSLATION-FILE-PATH section or parse DEVICE-FILE-PATH section failed
            if ((false == ParseTransFileSection(translationFilePath, transFileSection, deviceName)) ||
                (false == ParseDeviceFileSection(translationFilePath, deviceFileSection, deviceName)))
            {
                UserInterface.Error(0, 13, Resources.ERR000013, translationFilePath);
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_012

        /// <summary>
        /// Init parse files
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_012
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     RuntimeConfiguration, CdfFiles
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// FOREACH file path in runtimeConfiguration.CDFFilePaths
        ///     LET Load XDocument from the file path to store in cdfFiles
        /// LET Handle error ERR000012 if can NOT read files or files have invalid XML format
        /// </algorithm>
        public override void LoadFile()
        {
            List<string> filePaths = RuntimeConfiguration.CDFFilePaths;
            CdfFiles = new Dictionary<string, XDocument>();
            // Load all XDocument from the file path to store in cdfFiles
            foreach (string each in filePaths.Where(x => IOWrapper.FileExists(x)))
            {
                // try parse well-form XML
                CdfFiles[each] = IOWrapper.LoadXML(each);
            } // End of foreach (string each in files)
        }
        // Implementation: GENERIC_TUD_CLS_025_010

        /// <summary>
        /// Update basic configuration if needed
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     CdfData
        ///
        /// GLOBAL VARIABLE OUT:
        ///     BasicConfiguration
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// GET list of devices variant and devices name from SupportedVariants
        /// FOREACH container in cdfData of current module (specified by basicConfiguration.ModuleName)
        ///     IF found parameter DeviceName and its value is NOT null or empty THEN
        ///         LET Add device name to collection "result"
        /// IF having device names in collection "result" THEN
        ///     LET set collection "result" to basicConfiguration.DeviceNames
        ///     LET set version as value got from BSWMDT to basicConfiguration.AutoSARVersion
        /// </algorithm>
        public override void UpdateBasicConfigurationIfNeeded()
        {
            BasicConfiguration.DeviceNames = new List<string> { GetDeviceName() };
            //TODO: set default AutosarVersion. Will update when new versions come.
            BasicConfiguration.AutoSARVersion = CdfData.GetBswConfigurations().FirstOrDefault().ArReleaseVersion;

            // Get valid device variant
            Dictionary<string, List<string>> devicesVar = ObjectFactory.SupportedVariants;

            foreach (string key in devicesVar.Keys)
            {
                if (BasicConfiguration.DeviceNames.Any(x => devicesVar[key].Contains(x)))
                {
                    BasicConfiguration.DeviceVariant = key;
                    break;
                }
                else
                {
                    // nothing
                }
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_013

        /// <summary>
        /// Check required modules
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// FOREACH module name in basicConfiguration.ModuleRequired
        ///     CALL method isExistModuleName to check if the module name is existed in input CDF files
        ///     IF is not existed THEN
        ///         LET record absented module name
        /// LET record error ERR[MSN]003 for absented module names if found.
        /// </algorithm>
        public override void CheckRequiredModules()
        {
            Dictionary<string, string> layersName = new Dictionary<string, string>()
            {
                { "OS", " Service Layer Component"},
                { "DEM", "  Component"},
            };
            string defaultLayerName = " Driver Component";
            string[] moduleNames = BasicConfiguration.ModuleRequired.Where(x => !string.IsNullOrEmpty(x))
                                                                    .Select(x => x.ToUpper()).ToArray();
            // Required module is specific regarding to [MSN] definition.
            string[] lackedModules = moduleNames.Where(m => !isExistModuleName(m)).ToArray();
            // Do nothing if required module is not defined by [MSN]
            if (Constant.INT_ZERO < lackedModules.Length)
            {
                string[] fullModuleNames = lackedModules
                    .Select(m => m + (layersName.ContainsKey(m) ? layersName[m] : defaultLayerName))
                    .ToArray();
                string verb = (lackedModules.Length > Constant.INT_ONE) ? "are" : "is";
                // Report error if CDF files of required module is missing.

                UserInterface.Error(BasicConfiguration.ModuleId,
                    3,
                    "{0} {1} not present in the input file(s) or not provided in <STUBS> tag of configuration XML file.", 
                                                                            string.Join(", ", fullModuleNames), verb);
                UserInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_009

        /// <summary>
        /// Check if moduleName existed in cdfData
        /// </summary>
        /// <param name="moduleName">Module name <range>!empty</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The checking result</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get all modules from cdfData by CALL method cdfData.GetModules()
        /// IF found a module name that matchs pattern {modulename}{number}* THEN
        ///     RETURN true
        /// ELSE
        ///     RETURN false
        /// </algorithm>
        private bool isExistModuleName(string moduleName)
        {
            bool ret = false;
            ICdfData CdfData = ObjectFactory.GetInstance<ICdfData>();
            IList<string> moduleList = CdfData.GetModules();
            // Check exists module with module name that can be suffix is a number
            if (moduleList.Any(x => Regex.IsMatch(x.ToLower(), String.Format("^{0}\\d*$", moduleName.ToLower()))))
            {
                ret = true;
            }
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_025_042

        /// <summary>
        /// Get multi instance information.
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET BasicConfiguration.NumberOfInstances = number of configuration with modulename
        /// IF NumberOfInstances is larger than 1
        ///     LET BasicConfiguration.InstanceOutType = InstanceOutputType.FILES
        ///     LET BasicConfiguration.HasInstanceSetting = true
        /// ELSE
        ///     LET BasicConfiguration.InstanceOutType = InstanceOutputType.DEFAULT
        ///     LET BasicConfiguration.HasInstanceSetting = false
        /// </algorithm>
        private void GetMultiInstanceInformation()
        {
            //Get all CDF configs 
            IList<Configuration> allConfigs = CdfData.GetAllInstanceConfigurations(BasicConfiguration.ModuleName);

            //Get number of instance.
            int numberOfInstances = Constant.INT_ZERO;
            foreach (Configuration each in allConfigs)
            {                
                    numberOfInstances++;               
            }// End of  foreach (Configuration each in configs)
            BasicConfiguration.NumberOfInstances = numberOfInstances;

            //Check if multi instance config is provided
            if (numberOfInstances > Constant.INT_ONE)
            {
                BasicConfiguration.InstanceOutType = InstanceOutputType.FILES;
                BasicConfiguration.HasInstanceSetting = true;
            }
            else
            {
                // If module is not multi-instance, apply output format of single instance module
                BasicConfiguration.InstanceOutType = InstanceOutputType.DEFAULT;
                BasicConfiguration.HasInstanceSetting = false;
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_048
        
        /// <summary>
        /// Check if verifivation Vendor Api Infix is needed
        /// </summary>
        /// <param name="bswNode">BswConfig <range>!empty</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The checking result</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF has cdf config relating bswmdt config
        ///     Return true
        /// ELSE
        ///     Return false
        /// </algorithm>
        private bool needVerifyVendorApiInfix(BswConfig bswNode)
        {
            bool ret = false;

            if (true == BasicConfiguration.HasInstanceSetting)
            {
                IList<Configuration> allConfigurations = 
                                                    CdfData.GetAllInstanceConfigurations(BasicConfiguration.ModuleName);
                if (true == allConfigurations.Any(x => x.ModuleDescriptionRef.Equals(bswNode.ImplementRootPath)))
                {
                    ret = true;
                }
                else
                {
                    //Do nothing
                }
                
            }
            else
            {
                //Do nothing
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_025_045

        /// <summary>
        /// Parse BSW package
        /// </summary>
        /// <param name="bswPackage">XElement <range>!empty</range></param>
        /// <param name="parentPath">string <range>empty/!empty</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Parse all Bsw config from AR-PACKAGE
        /// </algorithm>
        public void ParseBswPackage(XElement bswPackage, string parentPath = "")
        {
            string curPackageShortName = bswPackage.Elements().Where(x => Constant.SHORT_NAME.Equals(
                                        x.Name.LocalName, StringComparison.OrdinalIgnoreCase)).SingleOrDefault().Value;
            bool hasChildPackages = bswPackage.Elements().Any(x => Constant.AR_PACKAGES.Equals(
                                                                 x.Name.LocalName, StringComparison.OrdinalIgnoreCase));
            bool hasBswConfig = bswPackage.Elements().Any(x => Constant.ELEMENTS.Equals(
                                                                 x.Name.LocalName, StringComparison.OrdinalIgnoreCase));
            string updatedPath = parentPath + curPackageShortName + Constant.PATH_SEPARATOR;
            if (true == hasChildPackages)
            {
                IEnumerable<XElement> allChildPackages = bswPackage.Elements().Where(x => Constant.AR_PACKAGES.Equals(
                                    x.Name.LocalName, StringComparison.OrdinalIgnoreCase)).SingleOrDefault().Elements();
                foreach (XElement childPackage in allChildPackages)
                {
                    ParseBswPackage(childPackage, updatedPath);
                }
            }
            else
            {
                //Do nothing
            }

            if (true == hasBswConfig)
            {
                XElement elements = bswPackage.Elements().Where(x => Constant.ELEMENTS.Equals(
                                            x.Name.LocalName, StringComparison.OrdinalIgnoreCase)).SingleOrDefault();
                string[] requiredFields = Resources.RequiredBswFields.Split(Constant.COMMA_CHAR).Select(
                                                                                               x => x.Trim()).ToArray();

                string name = curPackageShortName;
                BswConfig bswConfig = new BswConfig();
                // Get Instance configurations from CDF data.

                //Parse sub elements:
                ParseSubElement(elements, requiredFields, tagNameToField, ref bswConfig);

                bswConfig.ImplementRootPath = updatedPath + bswConfig.ImplementSortName;

                CheckRelationBswmdtAndCdf(bswConfig);

                // Check error 26
                ValidateBswConfigurationDetail(bswConfig);

                CdfData.SaveBswConfiguration(bswConfig.DescriptionShortName, bswConfig);
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_046

        /// <summary>
        /// Check variant PostBuild CDF
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_057
	    	/// CMN_TAD_ERR_058
	    	/// CMN_TAD_ERR_059
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     UserInterface
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///	LET configs = Get Instance configurations from CDF data.
	    /// FOREACH Configuration config in configs
	    ///		IF config.postBuildVariantSupport is not null or empty
	    ///			IF postBuildVariantSupport is equal to TRUE
	    ///				LET instanceContainers = Get all instance containers in CdfData by ModuleName
    	///				LET variantset = Get ealuated variant set in CdfData
	    ///				LET variantcriterionset = Get variant criterion set in CdfData
	    ///				LET variantcriterionmod = Get variant criterion module configuration in CdfData
	    ///				IF variantcriterionset is not equal to variantcriterionmod
	    ///				  LET record ERR000057
	    ///				ELSE
	    ///               Do nothing
	    ///       FOREACH eachinstance IN instanceContainers.Values
	    ///         LET varianIDs = List of Variant ID in CDF
	    ///         IF variantset does not contain a id in varianIDs
	    ///           LET record ERR000059
	    ///         ELSE
	    ///           Do nothing
	    ///         FOREACH subinstace in eachInstance
	    ///           IF subinstance.VariantID and subinstance.ListConfiguredVariantID is not null
	    ///             IF subinstance.VariantID and variantIDs in each parameter are different
	    ///               LET record ERR000058
	    ///             ELSE
	    ///               Do nothing
	    ///           ELSE
		///               Do nothing
		///			ELSE
	    ///           Do nothing
		///		ELSE
		///       Do nothing
        /// </algorithm>
        protected virtual void CheckVariantPostBuildCDF()
        {
            // Get Instance configurations from CDF data.
            IList<Configuration> configs = CdfData.GetAllInstanceConfigurations(BasicConfiguration.ModuleName);

            foreach (Configuration config in configs)
            {
                if (!String.IsNullOrEmpty(config.postBuildVariantSupport))
                {
                    if (config.postBuildVariantSupport.Equals(Constant.TRUE))
                    {
                        Dictionary<string, IList<Container>> instanceContainers =
                                                            CdfData.GetAllInstanceContainers(BasicConfiguration.ModuleName);
                        Dictionary<string, string> variantset = CdfData.GetEvaluatedVariantSet();

                        string variantcriterionset = CdfData.GetVariantCriterionSet();
                        string variantcriterionmod = CdfData.GetVariantCriterionModuleConfig();

                        if (!string.Equals(variantcriterionset, variantcriterionmod))
                        {
                            UserInterface.Error(0, 57, Resources.ERR000057, BasicConfiguration.ModuleName);
                            UserInterface.Exit();
                        }
                        else
                        {
                          // Do nothing
                        }

                        // Consider each instance in CDFs
                        foreach (IList<Container> eachInstance in instanceContainers.Values)
                        {
                            List<string> varianIDs = eachInstance.SelectMany(x => x.ListConfiguredVariantID)
                              .Where(x => null != x).Distinct().OrderBy(x => x).ToList();
                            foreach (string id in varianIDs)
                            {
                                if (!variantset.ContainsKey(id))
                                {
                                    UserInterface.Error(0, 59, Resources.ERR000059, BasicConfiguration.ModuleName);
                                    UserInterface.Exit();
                                }
                                else
                                {
                                  // Do nothing
                                }
                            }

                            foreach (Container subinstance in eachInstance)
                            {
                                if (!String.IsNullOrEmpty(subinstance.VariantID) && subinstance.ListConfiguredVariantID.Count > 0)
                                {
                                    string paramErr = "";
                                    foreach (ItemValue paramvalue in subinstance.ParameterValues)
                                    {
                                        foreach (string item in paramvalue.getListVariantIDs())
                                        {
                                            if (item != subinstance.VariantID)
                                            {
                                                paramErr += paramvalue.DefinitionRef().Split('/').Last() + ", ";
                                                break;
                                            }
                                            else
                                            {
                                              // Do nothing
                                            }
                                        }
                                    }

                                    foreach (ItemValue refvalue in subinstance.ReferenceValues)
                                    {
                                        foreach (string item in refvalue.getListVariantIDs())
                                        {
                                            if (item != subinstance.VariantID)
                                            {
                                                paramErr += refvalue.DefinitionRef().Split('/').Last() + ", ";
                                                break;
                                            }
                                            else
                                            {
                                                // Do nothing
                                            }
                                        }
                                    }

                                    if (!String.IsNullOrEmpty(paramErr))
                                    {
                                        UserInterface.Error(0, 58, Resources.ERR000058, subinstance.ShortName, paramErr);
                                        UserInterface.Exit();
                                    }
                                    else
                                    {
                                      // Do nothing
                                    }
                                }
                                else
                                {
                                    // Do nothing
                                }
                            }
                        }
                    }
                    else
                    {
                        // Not required
                    }
                }
                else
                {
                  // Do nothing
                }
            }
        }
        // Implementation: GENERIC_TUD_CLS_025_052
    }
}

