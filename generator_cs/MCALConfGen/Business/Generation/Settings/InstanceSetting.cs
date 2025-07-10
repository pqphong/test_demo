/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = InstanceSetting.cs                                                                                  */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains InstanceSetting class that is used to store all settings of multi-instance             */
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
/*              : class InstanceSetting                                                                               */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            19/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    Add new method AppendSuffixToMacro and property BasicConfig                             */
/*            16/07/2021 :    Update pseudo code for AppendSuffixToMacro and GetInstanceSuffix                        */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using System;
using static Renesas.Generator.MCALConfGen.Data.BasicConfiguration.BasicConfiguration;

namespace Renesas.Generator.MCALConfGen.Business.Generation.Settings
{
    /// <summary>
    /// "InstanceSetting" class that is used to store all settings of multi-instance
    /// </summary>
    public class InstanceSetting
    {

        /// <summary>
        /// Property of instance checking.
        /// </summary>
        public bool IsMultiInstance { get; set; }
        // Implementation: GENERIC_TUD_CLS_021_001

        /// <summary>
        /// Property of instance index value
        /// </summary>
        public int InstanceIndex { get; set; }
        // Implementation: GENERIC_TUD_CLS_021_002

        /// <summary>
        /// Property of Basic config
        /// </summary>
        protected IBasicConfiguration BasicConfig = ObjectFactory.GetInstance<IBasicConfiguration>();
        // Implementation: GENERIC_TUD_CLS_021_005

        /// <summary>
        /// Constructor of InstanceSetting
        /// </summary>
        public InstanceSetting(IBasicConfiguration basicConfiguration)
        {
            IsMultiInstance = basicConfiguration.HasInstanceSetting;
            InstanceIndex = basicConfiguration.InstanceIndex;
            BasicConfig = basicConfiguration;
        }
        // Implementation: GENERIC_TUD_CLS_021_007

        /// <summary>
        /// Return Instance suffix value in case module run with multi instance set.
        /// </summary>
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
        /// RETURN BasicConfig.ToInstanceValue() with input is type
        /// </algorithm>
        public string GetInstanceSuffix(AppendType type = AppendType.FULL_UPPER)
        {
            return BasicConfig.ToInstanceValue(type);
        }
        // Implementation: GENERIC_TUD_CLS_021_004

        /// <summary>
        /// Return macro name with suffix in case module run with multi instance set.
        /// </summary>
        /// <param name="macro">Name of macro<range>valid string/empty</range></param>
        /// <param name="type">Type<range>valid enum AppendType</range></param>
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
        /// RETURN BasicConfig.AppendInstanceToMacro(macro)
        /// </algorithm>
        public string AppendSuffixToMacro(string macro, AppendType type = AppendType.FULL_UPPER)
        {
            return BasicConfig.AppendInstanceToMacro(macro, type);
        }
        // Implementation: GENERIC_TUD_CLS_021_006
    }
}
