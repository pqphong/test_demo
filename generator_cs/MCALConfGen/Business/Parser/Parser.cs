/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = Parser.cs                                                                                           */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains abstract Parser class that provide abstract methods and is implemented by              */
/* specific module                                                                                                    */
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
/*              : class Parser                                                                                        */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     18/02/2019 :    Initial Version                                                                         */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001


namespace Renesas.Generator.MCALConfGen.Business.Parser
{
    /// <summary>
    /// This is abstract class that is used as template method and is concreted implement by other class.
    /// </summary>
    public abstract class Parser : IParser
    {
        /// <summary>
        /// This abstract method is used to parse CDF files include CDF, BSW
        /// </summary>
        public abstract void ParseCDFs();
        // Implementation: GENERIC_TUD_CLS_024_003
        /// <summary>
        /// This abstract method is used to parse CDF files include Translation File.
        /// </summary>
        public abstract void ParseTranslationFile();
        // Implementation: GENERIC_TUD_CLS_024_004
        /// <summary>
        /// This abstract method is used to check required modules
        /// </summary>
        public abstract void CheckRequiredModules();
        // Implementation: GENERIC_TUD_CLS_024_001
        /// <summary>
        /// This abstract method is used to load CDF files include CDF, BSW, Translation File.
        /// </summary>
        public abstract void LoadFile();
        // Implementation: GENERIC_TUD_CLS_024_002
        /// <summary>
        /// This abstract method is used to update basic configuration
        /// </summary>
        public abstract void UpdateBasicConfigurationIfNeeded();
        // Implementation: GENERIC_TUD_CLS_024_006

        /// <summary>
        /// Outline algorithm parse and validate CDFs in Autosar
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
        ///     None
        ///
        /// GLOBAL VARIABLE OUT:
        ///     None
        ///
        /// PRECONDITION:
        ///     None
        ///
        /// LET CALL LoadFile to load  XDocuments from CDF file paths.
        /// LET CALL ParseCDFs to parse all CDF and BSW files.
        /// LET CALL CheckRequiredModules to validate necessary module CDF.
        /// LET CALL ParseTranslationFile to check required modules and parse translation files.
        /// LET CALL UpdateBasicConfigurationIfNeeded to update information used for Object Factory.
        /// </algorithm>
        public virtual void RunAll()
        {
            LoadFile();
            ParseCDFs();
            CheckRequiredModules();
            ParseTranslationFile();
            UpdateBasicConfigurationIfNeeded();
        }
        // Implementation: GENERIC_TUD_CLS_024_005
    }
}
