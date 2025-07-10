/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = IntermediateData.cs                                                                                 */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains IntermediateData class to implement IIntermediateData interface to save and retrive    */
/*          intermediate data.                                                                                        */
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
/*              : class IntermediateData                                                                              */
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

using System;
using System.Collections.Generic;
using System.Linq;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

namespace Renesas.Generator.MCALConfGen.Data.IntermediateData
{
    /// <summary>
    /// This intermediateData class to implement iIntermediateData interface to save and retrive
    /// intermediate data.
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    public class IntermediateData : IIntermediateData
    {
        /// <summary>
        /// intermediateData instance used by objectFactory to get a new intermediateData object
        /// </summary>
        public static readonly IntermediateData Instance = new IntermediateData();
        // Implementation: GENERIC_TUD_CLS_049_001

        /// <summary>
        /// Root
        /// </summary>
        private BaseIntermediateItem root = new BaseIntermediateItem("root", String.Empty);
        // Implementation: GENERIC_TUD_CLS_049_002

        /// <summary>
        /// intermediate data constructor
        /// </summary>
        /// <returns>
        ///     None
        ///     <range> None </range>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Init component
        /// </algorithm>
        public IntermediateData() { }
        // Implementation: GENERIC_TUD_CLS_049_006

        /// <summary>
        /// Get root
        /// </summary>
        /// <returns>
        ///     <para>baseIntermediateItem
        ///         <desc>intermediate data</desc>
        ///         <range>null/valid baseIntermediateItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Return root BaseIntermediateItem
        /// </algorithm>
        public BaseIntermediateItem GetRoot()
        {
            return root;
        }
        // Implementation: GENERIC_TUD_CLS_049_004

        /// <summary>
        /// Get string data by path
        /// </summary>
        /// <param name="path">Path <range>null/valid string</range></param>
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
        /// Get string data by path from root BaseIntermediateItem
        /// </algorithm>
        public string GetStringDataByPath(string path)
        {
            return root.GetStringDataByPath(path);
        }
        // Implementation: GENERIC_TUD_CLS_049_005

        /// <summary>
        /// Get item by path
        /// </summary>
        /// <param name="path">Path <range>null/valid string</range></param>
        /// <returns>
        ///     <para>baseIntermediateItem
        ///         <desc>intermediate data</desc>
        ///         <range>null/valid baseIntermediateItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get BaseIntermediateItem by path from root BaseIntermediateItem
        /// </algorithm>
        public BaseIntermediateItem GetItemByPath(string path)
        {
            return root.GetItemByPath(path);
        }
        // Implementation: GENERIC_TUD_CLS_049_003

        /// <summary>
        /// Store baseIntermediateItem into root
        /// </summary>
        /// <param name="path">Path <range>empty/valid string</range></param>
        /// <param name="target">Target <range>null/valid BaseIntermediateItem</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Store BaseIntermediateItem with path into root
        /// </algorithm>
        public void Store(string path, BaseIntermediateItem target)
        {
            root.Store(path, target);
        }
        // Implementation: GENERIC_TUD_CLS_049_007
    }
}
