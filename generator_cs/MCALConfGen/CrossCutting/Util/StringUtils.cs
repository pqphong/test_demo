/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = StringUtils.cs                                                                                      */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains the util functions for processing string                                               */
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
/*              : class StringUtils                                                                                   */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            21/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/*            01/03/2019 :    Added method IsNameSyntaxAsC #89553 #note24                                             */
/*            05/03/2019 :    Modified method IsNameSyntaxAsC to add keyword C, fixed return value                    */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.1.1:     20/08/2020 :    As per ARDAACJ-59, added method DoubleToString                                          */
/* 1.2.0:     24/08/2020 :    No change code, only increase version.                                                  */
/* 1.2.1:     19/05/2021 :    Add new method StringToDouble                                                           */
/*            02/07/2021 :    Add new method StringSeparateWith                                                       */
/*            16/07/2021 :    Update pseudo code for StringSeparateWith and GetQacSignChar                            */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Renesas.Generator.MCALConfGen.CrossCutting.Util
{
    /// <summary>
    /// This class contains the util functions for processing string.
    /// </summary>
    public class StringUtils
    {
        /// <summary>
        /// Find substring in text that match a regular expression
        /// </summary>
        /// <param name="text">Text <range>string</range></param>
        /// <param name="expression">Expression <range>string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The string is found in the test</desc>
        ///         <range>empty/string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// IF text or expr is NULL or empty THEN
        ///     RETURN emtpy
        /// ELSE
        ///     IF found 1 or more than 1 of matched substring THEN
        ///         RETURN the last found item
        ///     ELSE
        ///         RETURN empty
        /// </algorithm>
        public static string FindString(string text, string expression)
        {
            string ret = String.Empty;

            if ((false == String.IsNullOrEmpty(text)) && (false == String.IsNullOrEmpty(expression)))
            {
                MatchCollection matchCollection = Regex.Matches(text, expression);

                foreach (Match match in matchCollection)
                {
                    ret = match.ToString();
                }
            }
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_002

        /// <summary>
        /// Get last element when spliting path into substrings by delimeter
        /// </summary>
        /// <param name="path">Path <range>string</range></param>
        /// <param name="delimeter">Delimeter <range>char</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The last string is found in the path</desc>
        ///         <range>empty/string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// IF path is not null THEN
        ///     LET arr = Split path into substrings by delimeter.
        ///     IF Length off arr > 1 THEN
        ///         RETURN last substring.
        ///     ELSE
        ///         RETURN empty
        /// RETURN empty
        /// </algorithm>
        public static string GetElementLastInArray(string path, char delimeter = '/')
        {
            string ret = String.Empty;

            if (null != path)
            {
                string[] arr = path.Split(delimeter);
                ret = arr.Last();
            } // End of if (null != path).
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_003

        /// <summary>
        /// Convert hex string to integer
        /// </summary>
        /// <param name="inputString">Input string <range>string</range></param>
        /// <returns>
        ///     <para>int
        ///         <desc>The value with type is Int</desc>
        ///         <range>0..Int32.Max</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// IF inputString is not null THEN
        ///     LET inputString = Upper case inputString
        ///     LET inputString = Remove all "0x", "0X", "U" and "L" characters from inputString
        ///     LET Using C# util function to convert inputString to integer value
        /// RETURN value
        /// </algorithm>
        public static int ParseHexToInt(string inputString)
        {
            int result = 0;

            if (null != inputString)
            {
                inputString = inputString.ToUpper();
                inputString = Regex.Replace(inputString, "0X|U|L", String.Empty);

                if (true == int.TryParse(inputString, System.Globalization.NumberStyles.HexNumber, null, out result))
                {
                    // Parse successful
                }
                else
                {

                }
            } // End of if (null != str).
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_040_010

        /// <summary>
        /// Convert hex string to unsigned integer
        /// </summary>
        /// <param name="inputString">Input string <range>string</range></param>
        /// <returns>
        ///     <para>uint
        ///         <desc>The value with type is UInt</desc>
        ///         <range>0..UInt32.Max</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// IF inputString is not null THEN
        ///     LET inputString = Upper case inputString
        ///     LET inputString = Remove all "0x", "0X", "U" and "L" characters from inputString
        ///     LET Using C# util function to convert inputString to unsigned integer value
        /// RETURN value
        /// </algorithm>
        public static uint ParseHexToUInt(string inputString)
        {
            uint result = 0;

            if (null != inputString)
            {
                inputString = inputString.ToUpper();
                inputString = Regex.Replace(inputString, "0X|U|L", String.Empty);

                if (true == uint.TryParse(inputString, System.Globalization.NumberStyles.HexNumber, null, out result))
                {
                    // Parse successful
                }
                else
                {

                }
            } // End of if (null != str).
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_040_011

        /// <summary>
        /// Replace placeholders in a string
        /// </summary>
        /// <param name="inputString">Input string <range>string</range></param>
        /// <param name="dictionary">Mapping placeholders and their values <range>Valid Dictionary</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The string has been replace</desc>
        ///         <range>empty/string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// FOR each placeholder in dictionary
        ///     LET Replace placeholder in inputString by its value defined in dictionary
        /// END
        /// </algorithm>
        public static string GetStringFromTemplate(string inputString, Dictionary<string, string> dictionary)
        {
            string result = String.Empty;
            result = Regex.Replace(inputString, @"\$\$[\w\:\d\ ]*\$\$",
                                                                    x => replaceStringByTemplate(x.Value, dictionary));
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_040_005

        /// <summary>
        /// Check if string is in hexa format
        /// </summary>
        /// <param name="value">Value <range>string</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The status of string is in hexa format or not</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// LET Using regular expression to check if string is in hexa format
        /// </algorithm>
        public static bool IsHex(string value)
        {
            return Regex.IsMatch(value, @"0x[0-9a-fA-F]+UL");
        }
        // Implementation: GENERIC_TUD_CLS_040_006

        /// <summary>
        /// Get relative path from current directory
        /// </summary>
        /// <param name="toPath">To path <range>string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The relative path</desc>
        ///         <range>empty/string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// LET fromPath = CALL GetCurrentDirectory
        /// LET fromUri = initialize new Uri WITH CALL appendDirectorySeparatorChar WITH fromPath
        /// LET toPath = CALL GetFullPath WITH toPath
        /// LET toUri = initialize new Uri WITH CALL appendDirectorySeparatorChar WITH toPath
        /// LET ret = ""
        /// IF fromUri.Scheme != toUri.Scheme THEN
        ///     LET ret = toPath
        /// ELSE
        ///     LET relativeUri = fromUri.MakeRelativeUri WITH toUri
        ///     LET relativePath = CALL UnescapeDataString WITH relativeUri
        ///     IF relativePath is not null THEN
        ///         LET relativePath = '.' + DirectorySeparatorChar
        ///     IF toUri.Scheme == Uri.UriSchemeFile THEN
        ///         LET relativePath = REPLACE AltDirectorySeparatorChar by DirectorySeparatorChar in relativePath
        ///     LET ret = relativePath
        /// RETURN ret
        /// </algorithm>
        public static string GetRelativePath(string toPath)
        {
            string fromPath = IOWrapper.GetCurrentDirectory();
            Uri fromUri = new Uri(appendDirectorySeparatorChar(fromPath));
            Uri toUri = null;
            string ret = String.Empty;

            toPath = IOWrapper.GetFullPath(toPath);

            toUri = new Uri(appendDirectorySeparatorChar(toPath));
            if (fromUri.Scheme != toUri.Scheme)
            {
                ret = toPath;
            }
            else
            {
                // Get relative path and replace all "/" by "\"
                Uri relativeUri = fromUri.MakeRelativeUri(toUri);
                string relativePath = Uri.UnescapeDataString(relativeUri.ToString());

                if (String.IsNullOrEmpty(relativePath))
                {
                    relativePath = String.Concat(".", Path.DirectorySeparatorChar);
                }
                else
                {
                    // Not required
                }

                if (String.Equals(toUri.Scheme, Uri.UriSchemeFile, StringComparison.OrdinalIgnoreCase))
                {
                    relativePath = relativePath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
                }
                else
                {
                    // Not required
                }

                ret = relativePath;
            } // End of if (fromUri.Scheme != toUri.Scheme).

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_004

        /// <summary>
        /// Check invalid name
        /// </summary>
        /// <param name="name">Name <range>string</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The status of name (invalid or not)</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// LET result = false
        /// IF name is null or empty or name starts with "-" or name contains "*", "?" or "|" THEN
        ///     LET result = true
        /// RETURN result
        /// </algorithm>
        public static bool IsInvalidName(string name)
        {
            bool result = false;
            // Invalid name when
            //   - name is null or empty
            //   - name starts with "-"
            //   - name contains "*", "?" or "|"
            if (((false == String.IsNullOrEmpty(name)) && name.StartsWith("-")) ||
                Regex.IsMatch(name, "[\\*\\?\\|]") ||
                (Regex.IsMatch(name, "[\"]") &&
                  !Regex.IsMatch(name, "\".+\"")) ||
                (Regex.IsMatch(name.Replace("\"", "").Trim(), "[:]") &&
                  name.Replace("\"", "").Trim().LastIndexOf(":") != Constant.INT_ONE))
            {
                result = true;
            }
            else
            {
                // Not required
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_040_007

        /// <summary>
        /// Replace placeholder in a string
        /// </summary>
        /// <param name="inputString">Input string to replace<range>string</range></param>
        /// <param name="dictionary">Template dictionary<range>Dictionary</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc> The string has been aligned</desc>
        ///         <range>empty/string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// LET ret = ""
        /// LET temp = REPLACE "$" by "" in inputString and split by ":"
        /// LET item = Get first element in array temp
        /// LET spaces = Get second element in array temp
        /// LET alignment = GET third element in array temp
        /// LET suffix = GET four element in array temp
        /// LET spaces = spaces - length of suffix
        /// IF alignment is "C" THEN
        ///     LET haftSpaces = (spaces - text.Length) / 2
        ///     LET ret = " "*haftSpaces + text + " "*((spaces - text.Length) - haftSpaces)
        /// ELSE IF alignment is "L" THEN
        ///     LET format = String.Format("{{0,-{0}}}", spaces)
        ///     LET ret = String.Format(format, text)
        /// ELSE
        ///     LET string format = String.Format("{{0,{0}}}", spaces)
        ///     LET ret = String.Format(format, text)
        /// RETURN ret
        /// </algorithm>
        private static string replaceStringByTemplate(string inputString, Dictionary<string, string> dictionary)
        {
            // inputString has format $${ placeholder}:{ fix_length_after_placeholder}:{ alignment}:{ suffix}$$
            // Return a string by following steps
            //     - Result = Replace placeholder by its value defined in dictionary
            //     - Result = Result + suffix
            //     - Add more spaces to Result so that: number of space + suffix length = fix_length_after_placeholder
            //     - Align Result to left, right or center based on alignment value (L, R, C)
            string ret = String.Empty;
            string[] temp = inputString.Replace("$", String.Empty).Split(':').ToArray();
            string item = temp[Constant.INT_ZERO];
            int spaces = ((Constant.INT_ONE < temp.Length) && (false == String.IsNullOrEmpty(temp[Constant.INT_ONE])))
                ? int.Parse(temp[Constant.INT_ONE]) : Constant.INT_ZERO;
            string alignment = ((Constant.INT_TWO < temp.Length) &&
                            (false == String.IsNullOrEmpty(temp[Constant.INT_TWO]))) ? temp[Constant.INT_TWO] : "L";
            string suffix = ((Constant.INT_THREE < temp.Length) &&
                (false == String.IsNullOrEmpty(temp[Constant.INT_THREE]))) ? temp[Constant.INT_THREE] : String.Empty;
            string text = String.Empty;

            spaces -= suffix.Length;
            text = dictionary[item] + suffix;
            // alignment in center
            if ("C" == alignment)
            {
                // space before value
                int haftSpaces = (spaces - text.Length) / Constant.INT_TWO;

                ret = (new String(' ', haftSpaces)) + text + (new String(' ', (spaces - text.Length) - haftSpaces));
            }
            // left alignment
            else if ("L" == alignment)
            {
                string format = String.Format("{{0,-{0}}}", spaces);

                ret = String.Format(format, text);
            }
            // right alignment and default
            else
            {
                string format = String.Format("{{0,{0}}}", spaces);

                ret = String.Format(format, text);
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_014

        /// <summary>
        /// Append directory separator "\" to a path
        /// </summary>
        /// <param name="path">Path <range>string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc> The string has been added separator '\'</desc>
        ///         <range>empty/string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     Path
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// IF path doesn't have extension at the end AND
        ///     path doesn't have directory separator "\" at the end THEN
        ///     LET Append directory separator "\" to a path
        /// </algorithm>
        private static string appendDirectorySeparatorChar(string path)
        {
            string ret = path;
            // Append a slash only if the path is a directory and does not have a slash.
            if ((false == Path.HasExtension(path)) &&
                (false == path.EndsWith(Path.DirectorySeparatorChar.ToString())))
            {
                ret = path + Path.DirectorySeparatorChar;
            }
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_012

        /// <summary>
        /// Parse short name in CDF to 2 parts: name and surfix number
        /// </summary>
        /// <param name="shrName">short name in CDF<range>string</range></param>
        /// <param name="name">name of parameter<range>string</range></param>
        /// <param name="number">surfix number<range>string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// LET match = match shrName WITH regex @"(\d+)$"
        /// IF match is Success
        ///     LET number = first element of match.Groups
        ///     LET name = replace number by "" in shrName
        /// ELSE
        ///     LET number = 0
        ///     LET name = shrName
        /// </algorithm>
        static private void parseShortName(string shrName, out string name, out int number)
        {
            var match = Regex.Match(shrName, @"(\d+)$");
            // Ex. Fls1 -> name = Fls, number = 1
            if (match.Success)
            {
                int.TryParse(match.Groups[Constant.INT_ONE].Value, out number);
                name = shrName.Replace(match.Groups[Constant.INT_ZERO].Value, "");
            }
            else
            {
                number = 0;
                name = shrName;
            }
        }
        // Implementation: GENERIC_TUD_CLS_040_013

        /// <summary>
        /// Compare 2 short name for sorting
        /// </summary>
        /// <param name="shrName1">short name for comparation<range>string</range></param>
        /// <param name="shrName2">short name for comparation<range>string</range></param>
        /// <returns>
        ///     <para>int
        ///         <desc>Indicates the lexical relationship between the two short name</desc>
        ///         <range>Less than 0 | 0 | Greater than 0</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// LET name1, name2 = ""
        /// LET num1, num2 = 0
        /// LET name1, name2, num1, num2 = CALL parseShortName WITH name1, name2, num1, num2
        /// IF name1 == name2
        ///     RETURN num1.compare(num2)
        /// ELSE
        ///     RETURN name1.compare(name2)
        /// </algorithm>
        static public int CompareShortName(string shrName1, string shrName2)
        {
            int ret = 0;
            string name1 = "";
            string name2 = "";
            int num1 = 0;
            int num2 = 0;
            parseShortName(shrName1, out name1, out num1);
            parseShortName(shrName2, out name2, out num2);
            ret = name1.CompareTo(name2);
            if (ret == Constant.INT_ZERO)
            {
                ret = num1.CompareTo(num2);
            }
            else
            {
                // Not required
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_001

        /// <summary>
        /// Check whether value is null pointer or not
        /// </summary>
        /// <param name="value">A value of parameter<range>string</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc> The status of value</desc>
        ///         <range>Less than 0 | 0 | Greater than 0</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// IF string value is null, null_ptr, empty THEN
        ///     RETURN true
        /// ELSE
        ///     RETURN false
        /// </algorithm>
        public static bool IsNullPointer(string value)
        {
            string[] NullValues = new string[] { Constant.NULL, Constant.NULL_PTR };
            return NullValues.Any(v => v.Equals(value, StringComparison.OrdinalIgnoreCase)) |
                                                                                           string.IsNullOrEmpty(value);
        }
        // Implementation: GENERIC_TUD_CLS_040_009

        /// <summary>
        /// Check whether variable name follow to C coding rule or not.
        /// </summary>
        /// <param name="name">A variable name<range>string</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc> The status of C syntax</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// LET ret = false
        /// LET regex = new Regex("^[a-zA-Z][a-zA-Z0-9_]*$")
        /// LET cLanguageKeywordList = list of key word C#
        /// IF name is not null and cLanguageKeywordList not contain name
        ///     LET ret =  reg.Match(name).Success
        /// RETURN ret
        /// </algorithm>
        public static bool IsNameSyntaxAsC(string name)
        {
            bool ret = false;
            Regex reg = new Regex("^[a-zA-Z][a-zA-Z0-9_]*$");
            List<string> cLanguageKeywordList = new List<string>()
            {
                "auto", "break", "case", "char", "const", "continue", "default", "do",
                "double", "else", "enum", "extern", "float", "for", "goto", "if",
                "int", "long", "register", "return", "short", "signed", "sizeof", "static",
                "struct", "switch", "typedef", "union", "unsigned", "void", "volatile", "while"
            };
            if (!string.IsNullOrEmpty(name) &&
                !cLanguageKeywordList.Any(x => x.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                Match match = reg.Match(name);
                ret = match.Success;
            }
            else
            {
                // Not required
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_008

        /// <summary>
        /// This method is used to convert double to string and ignore CultureInfo
        /// </summary>
        /// <param name="value">value of double type</param>
        /// <returns>
        ///     <para>string
        ///         <desc>coverted string without culture</desc>
        ///         <range>valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Use option InvariantCulture to ignore culture when convert double to string.
        /// </algorithm>
        public static string DoubleToString(double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }
        // Implementation: GENERIC_TUD_CLS_040_015

        /// <summary>
        /// This method is used to convert string to double and ignore CultureInfo
        /// </summary>
        /// <param name="value">Value of string representation</param>
        /// <param name="numStyle">Number style of string representation</param>
        /// <returns>
        ///     <para>double
        ///         <desc>coverted double without culture</desc>
        ///         <range>valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Use option InvariantCulture to ignore culture when convert string to double following number style.
        /// </algorithm>
        public static double StringToDouble(string value, NumberStyles numStyle = NumberStyles.Float)
        {
            double result = 0;
            double.TryParse(value, numStyle, CultureInfo.InvariantCulture, out result);

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_040_016

        /// <summary>
        /// This method is used to Separate string with string
        /// </summary>
        /// <param name="value">Value of string need to be separated</param>
        /// <param name="separator">string separator</param>
        /// <returns>
        ///     <para>string[]
        ///         <desc>array of string</desc>
        ///         <range>valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET ret is empty array string
        /// IF separator is found in value
        ///    LET index = index of separator in value
        ///    LET firstString = retrieve the substring of value from index 0 to length of index + separator
        ///    LET secondString = retrieve the substring of value startIndex is length of index + separator
        ///    LET ret[0] = firstString
        ///    LETret[1] = secondString;
        /// ELSE
        ///    Do nothing
        /// RETURN ret
        /// </algorithm>
        public static string[] StringSeparateWith(string value, string separator)
        {
            string[] ret = { string.Empty, string.Empty }; 
            if(-1 != value.IndexOf(separator, StringComparison.OrdinalIgnoreCase))
            {
                int index = value.IndexOf(separator, StringComparison.OrdinalIgnoreCase);
                string firstString = value.Substring(0, index + separator.Length);
                string secondString = value.Substring(index + separator.Length);
                ret[0] = firstString;
                ret[1] = secondString;
            }
            else
            {
                //Do nothing
            }
            
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_017

        /// <summary>
        /// Write to file
        /// </summary>
        /// <param name="defineList">List of checked param<range>null/valid List</range></param>
        /// <param name="qacMessage">qac message of significant character <range>null/valid Dictionary</range></param>
        /// <returns>
        ///     <para>
        ///         <desc>store name of parameter and QAC message</desc>
        ///         <range>valid dictionary</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// None
        /// </ref>
        /// <algorithm>
        /// Return Parameter name with QAC message
        /// </algorithm>
        public static Dictionary<string, Dictionary<string, string>> GetQacSignChar(
                                                         List<string> defineList, Dictionary<string, string> qacMessage)
        {
            Func<string, string, bool> checkSignificantChar = (name, sameName) =>
            {
                string subname = name.Substring(0, 31);
                string subsameName = sameName.Substring(0, 31);
                return subname.Equals(subsameName);
            };
            Dictionary<string, Dictionary<string, string>> ret = new Dictionary<string, Dictionary<string, string>>();
            if (null != defineList && defineList.Count > 0)
            {
                //Create default value.
                foreach (string defineName in defineList)
                {
                    if (ret.ContainsKey(defineName))
                    {
                        ret[defineName] = null;
                    }
                    else
                    {
                        ret.Add(defineName, null);
                    }
                }

                List<string> checkedName = ret.Keys.Where(x => Constant.SignificantCharNum <= x.Length).ToList();

                foreach (string name in checkedName)
                {
                    string sameName = checkedName.Where(x => checkSignificantChar(name, x)).FirstOrDefault();
                    if (!string.IsNullOrEmpty(sameName) && (checkedName.IndexOf(sameName) < checkedName.IndexOf(name)))
                    {
                        ret[name] = qacMessage;
                    }
                    else
                    {
                        //Do nothing
                    }
                }
            }
            else
            {
                //Do nothing
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_040_018
    }
}
