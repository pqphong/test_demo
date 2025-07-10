/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = BasicConfiguration.cs                                                                               */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains BasicConfiguration class which implements IBasicConfiguration interface to store basic */
/*          information of Gentool.                                                                                   */
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
/*              : class BasicConfiguration                                                                            */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            21/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    add new property MultiInstanceWithInfix, NumberOfInstances, VendorApiInfix              */
/*                            Update ToInstanceValue, AppendInstanceToFileName. Add new method AppendInstanceToMacro  */
/*            16/07/2021 :    Update summary for VendorApiInfix and pseudo code for ToInstanceValue                   */
/*                            and AppendInstanceToMacro, update ID GENERIC_TUD_CLS_041_024 for                        */
/*                            method MultiInstanceWithInfix                                                           */
/* 1.2.2:     30/08/2021 :    Update condition in ToInstanceValue, AppendInstanceToFileName, AppendInstanceToMacro    */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;

namespace Renesas.Generator.MCALConfGen.Data.BasicConfiguration
{
    /// <summary>
    /// This class implements IBasicConfiguration interface to store basic information of gentool module.
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    public class BasicConfiguration : IBasicConfiguration
    {
        /// <summary>
        /// "BasicConfiguration" instance used by "ObjectFactory" to get a new "BasicConfiguration" object
        /// </summary>
        public static readonly BasicConfiguration Instance = new BasicConfiguration();
        // Implementation: GENERIC_TUD_CLS_041_001

        /// <summary>
        /// Basic configuration constructor
        /// </summary>
        /// <returns>
        ///     None
        ///     <range> None </range>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Init component
        /// </algorithm>
        private BasicConfiguration()
        {
            ModuleId = 82;
            AutoSARVersion = String.Empty;
            DeviceNames = new List<string>();
            ExeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DeviceVariant = String.Empty;
        }
        // Implementation: GENERIC_TUD_CLS_041_020

        /// <summary>
        /// Property of module name
        /// </summary>
        public string ModuleName { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_002

        /// <summary>
        /// Property of micro family name
        /// </summary>
        public string MicroFamilyName { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_003

        /// <summary>
        /// Property of autoSAR version
        /// </summary>
        public string AutoSARVersion { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_004

        /// <summary>
        /// Property of device names
        /// </summary>
        public List<string> DeviceNames { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_005

        /// <summary>
        /// Property of VendorID
        /// </summary>
        public int VendorId { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_006

        /// <summary>
        /// Property of Executable directory
        /// </summary>
        public string ExeDirectory { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_007

        /// <summary>
        /// Property of Module id
        /// </summary>
        public int ModuleId { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_008

        /// <summary>
        /// OProperty of utput folder
        /// </summary>
        public string OutputFolder { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_009

        /// <summary>
        /// Property of Execution name
        /// </summary>
        public string ExecutionName { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_010

        /// <summary>
        /// Property of Execution version
        /// </summary>
        public string ExecutionVersion { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_011

        /// <summary>
        /// Property of Modules required
        /// </summary>
        public List<string> ModuleRequired { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_012

        /// <summary>
        /// Property of Project title
        /// </summary>
        public string ProjectTitle { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_013

        /// <summary>
        /// Property of Instance index
        /// </summary>
        public int InstanceIndex { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_014

        /// <summary>
        /// Property of Enable/Disable multiple instance
        /// </summary>
        public bool HasInstanceSetting { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_015
        /// <summary>
        /// Property of Output type: Files or Folders
        /// </summary>
        public InstanceOutputType InstanceOutType { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_016

        /// <summary>
        /// Property of Device Variant value at runtime
        /// </summary>
        public string DeviceVariant { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_017

        /// <summary>
        /// Property of number of multi instance value at runtime
        /// </summary>
        public int NumberOfInstances { get; set; } = Constant.INT_ZERO;
        // Implementation: GENERIC_TUD_CLS_041_021

        /// <summary>
        /// Property of VendorApiInfix
        /// </summary>
        public string VendorApiInfix { get; set; }
        // Implementation: GENERIC_TUD_CLS_041_022

        /// <summary>
        /// Get index instance if has any instance setting
        /// </summary>
        /// <param name="type">Type<range>valid enum AppenType</range></param>
        /// <returns>
        /// <para>
        ///     string:
        ///     <desc> return instance value type of string </desc>
        ///     <range> string.Empty/Valid string </range>
        /// </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET define result is empty
        /// IF multi instance config
        ///     IF instance value is used for macro
        ///         LET result = _{VendorId}_{VendorApiInfix in upper case}
        ///     ELSE
        ///         LET result = _{VendorId}_{VendorApiInfix in original as bswmdt tag}
        /// ELSE
        ///     Do nothing
        /// Return result
        /// </algorithm>
        public string ToInstanceValue(AppendType type = AppendType.FULL_UPPER)
        {
            string result = string.Empty;
            // Used for process format multi-instance
            if (true == HasInstanceSetting)
            {
                string apiInfix = string.Empty;
                if (AppendType.FULL_UPPER == type)
                {
                    apiInfix = VendorApiInfix.ToUpper();
                }
                else if (AppendType.ORIGINAL == type)
                {
                    apiInfix = VendorApiInfix;
                }
                else
                {
                    //Do nothing
                }
                result = "_" + VendorId.ToString() + "_" + apiInfix;
            }
            else
            {
                // No action required
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_041_019

        /// <summary>
        /// Append instance to file name
        /// </summary>
        /// <param name="name">Name of file name<range>empty/string</range></param>
        /// <returns>
        /// <para>
        ///     string:
        ///     <desc> return string after a appending instance to file name </desc>
        ///     <range> string.Empty/Valid string </range>
        /// </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET define result
        /// IF name is not null or empty
        ///     result = name
        ///     IF name contains ModuleName
        ///         IF multi instance config
        ///             ADD infix to File name
        /// Return result
        /// </algorithm>
        public string AppendInstanceToFileName(string name)
        {
            string result = String.Empty;

            // Choose format display output for multi-instance.
            // Example for FILES format:
            // Icu_59_Inst0_Cbk.h, Icu_59_Inst0_Cfg.h
            // Icu_59_Inst1_Cbk.h, Icu_59_Inst1_Cfg.h
            if (!string.IsNullOrEmpty(name))
            {
                result = name;
                if (name.ToUpper().Contains(ModuleName.ToUpper()))
                {
                    if (true == HasInstanceSetting)
                    {
                        string file = Path.GetFileNameWithoutExtension(name);
                        string[] separatedFileName = StringUtils.StringSeparateWith(file, ModuleName);
                        string exts = Path.GetExtension(name);
                        result = string.Format("{0}{1}{2}{3}", separatedFileName[0],
                                                    ToInstanceValue(type: AppendType.ORIGINAL), separatedFileName[1], exts);
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
            }
            else
            {
                //Do nothing
            }
            
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_041_018

        /// <summary>
        /// Append instance to macro name
        /// </summary>
        /// <param name="macro">Name of macro<range>Empty/Valid string </range></param>
        /// <returns>
        /// <para>
        ///     string:
        ///     <desc> return string after a appending instance to macro name </desc>
        ///     <range> Empty/Valid string </range>
        /// </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET define result
        /// IF macro is not null or empty
        ///     LET result = macro
        ///     IF ModuleName in macro
        ///         IF multi instance config is true
        ///             ADD infix to macro name with AppendType is type
        /// Return result
        /// </algorithm>
        public string AppendInstanceToMacro(string macro, AppendType type = AppendType.FULL_UPPER)
        {
            string result = string.Empty;

            if(!string.IsNullOrEmpty(macro))
            {
                result = macro;
                // Choose format display output for multi-instance.
                int index = macro.IndexOf(ModuleName, StringComparison.OrdinalIgnoreCase);
                if (Constant.InvalidIndex != index)
                {
                    if (true == HasInstanceSetting)
                    {
                        result = macro.Insert(index + ModuleName.Length, ToInstanceValue(type));
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
            }
            else
            {
                //D�nthing
            }
            
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_041_023
    }
}
