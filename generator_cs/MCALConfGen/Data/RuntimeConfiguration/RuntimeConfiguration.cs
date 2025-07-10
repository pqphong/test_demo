/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = RuntimeConfiguration.cs                                                                             */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2022 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains RuntimeConfiguration class to implement IRuntimeConfiguration interface to store       */
/*          information processed by command line.                                                                    */
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
/*              : class RuntimeConfiguration                                                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            22/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/*            12/03/2019 :    Fix bug that is cloned from C1X - #91630 as follow:                                     */
/*                            Modify method getCmdOptions() to remove unnecessary code.                               */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     04/05/2021 :    add new property StubsFilter                                                            */
/* 1.3.2:     23/02/2022 :    add new property PrintToolVersion                                                       */
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
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

namespace Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration
{
    /// <summary>
    /// This class implement "IRuntimeConfiguration" interface to store
    /// information processed by command line.
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    public class RuntimeConfiguration : IRuntimeConfiguration
    {
        /// <summary>
        /// Default vendor name Renesas
        /// </summary>
        public static readonly string DefaultVendor = "Renesas";
        // Implementation: GENERIC_TUD_CLS_052_001

        /// <summary>
        /// "RuntimeConfiguration" instance used by "ObjectFactory" to get a new "RuntimeConfiguration" object
        /// </summary>
        public static readonly RuntimeConfiguration Instance = new RuntimeConfiguration();
        // Implementation: GENERIC_TUD_CLS_052_002

        /// <summary>
        /// Property of Translation file path
        /// </summary>
        public string TranslationFilePath { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_052_003

        /// <summary>
        /// Property of CDF file paths
        /// </summary>
        public List<string> CDFFilePaths { get; set; } = new List<string>();
        // Implementation: GENERIC_TUD_CLS_052_004

        /// <summary>
        /// Property of Module name
        /// </summary>
        [Option("m|module")]
        public string Module { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_052_005

        /// <summary>
        /// Property of Config file path
        /// </summary>
        [Option("c|configfile")]
        public string ConfigFilePath { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_052_006

        /// <summary>
        /// Property of Print help
        /// </summary>
        [Option("h|help")]
        public bool PrintHelp { get; set; }
        // Implementation: GENERIC_TUD_CLS_052_007

        /// <summary>
        /// Property of Print Version Information
        /// </summary>
        [Option("v|version")]
        public bool PrintToolVersion { get; set; } = false;
        // Implementation: GENERIC_TUD_CLS_052_025

        /// <summary>
        /// Property of Src output directory
        /// </summary>
        [Option("osrc")]
        public string SrcOutputDirectory { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_052_008

        /// <summary>
        /// Property of Inc output directory
        /// </summary>
        [Option("oinc")]
        public string IncOutputDirectory { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_052_009

        /// <summary>
        /// Property of Write log
        /// </summary>
        [Option("l|log")]
        public bool WriteLog { get; set; }
        // Implementation: GENERIC_TUD_CLS_052_010

        /// <summary>
        /// Property of Log file path
        /// </summary>
        public string LogFilePath { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_052_011

        /// <summary>
        /// Property of Dry run
        /// </summary>
        [Option("d|dryrun")]
        public bool DryRun { get; set; }
        // Implementation: GENERIC_TUD_CLS_052_012

        /// <summary>
        /// Property of Folder output
        /// </summary>
        [Option("o|output")]
        public string FolderOutput { get; set; }
        // Implementation: GENERIC_TUD_CLS_052_013

        /// <summary>
        /// Property of Vendor filter
        /// </summary>
        [Option("fr|filter")]
        public string VendorFilter { get; set; } = DefaultVendor;
        // Implementation: GENERIC_TUD_CLS_052_014

        /// <summary>
        /// Property of Stubs module filter
        /// </summary>
        public List<string> StubsFilter { get; set; } = new List<string>();
        // Implementation: GENERIC_TUD_CLS_052_024

        /// <summary>
        /// Runtime configuration constructor
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
        private RuntimeConfiguration()
        {
        }
        // Implementation: GENERIC_TUD_CLS_052_019

        /// <summary>
        /// Get single command options
        /// </summary>
        /// <returns>
        ///     <para>string[]
        ///         <desc>Array of command option</desc>
        ///         <range>valid options</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get all options that has type bool
        /// </algorithm>
        public string[] GetSingleCmdOptions()
        {
            return getCmdOptions(s => typeof(bool) == s.PropertyType).ToArray();
        }
        // Implementation: GENERIC_TUD_CLS_052_016

        /// <summary>
        /// Get all command options
        /// </summary>
        /// <returns>
        ///     <para>string[]
        ///         <desc>Array of command option</desc>
        ///         <range>valid options</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get all valid options of command line
        /// </algorithm>
        public string[] GetAllCmdOptions()
        {
            return getCmdOptions(s => true).ToArray();
        }
        // Implementation: GENERIC_TUD_CLS_052_015

        /// <summary>
        /// This method override options from command line
        /// </summary>
        /// <param name="options">Collection of command line options<range>null/valid Dictionary<string, string></range></param>
        /// <param name="filePaths">File paths <range>null/valid List<string></range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// CALL overrideOptions to override all options
        /// CALL overrideFiles to override all files
        /// </algorithm>
        public void OverrideCurrentConfigsBy(Dictionary<string, string> options, List<string> filePaths)
        {
            overrideOptions(options);
            overrideFiles(filePaths);
        }
        // Implementation: GENERIC_TUD_CLS_052_017

        /// <summary>
        /// Set default options value
        /// </summary>
        /// <param name="basicConfig">Basic config <range>null/valid IBasicConfiguration</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_USG_014
        /// </ref>
        /// <algorithm>
        /// IF options is not configed, it is assigned by default value.
        /// IF IncOutputDirectory is NOT specified
        ///     IncOutputDirectory = FolderOutput + "\include\"
        /// ELSE
        ///     IncOutputDirectory = IncOutputDirectory + "\include\"
        ///
        /// IF SrcOutputDirectory is NOT specified
        ///     SrcOutputDirectory = FolderOutput + "\include\"
        /// ELSE
        ///     SrcOutputDirectory = SrcOutputDirectory + "\src\"
        ///
        /// IF TranslationFilePath is NOT specified
        ///     TranslationFilePath = ExeDirectory + ModuleName + "_" + MicroFamilyName + ".trxml"
        /// End
        /// </algorithm>
        public void SetDefaultOptionsValue(IBasicConfiguration basicConfig)
        {
            if (false == String.IsNullOrEmpty(FolderOutput))
            {
                // In case inc output folder is not provided, inc output folder = default folder
                if (String.IsNullOrEmpty(IncOutputDirectory))
                {
                    IncOutputDirectory = FolderOutput;
                }
                else
                {
                    // Not required
                }
                // In case inc output folder is not provided, src output folder = default folder
                if (String.IsNullOrEmpty(SrcOutputDirectory))
                {
                    SrcOutputDirectory = FolderOutput;
                }
                else
                {
                    // Not required
                }
            } // End of if (false == String.IsNullOrEmpty(FolderOutput)).
            else
            {
                // Not required
            }

            IncOutputDirectory = concatPaths(IncOutputDirectory, @"include\");
            SrcOutputDirectory = concatPaths(SrcOutputDirectory, @"src\");

            // Assign default value for File Translation Path If have not value
            if (String.IsNullOrEmpty(TranslationFilePath))
            {
                TranslationFilePath = String.Concat(basicConfig.ExeDirectory, basicConfig.ModuleName, "_",
                                                    basicConfig.MicroFamilyName, Constant.TRANSLATION_FILE_EXTENSION);
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_052_018

        /// <summary>
        /// This method override options from command line
        /// </summary>
        /// <param name="options">Collection of command line options<range>null/valid Dictionary<string, string></range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Loop all options and override it by options from command line
        /// </algorithm>
        private void overrideOptions(Dictionary<string, string> options)
        {
            if (null != options)
            {
                PropertyInfo[] properties = this.GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    OptionAttribute attribute = (OptionAttribute)property.GetCustomAttribute(typeof(OptionAttribute));

                    if (null != attribute)
                    {
                        IEnumerable<string> opts = attribute.GetOption().Split('|').Select(e => String.Concat("-", e));
                        // Loop via all options command line that is defined in RuntimeConfiguration class
                        // Override value from options variable.
                        foreach (string opt in opts)
                        {
                            if (options.ContainsKey(opt))
                            {
                                string optValue = options[opt];
                                // With boolean type, should parse corresponding value.
                                if (typeof(bool) == property.PropertyType)
                                {
                                    bool flag = false;

                                    if (Boolean.TryParse(optValue, out flag))
                                    {
                                        property.SetValue(this, flag);
                                    }
                                    else
                                    {
                                        // Not required
                                    }
                                } // End of if (typeof(bool) == property.PropertyType).
                                else if (typeof(string) == property.PropertyType)
                                {
                                    property.SetValue(this, optValue);
                                }
                                else
                                {
                                    // Not required
                                }
                            } // End of if (options.ContainsKey(opt)).
                            else
                            {
                                // Not required
                            }
                        } // End of foreach (string opt in opts).
                    } // End of if (null != attribute).
                    else
                    {
                        // Not required
                    }
                } // End of foreach (PropertyInfo property in properties).
            } // End of if (null != options).
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_052_023

        /// <summary>
        /// This method override CDF file option from command line
        /// </summary>
        /// <param name="filePaths">File paths <range>null/valid List<string></range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF filePaths is not null AND count of filePaths is not 0
        ///     LET TranslationFilePath = String.Empty
        ///     LET CDFFilePaths = init new List<string>()
        ///     FOREACH filePath IN filePaths
        ///         IF filePath ends with '.trxml'
        ///             LET TranslationFilePath = filePath
        ///         ELSE
        ///             ADD filePath to CDFFilePaths
        /// ELSE
        ///     Do nothing
        /// </algorithm>
        private void overrideFiles(List<string> filePaths)
        {
            // Override only file and separate file "trxml" and cdf file in store
            if ((null != filePaths) && (Constant.INT_ZERO != filePaths.Count))
            {
                // Cleanup old values
                TranslationFilePath = String.Empty;
                CDFFilePaths = new List<string>();

                // Set new ones
                foreach (string filePath in filePaths)
                {
                    if (filePath.EndsWith(Constant.TRANSLATION_FILE_EXTENSION))
                    {
                        TranslationFilePath = filePath;
                    }
                    else
                    {
                        CDFFilePaths.Add(filePath);
                    }
                } // End of foreach (string filePath in filePaths)
            } // End of if ((null != filePaths) && (0 != filePaths.Count)).
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_052_022

        /// <summary>
        /// Get commandline options which include both sort/completed format based on specific condition
        /// </summary>
        /// <param name="condition">Specific condition to filter result <range>null/valid Predicate<PropertyInfo></range></param>
        /// <returns>
        ///     <para>List<string>
        ///         <desc>List of commandline options</desc>
        ///         <range>empty/valid list string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Scan all fields decorated by OptionAttribute
        ///     Add both sort/completed format of option to collection "result"
        /// End
        ///
        /// Return collection "result"
        /// </algorithm>
        private List<string> getCmdOptions(Predicate<PropertyInfo> condition)
        {
            List<string> result = new List<string>();
            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                OptionAttribute attribute = (OptionAttribute)property.GetCustomAttribute(typeof(OptionAttribute));
                // Get option command lines that is defined Runtime Configuration class
                // Add character "-" if missing in options. Ex. m|module => -m|-module
                if ((null != attribute) && (true == condition(property)))
                {
                    string options = attribute.GetOption();

                    if (false == String.IsNullOrEmpty(options))
                    {
                        string[] optionList = options.Split('|');

                        foreach (string option in optionList)
                        {
                            result.Add(String.Concat("-", option));
                        }
                    } // End of if (false == String.IsNullOrEmpty(options)).
                    else
                    {
                        // Not required
                    }
                } // End of if ((null != attribute) && (true == condition(property))).
                else
                {
                    // Not required
                }
            } // End of foreach (PropertyInfo property in properties).

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_052_021

        /// <summary>
        /// Concatenate paths
        /// </summary>
        /// <param name="paths">Paths <range>null/valid string[]</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The file path</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// concatenate paths to create a valid path with correct separator
        /// </algorithm>
        private string concatPaths(params string[] paths)
        {
            string result = String.Empty;
            string separator = Path.DirectorySeparatorChar.ToString();
            // Unify paths with correct separator. Ex: C:/path1/path2 => C:\\path1\\path2
            for (int i = Constant.INT_ZERO; paths.Length > i; i++)
            {
                string path = paths[i].Replace('/', '\\');

                if (Constant.INT_ZERO == i)
                {
                    result = path;
                }
                else
                {
                    if (result.EndsWith(separator))
                    {
                        result = result.Substring(Constant.INT_ZERO, result.Length - Constant.INT_ONE);
                    }
                    else
                    {
                        // Not required
                    }

                    if (path.StartsWith(separator))
                    {
                        path = path.Substring(Constant.INT_ONE, path.Length - Constant.INT_ONE);
                    }
                    else
                    {
                        // Not required
                    }

                    result = result + separator + path;
                } // End of if (0 == i).
            } // End of for (int i = 0; paths.Length > i; i++).

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_052_020
    }
}
