/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = Generation.cs                                                                                       */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains Generation class that look up all classes used to generate .h and .c files             */
/*          and call their GenerateFile method.                                                                       */
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
/*              : class Generation                                                                                    */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.2:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            19/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

namespace Renesas.Generator.MCALConfGen.Business.Generation
{
    /// <summary>
    /// "Generation" class that look up all classes used to generate .h and .c files and call their GenerateFile method.
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    public class Generation : IGeneration
    {
        /// <summary>
        /// "Generation" instance used by ObjectFactory to get a new Generation object
        /// </summary>
        public static readonly Generation Instance = new Generation();
        // Implementation: GENERIC_TUD_CLS_006_001

        /// <summary>
        /// To record log information for debugging.
        /// </summary>
        private ILogger logger = null;
        // Implementation: GENERIC_TUD_CLS_006_002

        /// <summary>
        /// To store the basic information of gentool module.
        /// </summary>
        private IBasicConfiguration basicConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_006_003

        /// <summary>
        /// To define information processed by command line.
        /// </summary>
        private IRuntimeConfiguration runtimeConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_006_004

        /// <summary>
        /// To save and retrive data intermediation.
        /// </summary>
        private IIntermediateData intermediateData = null;
        // Implementation: GENERIC_TUD_CLS_006_005

        /// <summary>
        /// "Generation" constructor
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
        private Generation() : this
        (
            ObjectFactory.GetInstance<ILogger>(),
            ObjectFactory.GetInstance<IBasicConfiguration>(),
            ObjectFactory.GetInstance<IRuntimeConfiguration>(),
            ObjectFactory.GetInstance<IIntermediateData>()
        )
        {
        }
        // Implementation: GENERIC_TUD_CLS_006_007

        /// <summary>
        /// "Generation" constructor
        /// </summary>
        /// <param name="logger">Logger <range>null/valid ILogger</range></param>
        /// <param name="basicConfiguration">Basic configuration <range>null/valid IBasicConfiguration</range></param>
        /// <param name="runtimeConfiguration">Runtime configuration <range>null/valid IRuntimeConfiguration</range></param>
        /// <param name="intermediateData">"Intermediate" data <range>null/valid IIntermediateData</range></param>
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
        private Generation
        (
            ILogger logger,
            IBasicConfiguration basicConfiguration,
            IRuntimeConfiguration runtimeConfiguration,
            IIntermediateData intermediateData
        )
        {
            this.logger = logger;
            this.basicConfiguration = basicConfiguration;
            this.runtimeConfiguration = runtimeConfiguration;
            this.intermediateData = intermediateData;
        }
        // Implementation: GENERIC_TUD_CLS_006_008

        /// <summary>
        /// "Generate" all output files
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
        /// LET allFiles = ObjectFactory.GetInstances<IFileGeneration>() to get all instances having interface IFileGeneration
        /// IF allFiles is not null THEN
        ///     FOREACH file IN allFiles
        ///         CALL file.GenerateFile() to generate file
        /// ELSE
        ///     Do nothing
        /// </algorithm>
        public void GenerateOuput()
        {
            IFileGeneration[] allFiles = ObjectFactory.GetInstances<IFileGeneration>();
            if (allFiles != null)
            {
                // Generate all files .h, .c
                foreach (IFileGeneration file in allFiles)
                {
                    file.GenerateFile();
                }
            }
            else
            {
                // Not required
            }

        }
        // Implementation: GENERIC_TUD_CLS_006_006
    }
}
