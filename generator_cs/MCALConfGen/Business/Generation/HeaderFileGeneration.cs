/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = HeaderFileGeneration.cs                                                                             */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains HeaderFileGeneration a base class for classes used to generate .h file.                */
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
/*              : class HeaderFileGeneration                                                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.0.2:     31/12/2019 :    Support AR431                                                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using System;
using System.Collections.Generic;

namespace Renesas.Generator.MCALConfGen.Business.Generation
{
    /// <summary>
    /// "HeaderFileGeneration" a abstract class for classes used to generate .h file.
    /// </summary>
    public abstract class HeaderFileGeneration : FileGeneration
    {

        /// <summary>
        /// Header file generation constructor
        /// </summary>
        /// <param name="fileName">File name <range>null/valid string</range></param>
        /// <param name="outputDirectory">Output directory <range>null/valid string</range></param>
        /// <param name="logger">Logger <range>null/valid ILogger</range></param>
        /// <param name="basicConfiguration">Basic configuration <range>null/valid IBasicConfiguration</range></param>
        /// <param name="runtimeConfiguration">Runtime configuration <range>null/valid IRuntimeConfiguration</range></param>
        /// <param name="intermediateData">"Intermediate" data <range>null/valid "IIntermediateData"</range></param>
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
        protected HeaderFileGeneration
        (
            string fileName,
            string outputDirectory,
            ILogger logger,
            IBasicConfiguration basicConfiguration,
            IRuntimeConfiguration runtimeConfiguration,
            IIntermediateData intermediateData
        ) : base(fileName, outputDirectory, logger, basicConfiguration, runtimeConfiguration, intermediateData)
        {
        }
        // Implementation: GENERIC_TUD_CLS_016_008

        /// <summary>
        /// Generate start macro
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of start macro</desc>
        ///         <range>Null/BaseGenerationItem[]</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate start macro from template
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.START_MACRO)]
        protected virtual BaseGenerationItem[] GenSTART_MACRO()
        {
            string macro = FileName.ToUpper().Replace('.', '_');

            macro = String.Format(Properties.Resources.START_MACRO_TEMPLATE, macro);

            return new BaseGenerationItem[] { new StringGenerationItem(macro) };
        }
        // Implementation: GENERIC_TUD_CLS_016_007

        /// <summary>
        /// Generate global symbols
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of global symbols</desc>
        ///         <range>Null/Empty</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate global symbols. An abstract method overrided by specific module
        /// to provide global symbols information
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.GLOBAL_SYMBOLS)]
        protected virtual BaseGenerationItem[] GenGLOBAL_SYMBOLS()
        {
            return new BaseGenerationItem[] { new StringGenerationItem(String.Empty) };
        }
        // Implementation: GENERIC_TUD_CLS_016_005

        /// <summary>
        /// Generate global data types
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of global data types</desc>
        ///         <range>Null/Empty</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate global data types. An abstract method overrided by specific module
        /// to provide global data types information
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.GLOBAL_DATA_TYPE)]
        protected virtual BaseGenerationItem[] GenGLOBAL_DATA_TYPE()
        {
            return new BaseGenerationItem[] { new StringGenerationItem(String.Empty) };
        }
        // Implementation: GENERIC_TUD_CLS_016_004

        /// <summary>
        /// Generate global data
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of global data</desc>
        ///         <range>Null/Empty </range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate global data. An abstract method overrided by specific module
        /// to provide global data information
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.GLOBAL_DATA)]
        protected virtual BaseGenerationItem[] GenGLOBAL_DATA()
        {
            return new BaseGenerationItem[] { new StringGenerationItem(String.Empty) };
        }
        // Implementation: GENERIC_TUD_CLS_016_003

        /// <summary>
        /// Generate function prototype
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of function prototype</desc>
        ///         <range>Null/Empty</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate function prototype. An abstract method overrided by specific module
        /// to provide function prototype information
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.FUNCTION_PROTOTYPE)]
        protected virtual BaseGenerationItem[] GenFUNCTION_PROTOTYPE()
        {
            return new BaseGenerationItem[] { new StringGenerationItem(String.Empty) };
        }
        // Implementation: GENERIC_TUD_CLS_016_002

        /// <summary>
        /// Generate end macro
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of end macro</desc>
        ///         <range>Null/BaseGenerationItem[]</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate end macro. An abstract method overrided by specific module
        /// to provide end macro information
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.END_MACRO)]
        protected virtual BaseGenerationItem[] GenEND_MACRO()
        {
            string macro = FileName.ToUpper().Replace('.', '_');

            macro = String.Format(Properties.Resources.END_MACRO_TEMPLATE, macro);

            return new BaseGenerationItem[] { new StringGenerationItem(macro) };
        }
        // Implementation: GENERIC_TUD_CLS_016_001

        /// <summary>
        /// Generate revision history
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of revision history</desc>
        ///         <range>Null/Empty</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate revision history. An abstract method overrided by specific module
        /// to provide revision history information
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.REVISION_HISTORY, SectionOrder = 0)]
        protected virtual BaseGenerationItem[] GenREVISION_HISTORY()
        {
            return new BaseGenerationItem[] { new StringGenerationItem(String.Empty) };
        }
        // Implementation: GENERIC_TUD_CLS_016_006
    }
}
