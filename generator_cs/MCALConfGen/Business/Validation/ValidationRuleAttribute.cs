/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = ValidationRuleAttribute.cs                                                                          */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains ValidationRuleAttribute class that decorates methods which will be invoked to          */
/*          validate rules.                                                                                           */
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
/*              : class ValidationRuleAttribute                                                                       */
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

using System;
using System.Runtime.CompilerServices;

namespace Renesas.Generator.MCALConfGen.Business.Validation
{
    /// <summary>
    /// This class decorates methods which will be invoked to
    /// validate rules
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class ValidationRuleAttribute : Attribute
    {
        /// <summary>
        /// Flag to validate the process of Gentool is pre-intermetiate.
        /// </summary>
        private bool preIntermediationValidation = false;
        // Implementation: GENERIC_TUD_CLS_028_006

        /// <summary>
        /// Flag to validate the process of Gentool is post-intermetiate.
        /// </summary>
        private bool postIntermediationValidation = false;
        // Implementation: GENERIC_TUD_CLS_028_007

        /// <summary>
        /// Flag to validate the process of Gentool, continue with any failure.
        /// </summary>
        private bool continueIfFailed = false;
        // Implementation: GENERIC_TUD_CLS_028_008

        /// <summary>
        /// Property of flag to validate the process of Gentool is pre-intermetiate.
        /// </summary>
        public bool PreIntermediationValidation
        {
            get { return preIntermediationValidation; }

            set { preIntermediationValidation = value; }
        }
        // Implementation: GENERIC_TUD_CLS_028_001

        /// <summary>
        /// Property of flag to validate the process of Gentool is post-intermetiate.
        /// </summary>
        public bool PostIntermediationValidation
        {
            get { return postIntermediationValidation; }
            set { postIntermediationValidation = value; }
        }
        // Implementation: GENERIC_TUD_CLS_028_002

        /// <summary>
        /// Property of flag to validate the process of Gentool, continue with any failure.
        /// </summary>
        public bool ContinueIfFailed
        {
            get { return continueIfFailed; }
            set { continueIfFailed = value; }
        }
        // Implementation: GENERIC_TUD_CLS_028_003

        /// <summary>
        /// Property of validation in method order
        /// </summary>
        public float Order { get; set; } = 0;
        // Implementation: GENERIC_TUD_CLS_028_004

        /// <summary>
        /// "Validation" rule attribute constructor
        /// </summary>
        /// <param name="order">Provide order that is in method order <range>float</range></param>
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
        public ValidationRuleAttribute(float order = 0)
        {
            Order = order;
        }
        // Implementation: GENERIC_TUD_CLS_028_009

        /// <summary>
        /// "Validation" rule attribute constructor
        /// </summary>
        /// <param name="preIntermediationValidation">Pre intermediation validation <range>true/false</range></param>
        /// <param name="postIntermediationValidation">Post intermediation validation <range>true/false</range></param>
        /// <param name="continueIfFailed">Continue if failed <range>true/false</range></param>
        /// <param name="enableMethod">Flag to enable debugger method <range>true/false</range></param>
        /// <param name="order">Provide order that is in method order <range>float</range></param>
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
        public ValidationRuleAttribute
        (
            bool preIntermediationValidation,
            bool postIntermediationValidation,
            bool continueIfFailed,
            bool enableMethod = true,
            float order = 0
        )
        {
            this.preIntermediationValidation = preIntermediationValidation;
            this.postIntermediationValidation = postIntermediationValidation;
            this.continueIfFailed = continueIfFailed;
            EnableMethod = enableMethod;
            Order = order;
        }
        // Implementation: GENERIC_TUD_CLS_028_010

        /// <summary>
        /// Property of flag to enable debugger method
        /// </summary>
        public bool EnableMethod { get; set; } = true;
        // Implementation: GENERIC_TUD_CLS_028_005

    }
}
