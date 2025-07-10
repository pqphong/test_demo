/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = ObjectFactoryAttribute.cs                                                                           */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains ObjectFactoryAttribute class. If a class wants to be resolved by ObjectFactory for     */
/*          its implemented inferface, it should be decorated by ObjectFactoryAttribute.                              */
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
/*              : class ObjectFactoryAttribute                                                                        */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.0.2:     10/02/2020 :    Remove supported GTM feature as #242611                                                 */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     05/05/2021 :    Add new property Variant                                                                */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;

namespace Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory
{
    /// <summary>
    /// This class contains attribute to be resolved by ObjectFactory for
    /// its implemented inferface, it should be decorated by ObjectFactoryAttribute.
    /// </summary>
    public class ObjectFactoryAttribute : Attribute
    {
        /// <summary>
        /// Property of Auto sar version
        /// </summary>
        public string AutoSarVersion { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_037_001

        /// <summary>
        /// Property of Device
        /// </summary>
        public string Device { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_037_002

        /// <summary>
        /// Property of Version
        /// </summary>
        public string Version { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_037_003

        /// <summary>
        /// Property of Module Name
        /// </summary>
        public string ModuleNames { get; set; } = "*";
        // Implementation: GENERIC_TUD_CLS_037_004

        /// <summary>
        /// Property of Module Variant
        /// </summary>
        public string Variant { get; set; } = "*";
        // Implementation: GENERIC_TUD_CLS_037_006

        /// <summary>
        /// Object factory attribute constructor
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
        public ObjectFactoryAttribute()
        {
        }
        // Implementation: GENERIC_TUD_CLS_037_005
    }
}
