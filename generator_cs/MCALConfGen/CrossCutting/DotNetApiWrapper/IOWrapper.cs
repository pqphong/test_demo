/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = IOWrapper.cs                                                                                        */
/* Version      = 2.3.0                                                                                              */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020, 2022 Renesas Electronics Corporation. All rights reserved.                                */
/*====================================================================================================================*/
/* Purpose: This file contains IOWrapper class to handle exception relate to .NET IO library                          */
/* such as wrapper class                                                                                              */
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
/*              : class IOWrapper                                                                                     */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            20/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.3.2:     23/02/2022 :    Add new method ReadLines                                                                */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using System;
using System.IO;
using Renesas.Generator.MCALConfGen.Properties;
using System.Security;
using System.Xml.Linq;
using System.Xml;
using System.Collections.Generic;

namespace Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper
{
    /// <summary>
    /// This class is used to wrap .NET methods of System.IO classes.
    /// </summary>
    public class IOWrapper
    {
        private static IUserInterface ui = ObjectFactory.ObjectFactory.GetInstance<IUserInterface>();
        // Implementation: GENERIC_TUD_CLS_031_001

        /// <summary>
        /// Handle kind of .NET exceptions incase create directory
        /// </summary>
        /// <param name="path">string path <range>string</range></param>
        /// <param name="exitCode">int? value <range>Null/!Null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_018, CMN_TAD_ERR_050, CMN_TAD_ERR_051
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     UserInterface
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
        /// LET CALL .NET API Directory.CreateDirectory(path) to create a new directory.
        /// IF exception(s) is(are) thrown
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     UnauthorizedAccessException: record error ERR000050
        ///     PathTooLongException: record error ERR000051
        ///     IOException: record error ERR000018
        ///     DirectoryNotFoundException: record error ERR000018
        ///     ArgumentException: record error ERR000018
        /// </algorithm>
        public static void CreateDirectory(string path, int? exitCode = null)
        {
            bool success = false;

            try
            {
                Directory.CreateDirectory(path);
                success = true;
            }
            // Not handle System.ArgumentNullException, this exception is handled by ERR000005
            // Not handle System.NotSupportedException, this exception is handled by ERR000010

            catch (Exception e) when (e is UnauthorizedAccessException)
            {
                ui.Error(0, 50, Resources.ERR000050, "create directory", path, e.Message);
            }
            catch (Exception e) when (e is PathTooLongException)
            {
                ui.Error(0, 51, Resources.ERR000051, "create directory", path, e.Message);
            }
            catch (Exception e) when (e is IOException || e is DirectoryNotFoundException || e is ArgumentException)
            {
                ui.Error(0, 18, Resources.ERR000018, path, e.Message);
            }
            if (!success)
            {
                exit(exitCode);
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_031_002

        /// <summary>
        /// Handle kind of .NET exceptions incase get files
        /// </summary>
        /// <param name="path">string path <range>Null or not</range></param>
        /// <param name="searchPattern">string path<range>TopDirectoryOnly AllDirectories</range></param>
        /// <param name="searchOption">To search all/top directories<range>SearchOption enum</range></param>
        /// <param name="exitCode">int? exitCode <range>Null or not</range></param>
        /// <returns>
        ///     <para>string[]
        ///         <desc>The list of file at current path</desc>
        ///         <range>-</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_018, CMN_TAD_ERR_050, CMN_TAD_ERR_051
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API Directory.GetFiles(path, searchPattern, searchOption) to search file names by pattern.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     UnauthorizedAccessException: record error ERR000050
        ///     PathTooLongException: record error ERR000051
        ///     IOException: record error ERR000018
        /// </algorithm>
        public static string[] GetFiles(string path,
                                        string searchPattern,
                                        SearchOption searchOption,
                                        int? exitCode = null)
        {
            bool success = false;
            string[] result = null;

            try
            {
                result = Directory.GetFiles(path, searchPattern, searchOption);
                success = true;
            }
            // Not handle System.ArgumentException,
            // it's validated and this exception does not occur in current implementation
            // Not handle System.ArgumentNullException,
            // it's validated and this exception does not occur in current implementation
            // Not handle System.DirectoryNotFoundException,
            // it's validated and this exception does not occur in current implementation
            catch (Exception e) when (e is UnauthorizedAccessException)
            {
                ui.Error(0, 50, Resources.ERR000050, "get files from directory", path, e.Message);
            }
            catch (Exception e) when (e is PathTooLongException)
            {
                ui.Error(0, 51, Resources.ERR000051, "get files from directory", path, e.Message);
            }
            catch (Exception e) when (e is IOException)
            {
                ui.Error(0, 53, Resources.ERR000053, "read", path, e.Message);
            }

            if (!success)
            {
                exit(exitCode);
            }
            else
            {
                // Not required
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_031_007

        /// <summary>
        /// This method call .NET API to check if a directory exists
        /// </summary>
        /// <param name="directory">string path <range>Null or not</range></param>
        /// <param name="exitCode">int? exitCode <range>Null or not</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The status of directory exists or not</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_050
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API Directory.Exists(directory) to check if a directory exists
        /// IF exception is thrown THEN
        ///     LET record ERR000050 and exit application
        /// </algorithm>
        public static bool DirectoryExists(string directory, int? exitCode = null)
        {
            bool result = false;
            try
            {
                result = Directory.Exists(directory);
            }
            catch (Exception e) when (e is SecurityException)
            {
                ui.Error(0, 50, Resources.ERR000050, "read directory ", directory, e.Message);
                exit(exitCode);
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_031_003

        /// <summary>
        /// This method call .NET API to get current directory of executing application
        /// </summary>
        /// <param name="exitCode">int? exitCode <range>Null or not</range>
        /// </param>
        /// <returns>
        ///     <para>string
        ///         <desc>The path of current directory</desc>
        ///         <range>empty/valid directory</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_050
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API Directory.GetCurrentDirectory() to get current directory of executing application.
        /// IF exception is thrown THEN
        ///     LET record ERR000050 and exit application
        /// </algorithm>
        public static string GetCurrentDirectory(int? exitCode = null)
        {
            string result = string.Empty;
            try
            {
                result = Directory.GetCurrentDirectory();
            }
            catch (Exception e) when (e is UnauthorizedAccessException)
            {
                ui.Error(0, 50, Resources.ERR000050, "read current folder", "", e.Message);
                exit(exitCode);
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_031_005

        /// <summary>
        /// Call .NET API to check if a file exists.
        /// </summary>
        /// <param name="file">string file <range>Null or not</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null or not</range>
        /// </param>
        /// <returns>
        ///     <para>bool
        ///         <desc>Status of file exists or not</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_050
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API File.Exists(file)  to get current directory of executing application.
        /// IF exception is thrown THEN\
        ///     LET record ERR000050 and exit application
        /// </algorithm>
        public static bool FileExists(string file, int? exitCode = null)
        {
            bool result = false;
            try
            {
                result = File.Exists(file);
            }
            catch (Exception e) when (e is SecurityException)
            {
                ui.Error(0, 50, Resources.ERR000050, "read file", file, e.Message);
                exit(exitCode);
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_031_004

        /// <summary>
        /// Handle kind of .NET exceptions incase read content of a file
        /// </summary>
        /// <param name="path">string path <range>empty/string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>string[]
        ///         <desc>Content of file</desc>
        ///         <range>null/valid strings</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_050, CMN_TAD_ERR_053
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API File.ReadAllLines(file) to read content of a file and return
        ///     an array of string in which a string is a line.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     UnauthorizedAccessException: record error ERR000050
        ///     SecurityException: record error ERR000050
        ///     IOException: record error ERR000053
        /// </algorithm>
        public static string[] ReadAllLines(string file, int? exitCode = null)
        {
            bool success = false;
            string[] data = null;

            try
            {
                data = File.ReadAllLines(file);
                success = true;
            }
            // Not handle System.ArgumentNullException,  this exception is handled by ERR000001
            // Not handle System.PathTooLongException,  this exception is handled by ERR000001
            // Not handle System.DirectoryNotFoundException,  this exception is handled by ERR000001
            // Not handle System.ArgumentException,  this exception is handled by ERR000001
            // Not handle System.NotSupportedException,  this exception is handled by ERR000001
            catch (Exception e) when (e is UnauthorizedAccessException || e is SecurityException)
            {
                ui.Error(0, 50, Resources.ERR000050, "read file", file, e.Message);
            }
            catch (Exception e) when (e is IOException)
            {
                ui.Error(0, 53, Resources.ERR000053, "read", file, e.Message);
            }

            if (!success)
            {
                exit(exitCode);
            }
            else
            {
                // Not required
            }
            return data;
        }
        // Implementation: GENERIC_TUD_CLS_031_010

        /// <summary>
        /// Handle kind of .NET exceptions incase read content of a file
        /// </summary>
        /// <param name="path">string path <range>empty/string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>IEnumerable of string
        ///         <desc>Content of file</desc>
        ///         <range>null/valid strings</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_050, CMN_TAD_ERR_053
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API File.ReadLines(file) to read content of a file and return
        ///     an array of string in which a string is a line.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     UnauthorizedAccessException: record error ERR000050
        ///     SecurityException: record error ERR000050
        ///     IOException: record error ERR000053
        /// </algorithm>
        public static IEnumerable<string> ReadLines(string file, int? exitCode = null)
        {
            bool success = false;
            IEnumerable<string> data = null;

            try
            {
                data = File.ReadLines(file);
                success = true;
            }
            // Not handle System.ArgumentNullException,  this exception is handled by ERR000001
            // Not handle System.PathTooLongException,  this exception is handled by ERR000001
            // Not handle System.DirectoryNotFoundException,  this exception is handled by ERR000001
            // Not handle System.ArgumentException,  this exception is handled by ERR000001
            // Not handle System.NotSupportedException,  this exception is handled by ERR000001
            catch (Exception e) when (e is UnauthorizedAccessException || e is SecurityException)
            {
                ui.Error(0, 50, Resources.ERR000050, "read file", file, e.Message);
            }
            catch (Exception e) when (e is IOException)
            {
                ui.Error(0, 53, Resources.ERR000053, "read", file, e.Message);
            }

            if (!success)
            {
                exit(exitCode);
            }
            else
            {
                // Not required
            }
            return data;
        }
        // Implementation: GENERIC_TUD_CLS_031_014

        /// <summary>
        /// Handle kind of .NET exceptions incase get the absolute path
        /// </summary>
        /// <param name="path">string path <range>empty/valid string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>string
        ///         <desc>The absolute path for the specified path string</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_050, CMN_TAD_ERR_051
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API Path.GetFullPath(path) to returns the absolute path for the specified path string
        /// IF exception(s) is(are) thrown THEN
        ///     LETrecord the error and exit application
        /// Handle .NET exceptions:
        ///     SecurityException: record error ERR000050
        ///     PathTooLongException: record error ERR000051
        /// </algorithm>
        public static string GetFullPath(string path, int? exitCode = null)
        {
            bool success = false;
            string result = string.Empty;

            try
            {
                result = Path.GetFullPath(path);
                success = true;
            }
            // Not handle ArgumentNullException,
            // it's validated and this exception does not occur in current implementation
            // Not handle NotSupportedException,
            // it's validated and this exception does not occur in current implementation
            // Not handle ArgumentException, it's validated and this exception does not occur in current implementation
            catch (Exception e) when (e is SecurityException)
            {
                ui.Error(0, 50, Resources.ERR000050, "access path", path, e.Message);
            }
            catch (Exception e) when (e is PathTooLongException)
            {
                ui.Error(0, 51, Resources.ERR000051, "access path", path, e.Message);
            }

            if (!success)
            {
                exit(exitCode);
            }
            else
            {
                //Not required
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_031_008

        /// <summary>
        /// Handle kind of .NET exceptions incase write content to streamWriter
        /// </summary>
        /// <param name="streamWriter">StreamWriter streamWriter <range>Null or not</range>
        /// </param>
        /// <param name="content">string content <range>empty/string</range>
        /// </param>
        /// <param name="path">string path <range>empty/string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_053
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API streamWriter.Write(content) to write content to streamWriter
        /// WHICH in turn will write to a file.
        /// Content is NOT appended a new line character at the end.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     IOException: record error ERR000053
        /// </algorithm>
        public static void StreamWrite(StreamWriter streamWriter, string content, string path, int? exitCode = null)
        {
            // Ref: GENERIC_TUM_U2X_GT_ERR_053
            try
            {
                streamWriter.Write(content);
            }
            catch (Exception e) when (e is IOException)
            {
                ui.Error(0, 53, Resources.ERR000053, "write", path, e.Message);
                exit(exitCode);
            }
        }
        // Implementation: GENERIC_TUD_CLS_031_011

        /// <summary>
        /// Handle kind of .NET exceptions incase write content to streamWriter
        /// </summary>
        /// <param name="streamWriter">StreamWriter streamWriter <range>Null or not</range>
        /// </param>
        /// <param name="content">string content <range>empty/string</range>
        /// </param>
        /// <param name="path">string path <range>empty/string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_053
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API streamWriter.Write(content) to write content to streamWriter
        /// which in turn will write to a file
        /// Content is appended a new line character at the end.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     IOException: record error ERR000053
        /// </algorithm>
        public static void StreamWriteLine(StreamWriter streamWriter,
                                            string content,
                                            string path,
                                            int? exitCode = null)
        {
            // Ref: GENERIC_TUM_U2X_GT_ERR_053
            try
            {
                streamWriter.WriteLine(content);
            }
            catch (Exception e) when (e is IOException)
            {
                ui.Error(0, 53, Resources.ERR000053, "write", path, e.Message);
                exit(exitCode);
            }
        }
        // Implementation: GENERIC_TUD_CLS_031_012

        /// <summary>
        /// Handle kind of .NET exceptions incase load XML file.
        /// </summary>
        /// <param name="file">string file <range>empty/string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>XDocument
        ///         <desc>The content of XML file</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_012, CMN_TAD_ERR_050
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API XDocument.Load(file) to load a XML file.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     FormatException: record error ERR000012
        ///     XmlException: record error ERR000012
        ///     UnauthorizedAccessException: record error ERR000050
        /// </algorithm>
        public static XDocument LoadXML(string file, int? exitCode = null)
        {
            bool success = false;
            XDocument doc = null;
            try
            {
                doc = XDocument.Load(file);
                success = true;
            }
            catch (Exception e) when (e is FormatException || e is XmlException)
            {
                ui.Error(0, 12, Resources.ERR000012, file);

            }
            catch (Exception e) when (e is UnauthorizedAccessException)
            {
                ui.Error(0, 50, Resources.ERR000050, "load xml file", file, e.Message);
            }

            if (!success)
            {
                exit(exitCode);
            }
            else
            {
                // Not required
            }
            return doc;

        }
        // Implementation: GENERIC_TUD_CLS_031_009

        /// <summary>
        /// Handle kind of .NET exceptions incase get file name and extension path string
        /// </summary>
        /// <param name="fileName">string file <range>empty/string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>string
        ///         <desc>The name of file</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_053
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     ui
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
        /// LET CALL .NET API Path.GetFileName(fileName) to get the file name
        /// and extension of the specified path string.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     ArgumentException: record error ERR000053
        /// </algorithm>
        public static string GetFileName(string fileName, int? exitCode = null)
        {
            string ret = string.Empty;
            try
            {
                ret = Path.GetFileName(fileName);
            }
            catch (Exception e) when (e is ArgumentException)
            {
                ui.Error(0, 53, Resources.ERR000053, "get file name", fileName, e.Message);
                exit(exitCode);
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_031_006

        /// <summary>
        /// Call to exit program
        /// </summary>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
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
        ///     ui
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
        /// This method receive parameter as exit code value from calling method.
        /// IF parameter does not provide THEN
        ///     LET exit program without status code.
        /// </algorithm>
        private static void exit(int? exitCode = null)
        {
            if (exitCode == null)
                ui.Exit();
            else
                ui.Exit(exitCode.Value);
        }
        // Implementation: GENERIC_TUD_CLS_031_013
    }
}
