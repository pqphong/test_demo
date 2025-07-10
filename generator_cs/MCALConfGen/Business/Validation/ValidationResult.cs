/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = ValidationResult.cs                                                                                 */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains ValidationResult class that is returned by validation methods decorated by             */
/*          ValidationRuleAttribute in validation class.                                                              */
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
/*              : class ValidationResult                                                                              */
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

namespace Renesas.Generator.MCALConfGen.Business.Validation
{
    /// <summary>
    /// This class contain result information of validation such code error, error message,
    /// module id, type, success, isError.
    /// </summary>
    public class ValidationResult
    {
        /// <summary>
        /// Property to define code for error/wrn/inf.
        /// </summary>
        public int Code { get; set; }
        // Implementation: GENERIC_TUD_CLS_027_001

        /// <summary>
        /// Property of message list to store the message for error/wrn/inf.
        /// </summary>
        public List<string> Message { get; set; } = new List<string>();
        // Implementation: GENERIC_TUD_CLS_027_002

        /// <summary>
        /// Property of specific module id, which was defined by AUTOSAR.
        /// </summary>
        public int ModuleId { get; set; }
        // Implementation: GENERIC_TUD_CLS_027_003

        /// <summary>
        /// Property of the message type such as error/wrn/inf.
        /// </summary>
        public MessageType Type { get; set; }
        // Implementation: GENERIC_TUD_CLS_027_004

        /// <summary>
        /// Check if this is an error result
        /// </summary>
        /// <returns>
        ///     <para>bool
        ///         <desc>The checking result</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF Type is NOT SUCCESS THEN
        ///     RETURN true
        /// Else
        ///     RETURN false
        /// </algorithm>
        public bool IsError()
        {
            return (MessageType.SUCCESS != Type);
        }
        // Implementation: GENERIC_TUD_CLS_027_007

        /// <summary>
        /// This enum is used to declare type of validation result
        /// </summary>
        public enum MessageType
        {
            SUCCESS,
            ERROR,
            WARN,
            INFO
        }
        // Implementation: CMN_TUD_DTT_002

        /// <summary>
        /// Property of SUCCESS result.
        /// </summary>
        public static ValidationResult Success { get { return new ValidationResult(); } }
        // Implementation: GENERIC_TUD_CLS_027_005

        /// <summary>
        /// "Validation" result constructor with only type.
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
        public ValidationResult()
        {
            Type = MessageType.SUCCESS;
        }
        // Implementation: GENERIC_TUD_CLS_027_008

        /// <summary>
        /// "Validation" result constructor with code and type.
        /// </summary>
        /// <param name="code">Code <range>integer</range></param>
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
        public ValidationResult(int code)
        {
            Code = code;
            Type = MessageType.SUCCESS;
        }
        // Implementation: GENERIC_TUD_CLS_027_009

        /// <summary>
        /// "Validation" result constructor full option.
        /// </summary>
        /// <param name="type">Type <range>MessageType</range></param>
        /// <param name="code">Code <range>integer</range></param>
        /// <param name="moduleId">Module id <range>integer</range></param>
        /// <param name="msgFormat">Message format <range>string</range></param>
        /// <param name="param">Parameters to fill in message format <range>null/!null</range></param>
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
        public ValidationResult(MessageType type, int code, int moduleId, string msgFormat, params object [] param)
        {
            Code = code;
            ModuleId = moduleId;
            Type = type;
            Message.Add(String.Format(msgFormat, param));
        }
        // Implementation: GENERIC_TUD_CLS_027_010

        /// <summary>
        /// Add new message constructed from message format
        /// </summary>
        /// <param name="msgFormat">Message format <range>string</range></param>
        /// <param name="param">Parameters to fill in message format <range>null/!null</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Add new message constructed from format and parameters to a list
        /// </algorithm>
        public void AddMessage(string msgFormat, params object[] param)
        {
            Message.Add(String.Format(msgFormat, param));
        }
        // Implementation: GENERIC_TUD_CLS_027_006
    }
}
