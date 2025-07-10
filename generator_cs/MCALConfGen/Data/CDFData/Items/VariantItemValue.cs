/*====================================================================================================================*/
/* Project      = RH850/X2x MCAL Development                                                                          */
/* Module       = ItemValue.cs                                                                                        */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2024,2025 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains ItemValue class that stores information of                                             */
/*          - Parameter value specified by CDF tag <POST-BUILD-VARIANT-CONDITION>/<VALUE>                             */
/*          - Reference value specified by CDF tag <POST-BUILD-VARIANT-CRITERION-VALUE-SET>/<SHORT-NAME>              */
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
/*              : class VariantItemValue                                                                              */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     27/01/2024 :    Initial Version                                                                         */
/* 1.0.1:     26/03/2024 :    Change method name: Value() to InternalValue()                                          */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001


namespace Renesas.Generator.MCALConfGen.Data.CDFData.Items
{
    public class VariantItemValue
    {
        /// <summary>
        /// This field store Definition reference of a tag <VALUE> inside tag <POST-BUILD-VARIANT-CONDITION>
        /// </summary>
        private string variantID;
        // Implementation: GENERIC_TUD_CLS_054_001

        /// <summary>
        /// This field store Value of a tag <SHORT-NAME> inside tag <POST-BUILD-VARIANT-CRITERION-VALUE-SET>
        /// </summary>
        private object value;
        // Implementation: GENERIC_TUD_CLS_054_002

        /// <summary>
        /// Variant Item value constructor
        /// </summary>
        /// <param name="variantID">Definition variant ID of variant<range>null/valid string</range></param>
        /// <param name="value">Value<range>null/valid object</range></param>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// </algorithm>
        public VariantItemValue(string variantID, object value)
        {
            this.variantID = variantID;
            this.value = value;
        }
        // Implementation: GENERIC_TUD_CLS_054_003

        /// <summary>
        /// This function return variantID of configured variant
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>variantID</desc>
        ///         <range>empty/valid vaule</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN variantID
        /// </algorithm>
        public string VariantID()
        {
            return variantID;
        }
        // Implementation: GENERIC_TUD_CLS_054_004

        /// <summary>
        /// This function return Value of Variant Name
        /// </summary>
        /// <returns>
        ///     <para>Type of value
        ///         <desc>value of reference</desc>
        ///         <range>null/valid vaule</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN value
        /// </algorithm>
        public object InternalValue()
        {
            return value;
        }
        // Implementation: GENERIC_TUD_CLS_054_005

        /// <summary>
        /// This function return Value of reference
        /// </summary>
        /// <returns>
        ///     <para>Type of value
        ///         <desc>value of reference</desc>
        ///         <range>null/valid vaule</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN value
        /// </algorithm>
        public T Value<T>()
        {
            return (T)value;
        }
        // Implementation: GENERIC_TUD_CLS_054_006

    }
}
