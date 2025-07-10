/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = BaseRegisterProcessing.cs                                                                           */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020, 2022 Renesas Electronics Corporation. All rights reserved.                                */
/*====================================================================================================================*/
/* Purpose: This file contains BaseRegisterProcessing class implements IRegisterProcessing interface to parses and    */
/*          stores information of translation and device header files.                                                */
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
/*              : class BaseRegisterProcessing                                                                        */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            21/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.0.2:     10/02/2020 :    Fix Gentool Unit test issue #252730                                                     */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.3.2:     23/02/2022 :    update SaveMacroAddressValue for optimize data size of macroAddressValue                */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Properties;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
namespace Renesas.Generator.MCALConfGen.Data.CDFData
{
    /// <summary>
    /// This BaseRegisterProcessing class implements IRegisterProcessing interface to parses and
    /// stores information of translation and device header files.
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    public class BaseRegisterProcessing : IRegisterProcessing
    {
        /// <summary>
        /// "BaseRegisterProcessing" instance used by "ObjectFactory" to get a new "BaseRegisterProcessing" object
        /// </summary>
        public static readonly BaseRegisterProcessing Instance = new BaseRegisterProcessing();
        // Implementation: GENERIC_TUD_CLS_042_001

        /// <summary>
        /// This field store macro name in translation file
        /// </summary>
        private IDictionary<string, string> macroLabelValue = new Dictionary<string, string>();
        // Implementation: GENERIC_TUD_CLS_042_002

        /// <summary>
        /// This field store macro address value in device file
        /// </summary>
        private IDictionary<string, string> macroAddressValue = new Dictionary<string, string>();
        // Implementation: GENERIC_TUD_CLS_042_003

        /// <summary>
        /// This field store macro address type in device file
        /// </summary>
        private IDictionary<string, string> macroAddressType = new Dictionary<string, string>();
        // Implementation: GENERIC_TUD_CLS_042_004

        /// <summary>
        /// This field isn't used, it is reserved
        /// </summary>
        private ILogger logger = null;
        // Implementation: GENERIC_TUD_CLS_042_005

        /// <summary>
        /// This field report error and exit
        /// </summary>
        private IUserInterface userInterface = null;
        // Implementation: GENERIC_TUD_CLS_042_006

        /// <summary>
        /// Contain path of translation file that contain macro definition.
        /// </summary>
        private string translationHeaderFilePath = string.Empty;
        // Implementation: GENERIC_TUD_CLS_042_007

        /// <summary>
        /// Contain path of device file that contain address values.
        /// </summary>
        private string deviceHeaderFilePath = string.Empty;
        // Implementation: GENERIC_TUD_CLS_042_008

        /// <summary>
        /// Base register processing constructor
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
        /// Init component
        /// </algorithm>
        protected BaseRegisterProcessing() : this
        (
            ObjectFactory.GetInstance<ILogger>(),
            ObjectFactory.GetInstance<IUserInterface>()
        )
        {

        }
        // Implementation: GENERIC_TUD_CLS_042_015

        /// <summary>
        /// Base register processing constructor
        /// </summary>
        /// <param name="logger">Logger <range>Null/Valid value</range></param>
        /// <param name="userInterface">User interface <range>Null/Valid value</range></param>
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
        protected BaseRegisterProcessing(ILogger logger, IUserInterface userInterface)
        {
            this.logger = logger;
            this.userInterface = userInterface;
        }
        // Implementation: GENERIC_TUD_CLS_042_016

        /// <summary>
        /// Get macro address value
        /// </summary>
        /// <param name="macroValue">Macro value <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The macro address values</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_023, CMN_TAD_ERR_024, CMN_TAD_ERR_038
        /// </ref>
        /// <algorithm>
        /// LET address = string empty
        /// IF macroValue is contained in macroAddressValue THEN
        ///     LET address = value in macroAddressValue with key is macroValue
        /// ELSE
        ///     LET record error ERR000023 into userInterface and exit
        /// IF address is null or empty THEN
        ///     LET record error ERR000024 into userInterface and exit
        /// ELSE IF address isn't hex format THEN
        ///     LET record error ERR000038 into userInterface and exit
        /// RETURN address
        /// </algorithm>
        public string GetMacroAddressValue(string macroValue)
        {
            string address = String.Empty;
            // Report error if macro definition is not found in input device specific C Header File(s).
            if (macroAddressValue.ContainsKey(macroValue))
            {
                address = macroAddressValue[macroValue];
            }
            else
            {
                userInterface.Error(0, 23, Resources.ERR000023, macroValue, deviceHeaderFilePath);
                userInterface.Exit();
            }
            // Report error if macro value is empty in input device specific C Header File(s).
            if (String.IsNullOrEmpty(address))
            {
                userInterface.Error(0, 24, Resources.ERR000024, macroValue, deviceHeaderFilePath);
                userInterface.Exit();
            }
            // Report error if register address has invalid Hex value in device C Header File.
            else if (!StringUtils.IsHex(address))
            {
                userInterface.Error(0, 38, Resources.ERR000038, macroValue, deviceHeaderFilePath);
                userInterface.Exit();
            }
            else
            {
                // Not required
            }

            return address;
        }
        // Implementation: GENERIC_TUD_CLS_042_010

        /// <summary>
        /// Get macro label value
        /// </summary>
        /// <param name="macroDefinition">Macro definition<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The macro label value</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_021, CMN_TAD_ERR_022
        /// </ref>
        /// <algorithm>
        /// LET macroValue = string empty
        /// IF macroDefinition is contained in macroLabelValue THEN
        ///     LET macroValue = value in macroLabelValue with key is macroDefinition
        /// ELSE
        ///     LET record error ERR000021 into userInterface and exit
        /// IF macroValue is null or empty THEN
        ///     LET record error ERR000022 into userInterface and exit
        /// RETURN macroValue
        /// </algorithm>
        public string GetMacroLabelValue(string macroDefinition)
        {
            string macroValue = String.Empty;
            // Report error if macro definition is not found in translation C Header File.
            if (macroLabelValue.ContainsKey(macroDefinition))
            {
                macroValue = macroLabelValue[macroDefinition];
            }
            else
            {
                // Ref: CMN_GDD_ERR_021
                userInterface.Error(0, 21, Resources.ERR000021, macroDefinition, translationHeaderFilePath);
                userInterface.Exit();
            }
            // Report error if macro label value is empty in translation C Header File.
            if (String.IsNullOrEmpty(macroValue))
            {
                // Ref: CMN_GDD_ERR_022
                userInterface.Error(0, 22, Resources.ERR000022, macroDefinition, translationHeaderFilePath);
                userInterface.Exit();
            }
            else
            {
                // Not required
            }

            return macroValue;
        }
        // Implementation: GENERIC_TUD_CLS_042_011

        /// <summary>
        /// Is register exist
        /// </summary>
        /// <param name="macroDefinition">Macro definition<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The status of checking</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET ret = false
        /// IF macroDefinition is contained in macroLabelValue THEN
        ///     LET ret = true
        /// RETURN ret
        /// </algorithm>
        public bool IsRegisterExist(string macroDefinition)
        {
            bool ret = false;

            if (macroLabelValue.ContainsKey(macroDefinition))
            {
                ret = true;
            }
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_042_012

        /// <summary>
        /// Get macro address type
        /// </summary>
        /// <param name="macroValue">Macro value <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The macro address type</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF macroValue is contained in macroAddressType THEN
        ///     LET addressType = value in macroAddressType with key is macroValue
        /// ELSE
        ///     LET addressType = empty string
        /// RETURN addressType
        /// </algorithm>
        public string GetAddressType(string macroValue)
        {
            string addressType = macroAddressType.ContainsKey(macroValue) ?
                macroAddressType[macroValue] : string.Empty;
            return addressType;
        }
        // Implementation: GENERIC_TUD_CLS_042_009

        /// <summary>
        /// Parse input file and save macro address value
        /// </summary>
        /// <param name="filesInput">File name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_001, CMN_TAD_ERR_037
        /// </ref>
        /// <algorithm>
        /// IF file NOT existed THEN
        ///     LET record error ERR000001 into userInterface and exit
        /// Else
        ///     FOREACH line IN file
        ///         IF line isn't a comment THEN
        ///             LET parse macro value and address
        ///             IF macroAddressValue existed duplication
        ///                 Report ERR000037
        ///             ELSE
        ///                 Add macro value and address to collection macroAddressValue
        ///         End
        ///     End
        /// </algorithm>
        public void SaveMacroAddressValue(string filesInput)
        {
            List<string[]> cache = new List<string[]>();
            IEnumerable<string> files = filesInput.Split().Where(s=>!string.IsNullOrEmpty(s));
            foreach (string fileName in files)
            {
                if (IOWrapper.FileExists(fileName))
                {
                    foreach (string line in IOWrapper.ReadLines(fileName))
                    {
                        if (line.Contains(Constant.IOREG) &&
                            (false == line.Contains("//")) && (false == line.Contains(@"/*")))
                        {
                            string[] lineSplit = Regex.Replace(line, @"[\(,\);\s]+", ",").Split(',');
                            if (lineSplit.Length > Constant.INT_ONE)
                            {
                                cache.Add(lineSplit);
                            }
                            else
                            {
                                // No action required
                            }
                        }
                        else
                        {
                            //No action required
                        }
                    }
                }
                // End of if (File.Exists(fileName)).
                else
                {
                    userInterface.ErrorFileNotFound(fileName);
                }
            }

            // Store device file path that contain address value to report error if have any.
            deviceHeaderFilePath = string.Join(", ", files.ToArray());

            List<string> check = cache
                        .GroupBy(s => s[Constant.INT_ONE],
                                            s => String.Empty)
                        .Where(g => Constant.INT_ONE < g.Count())
                        .Select(g => g.Key).ToList();

            // Checking address value is duplication
            // Report error if one register label in  device C Header File is defined for than one address.
            if (check.Count > 0)
            {
                foreach (string err in check)
                {
                // Error Handling
                // Ref: CMN_GDD_ERR_037
                userInterface.Error(0, 37, Resources.ERR000037,
                                                        err, filesInput);
                }
                userInterface.Exit();
            }
            else
            {
                macroAddressValue = cache
                    .ToDictionary(cell => cell[Constant.INT_ONE].Trim(),
                             cell => (Constant.INT_TWO < cell.Length) ? cell[Constant.INT_TWO].Trim() : String.Empty);
                macroAddressType = cache
                    .ToDictionary(cell => cell[Constant.INT_ONE].Trim(),
                             cell => (4 < cell.Length) ? cell[4].Trim() : String.Empty);
            }
        }
        // Implementation: GENERIC_TUD_CLS_042_013


        /// <summary>
        /// Parse file and save macro label value
        /// </summary>
        /// <param name="fileName">File name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_001, CMN_TAD_ERR_020
        /// </ref>
        /// <algorithm>
        /// If file NOT existed
        ///     Record error ERR000001 and exit
        /// Else
        ///     For each line in file
        ///         If line NOT a comment
        ///             Parse macro label and value
        ///             Add macro label and value to collection macroLabelValue
        ///         End
        ///     End
        ///
        ///     If NO item found in collection macroLabelValue
        ///         Record error ERR000020 and exit
        ///     End
        /// </algorithm>
        public void SaveMacroLabelValue(string fileName)
        {
            List<string[]> cache = null;

            if (IOWrapper.FileExists(fileName))
            {
                // Parse macro value from translation file.
                cache = IOWrapper.ReadAllLines(fileName)
                    .Where(f => f.Contains("#define") &&
                        (false == f.Contains("//")) && (false == f.Contains(@"/*")))
                    .Select(s => Regex.Replace(s, @"\s+", " "))
                    .Select(s => s.Split(' '))
                    .Where(s => (Constant.INT_ONE < s.Length)).ToList();

            } // End of if (File.Exists(fileName)).
            else
            {
                // Ref: CMN_GDD_ERR_001
                userInterface.ErrorFileNotFound(fileName);
            }

            // Save translation file information that contain macro definition
            translationHeaderFilePath = fileName;

            List<string> check = cache
                        .GroupBy(s => s[Constant.INT_ONE],
                                            s => String.Empty)
                        .Where(g => Constant.INT_ONE < g.Count())
                        .Select(g => g.Key).ToList();
            // Check macro value is duplication.
            // Report error if macro label is not unique in translation C Header File.
            if (check.Count > 0)
            {
                foreach (string err in check)
                {
                // Ref: CMN_GDD_ERR_020
                userInterface.Error(0, 20, Resources.ERR000020,
                                                            err, fileName);
                }
                userInterface.Exit();
            }
            else
            {
                macroLabelValue = cache
                    .ToDictionary(cell => cell[Constant.INT_ONE].Trim(),
                            cell => (Constant.INT_TWO < cell.Length) ? cell[Constant.INT_TWO].Trim() : String.Empty);
            }
        }
        // Implementation: GENERIC_TUD_CLS_042_014
    }
}
