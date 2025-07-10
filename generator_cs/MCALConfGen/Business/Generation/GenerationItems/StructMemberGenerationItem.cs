/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = StructMemberGenerationItem.cs                                                                       */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains StructMemberGenerationItem that defines a field of struct will be output.              */
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
/*              : class StructMemberGenerationItem                                                                    */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            19/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/*            28/02/2019 :    GenTool Improvement Idea #89553                                                         */
/*            25/03/2019 :    Supporting multi-line QAC message                                                       */
/*                             Updated methods: Generate                                                              */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    Update Generate method                                                                  */
/*            10/07/2021 :    Update constructor and Generate method                                                  */
/*            16/07/2021 :    Update pseudo code for StructMemberGenerationItem and Generate                          */
/* 1.2.2:     31/08/2021 :    Update Generate method                                                                  */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static Renesas.Generator.MCALConfGen.Data.BasicConfiguration.BasicConfiguration;

namespace Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems
{
    /// <summary>
    /// "StructMemberGenerationItem" class that defines a field of struct will be output.
    /// </summary>
    public class StructMemberGenerationItem : BaseGenerationItem
    {
        /// <summary>
        /// Struct member generation item constructor
        /// </summary>
        /// <param name="preComment">Pre comment <range>null/valid string</range></param>
        /// <param name="postComment">Post comment <range>null/valid string</range></param>
        /// <param name="qacMessage">Qac message Dictionary<range>null/valid Dictionary</range></param>
        /// <param name="value">Value of define statement <range>null/valid string</range></param>
        /// <param name="hasInstanceSetting">Instance setting<range>true/false</range></param>
        /// <param name="expansion">Level of parent struct type<range>AppendType</range></param>
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
        public StructMemberGenerationItem(
            string preComment,
            string postComment,
            Dictionary<string, string> qacMessage = null,
            string value = "",
            bool hasInstanceSetting = false,
            AppendType expansion = AppendType.ORIGINAL)
            : base(preComment, postComment, qacMessage, String.Empty, String.Empty, value, 0,
                                                                                   hasInstanceSetting, false, expansion)
        {
        }
        // Implementation: GENERIC_TUD_CLS_009_001

        /// <summary>
        /// Generate output string of a struct member item
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
        /// LET stringBuilder = new StringBuilder()
        /// LET indentStr = (new StringBuilder()).Insert(Constant.INT_ZERO, "  ", Level).ToString()
        ///
        /// CALL AppendLine(stringBuilder, string.Empty, new string[] { PreComment }) to add pre comment
        /// IF Value is not null THEN
        ///     LET instSetting = (genSettings != null) ? genSettings.InstanceSetting : null
        ///     LET valueOfInstance = Value
        ///     IF HasNameInstanceSetting is true AND instSetting is not null AND instSetting.IsMultiInstance is true
        ///     THEN
        ///        LET valueOfInstance = instSetting.AppendSuffixToMacro(valueOfInstance, Expansion)
        ///     ELSE
        ///         Do nothing
        ///     CALL stringBuilder.AppendLine(
        ///                         indentStr + String.Format("{0}{1}", valueOfInstance, IsLast ? String.Empty : ","))
        ///     LET wrappedString = indentStr + WrapText(structMemberValue)
        ///     CALL stringBuilder.AppendLine(AddQACMessage(wrappedString, Value, Value, QACMessage))
        /// ELSE
        ///     Do nothing
        ///
        /// CALL AppendLine(stringBuilder, indentStr, new string[] { PostComment }) to append post comment
        ///
        /// RETURN stringBuilder.ToString().TrimEnd()
        /// </algorithm>
        internal override string Generate(GenerationSettings genSettings)
        {
            StringBuilder stringBuilder = new StringBuilder();
            // Update parent level struct in case there are many nested structs
            if (Level < PARENT_LEVEL)
            {
                Level = PARENT_LEVEL;
            }
            else
            {
                // Not required
            }
            string indentStr = (new StringBuilder()).Insert(Constant.INT_ZERO, "  ", Level).ToString();

            // Add precomment and startQac to struct member
            AppendLine(stringBuilder, indentStr, new string[] { PreComment });

            // Ignore generation of a struct member item if it's value is empty or null
            if (false == String.IsNullOrEmpty(Value))
            {
                InstanceSetting instSetting = (genSettings != null) ? genSettings.InstanceSetting : null;
                string valueOfInstance = Value;

                // Concatenate string of struct items, which is separated by comma, excepted last item
                if (HasNameInstanceSetting && instSetting != null && instSetting.IsMultiInstance)
                {
                    valueOfInstance = instSetting.AppendSuffixToMacro(valueOfInstance, Expansion);
                }// End of if (HasNameInstanceSetting && instSetting != null && instSetting.IsMultiInstance)
                else
                {
                    // Not required
                }
                // Add comma between structs except last struct.
                string structMemberValue = String.Format("{0}{1}", valueOfInstance, IsLast ? String.Empty : ",");

                string wrappedString = indentStr + WrapText(structMemberValue);
                stringBuilder.AppendLine(AddQACMessage(wrappedString, Value, Value, QACMessage));
            }// End of if (false == String.IsNullOrEmpty(Value))
            else
            {
                // Not required
            }

            // Add post comment and end start qac to struct member.
            AppendLine(stringBuilder, indentStr, new string[] { PostComment });

            return stringBuilder.ToString().TrimEnd();
        }
        // Implementation: GENERIC_TUD_CLS_009_002
    }
}
