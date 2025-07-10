/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = ReflectionWrapper.cs                                                                                */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains ReflectionWrapper class to handle exception relate to .NET reflection library          */
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
/*              : class ReflectionWrapper                                                                             */
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
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.Properties;
using System;
using System.IO;
using System.Reflection;
using System.Security;

namespace Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper
{
    /// <summary>
    /// This class is used to wrap .NET methods of System.Reflection classes
    /// </summary>
    public class ReflectionWrapper
    {
        private static IUserInterface ui = ObjectFactory.ObjectFactory.GetInstance<IUserInterface>();
        // Implementation: GENERIC_TUD_CLS_032_001

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
        // Implementation: GENERIC_TUD_CLS_032_004

        /// <summary>
        /// Handle kind of .NET exceptions incase load the contents of an assembly file.
        /// </summary>
        /// <param name="path">string file <range>empty/string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>Assembly
        ///         <desc>Assembly of file</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_055, CMN_TAD_ERR_056
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
        /// LET CALL .NET API Assembly.LoadFile(path) to load the contents of an assembly file on the specified path.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     FileLoadException: record error ERR000055
        ///     BadImageFormatException: record error ERR000056
        /// </algorithm>
        public static Assembly LoadFile(string path, int? exitCode = null)
        {
            bool success = false;
            Assembly result = null;

            try
            {
                result = Assembly.LoadFile(path);
                success = true;
            }
            // Not handle System.ArgumentException,
            // it's validated and this exception does not occur in current implementation
            // Not handle System.ArgumentNullException,
            // it's validated and this exception does not occur in current implementation
            // Not handle System.IO.FileNotFoundException,
            // it's validated and this exception does not occur in current implementation
            catch (Exception e) when (e is FileLoadException)
            {
                ui.Error(0, 55, Resources.ERR000055, path, e.Message);
            }
            catch (Exception e) when (e is BadImageFormatException)
            {
                ui.Error(0, 56, Resources.ERR000056, path, e.Message);
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
        // Implementation: GENERIC_TUD_CLS_032_002

        /// <summary>
        /// Handle kind of .NET exceptions incase load an assembly given its file name or path.
        /// </summary>
        /// <param name="path">string file <range>empty/string</range>
        /// </param>
        /// <param name="exitCode">int? exitCode <range>Null/integer</range>
        /// </param>
        /// <returns>
        ///     <para>Assembly
        ///         <desc>Assembly of path</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_050, CMN_TAD_ERR_051, CMN_TAD_ERR_055, CMN_TAD_ERR_056
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
        /// LET CALL .NET API Assembly.LoadFrom(path) to load an assembly
        /// LET given its file name or path.
        /// IF exception(s) is(are) thrown THEN
        ///     LET record the error and exit application
        /// Handle .NET exceptions:
        ///     - FileLoadException: record error ERR000055
        ///     - BadImageFormatException: record error ERR000056
        ///     - SecurityException: record error ERR000050
        ///     - PathTooLongException: record error ERR000051
        /// </algorithm>
        public static Assembly LoadFrom(string path, int? exitCode = null)
        {
            bool success = false;
            Assembly result = null;
            try
            {
                result = Assembly.LoadFrom(path);
                success = true;
            }
            // Not handle System.ArgumentException,
            // it's validated and this exception does not occur in current implementation
            // Not handle System.ArgumentNullException,
            // it's validated and this exception does not occur in current implementation
            // Not handle System.IO.FileNotFoundException,
            // it's validated and this exception does not occur in current implementation
            catch (Exception e) when (e is FileLoadException)
            {
                ui.Error(0, 55, Resources.ERR000055, path, e.Message);
            }
            catch (Exception e) when (e is BadImageFormatException)
            {
                ui.Error(0, 56, Resources.ERR000056, path, e.Message);
            }
            catch (Exception e) when (e is SecurityException)
            {
                ui.Error(0, 50, Resources.ERR000050, "load file", path, e.Message);
            }
            catch (Exception e) when (e is PathTooLongException)
            {
                ui.Error(0, 51, Resources.ERR000051, "load file", path, e.Message);
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
        // Implementation: GENERIC_TUD_CLS_032_003
    }
}
