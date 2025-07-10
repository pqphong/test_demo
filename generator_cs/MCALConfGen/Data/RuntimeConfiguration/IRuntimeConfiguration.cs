/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = IRuntimeConfiguration.cs                                                                            */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2022 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains IRuntimeConfiguration interface to define properties to store information processed    */
/*          by command line.                                                                                          */
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
/* Classes      : This file contains the following interface IRuntimeConfiguration                                    */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     04/05/2021 :    add new property StubsFilter                                                            */
/* 1.3.2:     23/02/2022 :    add new property PrintToolVersion                                                       */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System.Collections.Generic;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

namespace Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration
{
    /// <summary>
    /// This "IRuntimeConfiguration" interface to define information processed by command line.
    /// </summary>
    public interface IRuntimeConfiguration
    {
        List<string> CDFFilePaths { get; set; }
        string ConfigFilePath { get; set; }
        bool DryRun { get; set; }
        string IncOutputDirectory { get; set; }
        string LogFilePath { get; set; }
        bool PrintHelp { get; set; }
        bool PrintToolVersion { get; set; }
        string SrcOutputDirectory { get; set; }
        string TranslationFilePath { get; set; }
        bool WriteLog { get; set; }
        string FolderOutput { get; set; }
        string VendorFilter { get; set; }
        List<string> StubsFilter { get; set; }

        string[] GetSingleCmdOptions();
        string[] GetAllCmdOptions();
        void OverrideCurrentConfigsBy(Dictionary<string, string> options, List<string> filePaths);
        void SetDefaultOptionsValue(IBasicConfiguration basicConfiguration);
    }
}
