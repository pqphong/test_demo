/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = CommentGenerationItem.cs                                                                            */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains CommentGenerationItem that defines a comment will be output to .h and.c files.         */
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
/*              : class CommentGenerationItem                                                                         */
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
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;

namespace Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems
{
    /// <summary>
    /// "CommentGenerationItem" class process output comments for header and source files.
    /// </summary>
    public class CommentGenerationItem : StringGenerationItem
    {
        /// <summary>
        /// Comment generation item constructor
        /// </summary>
        /// <param name="text">Text <range>null/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET text = text.Trim()
        /// IF text starts with '/*' THEN
        ///     text = CALL text.Substring(Constant.INT_TWO) to remove '/*'
        /// ELSE
        ///     Do nothing
        /// IF text ends with '*/' THEN
        ///     text = CALL text = text.Substring(Constant.INT_ZERO, text.Length - Constant.INT_TWO) to remove '*/'
        /// ELSE
        ///     Do nothing
        /// Value = text
        /// </algorithm>
        public CommentGenerationItem(string text): base(text)
        {
            text = text.Trim();
            // Concatenate with character start of a comment
            if (text.StartsWith("/*"))
            {
                text = text.Substring(Constant.INT_TWO);
            }
            else
            {
                // Not required
            }

            // Concatenate with character end of a comment
            if (text.EndsWith("*/"))
            {
                text = text.Substring(Constant.INT_ZERO, text.Length - Constant.INT_TWO);
            }
            else
            {
                // Not required
            }
            Value = text;
        }
        // Implementation: GENERIC_TUD_CLS_011_001

        /// <summary>
        /// Generate output string of a comment
        /// </summary>
        /// <param name="genSettings">generation setting
        ///     <range>null/valid GenerationSettings</range>
        /// </param>
        /// <returns>
        ///     <para>string
        ///         <desc>The output string</desc>
        ///         <range>N/A</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET temp = CALL base.Generate(genSettings)
        /// LET temp = CALL WrapText(temp,"/*","*/")
        ///
        /// RETURN temp
        /// </algorithm>
        internal override string Generate(GenerationSettings genSettings)
        {
            string temp = base.Generate(genSettings);
            temp = WrapText(temp,"/*","*/");
            return temp;
        }
        // Implementation: GENERIC_TUD_CLS_011_002
    }
}
