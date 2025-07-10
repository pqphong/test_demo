/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = UserInterface.cs                                                                                    */
/* Version      = 2.3.0                                                                                              */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020, 2022 Renesas Electronics Corporation. All rights reserved.                                */
/*====================================================================================================================*/
/* Purpose: This file contains UserInterface class that implements IUserInterface interface to record Error, Warning, */
/*          Info information and exit Gentool.                                                                        */
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
/*              : class UserInterface                                                                                 */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            21/02/2019 :    Handle ILC findings to improve GenTool - #88604                                         */
/*            12/03/2019 :    Fix bug that is cloned from C1X - #91630 as follow:                                     */
/*                             Remove unuse argument in method textWrap()                                             */
/* 1.0.2:     30/12/2019 :    Support AR431                                                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.3.2:     23/02/2022 :    Update getDateTime for format of date time                                              */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Business.Intermediate;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Properties;
using System.Text.RegularExpressions;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using System.Globalization;

namespace Renesas.Generator.MCALConfGen.CrossCutting.UserInterface
{
    /// <summary>
    /// This class that implements "IUserInterface" interface to record Error, Warning,
    /// Info information and exit Gentool
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL, Version =
                                                                                            Constant.VERSION_1_0_0)]
    class UserInterface : IUserInterface
    {
        /// <summary>
        /// "UserInterface" instance used by "ObjectFactory" to get a new "UserInterface" object
        /// </summary>
        public static readonly UserInterface Instance = new UserInterface();
        // Implementation: GENERIC_TUD_CLS_038_001

        /// <summary>
        /// Runtime config
        /// </summary>
        private IRuntimeConfiguration runtimeConfig = ObjectFactory.ObjectFactory.GetInstance<IRuntimeConfiguration>();
        // Implementation: GENERIC_TUD_CLS_038_004

        /// <summary>
        /// Basic config
        /// </summary>
        private IBasicConfiguration basicConfig = ObjectFactory.ObjectFactory.GetInstance<IBasicConfiguration>();
        // Implementation: GENERIC_TUD_CLS_038_005

        /// <summary>
        /// Stream writer log
        /// </summary>
        private StreamWriter swLog = null;
        // Implementation: GENERIC_TUD_CLS_038_006

        /// <summary>
        /// Log content
        /// </summary>
        private StringBuilder logContent = new StringBuilder(Resources.CopyRightLog);
        // Implementation: GENERIC_TUD_CLS_038_007

        /// <summary>
        /// Error count
        /// </summary>
        public int ErrorCount { get { return errorCount; } }
        // Implementation: GENERIC_TUD_CLS_038_002

        /// <summary>
        /// Warning count
        /// </summary>
        public int WarningCount { get { return warningCount; } }
        // Implementation: GENERIC_TUD_CLS_038_003

        /// <summary>
        /// Error count
        /// </summary>
        private int errorCount = 0;
        // Implementation: GENERIC_TUD_CLS_038_008

        /// <summary>
        /// Warning count
        /// </summary>
        private int warningCount = 0;
        // Implementation: GENERIC_TUD_CLS_038_009

        /// <summary>
        /// in Exit Mode
        /// </summary>
        private bool inExitMode = false;
        // Implementation: GENERIC_TUD_CLS_038_010

        /// <summary>
        /// Get current date time with format "dd MMM yyyy - hh:mm:ss"
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>The runtime date time</desc>
        ///         <range>valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get current date time with format "dd MMM yyyy - HH:mm:ss"
        /// </algorithm>
        private string getDateTime()
        {
            return DateTime.Now.ToString("dd MMM yyyy - HH:mm:ss", CultureInfo.InvariantCulture);
        }
        // Implementation: GENERIC_TUD_CLS_038_022

        /// <summary>
        /// Record error
        /// </summary>
        /// <param name="moduleId">Module id <range>integer</range></param>
        /// <param name="errorCode">Error code <range>integer</range></param>
        /// <param name="message">Message <range>string</range></param>
        /// <param name="parameters">Parameters <range>null/!null</range></param>
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
        ///     errorCount
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
        /// LET Increase number of errors and call report method
        /// CALL report method WITH moduleId, errorCode, "ERR", message, parameters
        /// </algorithm>
        public void Error(int moduleId, int errorCode, string message, params object[] parameters)
        {
            errorCount++;
            report(moduleId, errorCode, "ERR", message, parameters);
        }
        // Implementation: GENERIC_TUD_CLS_038_012

        /// <summary>
        /// Report warning
        /// </summary>
        /// <param name="moduleId">Module id <range>integer</range></param>
        /// <param name="errorCode">Error code <range>integer</range></param>
        /// <param name="message">Message <range>string</range></param>
        /// <param name="parameters">Parameters <range>null/!null</range></param>
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
        ///     warningCount
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
        /// LET Increase number of warnings and call report method
        /// CALL report method WITH moduleId, errorCode, "WRN", message, parameters
        /// </algorithm>
        public void Warn(int moduleId, int errorCode, string message, params object[] parameters)
        {
            warningCount++;
            report(moduleId, errorCode, "WRN", message, parameters);
        }
        // Implementation: GENERIC_TUD_CLS_038_020

        /// <summary>
        /// Report info
        /// </summary>
        /// <param name="moduleId">Module id <range>integer</range></param>
        /// <param name="errorCode">Error code <range>integer</range></param>
        /// <param name="message">Message <range>string</range></param>
        /// <param name="parameters">Parameters <range>null/!null</range></param>
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
        /// CALL report method WITH moduleId, errorCode, "INF", message, parameters
        /// </algorithm>
        public void Info(int moduleId, int errorCode, string message, params object[] parameters)
        {
            report(moduleId, errorCode, "INF", message, parameters);
        }
        // Implementation: GENERIC_TUD_CLS_038_017

        /// <summary>
        /// Get caller class
        /// </summary>
        /// <returns>
        ///     <para>Type
        ///         <desc>The type</desc>
        ///         <range>null/!=null</range>
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
        /// LET ret WITH type is Type and initialize value is null
        /// LET stack = initialize new StackTrace
        /// FOR index from 0 to length of stack.GetFrames
        ///     LET type = stack.GetFrame(index).GetMethod
        ///     IF type.DeclaringType.GetInterfaces().FirstOrDefault is not null THEN
        ///         LET ret = type.DeclaringType.GetInterfaces().FirstOrDefault
        /// RETURN ret
        /// </algorithm>
        private Type getCallerClass()
        {
            Type ret = null;
            var stack = new StackTrace();
            // Get caller class cause error to report coresponding info, start with class invoking it.
            for (int index = Constant.INT_TWO, size = stack.GetFrames().Length; index < size; index++)
            {
                var frame = stack.GetFrame(index);
                var type = frame.GetMethod();
                var x = type.DeclaringType.GetInterfaces();
                // Get interface that cause error
                if (x.FirstOrDefault() != null)
                {
                    ret = x.FirstOrDefault();
                    break;
                }
                else
                {
                    // Not required
                }
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_038_021

        /// <summary>
        /// exit Code Dictionary
        /// </summary>
        private Dictionary<Type, int> exitCodeDic = new Dictionary<Type, int>()
        {
            { typeof (ICommandLine), Constant.EXIT_DUE_CMD_ERROR },
            { typeof (IParser), Constant.EXIT_DUE_INPUT_FILES_ERROR },
            { typeof (IValidation), Constant.EXIT_DUE_INPUT_FILES_ERROR },
            { typeof (IIntermediate), Constant.EXIT_DUE_INPUT_FILES_ERROR },
            { typeof (IGeneration), Constant.EXIT_DUE_STRUCTURE_GENERATION_ERROR},
            { typeof (IFileGeneration), Constant.EXIT_DUE_OVERWRITTEN_FILE_ERROR},
            { typeof (IRegisterProcessing), Constant.EXIT_DUE_INPUT_FILES_ERROR}

        };
        // Implementation: GENERIC_TUD_CLS_038_011

        /// <summary>
        /// Open file from path
        /// </summary>
        /// <param name="path">Path <range>string</range></param>
        /// <returns>
        ///     <para>StreamWriter
        ///         <desc>The string wrapped</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_INF_004
        /// </ref>
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
        /// LET Open file from path
        /// LET CALL Info WITH (0, 4, String.Format(Resources.INF000004, StringUtils.GetRelativePath(path),
        ///     getDateTime())) TO Record info INF000004
        /// </algorithm>
        public StreamWriter OpenFile(string path)
        {
            // Ref: GENERIC_TUM_U2x_GT_INF_004
            StreamWriter sw = new StreamWriter(path);
            string fileOpenMsg = String.Format(Resources.INF000004, StringUtils.GetRelativePath(path), getDateTime());

            Info(0, 4, fileOpenMsg);

            return sw;
        }
        // Implementation: GENERIC_TUD_CLS_038_019

        /// <summary>
        /// Exit Gentool without parameter
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_USG_013
        /// </ref>
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
        /// LET Identify exitcode from caller class
        /// IF CALL class NOT found in exitCodeDic THEN
        ///     LET exitcode = EXIT_SUCCESSFUL
        /// LET CALL Exit method with parameter exitcode
        /// </algorithm>
        public void Exit()
        {
            var caller = getCallerClass();
            int exitcode = 0;
            // Report exit code corresponding to caller class that cause error.
            if ((null == caller) || (false == exitCodeDic.TryGetValue(caller, out exitcode)))
            {
                exitcode = Constant.EXIT_SUCCESSFUL;
            }
            else
            {
                // Not required.
            }

            Exit(exitcode);
        }
        // Implementation: GENERIC_TUD_CLS_038_015

        /// <summary>
        /// Exit Gentool with parameter exit code
        /// </summary>
        /// <param name="exitCode">Exit code <range>integer</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_004, CMN_TAD_INF_005
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     runtimeConfig, swLog, basicConfig
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
        /// LET Use basicConfig.OutputFolder if runtimeConfig.FolderOutput NOT existed
        /// IF runtimeConfig.DryRun is false THEN
        ///     LET Write to log file
        ///     LET Handle error ERR000004 when can NOT write log file
        /// End
        ///
        /// LET Record info INF000005
        /// LET CALL infoErrorCode method to record info based on exitCode
        /// IF exitCode = EXIT_SUCCESSFUL THEN
        ///     LET Environment.Exit with 0
        /// ELSE
        ///     LET Environment.Exit with 1
        ///
        /// </algorithm>
        public void Exit(int exitCode)
        {
            try
            {
                if (inExitMode)
                {
                    return;
                }
                else
                {
                    inExitMode = true;
                }
                // No report to log file If user enable dryrun property.
                if (false == runtimeConfig.DryRun)
                {
                    runtimeConfig.LogFilePath =
                        Path.Combine(runtimeConfig.FolderOutput, basicConfig.ModuleName + ".log");
                    try
                    {
                        swLog = OpenFile(runtimeConfig.LogFilePath);
                    }
                    catch
                    {
                        Error(0, 4, Resources.ERR000004, runtimeConfig.LogFilePath);
                    }
                } // End of if (false == runtimeConfig.DryRun).
                else
                {
                    // Not required
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
            finally
            {
                Info(0, 5, Resources.INF000005, errorCount, warningCount);
                InfoErrorCode(exitCode);
                // If dryrun is disabled, write content to log file.
                if (false == runtimeConfig.DryRun && null != swLog)
                {
                    writeLog();
                }
                else
                {
                    // Not required
                }

                // Flush and close
                if (swLog != null)
                {
                    swLog.Flush();
                    swLog.Close();
                }
                else
                {
                    // Not required
                }

                int returnCode = (exitCode == Constant.EXIT_SUCCESSFUL) ? 0 : 1;
                EnvironmentWrapper.Exit(returnCode);
            }
        }
        // Implementation: GENERIC_TUD_CLS_038_016

        /// <summary>
        /// Handle file not found error
        /// </summary>
        /// <param name="fileName">File name <range>string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_001
        /// </ref>
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
        /// LET Record error ERR000001
        /// LET CALL Exit method with exitCode EXIT_DUE_CMD_ERROR
        /// </algorithm>
        public void ErrorFileNotFound(string fileName)
        {
            // Ref: GENERIC_TUM_U2X_GT_ERR_001
            Error(0, 1, Resources.ERR000001, fileName);
            Exit(Constant.EXIT_DUE_CMD_ERROR);
        }
        // Implementation: GENERIC_TUD_CLS_038_013

        /// <summary>
        /// Handle module not found error
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_031, CMN_TAD_INF_005
        /// </ref>
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
        /// LET Record error ERR000031
        /// LET Record info INF000005
        /// LET CALL infoErrorCode method to record info based on error code EXIT_DUE_CMD_ERROR
        /// LET CALL Environment.Exit with 1
        /// </algorithm>
        public void ErrorModuleNotFound()
        {
            // Ref: GENERIC_TUM_U2x_GT_ERR_031
            Error(0, 31, Resources.ERR000031, Resources.MCAL_MODULES);
            Info(0, 5, Resources.INF000005, errorCount, warningCount);
            InfoErrorCode(Constant.EXIT_DUE_CMD_ERROR);
            EnvironmentWrapper.Exit(1);
        }
        // Implementation: GENERIC_TUD_CLS_038_014

        /// <summary>
        /// Record error based on error code
        /// </summary>
        /// <param name="errorcode">Errorcode <range>integer</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_INF_006, CMN_TAD_INF_008, CMN_TAD_INF_009, CMN_TAD_INF_010, CMN_TAD_INF_011,
        /// CMN_TAD_INF_012, CMN_TAD_INF_014, CMN_TAD_INF_007
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     WarningCount
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
        /// IF errorcode iS:
        ///     - EXIT_DUE_CMD_ERROR THEN LET record info INF000008
        ///     - EXIT_SUCCESSFUL and EXIT_SUCCESSFUL_WITH_WARNINGS
        ///         + IF WarningCount > 0 THEN LET record info INF000008
        ///         + ELSE LET record info INF000006
        ///     - EXIT_DUE_INPUT_FILES_ERROR THEN LET record info INF000009
        ///     - EXIT_DUE_STRUCTURE_GENERATION_ERROR THEN LET record info INF000010
        ///     - EXIT_DUE_OVERWRITTEN_FILE_ERROR THEN LET record info INF000011
        /// </algorithm>
        public void InfoErrorCode(int errorcode)
        {
            switch (errorcode)
            {
                case Constant.EXIT_DUE_CMD_ERROR:
                    Info(0, 8, Resources.INF000008);
                    break;

                case Constant.EXIT_SUCCESSFUL:
                case Constant.EXIT_SUCCESSFUL_WITH_WARNINGS:
                    if (0 < WarningCount)
                    {
                        Info(0, 7, Resources.INF000007);
                    }
                    else
                    {
                        Info(0, 6, Resources.INF000006);
                    }
                    break;

                case Constant.EXIT_DUE_INPUT_FILES_ERROR:
                    Info(0, 9, Resources.INF000009);
                    break;

                case Constant.EXIT_DUE_STRUCTURE_GENERATION_ERROR:
                    Info(0, 10, Resources.INF000010);
                    break;

                case Constant.EXIT_DUE_OVERWRITTEN_FILE_ERROR:
                    Info(0, 11, Resources.INF000011);
                    break;

                case Constant.EXIT_DUE_UNCOMPATIBLE_DLL:
                    Info(0, 12, Resources.INF000012);
                    break;

                case Constant.EXIT_DUE_DLL_NOT_FOUND:
                    Info(0, 14, Resources.INF000014);
                    break;

                case Constant.EXIT_DUE_CRASH:
                default:
                    break;
            } // End of switch (errorcode).
        }
        // Implementation: GENERIC_TUD_CLS_038_018

        /// <summary>
        /// Report error, warning and info
        /// </summary>
        /// <param name="moduleId">Module id <range>integer</range></param>
        /// <param name="errorCode">Error code <range>integer</range></param>
        /// <param name="msgType">Message type: ERR, WRN and INF <range>string</range></param>
        /// <param name="msg">Message format <range>string</range></param>
        /// <param name="parameters">Parameters <range>null/!null</range></param>
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
        ///     logContent
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
        /// Infomration = msgType + moduleId + errorCode + message which is constructed from format and parameters
        /// IF Infomration length is larger than 80 THEN
        ///     LET Split Infomration into multiple lines, each of which has maximum length is 80
        /// End
        /// LET wite information to logContent and Console
        /// </algorithm>
        private void report(int moduleId, int errorCode, string msgType, string msg, params object[] parameters)
        {
            string prefix = String.Format("{0}{1:D3}{2:D3}:", msgType, moduleId, errorCode);
            string outMessage = textWrap(prefix, String.Format(msg, parameters), 76);
            logContent.AppendLine(outMessage);
            ConsoleWrapper.WriteLine(outMessage);
        }
        // Implementation: GENERIC_TUD_CLS_038_023

        /// <summary>
        /// Wrap text
        /// </summary>
        /// <param name="prefix">Prefix <range>string</range></param>
        /// <param name="inputString">Input string <range>string</range></param>
        /// <param name="width">Width <range>integer</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The string wrapped</desc>
        ///         <range>null/!=null</range>
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
        /// LET outStr = ""
        /// LET newLinePrefix = ""
        /// LET outlines = initialize list of string
        /// IF prefix is not null THEN
        ///     prefix += ""
        /// LET inputString.Trim()
        /// LET newLinePrefix = String.Concat(Enumerable.Repeat(" ", prefix.Length))
        /// LET outStr = prefix
        /// LET words = Split Infomration into multiple lines
        /// FOREACH word in words
        ///     IF length of word + length of outStr less than outStr THEN
        ///         LET outStr += word + " "
        ///     ELSE
        ///         LET outlines.Add(outStr);
        ///         LET outStr = Environment.NewLine + newLinePrefix + word + " "
        /// RETURN String.Join(" ", outlines) + outStr
        /// </algorithm>
        private string textWrap(string prefix, string inputString, int width = 80)
        {
            string outStr = String.Empty;
            string newLinePrefix = String.Empty;
            List<string> outlines = new List<string>();

            //Append space onto $prefix if it is not NULL.
            if (String.Empty != prefix)
            {
                prefix = prefix + " ";
            }
            else
            {
                // do nothing
            }

            //Remove possible newline at end.
            inputString = inputString.Trim();
            newLinePrefix = String.Concat(Enumerable.Repeat(" ", prefix.Length));
            outStr = prefix;
            string[] words = Regex.Split(inputString, @"\s").Where(x => !string.IsNullOrEmpty(x)).ToArray();
            foreach (string word in words)
            {
                // If a word over 80 character in line, it will be put at new line.
                if ((outStr.Length + word.Length) < width)
                {
                    outStr += word + " ";
                }
                else
                {
                    outlines.Add(outStr);
                    outStr = Environment.NewLine + newLinePrefix + word + " ";
                }
            }
            outStr = String.Join(" ", outlines) + outStr;

            return outStr;
        }
        // Implementation: GENERIC_TUD_CLS_038_024

        /// <summary>
        /// Write content to log file
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
        /// GLOBAL VARIABLE IN:
        ///     basicConfig, swLog, LogFilePath, runtimeConfig
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
        /// IF 0 less than length of logContent and swLog is not null
        ///     LET str = String.Format(logContent.ToString(), basicConfig.ModuleName.ToUpper(), getDateTime(),
        ///                 String.Join(Environment.NewLine + "#\t", runtimeConfig.CDFFilePaths.ToArray())
        ///     LET IOWrapper.StreamWriteLine(swLog, str, runtimeConfig.LogFilePath
        /// </algorithm>
        private void writeLog()
        {
            if ((Constant.INT_ZERO < logContent.Length) && (null != swLog))
            {
                string str = String.Format(logContent.ToString(),
                    basicConfig.AutoSARVersion,
                    basicConfig.ModuleName.ToUpper(),
                    getDateTime(),
                    String.Join(Environment.NewLine + "#\t", runtimeConfig.CDFFilePaths.ToArray()));

                IOWrapper.StreamWriteLine(swLog, str, runtimeConfig.LogFilePath);
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_038_025
    }
}
