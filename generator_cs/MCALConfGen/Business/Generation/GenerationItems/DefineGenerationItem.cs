/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = DefineGenerationItem.cs                                                                             */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains DefineGenerationItem that defines a macro definition will be output to .h and.c files. */
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
/*              : class DefineGenerationItem                                                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            28/02/2019 :    GenTool Improvement Idea #89553                                                         */
/*            25/03/2019 :    Supporting multi-line QAC message                                                       */
/*                             Updated methods: Generate                                                              */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     28/04/2021 :    Update computeSpaces method to support generate macro has more than 80 characters       */
/*            02/07/2021 :    Change default value of hasNameInstanceSetting                                          */
/*            10/07/2021 :    update constructor, Generate and computeSpaces                                          */
/*            16/07/2021 :    Update pseudo code for methods DefineGenerationItem, Generate, computeSpaces            */
/* 1.2.2:     09/08/2021 :    Change default falue of hasNameInstanceSetting to false                                 */
/*            31/08/2021 :    Update Generate and computeSpaces method                                                */
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
using static Renesas.Generator.MCALConfGen.Data.BasicConfiguration.BasicConfiguration;

namespace Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems
{
    /// <summary>
    /// "DefineGenerationItem" class that defines a macro definition will be output to .h and.c files.
    /// </summary>
    public class DefineGenerationItem : BaseGenerationItem
    {
        /// <summary>
        /// Define generation item constructor
        /// </summary>
        /// <param name="preComment">Pre comment <range>null/valid string</range></param>
        /// <param name="postComment">Post comment <range>null/valid string</range></param>
        /// <param name="qacMessage">Qac message Dictionary<range>null/valid Dictionary</range></param>
        /// <param name="name">Name of define statement or struct <range>null/valid string</range></param>
        /// <param name="value">Value of define statement <range>null/valid string</range></param>
        /// <param name="level">Level of inner struct <range>0/valid integer</range></param>
        /// <param name="hasNameInstanceSetting">Instance setting<range>true/false</range></param>
        /// <param name="hasValueInstanceSetting">Instance setting<range>true/false</range></param>
        /// <param name="expansion">Level of parent struct type<range>0/1</range></param>
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
        public DefineGenerationItem(
            string preComment,
            string postComment,
            Dictionary<string, string> qacMessage = null,
            string name = "",
            string value = "",
            int level = 0,
            bool hasNameInstanceSetting = false,
            bool hasValueInstanceSetting = false,
            AppendType expansion = AppendType.FULL_UPPER)
            : base(
                  preComment,
                  postComment,
                  qacMessage,
                  name,
                  String.Empty,
                  value,
                  level,
                  hasNameInstanceSetting,
                  hasValueInstanceSetting,
                  expansion)
        {
        }
        // Implementation: GENERIC_TUD_CLS_012_001

        /// <summary>
        /// Generate output string of a define macro
        /// </summary>
        /// <param name="genSettings">generation setting
        ///     <range>null/valid GenerationSettings</range>
        /// </param>
        /// <returns>
        ///     <para>string
        ///         <desc>The output string of definition macros</desc>
        ///         <range>valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET stringBuilder = new StringBuilder()
        /// CALL AppendLine(stringBuilder, string.Empty, new string[] { PreComment }) to add pre comment
        /// LET instSetting = (genSettings != null) ? genSettings.InstanceSetting : null
        /// IF instSetting is not null AND instSetting.IsMultiInstance is true THEN
        ///     IF HasNameInstanceSetting is true THEN
        ///         LET nameOfInstance = instSetting.AppendSuffixToMacro(nameOfInstance, Expansion)
        ///     ELSE
        ///         Do nothing
        ///     IF HasValueInstanceSetting is true THEN
        ///         LET valueOfInstance = instSetting.AppendSuffixToMacro(valueOfInstance, Expansion)
        ///     ELSE
        ///         Do nothing
        /// ELSE
        ///     Do nothing
        /// CALL stringBuilder.AppendLine(String.Format(computeSpaces(nameOfInstance, valueOfInstance),QACMessage))
        /// CALL AppendLine(stringBuilder, string.Empty, new string[] { PostComment }) to append post comment
        /// </algorithm>
        internal override string Generate(GenerationSettings genSettings)
        {
            StringBuilder stringBuilder = new StringBuilder();

            // Add precomment
            AppendLine(stringBuilder, string.Empty, new string[] { PreComment });

            string nameOfInstance = Name;
            string valueOfInstance = Value;
            InstanceSetting instSetting = (genSettings != null) ? genSettings.InstanceSetting : null;
            
            // Concatenate string of a macro definition with format: #define MacroName {spaces} MacroValue
            if (instSetting != null && instSetting.IsMultiInstance)
            {
                // If apply multi-instance, add suffix to name of instance
                if (HasNameInstanceSetting)
                {
                    nameOfInstance = instSetting.AppendSuffixToMacro(nameOfInstance, Expansion);
                }
                else
                {
                    // Not required
                }
                // If apply multi-instance, add suffix to value of instance
                if (HasValueInstanceSetting)
                {
                    valueOfInstance = instSetting.AppendSuffixToMacro(valueOfInstance, Expansion);
                }
                else
                {
                    // Not required
                }
            }// End of if (instSetting != null && instSetting.IsMultiInstance)
            else
            {
                // Not required
            }
            stringBuilder.AppendLine(computeSpaces(nameOfInstance, valueOfInstance));

            // Add post comment
            AppendLine(stringBuilder, string.Empty, new string[] { PostComment });

            return stringBuilder.ToString().Trim();
        }
        // Implementation: GENERIC_TUD_CLS_012_002

        /// <summary>
        /// To compute space needed to generate define items
        /// Macro definition has format: #define name spaces value
        /// This method calculate spaces length to make length of macro definition string is MAX_LINE_LENGTH
        /// Mininum spaces length is 1
        /// If length of macro definition string is more than MAX_LINE_LENGTH
        ///     Break into multiple lines
        /// End
        /// </summary>
        /// <param name="name">The define name<range>null/valid string</range></param>
        /// <param name="value">The define value<range>null/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The output string</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF value is not null THEN
        ///     LET nameLengthIsOver = name.Length >= (DEFINE_INDENT - DEFINE_LENGTH)
        ///     LET valueLengthIsOver = value.Length >= (MAX_LINE_LENGTH - DEFINE_INDENT + MIN_SPACE_LENGTH)
        ///     LET valueLengthIsOverMax = value.Length >= MAX_LINE_LENGTH
        ///     IF nameLengthIsOver is true AND valueLengthIsOver is false THEN
        ///         spaces += @" \" + Environment.NewLine + new string(' ', DEFINE_INDENT)
        ///     ELSE IF nameLengthIsOver is false AND valueLengthIsOver is true THEN
        ///         spaces += new string(' ', DEFINE_INDENT - name.Length - DEFINE_LENGTH) + @"\"
        ///         + Environment.NewLine + subSpaces
        ///     ELSE IF nameLengthIsOver is true AND valueLengthIsOver is true THEN
        ///         spaces += @" \" + Environment.NewLine + subSpaces
        ///     ELSE
        ///         spaces += new string(' ', DEFINE_INDENT - name.Length - DEFINE_LENGTH)
        /// ELSE
        ///     Do nothing
        ///
        /// RETURN spaces
        /// </algorithm>
        private string computeSpaces(string name, string value)
        {
            string ret = string.Empty;
            string defineFormat = "#define {0}{1}{2}";

            name = name ?? string.Empty;
            string spaces = String.Empty;

            string nameSubSpaces = string.Empty;
            string wrappedString = string.Empty;
            if (!String.IsNullOrEmpty(value))
            {
                bool nameLengthIsOver = name.Length >= (DEFINE_INDENT - DEFINE_LENGTH);
                bool valueLengthIsOver = value.Length >= (MAX_LINE_LENGTH - DEFINE_INDENT + MIN_SPACE_LENGTH);
                bool valueLengthIsOverMax = value.Length >= MAX_LINE_LENGTH;
                string valueSubSpaces = valueLengthIsOverMax ? string.Empty : valueLengthIsOver ? 
                                                    new string(Constant.SpaceCharacter, MAX_LINE_LENGTH - value.Length):
                                                                     new string(Constant.SpaceCharacter, DEFINE_INDENT);              
                // Handler to compute spaces if length of macro definition is greater than 80 characters
                // In case length of macro name is over
                if (nameLengthIsOver && !valueLengthIsOver)
                {
                    spaces += Environment.NewLine + valueSubSpaces;
                    wrappedString = String.Format(defineFormat, name, spaces, value);
                }
                // Incase length of macro value is over
                else if (!nameLengthIsOver && valueLengthIsOver)
                {
                    spaces += new string(' ', DEFINE_INDENT - name.Length - DEFINE_LENGTH - Constant.INT_ONE) 
                                                + Environment.NewLine + valueSubSpaces;
                    wrappedString = String.Format(defineFormat, name, spaces, value);
                }
                // In case length of macro name and macro value is over, process a new line
                else if (nameLengthIsOver && valueLengthIsOver)
                {
                    spaces += Environment.NewLine + valueSubSpaces;
                    wrappedString = String.Format(defineFormat, name, spaces, value);
                }
                // Handler to compute spaces if length of macro definition is not over 80 characters
                else
                {
                    spaces += new string(' ', DEFINE_INDENT - name.Length - DEFINE_LENGTH);
                    wrappedString = String.Format(defineFormat, name, spaces, value);
                }                
            } // End of if (!String.IsNullOrEmpty(value))
            else
            {
                wrappedString = String.Format(defineFormat, name, spaces, value);
            }
            ret = AddQACMessage(wrappedString, name, name, QACMessage, @" \");
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_012_003
    }
}
