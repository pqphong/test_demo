/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = IBasicConfiguration.cs                                                                              */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains IBasicConfiguration interface that defines properties to store basic information       */
/*          of Gentool.                                                                                               */
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
/* Classes      : This file contains the following interface IBasicConfiguration                                      */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.1.1:     02/07/2021 :    Add new data type AppendType                                                            */
/*                            Add property MultiInstanceWithInfix, NumberOfInstances, method AppendInstanceToMacro    */
/* 1.2.2:     01/09/2021 :    Remove MultiInstanceWithInfix                                                           */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System.Collections.Generic;

namespace Renesas.Generator.MCALConfGen.Data.BasicConfiguration
{
    /// <summary>
    /// Type of instance output
    /// </summary>
    public enum InstanceOutputType
    {
        // Bit mask
        DEFAULT = 0x0,
        FILES = 0x1,
        FOLDERS = 0x2
    }
    // Implementation: CMN_TUD_DTT_005

    /// <summary>
    /// This enum is used to declare type is of post build struct, define macro or file
    /// </summary>
    public enum AppendType
    {
        FULL_UPPER,
        ORIGINAL
    }
    // Implementation: CMN_TUD_DTT_006

    /// <summary>
    /// This interface defines properties to store basic information
    /// of Gentool.
    /// </summary>
    public interface IBasicConfiguration
    {
        string ModuleName { get; set; }
        string MicroFamilyName { get; set; }
        string AutoSARVersion { get; set; }
        List<string> DeviceNames { get; set; }
        int VendorId { get; set; }
        string ExeDirectory { get; set; }
        int ModuleId { get; set; }
        string OutputFolder { get; set; }
        string ExecutionName { get; set; }
        string ExecutionVersion { get; set; }
        List<string> ModuleRequired { get; set; }
        string ProjectTitle { get; set; }
        bool HasInstanceSetting { get; set; }
        int InstanceIndex { get; set; }
        InstanceOutputType InstanceOutType { get; set; }
        string ToInstanceValue(AppendType type = AppendType.FULL_UPPER);
        string AppendInstanceToFileName(string fileName);
        string AppendInstanceToMacro(string macro, AppendType type = AppendType.FULL_UPPER);
        string DeviceVariant { get; set; }
        int NumberOfInstances { get; set; }
        string VendorApiInfix { get; set; }
    }
}
