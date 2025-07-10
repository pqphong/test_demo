/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = BaseGenerationItem.cs                                                                               */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains BaseGenerationItem a base class for other generation item classes.                     */
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
/*              : class BaseGenerationItem                                                                            */
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
/*                             Updated methods: addCommentFormat, AppendLine, BaseGenerationItem constructor          */
/* 1.0.2:     13/02/2020 :    Fix WrapText method to generate not exceed 80 characters                                */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    add new property Expansion                                                              */
/*            10/07/2021 :    Update MAX_LINE_LENGTH. Remove StartQAC and EndQAC. Add QACMessage                      */
/*                            Update constructor, add new method ComputeSpacesQAC, CreateQACMessage                   */
/*            16/07/2021 :    Update pseudo code for BaseGenerationItem and correct typo for "QAC mesage"             */
/* 1.2.2:     31/08/2021 :    Update constructor, QACMessage, ComputeSpacesQAC.Add new TypeQAC, AddQACMessage         */
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
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems
{
    /// <summary>
    /// "BaseGenerationItem" a base class for other generation item classes.
    /// </summary>
    public class BaseGenerationItem
    {
        /// <summary>
        /// Maxinum line lengh when writting output files .h and .c
        /// </summary>
        protected static readonly int MAX_LINE_LENGTH = 120;
        // Implementation: GENERIC_TUD_CLS_010_009

        /// <summary>
        /// Define indent
        /// </summary>
        protected static readonly int DEFINE_INDENT = 80;
        // Implementation: GENERIC_TUD_CLS_010_010

        /// <summary>
        /// Pre comment
        /// </summary>
        protected string PreComment { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_010_001

        /// <summary>
        /// QAC message
        /// </summary>
        protected Dictionary<string, string> QACMessage;
        // Implementation: GENERIC_TUD_CLS_010_029

        /// <summary>
        /// Post comment
        /// </summary>
        protected string PostComment { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_010_004

        /// <summary>
        /// Name of define statement or struct
        /// </summary>
        protected string Name { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_010_005

        /// <summary>
        /// Type of a struct
        /// </summary>
        protected string Type { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_010_006

        /// <summary>
        /// Value of define statement
        /// </summary>
        protected string Value { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_010_007

        /// <summary>
        /// Level of inner struct
        /// </summary>
        protected int Level { get; set; } = 0;
        // Implementation: GENERIC_TUD_CLS_010_008

        /// <summary>
        /// Is last element in a struct
        /// </summary>
        protected bool IsLast = false;
        // Implementation: GENERIC_TUD_CLS_010_015

        /// <summary>
        /// Has name instance setting
        /// </summary>
        protected bool HasNameInstanceSetting = false;
        // Implementation: GENERIC_TUD_CLS_010_016

        /// <summary>
        /// Has value instance setting
        /// </summary>
        protected bool HasValueInstanceSetting = false;
        // Implementation: GENERIC_TUD_CLS_010_017

        /// <summary>
        /// Length of #define
        /// </summary>
        protected static readonly int DEFINE_LENGTH = 8;
        // Implementation: GENERIC_TUD_CLS_010_011

        /// <summary>
        /// Minimum space length
        /// </summary>
        protected static readonly int MIN_SPACE_LENGTH = 1;
        // Implementation: GENERIC_TUD_CLS_010_012

        /// <summary>
        /// Increase level of inner struct child element by one
        /// </summary>
        protected static readonly int CHILD_LEVEL = 1;
        // Implementation: GENERIC_TUD_CLS_010_013

        /// <summary>
        /// Level of a parent struct type
        /// </summary>
        protected static readonly int PARENT_LEVEL = 0;
        // Implementation: GENERIC_TUD_CLS_010_014

        /// <summary>
        /// Level of a parent struct type
        /// </summary>
        protected AppendType Expansion { get; set; } = AppendType.FULL_UPPER;
        // Implementation: GENERIC_TUD_CLS_010_026

        /// <summary>
        /// List QAC Message go with Type
        /// </summary>
        protected List<string> TypeQAC { get; set; } = new List<string>() { "0303" , "0315" , "0326" ,
                                                                                             "0306" , "0314" , "0751" };
        // Implementation: GENERIC_TUD_CLS_010_030

        /// <summary>
        /// Base generation item constructor
        /// </summary>
        /// <param name="preComment">Pre comment <range>null/valid string</range></param>
        /// <param name="postComment">Post comment <range>null/valid string</range></param>
        /// <param name="qacMessage">Qac message Dictionary<range>null/valid Dictionary</range></param>
        /// <param name="name">Name of define statement or struct <range>null/valid string</range></param>
        /// <param name="type">Type of a struct <range>null/valid string</range></param>
        /// <param name="value">Value of define statement <range>null/valid string</range></param>
        /// <param name="level">Level of inner struct <range>0/valid integer</range></param>
        /// <param name="hasNameInstanceSetting">Instance setting<range>true/false</range></param>
        /// <param name="hasValueInstanceSetting">Instance setting<range>true/false</range></param>
        /// <param name="expansion">Level of parent struct type<range>AppendType</range></param>
        /// <returns>
        ///     <para>
        ///      None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Init Base Generation Component
        /// </algorithm>
        public BaseGenerationItem
        (
            string preComment,
            string postComment,
            Dictionary<string,string> qacMessage = null,
            string name = "",
            string type = "",
            string value = "",
            int level = 0,
            bool hasNameInstanceSetting = false,
            bool hasValueInstanceSetting = false,
            AppendType expansion = AppendType.FULL_UPPER
        )
        {
            PreComment = addCommentFormat(preComment).First();
            PostComment = addCommentFormat(postComment).First();
            QACMessage = qacMessage;
            Name = name;
            Type = type;
            Value = value;
            Level = level;
            HasNameInstanceSetting = hasNameInstanceSetting;
            HasValueInstanceSetting = hasValueInstanceSetting;
            Expansion = expansion;
        }
        // Implementation: GENERIC_TUD_CLS_010_018

        /// <summary>
        /// Set level of inner struct
        /// </summary>
        /// <param name="level">Level of inner struct <range>None</range></param>
        /// <returns>
        ///     <para>
        ///      None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Set Level field.
        /// </algorithm>
        public void SetLevel(int level)
        {
            Level = level;
        }
        // Implementation: GENERIC_TUD_CLS_010_020

        /// <summary>
        /// Set if last element in a struct
        /// </summary>
        /// <param name="value">Is last element in a struct <range>true/false</range></param>
        /// <returns>
        ///     <para>
        ///      None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET IsLast = value
        /// </algorithm>
        public void SetLastItem(bool value)
        {
            IsLast = value;
        }
        // Implementation: GENERIC_TUD_CLS_010_019

        /// <summary>
        /// Wrap long text to meets MAX_LINE_LENGTH
        /// </summary>
        /// <param name="inputString">Input string <range>null/valid string</range></param>
        /// <param name="prefix">Prefix string <range>null/valid string</range></param>
        /// <param name="suffix">Suffix string <range>null/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>wrapped string</desc>
        ///         <range>N/A</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET outStr = String.Empty
        /// LET outlines = new List<string>()
        /// LET targetLength = MAX_LINE_LENGTH - suffix.Length - (suffix.Length == Constant.INT_ZERO ?
        /// Constant.INT_ZERO : Constant.INT_ONE)
        /// LET inputString = prefix + " " + inputString.Trim()
        /// LET words = split inputString into the array of words
        /// FOREACH wrap IN words
        ///     IF outStr.Length + wrap.Length is less than targetLength THEN
        ///         outStr += wrap + " "
        ///     ELSE
        ///         IF targetLength - outStr.Length is greater than Constant.INT_ZERO THEN
        ///             outStr += new string(' ', targetLength - outStr.Length) + " " + suffix
        ///         ELSE
        ///             outStr += " " + suffix
        ///         ADD outStr into outlines
        ///         outStr = Environment.NewLine + prefix + "   " + wrap + " "
        ///         targetLength = MAX_LINE_LENGTH - suffix.Length - (suffix.Length == Constant.INT_ZERO ?
        ///         Constant.INT_ZERO : Constant.INT_ONE) + Environment.NewLine.Length
        /// IF outlines.Count is greater than 0 THEN
        ///     outStr += new string(' ', targetLength - outStr.Length) + " "
        /// ELSE
        ///     Do nothing
        /// outStr = String.Join(" ", outlines) + outStr + suffix
        /// outStr = CALL outStr.Trim() to remove last space
        /// </algorithm>
        protected string WrapText(string inputString, string prefix = "", string suffix = "")
        {
            string outStr = String.Empty;
            List<string> outlines = new List<string>();
            int targetLength = MAX_LINE_LENGTH - suffix.Length - (suffix.Length == Constant.INT_ZERO ?
                                                                 Constant.INT_ZERO : Constant.INT_ONE);

            //Remove possible newline at end.
            inputString = prefix + " " + inputString.Trim();
            string[] words = Regex.Split(inputString, @"\s+").Where(x => !string.IsNullOrEmpty(x)).ToArray();
            foreach (string wrap in words)
            {
                // Concatenate words into a line with max line lengh is 80 characters
                if (outStr.Length + wrap.Length < targetLength)
                {
                    outStr += wrap + " ";
                }
                else
                {
                    // Create new line for concatenating words
                    // in the case total words lengh are more than 80 characters
                    if (targetLength - outStr.Length > Constant.INT_ZERO)
                    {
                        if (suffix.Length == Constant.INT_ZERO)
                        {
                            outStr += new string(' ', targetLength - outStr.Length);
                        }
                        else
                        {
                            outStr += new string(' ', targetLength - outStr.Length) + " " + suffix;
                        }
                    }
                    else
                    {
                        // Do not need to create new line
                        outStr += " " + suffix;
                    }

                    outlines.Add(outStr);
                    outStr = Environment.NewLine + prefix + "   " + wrap + " ";
                    targetLength = MAX_LINE_LENGTH - suffix.Length - (suffix.Length == Constant.INT_ZERO ?
                                                                            Constant.INT_ZERO : Constant.INT_ONE) +
                                                                            Environment.NewLine.Length;
                }
            }// End of foreach (string wrap in words)

            if (Constant.INT_ZERO < outlines.Count && (targetLength - outStr.Length > Constant.INT_ZERO))
            {
                outStr += new string(' ', targetLength - outStr.Length) + " ";
            }
            else
            {
                // Not required
            }

            outStr = String.Join("", outlines) + outStr + suffix;
            //remove last space
            outStr = outStr.Trim();

            return outStr;
        }
        // Implementation: GENERIC_TUD_CLS_010_022

        /// <summary>
        /// Generate output string of a generation item
        /// An abstract method to be override by subclasses, e.g. DefineGenerationItem, StructGenerationItem
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
        /// RETURN String.Empty
        /// </algorithm>
        internal virtual string Generate(GenerationSettings genSettings)
        {
            return String.Empty;
        }
        // Implementation: GENERIC_TUD_CLS_010_023

        /// <summary>
        /// Generate output strings of an array of generation items
        /// </summary>
        /// <param name="items">Generation items <range>None</range></param>
        /// <param name="genSettings">generation setting<range>null/valid GenerationSettings</range></param>
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
        /// FOREACH item IN items
        ///     CALL stringBuilder.AppendLine WITH item.Generate(genSettings)
        /// RETURN stringBuilder.ToString()
        /// </algorithm>
        internal static string Generate(BaseGenerationItem[] items, GenerationSettings genSettings)
        {
            StringBuilder stringBuilder = new StringBuilder();
            // Loop all generation items and concatenate generated strings by new line characters
            foreach (BaseGenerationItem item in items.Where(i => null != i))
            {
                stringBuilder.AppendLine(item.Generate(genSettings));
            }

            return stringBuilder.ToString();
        }
        // Implementation: GENERIC_TUD_CLS_010_024

        /// <summary>
        /// Update comment based on input string
        /// </summary>
        /// <param name="comment">Input string<range>null/valid string</range></param>
        /// <returns>
        ///     <para>string[]
        ///         <desc>The output string</desc>
        ///         <range>N/A</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET lstComment = new List<string>()
        /// LET comment = string.IsNullOrEmpty(comment) ? string.Empty : comment
        /// LET comments = split comment by newline character
        /// FOREACH s IN comments
        ///     CALL lstComment.Add(!string.IsNullOrEmpty(s) ? WrapText(s, "/*", "*/") : s)
        ///
        /// RETURN lstComment.ToArray()
        /// </algorithm>
        private string[] addCommentFormat(string comment)
        {
            List<string> lstComment = new List<string>();
            comment = string.IsNullOrEmpty(comment) ? string.Empty : comment;
            string[] comments = Regex.Split(comment, Environment.NewLine);
            foreach (string s in comments)
            {
                lstComment.Add(!string.IsNullOrEmpty(s) ? WrapText(s, "/*", "*/") : s);
            }
            return lstComment.ToArray();
        }
        // Implementation: GENERIC_TUD_CLS_010_025

        /// <summary>
        /// Update comment based on input string
        /// </summary>
        /// <param name="builder">Input string<range>null/valid StringBuilder</range></param>
        /// <param name="indent">The indent string<range>null/valid StringBuilder</range></param>
        /// <param name="comments">The array of comment<range>null/valid StringBuilder</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// FOREACH comment IN comments WHERE comment is not null
        ///     CALL builder.AppendLine(string.Concat(indent, comment))
        /// </algorithm>
        protected virtual void AppendLine(StringBuilder builder, string indent, string[] comments)
        {
            foreach (string comment in comments.Where(x => !string.IsNullOrEmpty(x)))
            {
                builder.AppendLine(string.Concat(indent, comment));
            }
        }
        // Implementation: GENERIC_TUD_CLS_010_021

        /// <summary>
        /// Compute space for QAC
        /// </summary>
        /// <param name="value">Input string<range>null/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     string
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Compute space to generate QAC message at character No.121
        /// </algorithm>
        protected string ComputeSpacesQAC(string value)
        {
            string spaces = string.Empty;
            int valueLendth = value.Length;

            bool isOver = (valueLendth >= (int)120 )? true : false;
            if (!isOver)
            {
                spaces = new string(Constant.SpaceCharacter, MAX_LINE_LENGTH - valueLendth);
            }
            else
            {
                spaces = new string(Constant.SpaceCharacter, Constant.INT_ONE);
            }
            
            return spaces;
        }
        // Implementation: GENERIC_TUD_CLS_010_027

        /// <summary>
        /// Update comment based on input string
        /// </summary>
        /// <param name = "qacData" > Input qac data dictionary<range>null/valid dictionary</range></param>
        /// <returns>
        ///     <para>
        ///     string
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate QAC message following format
        /// </algorithm>
        protected string CreateQACMessage(Dictionary<string, string> qacData)
        {
            string ret = string.Empty;            
            if ((null != qacData) && (0 < qacData.Count))
            {
                string qacFormat = "/* PRQA S {0} # {1} */";
                string qacCode = string.Join(Constant.ListSeparator, qacData.Keys.ToArray());
                string qacJust = string.Join(Constant.ListSeparator, qacData.Values.ToArray());

                ret = string.Format(qacFormat, qacCode, qacJust);
            }
            else
            {
                //Do nothing
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_010_028

        /// <summary>
        /// Generate item format in multi line and Add corresponding QAC message
        /// </summary>
        /// <param name = "wrappedText" > Input text<range>null/valid string</range></param>
        /// <param name = "type" > type of item<range>null/valid string</range></param>
        /// <param name = "name" > name of item<range>null/valid string</range></param>
        /// <param name = "qacData" > Input qac data dictionary<range>null/valid dictionary</range></param>
        /// <param name = "delimiter" > delimiter for line<range>null/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     Generation string to write to file
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate item format in multi line and Add corresponding QAC message
        /// 
        /// IF qacData and input text are not null
        ///     Find position of Type and Name of item
        ///     IF type and name is in invalid position
        ///         Add QAC to end of last line
        ///     ELSE
        ///         Add QAC to each corresponding Line
        ///         FOR each line in dictionary QAC
        ///             Add QAC message to end of line
        ///         Merge these Line to string
        /// ELSE
        ///     return text in multi line
        /// RETURN text in multi line with QAC
        /// </algorithm>
        protected string AddQACMessage(string wrappedText, string type, string name, 
                                                              Dictionary<string, string> qacData, string delimiter = "")
        {              
            string ret = wrappedText;
            List<string> listLine = wrappedText.Split(new string[] { Environment.NewLine },
                                                                            StringSplitOptions.None).ToList();
            if (null != qacData && !string.IsNullOrEmpty(wrappedText))
            {

                int typeLine = Constant.InvalidIndex;
                int nameLine = Constant.InvalidIndex;
                //Find position of type and name
                foreach (string line in listLine)
                {
                    if (!string.IsNullOrEmpty(type) && line.Contains(type))
                    {
                        typeLine = listLine.IndexOf(line);
                    }
                    else
                    {
                        //Do nothing
                    }
                    if (!string.IsNullOrEmpty(name) && line.Contains(name))
                    {
                        nameLine = listLine.IndexOf(line);
                    }
                    else
                    {
                        //Do nothing
                    }
                }

                //If not found name and type, write QAC to end of string 
                if (Constant.InvalidIndex == typeLine && Constant.InvalidIndex == nameLine)
                {
                    string lastLine = listLine.LastOrDefault();
                    ret = string.Join(delimiter + Environment.NewLine, listLine) + ComputeSpacesQAC(lastLine) +
                                                                                              CreateQACMessage(qacData);
                }
                else
                {
                    Dictionary<int, Dictionary<string, string>> lineDict =
                                                                    new Dictionary<int, Dictionary<string, string>>();
                    foreach (string qac in qacData.Keys)
                    {
                        if (TypeQAC.Contains(qac))
                        {
                            if (lineDict.ContainsKey(typeLine))
                            {
                                lineDict[typeLine].Add(qac, qacData[qac]);
                            }
                            else
                            {
                                lineDict.Add(typeLine, new Dictionary<string, string>() { { qac, qacData[qac] } });
                            }
                        }
                        else
                        {
                            if (lineDict.ContainsKey(nameLine))
                            {
                                lineDict[nameLine].Add(qac, qacData[qac]);
                            }
                            else
                            {
                                lineDict.Add(nameLine, new Dictionary<string, string>() { { qac, qacData[qac] } });
                            }
                        }
                    }
                    //Add QAC to line
                    for (int i = 0; i < listLine.Count; i++)
                    {
                        if (lineDict.ContainsKey(i))
                        {
                            string qacMessage = ComputeSpacesQAC(listLine[i]) + CreateQACMessage(lineDict[i]);

                            listLine[i] = listLine[i] + qacMessage;
                        }
                        else
                        {
                            //Do nothing 
                        }
                    }
                    ret = string.Join(delimiter + Environment.NewLine, listLine);
                }
            }
            else
            {
                ret = string.Join(delimiter + Environment.NewLine, listLine);
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_010_032
    }
}
