/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = Constant.cs                                                                                         */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2024 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file define common constant and is used by other file                                                */
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
/*              : class Constant                                                                                      */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

namespace Renesas.Generator.MCALConfGen.CrossCutting.Util
{
    /// <summary>
    /// This class define common constant and is used by other class.
    /// </summary>
    public class Constant
    {
        /// <summary>
        /// ON
        /// </summary>
        public const bool ON = true;
        // Implementation: GENERIC_TUD_CLS_039_001

        /// <summary>
        /// OFF
        /// </summary>
        public const bool OFF = false;
        // Implementation: GENERIC_TUD_CLS_039_002

        /// <summary>
        /// StdOn
        /// </summary>
        public const string STD_ON = "STD_ON";
        // Implementation: GENERIC_TUD_CLS_039_003

        /// <summary>
        /// StdOff
        /// </summary>
        public const string STD_OFF = "STD_OFF";
        // Implementation: GENERIC_TUD_CLS_039_004

        /// <summary>
        /// Ecuc container value
        /// </summary>
        public const string ECUC_CONTAINER_VALUE = "ECUC-CONTAINER-VALUE";
        // Implementation: GENERIC_TUD_CLS_039_005

        /// <summary>
        /// Container
        /// </summary>
        public const string CONTAINERS = "CONTAINERS";
        // Implementation: GENERIC_TUD_CLS_039_006

        /// <summary>
        /// Subcontainer
        /// </summary>
        public const string SUB_CONTAINERS = "SUB-CONTAINERS";
        // Implementation: GENERIC_TUD_CLS_039_007

        /// <summary>
        /// Ecuc module configuration value
        /// </summary>
        public const string ECUC_MODULE_CONFIGURATION_VALUES = "ECUC-MODULE-CONFIGURATION-VALUES";
        // Implementation: GENERIC_TUD_CLS_039_008

        /// <summary>
        /// Basic software implementation
        /// </summary>
        public const string BSW_IMPLEMENTATION = "BSW-IMPLEMENTATION";
        // Implementation: GENERIC_TUD_CLS_039_009

        /// <summary>
        /// Basic software module description
        /// </summary>
        public const string BSW_MODULE_DESCRIPTION = "BSW-MODULE-DESCRIPTION";
        // Implementation: GENERIC_TUD_CLS_039_010

        /// <summary>
        /// Translation file path
        /// </summary>
        public const string TRANSLATION_FILE_PATH = "TRANSLATION-FILE-PATH";
        // Implementation: GENERIC_TUD_CLS_039_011

        /// <summary>
        /// Device file path
        /// </summary>
        public const string DEVICE_FILE_PATH = "DEVICE-FILE-PATH";
        // Implementation: GENERIC_TUD_CLS_039_012

        /// <summary>
        /// ONE
        /// </summary>
        public const string ONE = "1";
        // Implementation: GENERIC_TUD_CLS_039_013

        /// <summary>
        /// ZERO
        /// </summary>
        public const string ZERO = "0";
        // Implementation: GENERIC_TUD_CLS_039_014

        /// <summary>
        /// TRUE
        /// </summary>
        public const string TRUE = "true";
        // Implementation: GENERIC_TUD_CLS_039_015

        /// <summary>
        /// FALSE
        /// </summary>
        public const string FALSE = "false";
        // Implementation: GENERIC_TUD_CLS_039_016

        /// <summary>
        /// IOREG
        /// </summary>
        public const string IOREG = "__IOREG";
        // Implementation: GENERIC_TUD_CLS_039_017

        /// <summary>
        /// OPTION
        /// </summary>
        public const string OPTION = "OPTION";
        // Implementation: GENERIC_TUD_CLS_039_018

        /// <summary>
        /// Input file
        /// </summary>
        public const string INPUT_FILE = "INPUT-FILE";
        // Implementation: GENERIC_TUD_CLS_039_019

        /// <summary>
        /// Ar Release 
        /// </summary>
        public const string AR_RELEASE_VERSION = "AR-RELEASE-VERSION";
        // Implementation: GENERIC_TUD_CLS_039_020

        /// <summary>
        /// Ar software version
        /// </summary>
        public const string SW_VERSION = "SW-VERSION";
        // Implementation: GENERIC_TUD_CLS_039_021

        /// <summary>
        /// Vendor id
        /// </summary>
        public const string VENDOR_ID = "VENDOR-ID";
        // Implementation: GENERIC_TUD_CLS_039_022

        /// <summary>
        /// Module id
        /// </summary>
        public const string MODULE_ID = "MODULE-ID";
        // Implementation: GENERIC_TUD_CLS_039_023

        /// <summary>
        /// Ar package
        /// </summary>
        public const string AR_PACKAGE = "AR-PACKAGE";
        // Implementation: GENERIC_TUD_CLS_039_024

        /// <summary>
        /// Ar packages
        /// </summary>
        public const string AR_PACKAGES = "AR-PACKAGES";
        // Implementation: GENERIC_TUD_CLS_039_025

        /// <summary>
        /// Elements
        /// </summary>
        public const string ELEMENTS = "ELEMENTS";
        // Implementation: GENERIC_TUD_CLS_039_026

        /// <summary>
        /// Short name
        /// </summary>
        public const string SHORT_NAME = "SHORT-NAME";
        // Implementation: GENERIC_TUD_CLS_039_027

        /// <summary>
        /// Ecuc value collection
        /// </summary>
        public const string ECUC_VALUE_COLLECTION = "ECUC-VALUE-COLLECTION";
        // Implementation: GENERIC_TUD_CLS_039_028

        /// <summary>
        /// Exit due to command line error
        /// </summary>
        public const int EXIT_DUE_CMD_ERROR = -1;
        // Implementation: GENERIC_TUD_CLS_039_032

        /// <summary>
        /// Exit successful
        /// </summary>
        public const int EXIT_SUCCESSFUL = 0;
        // Implementation: GENERIC_TUD_CLS_039_033

        /// <summary>
        /// Exit successful with warnings
        /// </summary>
        public const int EXIT_SUCCESSFUL_WITH_WARNINGS = 1;
        // Implementation: GENERIC_TUD_CLS_039_034

        /// <summary>
        /// Exit due to input files error
        /// </summary>
        public const int EXIT_DUE_INPUT_FILES_ERROR = 2;
        // Implementation: GENERIC_TUD_CLS_039_035

        /// <summary>
        /// Exit due to structure generation error
        /// </summary>
        public const int EXIT_DUE_STRUCTURE_GENERATION_ERROR = 3;
        // Implementation: GENERIC_TUD_CLS_039_036

        /// <summary>
        /// Exit due to overwritten file error
        /// </summary>
        public const int EXIT_DUE_OVERWRITTEN_FILE_ERROR = 4;
        // Implementation: GENERIC_TUD_CLS_039_037

        /// <summary>
        /// Exit due to overwritten file error
        /// </summary>
        public const int EXIT_DUE_CRASH = 6;
        // Implementation: GENERIC_TUD_CLS_039_038

        // <summary>
        /// Mark for bool data type
        /// </summary>
        public static readonly string BoolDataTypeMarked = "ECUC-BOOLEAN-PARAM-DEF";
        // Implementation: GENERIC_TUD_CLS_039_039

        // <summary>
        /// Mark for float data type
        /// </summary>
        public static readonly string FloatDataTypeMarked = "ECUC-FLOAT-PARAM-DEF";
        // Implementation: GENERIC_TUD_CLS_039_040

        /// <summary>
        /// Exit due to overwritten file error
        /// </summary>
        public const int EXIT_DUE_UNCOMPATIBLE_DLL = 5;
        // Implementation: GENERIC_TUD_CLS_039_041

        /// <summary>
        /// Exit due to overwritten file error
        /// </summary>
        public const int EXIT_DUE_DLL_NOT_FOUND = 7;
        // Implementation: GENERIC_TUD_CLS_039_042

        /// <summary>
        /// Device name of all.
        /// </summary>
        public const string DEVICE_NAME_ALL = "*";
        // Implementation: GENERIC_TUD_CLS_039_051

        /// <summary>
        /// AutoSar Version 4.2.2
        /// </summary>
        public const string AR_VERSION_4_2_2 = "4.2.2";
        // Implementation: GENERIC_TUD_CLS_039_052

        /// <summary>
        /// AutoSar Version of all support
        /// </summary>
        public const string AR_VERSION_ALL = "*";
        // Implementation: GENERIC_TUD_CLS_039_053

        /// <summary>
        /// Version 1.0.0
        /// </summary>
        public const string VERSION_1_0_0 = "1.0.0";
        // Implementation: GENERIC_TUD_CLS_039_054

        /// <summary>
        /// Version of all support
        /// </summary>
        public const string VERSION_ALL = "*";
        // Implementation: GENERIC_TUD_CLS_039_055

        // <summary>
        /// Vendor id position
        /// </summary>
        public static readonly int VendorIdPosition = 22;
        // Implementation: GENERIC_TUD_CLS_039_056

        // <summary>
        /// Module id position
        /// </summary>
        public static readonly int ModuleIdPosition = 14;
        // Implementation: GENERIC_TUD_CLS_039_057

        // <summary>
        /// SwMajor Version Position
        /// </summary>
        public static readonly int SwMajorVersionPosition = 8;
        // Implementation: GENERIC_TUD_CLS_039_058

        // <summary>
        /// SwMinor Version Position
        /// </summary>
        public static readonly int SwMinorVersionPosition = 3;
        // Implementation: GENERIC_TUD_CLS_039_059

        // <summary>
        /// ZERO numeric
        /// </summary>
        public static readonly int INT_ZERO = 0;
        // Implementation: GENERIC_TUD_CLS_039_060

        // <summary>
        /// ONE numeric
        /// </summary>
        public static readonly int INT_ONE = 1;
        // Implementation: GENERIC_TUD_CLS_039_061

        /// <summary>
        /// FILTER
        /// </summary>
        public const string FILTER = "FILTER";
        // Implementation: GENERIC_TUD_CLS_039_068

        /// <summary>
        /// DEFINITION REF
        /// </summary>
        public const string DEFINITION_REF = "DEFINITION-REF";
        // Implementation: GENERIC_TUD_CLS_039_069

        /// <summary>
        /// VALUE REF
        /// </summary>
        public const string VALUE_REF = "VALUE-REF";
        // Implementation: GENERIC_TUD_CLS_039_070

        /// <summary>
        /// DEST
        /// </summary>
        public const string DEST = "DEST";
        // Implementation: GENERIC_TUD_CLS_039_071

        /// <summary>
        /// Module description ref
        /// </summary>
        public const string MODULE_DESCRIPTION_REF = "MODULE-DESCRIPTION-REF";
        // Implementation: GENERIC_TUD_CLS_039_072

        /// <summary>
        /// UUID
        /// </summary>
        public const string UUID = "UUID";
        // Implementation: GENERIC_TUD_CLS_039_073

        /// <summary>
        /// Parameter Values
        /// </summary>
        public const string PARAMETER_VALUES = "PARAMETER-VALUES";
        // Implementation: GENERIC_TUD_CLS_039_074

        /// <summary>
        /// Reference Values
        /// </summary>
        public const string REFERENCE_VALUES = "REFERENCE-VALUES";
        // Implementation: GENERIC_TUD_CLS_039_075

        /// <summary>
        /// Vendor API infix
        /// </summary>
        public const string VENDOR_API_INFIX = "VENDOR-API-INFIX";
        // Implementation: GENERIC_TUD_CLS_039_076

        /// <summary>
        /// STR_ON
        /// </summary>
        public const string STR_ON = "ON";
        // Implementation: GENERIC_TUD_CLS_039_077

        /// <summary>
        /// STR_OFF
        /// </summary>
        public const string STR_OFF = "OFF";
        // Implementation: GENERIC_TUD_CLS_039_078

        /// <summary>
        /// OUTPUT PATH
        /// </summary>
        public const string OUTPUT_PATH = "OUTPUT-PATH";
        // Implementation: GENERIC_TUD_CLS_039_079

        /// <summary>
        /// FILTER NAME
        /// </summary>
        public const string FILTER_NAME = "FILTER-NAME";
        // Implementation: GENERIC_TUD_CLS_039_080

        /// <summary>
        /// NAN
        /// </summary>
        public const string NAN = "NAN";
        // Implementation: GENERIC_TUD_CLS_039_081

        /// <summary>
        /// Min value float point
        /// </summary>
        public const string DOUBLE_MIN_VALUE = "-INF";
        // Implementation: GENERIC_TUD_CLS_039_082

        /// <summary>
        /// Max value float point
        /// </summary>
        public const string DOUBLE_MAX_VALUE = "INF";
        // Implementation: GENERIC_TUD_CLS_039_083

        /// <summary>
        /// Value string
        /// </summary>
        public const string VALUE = "VALUE";
        // Implementation: GENERIC_TUD_CLS_039_084

        /// <summary>
        /// Mark for ECUC BOOLEAN PARAM DEF attribute CDF
        /// </summary>
        public const string ECUC_BOOLEAN_PARAM_DEF = "ECUC-BOOLEAN-PARAM-DEF";
        // Implementation: GENERIC_TUD_CLS_039_085

        /// <summary>
        /// Mark for ECUC_INTEGER_PARAM_DEF attribute CDF
        /// </summary>
        public const string ECUC_INTEGER_PARAM_DEF = "ECUC-INTEGER-PARAM-DEF";
        // Implementation: GENERIC_TUD_CLS_039_086

        /// <summary>
        /// Mark for ECUC_FLOAT_PARAM_DEF attribute CDF
        /// </summary>
        public const string ECUC_FLOAT_PARAM_DEF = "ECUC-FLOAT-PARAM-DEF";
        // Implementation: GENERIC_TUD_CLS_039_087

        /// <summary>
        /// Mark for ECUC_STRING_PARAM_DEF attribute CDF
        /// </summary>
        public const string ECUC_STRING_PARAM_DEF = "ECUC-STRING-PARAM-DEF";
        // Implementation: GENERIC_TUD_CLS_039_088

        /// <summary>
        /// Mark for ECUC_LINKER_SYMBOL_DEF attribute CDF
        /// </summary>
        public const string ECUC_LINKER_SYMBOL_DEF = "ECUC-LINKER-SYMBOL-DEF";
        // Implementation: GENERIC_TUD_CLS_039_089

        /// <summary>
        /// Mark for ECUC_FUNCTION_NAME_DEF attribute CDF
        /// </summary>
        public const string ECUC_FUNCTION_NAME_DEF = "ECUC-FUNCTION-NAME-DEF";
        // Implementation: GENERIC_TUD_CLS_039_090

        /// <summary>
        /// Mark for ECUC_ENUMERATION_PARAM_DEF attribute CDF
        /// </summary>
        public const string ECUC_ENUMERATION_PARAM_DEF = "ECUC-ENUMERATION-PARAM-DEF";
        // Implementation: GENERIC_TUD_CLS_039_091

        /// <summary>
        /// Mark for ECUC_ENUMERATION_LITERAL_DEF attribute CDF
        /// </summary>
        public const string ECUC_ENUMERATION_LITERAL_DEF = "ECUC-ENUMERATION-LITERAL-DEF";
        // Implementation: GENERIC_TUD_CLS_039_092

        /// <summary>
        /// Mark for ECUC_SYMBOLIC_NAME_REFERENCE_DEF attribute CDF
        /// </summary>
        public const string ECUC_SYMBOLIC_NAME_REFERENCE_DEF = "ECUC-SYMBOLIC-NAME-REFERENCE-DEF";
        // Implementation: GENERIC_TUD_CLS_039_093

        /// <summary>
        /// Mark for ECUC_URI_REFERENCE_DEF attribute CDF
        /// </summary>
        public const string ECUC_URI_REFERENCE_DEF = "ECUC-URI-REFERENCE-DEF";
        // Implementation: GENERIC_TUD_CLS_039_094

        /// <summary>
        /// Mark for ECUC_ADD_INFO_PARAM_DEF attribute CDF
        /// </summary>
        public const string ECUC_ADD_INFO_PARAM_DEF = "ECUC-ADD-INFO-PARAM-DEF";
        // Implementation: GENERIC_TUD_CLS_039_095

        /// <summary>
        /// Invalid Attribute
        /// </summary>
        public const int INVALID_ATTRIBUTE = -1;
        // Implementation: GENERIC_TUD_CLS_039_096

        // <summary>
        /// TWO numeric
        /// </summary>
        public const int INT_TWO = 2;
        // Implementation: GENERIC_TUD_CLS_039_103

        // <summary>
        /// THREE numeric
        /// </summary>
        public const int INT_THREE = 3;
        // Implementation: GENERIC_TUD_CLS_039_104

        /// <summary>
        /// FOUR numeric
        /// </summary>
        public const int INT_FOUR = 4;
        // Implementation: GENERIC_TUD_CLS_039_105

        /// <summary>
        /// Instance index
        /// </summary>
        public const string INSTANCE_INDEX = "INSTANCE_INDEX";
        // Implementation: GENERIC_TUD_CLS_039_106

        /// <summary>
        /// Max line length
        /// </summary>
        public const int MAX_LINE_LENGTH = 120;
        // Implementation: GENERIC_TUD_CLS_039_107

        /// <summary>
        /// Indent section length
        /// </summary>
        public const int INDENT_SECTION = 26;
        // Implementation: GENERIC_TUD_CLS_039_108

        /// <summary>
        /// OUTPUT
        /// </summary>
        public const string OUTPUT = "OUTPUT";
        // Implementation: GENERIC_TUD_CLS_039_109

        /// <summary>
        /// Implement Prefix
        /// </summary>
        public const string IMPLEMENT_PREFIX = "IMPLEMENT-";
        // Implementation: GENERIC_TUD_CLS_039_110

        /// <summary>
        /// Implement Prefix
        /// </summary>
        public const string DESCRIPTION_PREFIX = "DESCRIPTION-";
        // Implementation: GENERIC_TUD_CLS_039_111

        /// <summary>
        /// CDF Extension
        /// </summary>
        public const string CDF_EXTENSION = ".arxml";
        // Implementation: GENERIC_TUD_CLS_039_113

        /// <summary>
        /// Translation Extension
        /// </summary>
        public const string TRANSLATION_FILE_EXTENSION = ".trxml";
        // Implementation: GENERIC_TUD_CLS_039_114

        /// <summary>
        /// NULL
        /// </summary>
        public const string NULL = "NULL";
        // Implementation: GENERIC_TUD_CLS_039_115

        /// <summary>
        /// NULL_PTR
        /// </summary>
        public const string NULL_PTR = "NULL_PTR";
        // Implementation: GENERIC_TUD_CLS_039_116

        /// <summary>
        /// ON_OFF_PARAMS
        /// </summary>
        public const string ON_OFF_PARAMS = "OnOffParams";
        // Implementation: GENERIC_TUD_CLS_039_117

        /// <summary>
        /// DEM_EVENT_PARAMS
        /// </summary>
        public const string DEM_EVENT_PARAMS = "DemEventParams";
        // Implementation: GENERIC_TUD_CLS_039_118

        /// <summary>
        /// DEM_CONF_DEM_EVENT_PARAMETER
        /// </summary>
        public const string DEM_CONF_DEM_EVENT_PARAMETER = "DemConf_DemEventParameter_";
        // Implementation: GENERIC_TUD_CLS_039_119

        /// <summary>
        /// MODULE_NAME
        /// </summary>
        public const string MODULE_NAME = "MODULE_NAME";
        // Implementation: GENERIC_TUD_CLS_039_120

        /// <summary>
        /// MICROFAMILY_NAME
        /// </summary>
        public const string MICROFAMILY_NAME = "MICROFAMILY_NAME";
        // Implementation: GENERIC_TUD_CLS_039_121

        /// <summary>
        /// MODULE_REQUIRED
        /// </summary>
        public const string MODULE_REQUIRED = "MODULE_REQUIRED";
        // Implementation: GENERIC_TUD_CLS_039_122

        /// <summary>
        /// PROJECT_TITLE
        /// </summary>
        public const string PROJECT_TITLE = "PROJECT_TITLE";
        // Implementation: GENERIC_TUD_CLS_039_123

        /// <summary>
        /// MODULE_TOOL_ID
        /// </summary>
        public const string MODULE_TOOL_ID = "MODULE_ID";
        // Implementation: GENERIC_TUD_CLS_039_124

        /// <summary>
        /// VERSION INFORMATION DATA
        /// </summary>
        public const string VERSION_INFORMATION_DATA= "VERSION_INFORMATION_DATA";
        // Implementation: GENERIC_TUD_CLS_039_125

        /// <summary>
        /// CFG AR RELEASE MAJOR VERSION
        /// </summary>
        public const string CFG_AR_RELEASE_MAJOR_VERSION = "CFG_AR_RELEASE_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_126

        /// <summary>
        /// CFG AR RELEASE MINOR VERSION
        /// </summary>
        public const string CFG_AR_RELEASE_MINOR_VERSION = "CFG_AR_RELEASE_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_127

        /// <summary>
        /// CFG AR RELEASE REVISION VERSION
        /// </summary>
        public const string CFG_AR_RELEASE_REVISION_VERSION = "CFG_AR_RELEASE_REVISION_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_128

        /// <summary>
        /// CFG SW MAJOR VERSION
        /// </summary>
        public const string CFG_SW_MAJOR_VERSION = "CFG_SW_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_129

        /// <summary>
        /// CFG SW MINOR VERSION
        /// </summary>
        public const string CFG_SW_MINOR_VERSION = "CFG_SW_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_130

        /// <summary>
        /// AR RELEASE MAJOR VERSION VALUE
        /// </summary>
        public const string AR_RELEASE_MAJOR_VERSION_VALUE = "AR_RELEASE_MAJOR_VERSION_VALUE";
        // Implementation: GENERIC_TUD_CLS_039_131

        /// <summary>
        /// AR RELEASE MINOR VERSION VALUE
        /// </summary>
        public const string AR_RELEASE_MINOR_VERSION_VALUE = "AR_RELEASE_MINOR_VERSION_VALUE";
        // Implementation: GENERIC_TUD_CLS_039_132

        /// <summary>
        /// AR RELEASE REVISION VERSION VALUE
        /// </summary>
        public const string AR_RELEASE_REVISION_VERSION_VALUE = "AR_RELEASE_REVISION_VERSION_VALUE";
        // Implementation: GENERIC_TUD_CLS_039_133

        /// <summary>
        /// SW MAJOR VERSION VALUE
        /// </summary>
        public const string SW_MAJOR_VERSION_VALUE = "SW_MAJOR_VERSION_VALUE";
        // Implementation: GENERIC_TUD_CLS_039_134

        /// <summary>
        /// SW MINOR VERSION VALUE
        /// </summary>
        public const string SW_MINOR_VERSION_VALUE = "SW_MINOR_VERSION_VALUE";
        // Implementation: GENERIC_TUD_CLS_039_135

        /// <summary>
        /// SW PATCH VERSION VALUE
        /// </summary>
        public const string SW_PATCH_VERSION_VALUE = "SW_PATCH_VERSION_VALUE";
        // Implementation: GENERIC_TUD_CLS_039_136

        /// <summary>
        /// VENDOR ID VALUE
        /// </summary>
        public const string VENDOR_ID_VALUE = "VENDOR_ID_VALUE";
        // Implementation: GENERIC_TUD_CLS_039_137

        /// <summary>
        /// MODULE ID VALUE
        /// </summary>
        public const string MODULE_ID_VALUE = "MODULE_ID_VALUE";
        // Implementation: GENERIC_TUD_CLS_039_138

        /// <summary>
        /// CBK AR RELEASE MAJOR VERSION
        /// </summary>
        public const string CBK_AR_RELEASE_MAJOR_VERSION = "CBK_AR_RELEASE_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_139

        /// <summary>
        /// CBK AR RELEASE MINOR VERSION
        /// </summary>
        public const string CBK_AR_RELEASE_MINOR_VERSION = "CBK_AR_RELEASE_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_140

        /// <summary>
        /// CBK AR RELEASE REVISION VERSION
        /// </summary>
        public const string CBK_AR_RELEASE_REVISION_VERSION = "CBK_AR_RELEASE_REVISION_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_141

        /// <summary>
        /// CBK SW MAJOR VERSION
        /// </summary>
        public const string CBK_SW_MAJOR_VERSION = "CBK_SW_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_142

        /// <summary>
        /// CBK SW MINOR VERSION
        /// </summary>
        public const string CBK_SW_MINOR_VERSION = "CBK_SW_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_143

        /// <summary>
        /// PBCFG C AR RELEASE MAJOR VERSION
        /// </summary>
        public const string PBCFG_C_AR_RELEASE_MAJOR_VERSION = "PBCFG_C_AR_RELEASE_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_144

        /// <summary>
        /// PBCFG C AR RELEASE MINOR VERSION
        /// </summary>
        public const string PBCFG_C_AR_RELEASE_MINOR_VERSION = "PBCFG_C_AR_RELEASE_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_145

        /// <summary>
        /// PBCFG C AR RELEASE REVISION VERSION
        /// </summary>
        public const string PBCFG_C_AR_RELEASE_REVISION_VERSION = "PBCFG_C_AR_RELEASE_REVISION_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_146

        /// <summary>
        /// PBCFG C SW MAJOR VERSION
        /// </summary>
        public const string PBCFG_C_SW_MAJOR_VERSION = "PBCFG_C_SW_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_147

        /// <summary>
        /// PBCFG C SW MINOR VERSION
        /// </summary>
        public const string PBCFG_C_SW_MINOR_VERSION = "PBCFG_C_SW_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_148

        /// <summary>
        /// VERSION INFORMATION CBK
        /// </summary>
        public const string VERSION_INFORMATION_CBK = "VERSION_INFORMATION_CBK";
        // Implementation: GENERIC_TUD_CLS_039_149

        /// <summary>
        /// VERSION INFORMATION PBCFG
        /// </summary>
        public const string VERSION_INFORMATION_PBCFG = "VERSION_INFORMATION_PBCFG";
        // Implementation: GENERIC_TUD_CLS_039_150

        /// <summary>
        /// CALL BACK
        /// </summary>
        public const string CALL_BACK = "CBK";
        // Implementation: GENERIC_TUD_CLS_039_151

        /// <summary>
        /// POST BUILD
        /// </summary>
        public const string POST_BUILD = "PBCFG";
        // Implementation: GENERIC_TUD_CLS_039_152

        // <summary>
        /// VERSION INFORMATION CFG
        /// </summary>
        public const string VERSION_INFORMATION_CFG = "VERSION_INFORMATION_CFG";
        // Implementation: GENERIC_TUD_CLS_039_153

        // <summary>
        /// LCFG_C_AR_RELEASE_MAJOR_VERSION
        /// </summary>
        public const string LCFG_C_AR_RELEASE_MAJOR_VERSION = "LCFG_C_AR_RELEASE_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_154

        // <summary>
        /// LCFG_C_AR_RELEASE_MINOR_VERSION
        /// </summary>
        public const string LCFG_C_AR_RELEASE_MINOR_VERSION = "LCFG_C_AR_RELEASE_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_155

        // <summary>
        /// LCFG_C_AR_RELEASE_REVISION_VERSION
        /// </summary>
        public const string LCFG_C_AR_RELEASE_REVISION_VERSION = "LCFG_C_AR_RELEASE_REVISION_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_156

        // <summary>
        /// LCFG_C_SW_MAJOR_VERSION
        /// </summary>
        public const string LCFG_C_SW_MAJOR_VERSION = "LCFG_C_SW_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_157

        // <summary>
        /// LCFG_C_SW_MINOR_VERSION
        /// </summary>
        public const string LCFG_C_SW_MINOR_VERSION = "LCFG_C_SW_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_158

        // <summary>
        /// LINK_TIME
        /// </summary>
        public const string LINK_TIME = "LCFG";
        // Implementation: GENERIC_TUD_CLS_039_159

        // <summary>
        /// VERSION INFORMATION LT
        /// </summary>
        public const string VERSION_INFORMATION_LT = "VERSION_INFORMATION_LT";
        // Implementation: GENERIC_TUD_CLS_039_160

        /// <summary>
        /// AutoSar Version 4.3.1
        /// </summary>
        public const string AR_VERSION_4_3_1 = "4.3.1";
        // Implementation: GENERIC_TUD_CLS_039_172

        /// <summary>
        /// E2x variant name
        /// </summary>
        public const string E2X_VARIANT = "E2x";
        // Implementation: GENERIC_TUD_CLS_039_173

        /// <summary>
        /// U2Ax variant name
        /// </summary>
        public const string U2AX_VARIANT = "U2Ax";
        // Implementation: GENERIC_TUD_CLS_039_174

        /// <summary>
        /// AR_VERSION value
        /// </summary>
        public const string AUTOSAR_VERSION = "AR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_175

        /// <summary>
        /// STUBS tag
        /// </summary>
        public const string STUBS = "STUBS";
        // Implementation: GENERIC_TUD_CLS_039_176

        /// <summary>
        /// Path Separator
        /// </summary>
        public const string PATH_SEPARATOR = "/";
        // Implementation: GENERIC_TUD_CLS_039_177

        /// <summary>
        /// Comma character
        /// </summary>
        public const char COMMA_CHAR = ',';
        // Implementation: GENERIC_TUD_CLS_039_178

        /// <summary>
        /// string of VendorApiInfix
        /// </summary>
        public const string VendorApiInfix = "VendorApiInfix";
        // Implementation: GENERIC_TUD_CLS_039_179

        /// <summary>
        /// string of space character
        /// </summary>
        public const char SpaceCharacter = ' ';
        // Implementation: GENERIC_TUD_CLS_039_180

        /// <summary>
        /// string of list separater
        /// </summary>
        public const string ListSeparator = ", ";
        // Implementation: GENERIC_TUD_CLS_039_181

        /// <summary>
        /// string of StartSec
        /// </summary>
        public const string StartSec = "StartSec";
        // Implementation: GENERIC_TUD_CLS_039_182

        /// <summary>
        /// string of list StopSec
        /// </summary>
        public const string StopSec = "StopSec";
        // Implementation: GENERIC_TUD_CLS_039_183

        /// <summary>
        /// Number of significant character
        /// </summary>
        public const int SignificantCharNum = 31;
        // Implementation: GENERIC_TUD_CLS_039_184

        /// <summary>
        /// Number of invalid index
        /// </summary>
        public const int InvalidIndex = -1;
        // Implementation: GENERIC_TUD_CLS_039_185

        /// <summary>
        /// U2Bx variant name
        /// </summary>
        public const string U2BX_VARIANT = "U2Bx";
        // Implementation: GENERIC_TUD_CLS_039_186

        /// <summary>
        /// U2Cx variant name
        /// </summary>
        public const string U2CX_VARIANT = "U2Cx";
        // Implementation: GENERIC_TUD_CLS_039_187

        /// <summary>
        /// U2BxE variant name
        /// </summary>
        public const string U2BXE_VARIANT = "U2Bx-E";
        // Implementation: GENERIC_TUD_CLS_039_202

        /// <summary>
        /// AutoSar Version 22.11
        /// </summary>
        public const string AR_VERSION_22_11 = "4.8.0";
        // Implementation: GENERIC_TUD_CLS_039_189

        /// <summary>
        /// MATCHING-CRITERION-REF
        /// </summary>
        public const string MATCHING_CRITERION_REF = "MATCHING-CRITERION-REF";
        // Implementation: GENERIC_TUD_CLS_039_190

        /// <summary>
        /// VARIATION-POINT
        /// </summary>
        public const string VARIATION_POINT = "VARIATION-POINT";
        // Implementation: GENERIC_TUD_CLS_039_191

        /// <summary>
        /// POST-BUILD-VARIANT-CONDITIONS
        /// </summary>
        public const string POST_BUILD_VARIANT_CONDITIONS = "POST-BUILD-VARIANT-CONDITIONS";
        // Implementation: GENERIC_TUD_CLS_039_192

        /// <summary>
        /// POST-BUILD-VARIANT-CONDITIONS
        /// </summary>
        public const string POST_BUILD_VARIANT_CONDITION = "POST-BUILD-VARIANT-CONDITION";
        // Implementation: GENERIC_TUD_CLS_039_193

        /// <summary>
        /// EcuC
        /// </summary>
        public const string EcuC = "EcuC";
        // Implementation: GENERIC_TUD_CLS_039_194

        /// <summary>
        /// EcucPostBuildVariants
        /// </summary>
        public const string EcucPostBuildVariants = "EcucPostBuildVariants";
        // Implementation: GENERIC_TUD_CLS_039_195

        /// <summary>
        /// EcucPostBuildVariantRef
        /// </summary>
        public const string EcucPostBuildVariantRef = "EcucPostBuildVariantRef";
        // Implementation: GENERIC_TUD_CLS_039_196

        /// <summary>
        /// ADMIN_DATA
        /// </summary>
        public const string ADMIN_DATA = "ADMIN-DATA";
        // Implementation: GENERIC_TUD_CLS_039_197

        /// <summary>
        /// EvaluateVariant
        /// </summary>
        public const string EvaluateVariant = "EvaluateVariant";
        // Implementation: GENERIC_TUD_CLS_039_198

        /// <summary>
        /// POST-BUILD-VARIANT-CRITERION-VALUE-SET
        /// </summary>
        public const string POST_BUILD_VARIANT_CRITERION_VALUE_SET = "POST-BUILD-VARIANT-CRITERION-VALUE-SET";
        // Implementation: GENERIC_TUD_CLS_039_199

        /// <summary>
        /// POST-BUILD-VARIANT-CRITERION
        /// </summary>
        public const string POST_BUILD_VARIANT_CRITERION = "POST-BUILD-VARIANT-CRITERION";
        // Implementation: GENERIC_TUD_CLS_039_200

        /// <summary>
        /// EVALUATED-VARIANT-SET
        /// </summary>
        public const string EVALUATED_VARIANT_SET = "EVALUATED-VARIANT-SET";
        // Implementation: GENERIC_TUD_CLS_039_201

        // <summary>
        /// CFG_C_AR_RELEASE_MAJOR_VERSION
        /// </summary>
        public const string CFG_C_AR_RELEASE_MINOR_VERSION = "CFG_C_AR_RELEASE_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_203

        // <summary>
        /// CFG_C_AR_RELEASE_MAJOR_VERSION
        /// </summary>
        public const string CFG_C_AR_RELEASE_REVISION_VERSION = "CFG_C_AR_RELEASE_REVISION_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_204

        // <summary>
        /// CFG_C_AR_RELEASE_MAJOR_VERSION
        /// </summary>
        public const string CFG_C_SW_MAJOR_VERSION = "CFG_C_SW_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_205

        // <summary>
        /// CFG_C_AR_RELEASE_MAJOR_VERSION
        /// </summary>
        public const string CFG_C_SW_MINOR_VERSION = "CFG_C_SW_MINOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_206
		
        // <summary>
        /// CFG_C_AR_RELEASE_MAJOR_VERSION
        /// </summary>
        public const string CFG_C_AR_RELEASE_MAJOR_VERSION = "CFG_C_AR_RELEASE_MAJOR_VERSION";
        // Implementation: GENERIC_TUD_CLS_039_207
    }
}
