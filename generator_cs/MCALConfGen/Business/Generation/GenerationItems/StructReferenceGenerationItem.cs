/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = StructReferenceGenerationItem.cs                                                                    */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains StructReferenceGenerationItem class that defines a reference of struct will be output. */
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
/*              : class StructReferenceGenerationItem                                                                 */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    Update default value of hasInstanceSetting                                              */
/*            10/07/2021 :    Update method StructReferenceGenerationItem                                             */
/* 1.2.2:     09/08/2021 :    Change default falue of hasInstanceSetting to false                                     */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/

using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems
{
    /// <summary>
    /// "StructReferenceGenerationItem" class that defines a reference of struct will be output.
    /// </summary>
    public class StructReferenceGenerationItem : StructMemberGenerationItem
    {
        /// <summary>
        /// Struct reference generation item constructor
        /// </summary>
        /// <param name="preComment">Pre comment <range>null/valid string</range></param>
        /// <param name="postComment">Post comment <range>null/valid string</range></param>
        /// <param name="qacMessage">Qac message Dictionary<range>null/valid Dictionary</range></param>
        /// <param name="value">Value of define statement <range>null/valid string</range></param>
        /// <param name="hasInstanceSetting">Instance setting<range>true/false</range></param>
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
        public StructReferenceGenerationItem(
            string preComment,
            string postComment,
            Dictionary<string, string> qacMessage = null,
            string value = "",
            bool hasInstanceSetting = false)
            : base(preComment, postComment, qacMessage, value, hasInstanceSetting)
        {
        }
        // Implementation: GENERIC_TUD_CLS_007_001
    }
}
