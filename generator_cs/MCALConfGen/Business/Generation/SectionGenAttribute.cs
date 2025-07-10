/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = SectionGenAttribute.cs                                                                              */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains ItemGenerationAttribute class that groups methods of generation classes into sections. */
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
/*              : class ItemGenerationAttribute                                                                       */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            19/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     10/07/2021 :    Update SectionName, sectionString                                                       */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;

namespace Renesas.Generator.MCALConfGen.Business.Generation
{
    /// <summary>
    /// "ItemGenerationAttribute" class that groups methods of generation classes into sections.
    /// Object is generate macro in proper order in a section.
    /// </summary>
    public class ItemGenerationAttribute : Attribute
    {
        /// <summary>
        /// This enum is used to declare where output is generated.
        /// </summary>
        public enum SectionName
        {
            COPY_RIGHT,
            REVISION_HISTORY,
            GENTOOL_VERSION,
            INPUT_FILES,
            START_MACRO, //Header only
            INSTANCE_INDEX,
            INCLUDE,
            CODING_RULE,
            VERSION_INFO,
            COMMON_PUBLISHED_INFO,
            GLOBAL_SYMBOLS, // Header file only
            VERSION_CHECK, // Source file only
            GLOBAL_DATA_TYPE, //Header file only
            GLOBAL_DATA, //Source file only
            FUNCTION_PROTOTYPE, //Header file only
            FUNTION_DEFINE, // Source only
            END_MACRO, //Header only
            END_OF_FILE,
        };
        // Implementation: CMN_TUD_DTT_001

        /// <summary>
        /// "Section" texts
        /// </summary>
        private static readonly string[] sectionString = new string[]
        {
            String.Empty, //COPY_RIGHT
            "Revision Control History", // REVISION HISTORY
            "Generation Tool Version", // GENTOOL_VERSION
            "Input File", // INPUT_FILES
            String.Empty, //START_MACRO
            "Instance Index", //INSTANCE_INDEX
            "Include Section", //INCLUDE
            "Coding Rule Violations", //CODING_RULE
            "Version Information", //VERSION_INFO
            "Common Published Information", //COMMON_PUBLISHED_INFO
            "Global Symbols", //GLOBAL_SYMBOLS
            "Version Check", //VERSION_CHECK
            "Global Data Types", //GLOBAL_DATA_TYPE
            "Global Data", //GLOBAL_DATA
            "Function Prototypes", //FUNCTION_PROTOTYPE
            "Function Definitions", //FUNTION_DEFINE
            String.Empty, //END_MACRO
            "End of File", //END_OF_FILE
        };
        // Implementation: GENERIC_TUD_CLS_017_003

        /// <summary>
        /// Property of "Section" enum
        /// </summary>
        public SectionName Section { get; set; }
        // Implementation: GENERIC_TUD_CLS_017_001

        /// <summary>
        /// Property of "Section" order
        /// </summary>
        public float SectionOrder { get; set; } = 0;
        // Implementation: GENERIC_TUD_CLS_017_002

        /// <summary>
        /// Get section name
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>The section name</desc>
        ///         <range>valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get text of section from SectionString array
        /// </algorithm>
        public string GetSectionName()
        {
            return sectionString[(int)Section];
        }
        // Implementation: GENERIC_TUD_CLS_017_004

        /// <summary>
        /// Get section name
        /// </summary>
        /// <param name="Section">section<range>null/valid SectionName</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The section name</desc>
        ///         <range>valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get text of section from SectionString array
        /// </algorithm>
        public static string GetSectionName(SectionName Section)
        {
            return sectionString[(int)Section];
        }
        // Implementation: GENERIC_TUD_CLS_017_005
    }
}
