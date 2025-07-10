/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = BreakLineGenerationItem.cs                                                                          */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains BreakLineGenerationItem that defines one or more new lines will be output              */
/*          to .h and.c files.                                                                                        */
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
/*              : class BreakLineGenerationItem                                                                       */
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
/* 1.2.1:     10/07/2021 :    Update constructor                                                                      */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems
{
    /// <summary>
    /// "BreakLineGenerationItem" class that defines one or more new lines will be output
    /// </summary>
    public class BreakLineGenerationItem : BaseGenerationItem
    {
        /// <summary>
        /// Number of break lines
        /// </summary>
        private int numberOfLines = 1;
        // Implementation: GENERIC_TUD_CLS_008_001

        /// <summary>
        /// Break line generation item constructor
        /// </summary>
        /// <param name="numberOfLines">Number of break lines. Default value = 1 <range>None</range></param>
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
        public BreakLineGenerationItem(int numberOfLines = 1)
            : base(String.Empty, String.Empty, null, String.Empty, String.Empty, String.Empty,
                  0, false, false)
        {
            this.numberOfLines = numberOfLines;
        }
        // Implementation: GENERIC_TUD_CLS_008_002

        /// <summary>
        /// Generate output string of break lines
        /// </summary>
        /// <param name="genSettings">generation setting
        ///     <range>null/valid "GenerationSettings"</range>
        /// </param>
        /// <returns>
        ///     <para>string
        ///         <desc>The output string</desc>
        ///         <range>empty/list of break lines</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET builder = new StringBuilder()
        /// IF numberOfLines is greater than 0 THEN
        ///     CALL builder.Insert(Constant.INT_ZERO, Environment.NewLine, numberOfLines - Constant.INT_ONE)
        /// ELSE
        ///     Do nothing
        ///
        /// RETURN builder.ToString()
        /// </algorithm>
        internal override string Generate(GenerationSettings genSettings)
        {
            StringBuilder builder = new StringBuilder();
            // Insert multiple new lines to output
            if (numberOfLines > Constant.INT_ZERO)
            {
                builder.Insert(Constant.INT_ZERO, Environment.NewLine, numberOfLines - Constant.INT_ONE);
            }
            else
            {
                // Not required
            }
            return builder.ToString();
        }
        // Implementation: GENERIC_TUD_CLS_008_003
    }
}
