/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = BswConfig.cs                                                                                        */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains BswConfig class to store basic software configuration information.                     */
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
/*              : class BswConfig                                                                                     */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.1.1:     02/07/2021 :    add property RootPath                                                                   */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

namespace Renesas.Generator.MCALConfGen.Data.CDFData.Items
{
    /// <summary>
    /// This class to store basic software configuration information.
    /// </summary>
    public class BswConfig
    {
        /// <summary>
        /// This field store Uuid of basic software configuration
        /// </summary>
        public string ImplementUuid { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_001

        /// <summary>
        /// This field store Sort Name of basic software configuration
        /// </summary>
        public string ImplementSortName { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_002

        /// <summary>
        /// This field store Programming language of basic software configuration
        /// </summary>
        public string ProgrammingLanguage { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_003

        /// <summary>
        /// This field store software Version of basic software configuration
        /// </summary>
        public string SwVersion { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_004

        /// <summary>
        /// This field store Vendor Id of basic software configuration
        /// </summary>
        public string VendorId { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_005

        /// <summary>
        /// This field store Autosar Release Version of basic software configuration
        /// </summary>
        public string ArReleaseVersion { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_006

        /// <summary>
        /// This field store Behavior reference of basic software configuration
        /// </summary>
        public string BehaviorRef { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_007

        /// <summary>
        /// This field store Vendor api infix of basic software configuration
        /// </summary>
        public string VendorApiInfix { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_008

        /// <summary>
        /// This field store Description uuid of basic software configuration
        /// </summary>
        public string DescriptionUuid { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_009

        /// <summary>
        /// This field store Description short name of basic software configuration
        /// </summary>
        public string DescriptionShortName { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_010

        /// <summary>
        /// This field store Module id of basic software configuration
        /// </summary>
        public string ModuleId { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_011

        /// <summary>
        /// This field store Describe information Vendor Specific Module DefRef
        /// </summary>
        public string VendorSpecificModuleDefRef { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_012

        /// <summary>
        /// This field store Bsw RootPath
        /// </summary>
        public string ImplementRootPath { get; set; }
        // Implementation: GENERIC_TUD_CLS_044_013
    }
}
