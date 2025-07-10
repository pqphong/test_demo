/*====================================================================================================================*/
/* Project      = AUTOSAR Renesas X2x MCAL Components                                                                 */
/* Module       = BaseIntermediate.cs                                                                                 */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2023 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains BaseIntermediate a base class for classes used to calculate intermediate data.         */
/*          It implements ComputeAll method of IIntermediate interface to look up all methods decorated by            */
/*          IntermediateItemAttribute an invoke them to calculate intermediate data.                                  */
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
/*              : class BaseIntermediate                                                                              */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.3:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            19/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.0.4:     31/12/2019 :    Support AR431                                                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    Update method ComputeAutosarVersion                                                     */
/* 1.2.2:     29/09/2022 :    Update method ComputeAutosarVersion for U2Cx                                            */
/* 1.2.3:     25/05/2023 :    Correct method ComputeAutosarVersion for AR R21_11                                      */
/* 1.2.4:     22/09/2023 :    Replace AR21-11 by AR22-11 in GENERIC_TUD_CLS_023_009                                   */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Renesas.Generator.MCALConfGen.Business.Intermediate
{
    /// <summary>
    /// "BaseIntermediate" an abstract class for classes used to calculate intermediate data.
    /// It implements ComputeAll method of IIntermediate interface to look up all methods decorated by
    /// IntermediateItemAttribute and invoke them to calculate intermediate data.
    /// </summary>
    public abstract class BaseIntermediate : IIntermediate
    {
        /// <summary>
        /// To record log information for debugging.
        /// </summary>
        protected ILogger Logger = null;
        // Implementation: GENERIC_TUD_CLS_023_001

        /// <summary>
        /// To provide more convenience operations to upper layers.
        /// </summary>
        protected IRepository Repo = null;
        // Implementation: GENERIC_TUD_CLS_023_002

        /// <summary>
        /// To save and retrive data intermediation.
        /// </summary>
        protected IIntermediateData Interdata = null;
        // Implementation: GENERIC_TUD_CLS_023_003

        /// <summary>
        /// To store the basic information of gentool module.
        /// </summary>
        protected IBasicConfiguration BasicConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_023_004

        /// <summary>
        /// To store all generation settings, e.g. settings of multi-instance.
        /// </summary>
        protected GenerationSettings GenSettings = null;
        // Implementation: GENERIC_TUD_CLS_023_005

        /// <summary>
        /// To initialize a new intermediate data instance.
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
        protected BaseIntermediate() : this
        (
            ObjectFactory.GetInstance<ILogger>(),
            ObjectFactory.GetInstance<IRepository>(),
            ObjectFactory.GetInstance<IIntermediateData>(),
            ObjectFactory.GetInstance<IBasicConfiguration>()
        )
        {
        }
        // Implementation: GENERIC_TUD_CLS_023_007

        /// <summary>
        /// This is constructor of "BaseIntermediate".
        /// </summary>
        /// <param name="logger">Logger <range>null/valid ILogger</range></param>
        /// <param name="repo">Repo <range>null/valid IRepository</range></param>
        /// <param name="interdata">"Intermediate" data <range>null/valid "IIntermediateData"</range></param>
        /// <param name="basicConfig">Basic configuration <range>null/valid IBasicConfiguration</range></param>
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
        protected BaseIntermediate(
            ILogger logger,
            IRepository repo,
            IIntermediateData interdata,
            IBasicConfiguration basicConfig)
        {
            this.Logger = logger;
            this.Repo = repo;
            this.Interdata = interdata;
            this.BasicConfiguration = basicConfig;
            this.GenSettings = new GenerationSettings
            {
                InstanceSetting = new InstanceSetting(basicConfig)
            };
        }
        // Implementation: GENERIC_TUD_CLS_023_008

        /// <summary>
        /// Initialize required attribute.
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
        /// Do nothing
        /// </algorithm>
        protected virtual void Init()
        {
        }
        // Implementation: GENERIC_TUD_CLS_023_010

        /// <summary>
        /// Compute all intermediate data by calling all intermediation methods
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
        /// LET methods = null.
        /// LET methods = return value by CALL GetType().GetMethods WITH all non-public methods that have
        ///                                            IntermediateItem attribute and order by line number position.
        /// FOREACH method in methods
        ///     LET attribute = return value by CALL GetCustomAttribute WITH
        ///                                        attributeType is IntermediateItemAttribute and inherit is false.
        ///     IF attribute is not null THEN
        ///         IF type of BaseIntermediateItem is type of method's returnType THEN
        ///             CALL intermediate methods to get result
        ///             LET store result in intermediate data with DBPath retrieving from IntermediateItem attribute
        /// </algorithm>
        public void ComputeAll()
        {
            IEnumerable<MethodInfo> methods = null;

            Logger.Debug("Init");
            Init();
            Logger.Debug("Compute start");

            // Scan all non-public methods that have IntermediateItem attribute and order by line number position
            methods = GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(method => null != method.GetCustomAttribute<IntermediateItemAttribute>())
                .OrderBy(method => method.GetCustomAttribute<IntermediateItemAttribute>().Line);

            // Regarding to scan result, each method will be invoked with process below:
            // CALL intermediate method to get result
            // Store result in intermediate data with DBPath retrieving from IntermediateItem attribute
            foreach (MethodInfo method in methods)
            {
                IntermediateItemAttribute attribute =
                    (IntermediateItemAttribute)method.GetCustomAttribute(typeof(IntermediateItemAttribute), false);

                // Call methods and get value from return value and store in database.
                // This value is used by Generation component that generate values to output.
                if (typeof(BaseIntermediateItem) == method.ReturnType)
                {
                    Interdata.Store(attribute.DBPath, (BaseIntermediateItem)method.Invoke(this, new object[] { }));
                }
                else if (typeof(BaseIntermediateItem[]) == method.ReturnType)
                {
                    BaseIntermediateItem[] temp = (BaseIntermediateItem[])method.Invoke(this, new object[] { });
                    // Process return value of method is array objects BaseIntermediateItem
                    if (null != temp)
                    {
                        foreach (BaseIntermediateItem item in temp)
                        {
                            Interdata.Store(attribute.DBPath, item);
                        }
                    }
                    else
                    {
                        // Not required
                    }
                } // End of if (typeof(BaseIntermediateItem[]) == method.ReturnType).
                else
                {
                    // Not required
                }
            } // End of foreach (MethodInfo method in methods).
        }
        // Implementation: GENERIC_TUD_CLS_023_006

        /// <summary>
        /// Compute the Autosar Macro value
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem
        ///         <desc>BaseGenerationItem of autosar version value</desc>
        ///         <range>Null/BaseGenerationItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        ///     SET arValue by AR-RELEASE-VERSION from BSWMDT
        ///     IF arValue is 4.2.2
        ///         RETURN value MSN_AR_422_VERSION
        ///     ELSE IF arValue is 4.3.1
        ///         RETURN value MSN_AR_431_VERSION
        ///     ELSE IF arValue is 4.8.0
        ///         RETURN value MSN_AR_R22_11_VERSION
        ///     ELSE
        ///         RETURN null
        /// </algorithm>
        [IntermediateItem(DBPath = "/" + Constant.AUTOSAR_VERSION)]
        protected virtual BaseIntermediateItem ComputeAutosarVersion()
        {
            string arValue = String.Empty;

            switch (BasicConfiguration.AutoSARVersion)
            {
                case Constant.AR_VERSION_4_2_2:
                    arValue = $"{BasicConfiguration.ModuleName.ToUpper()}_AR_422_VERSION";
                    break;
                case Constant.AR_VERSION_4_3_1:
                    arValue = $"{BasicConfiguration.ModuleName.ToUpper()}_AR_431_VERSION";
                    break;
                case Constant.AR_VERSION_22_11:
                    arValue = $"{BasicConfiguration.ModuleName.ToUpper()}_AR_R22_11_VERSION";
                    break;
                default:
                    break;
            }
            string arName = $"{BasicConfiguration.ModuleName.ToUpper()}_{Constant.AUTOSAR_VERSION}";
            return String.IsNullOrEmpty(arValue) ? null :
                new BaseIntermediateItem(arName, arValue);
        }
        // Implementation: GENERIC_TUD_CLS_023_009
         
    }
}
