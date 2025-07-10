/*====================================================================================================================*/
/* Project      = AUTOSAR Renesas X2x MCAL Components                                                                 */
/* Module       = BasicConfigurationLoader.cs                                                                         */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2017-2019 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains BasicConfigurationLoader abstract class that is used by ObjectFactory to get a new     */
/*          BasicConfiguration object.                                                                                */
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
/*              : class BasicConfigurationLoader                                                                      */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* V1.0.0:    20-Sep-2017   : Initial Version                                                                         */
/* V1.0.1:    01-Oct-2018   : Add reference of GENERIC_GDD_FST_001                                                    */
/*            28-Nov-2018   : Add class summary as NES's finding                                                      */
/* V1.0.2:    04-Jun-2019   : Update copyright information format in header comment                                   */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
/* References: GENERIC_GDD_FST_001 */

using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

namespace Renesas.Generator.MCALConfGen.Business.ConfigurationLoader
{
    /// <summary>
    /// BasicConfiguration instance used by ObjectFactory to get a new BasicConfiguration object.
    /// </summary>
    public abstract class BasicConfigurationLoader : IBasicConfigurationLoader
    {
        /// <summary>
        /// Basic configuration
        /// </summary>
        protected IBasicConfiguration BasicConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_004_001

        /// <summary>
        /// Basic configuration loader constructor
        /// </summary>
        /// <returns>
        ///     None
        ///     <range> None </range>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        ///
        /// </algorithm>
        protected BasicConfigurationLoader() : this(ObjectFactory.GetIntance<IBasicConfiguration>())
        {
        }
        // Implementation: GENERIC_TUD_CLS_004_003

        /// <summary>
        /// Basic configuration loader constructor
        /// </summary>
        /// <param name="basicConfiguration">Basic configuration <range>None</range></param>
        /// <returns>
        ///     None
        ///     <range> None </range>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        ///
        /// </algorithm>
        protected BasicConfigurationLoader(IBasicConfiguration basicConfiguration)
        {
            this.BasicConfiguration = basicConfiguration;
        }
        // Implementation: GENERIC_TUD_CLS_004_004

        /// <summary>
        /// Load configuration, an abstract method to be override by
        /// specific module to provide basic configuration information
        /// </summary>
        /// <returns>
        ///     return a void
        ///     <range> None </range>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        ///
        /// </algorithm>
        public virtual void LoadConfiguration()
        {
        }
        // Implementation: GENERIC_TUD_CLS_004_002
    }
}
