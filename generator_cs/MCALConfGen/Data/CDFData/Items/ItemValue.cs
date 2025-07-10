/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = ItemValue.cs                                                                                        */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains ItemValue class that stores information of                                             */
/*          - Parameter value specified by CDF tag ECUC-TEXTUAL-PARAM-VALUE or ECUC-NUMERICAL-PARAM-VALUE             */
/*          - Reference value specified by CDF tag ECUC-REFERENCE-VALUE                                               */
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
/*              : class ItemValue                                                                                     */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 2.0.1:     07/02/2024 :    To support multiple post build variant:                                                 */
/*                            - Add new parameter variant in class ItemValue                                          */
/*                            - Add new method ItemValue(string definitionRef, object value,                          */
/*                              List<VariantItemValue> variant) to support post build variant parameter               */
/*                            - Add new method getVariantIDs, getListVariantIDs, getVariantItem, addVariantValue      */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System.Collections.Generic;
using System.Linq;

namespace Renesas.Generator.MCALConfGen.Data.CDFData.Items
{
    /// <summary>
    /// This class stores information of
    /// Parameter value specified by CDF tag ECUC-TEXTUAL-PARAM-VALUE or ECUC-NUMERICAL-PARAM-VALUE
    /// Reference value specified by CDF tag ECUC-REFERENCE-VALUE
    /// </summary>
    public class ItemValue
    {
        /// <summary>
        /// This field store Definition reference of a ECUC-REFERENCE-VALUE
        /// </summary>
        private string definitionRef;
        // Implementation: GENERIC_TUD_CLS_047_001

        /// <summary>
        /// This field store Value of reference of a ECUC-REFERENCE-VALUE
        /// </summary>
        private object value;
        // Implementation: GENERIC_TUD_CLS_047_002

        /// <summary>
        /// This field store Variant point of post build configuration of a VARIATION-POINT
        /// </summary>
        private List<VariantItemValue> variant = new List<VariantItemValue>();
        // Implementation: GENERIC_TUD_CLS_047_007

        /// <summary>
        /// Item value constructor
        /// </summary>
        /// <param name="definitionRef">Definition reference<range>null/valid string</range></param>
        /// <param name="value">Value<range>null/valid object</range></param>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// </algorithm>
        public ItemValue(string definitionRef, object value)
        {
            this.definitionRef = definitionRef;
            this.value = value;
        }
        // Implementation: GENERIC_TUD_CLS_047_004

        /// <summary>
        /// Item value constructor for Post Build Multi Configuration
        /// </summary>
        /// <param name="definitionRef">Definition reference<range>null/valid string</range></param>
        /// <param name="value">Value<range>null/valid object</range></param>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// </algorithm>
        public ItemValue(string definitionRef, object value, List<VariantItemValue> variant)
        {
            this.definitionRef = definitionRef;
            this.value = value;
            this.variant = variant;
        }
        // Implementation: GENERIC_TUD_CLS_047_008

        /// <summary>
        /// This function return Definition reference
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>Definition reference</desc>
        ///         <range>empty/valid vaule</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN definitionRef
        /// </algorithm>
        public string DefinitionRef()
        {
            return definitionRef;
        }
        // Implementation: GENERIC_TUD_CLS_047_003

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
        // Implementation: GENERIC_TUD_CLS_047_005
        }

        /// <summary>
        /// This function return Value of reference
        /// </summary>
        /// <returns>
        ///     <para>object
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
        internal object InternalValue()
        {
            return value;
        }
        // Implementation: GENERIC_TUD_CLS_047_006

        /// <summary>
        /// This function return Value of reference
        /// </summary>
        /// <returns>
        ///     <para>object
        ///         <desc>value of reference</desc>
        ///         <range>null/valid vaule</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN variant
        /// </algorithm>
        public List<VariantItemValue> getVariantIDs()
        {
            return variant;
        }
        // Implementation: GENERIC_TUD_CLS_047_009

        /// <summary>
        /// This function return List variant ID of object
        /// </summary>
        /// <returns>
        ///     <para>object
        ///         <desc>value of reference</desc>
        ///         <range>null/valid vaule</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN list of VariantID
        /// </algorithm>
        public List<string> getListVariantIDs()
        {
            List<string> ret = new List<string>();

            ret = variant.Select(x => x.VariantID()).ToList();

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_047_010

        /// <summary>
        /// This function return Value of reference
        /// </summary>
        /// <returns>
        ///     <para>object
        ///         <desc>value of reference</desc>
        ///         <range>null/valid vaule</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN a VariantItemValue
        /// </algorithm>
        public VariantItemValue getVariantItem(string variantID)
        {
            VariantItemValue ret = null;

            ret = variant.Find(x => x.VariantID() == variantID);

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_047_011

        /// <summary>
        /// This method to support add new variant to support for Multi post build configuration
        /// </summary>
        /// <returns>
        ///     <para>object
        ///         <desc>value of reference</desc>
        ///         <range>null/valid vaule</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET value = null
        /// Add variant to object
        /// </algorithm>
        public void addVariantValue(VariantItemValue variant)
        {
            //// Set value of main container is null, when multi post build variant have been configured
            value = null;

            this.variant.Add(variant);
        }
        // Implementation: GENERIC_TUD_CLS_047_012
    }
}
