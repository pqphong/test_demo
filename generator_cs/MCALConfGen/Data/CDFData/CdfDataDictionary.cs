/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = CdfDataDictionary.cs                                                                                */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains CdfDataDictionary class that implements ICdfData interface to save and retrive         */
/*          infomration of CDF files.                                                                                 */
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
/*              : class CdfDataDictionary                                                                             */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            21/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    Update method GetBswConfiguration, SaveBswConfiguration, property bswConfigs            */
/*                            Add new method GetCurrentInstanceBswConfig                                              */
/* 1.2.2:     06/03/2024 :    Add GENERIC_TUD_CLS_043_028 - GENERIC_TUD_CLS_043_036                                   */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Renesas.Generator.MCALConfGen.Data.CDFData
{
    /// <summary>
    /// This CdfDataDictionary class that implements ICdfData interface to save and retrive
    /// infomration of CDF files.
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    class CdfDataDictionary : ICdfData
    {
        /// <summary>
        /// "CdfDataDictionary" instance used by "ObjectFactory" to get a new "CdfDataDictionary" object
        /// </summary>
        public static readonly CdfDataDictionary Instance = new CdfDataDictionary();
        // Implementation: GENERIC_TUD_CLS_043_001

        /// <summary>
        /// A 2-levels dictionary current context which store multiple instances data
        ///     Instance short name 1 --------- Container Short Name 1 --------- Container Object 1
        ///                           +-------- Container Short Name 2 --------- Container Object 2
        ///     Instance short name 2 --------- Container Short Name 3 --------- Container Object 3
        ///                           +-------- Container Short Name 4 --------- Container Object 4
        /// </summary>
        private Dictionary<string, Dictionary<string, Container>> dataContext =
            new Dictionary<string, Dictionary<string, Container>>();
        // Implementation: GENERIC_TUD_CLS_043_002

        /// <summary>
        /// This field store current Instance Index
        /// </summary>
        private int currentInstanceIndex = -1;
        // Implementation: GENERIC_TUD_CLS_043_003

        /// <summary>
        /// Mapping between 1 moduleName --------- n instances Shortname
        /// </summary>
        private Dictionary<string, List<string>> moduleInstances = new Dictionary<string, List<string>>();
        // Implementation: GENERIC_TUD_CLS_043_004

        /// <summary>
        /// This field store configurations
        /// </summary>
        private Dictionary<string, Configuration> configurations = new Dictionary<string, Configuration>();
        // Implementation: GENERIC_TUD_CLS_043_005

        /// <summary>
        /// This field store CDF files
        /// </summary>
        private Dictionary<string, string> cdfFiles = new Dictionary<string, string>();
        // Implementation: GENERIC_TUD_CLS_043_006

        /// <summary>
        /// This field store Basic software configuration
        /// </summary>
        private Dictionary<string, List<BswConfig>> bswConfigs = new Dictionary<string, List<BswConfig>>();
        // Implementation: GENERIC_TUD_CLS_043_007

        /// <summary>
        /// This field store Evaluated Variant Set
        /// </summary>
        private Dictionary<string, string> EvaluatedVariantSet = new Dictionary<string, string>();
        // Implementation: GENERIC_TUD_CLS_043_028

        /// <summary>
        /// This field store Variant Criterion Set
        /// </summary>
        private string VariantCriterionSet;
        // Implementation: GENERIC_TUD_CLS_043_029

        /// <summary>
        /// This field store Variant Criterion of Module
        /// </summary>
        private string VariantCriterionModuleConfig;
        // Implementation: GENERIC_TUD_CLS_043_030

        /// <summary>
        /// Cdf data dictionary constructor
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
        private CdfDataDictionary()
        {
        }
        // Implementation: GENERIC_TUD_CLS_043_022

        /// <summary>
        /// Perform save variant criterion set
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Configuration
        ///         <desc>The module configuration</desc>
        ///         <range>null/found config object</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET VariantCriterionSet = variantcriterion
        /// </algorithm>
        public void SaveVariantCriterionSet(string variantcriterion)
        {
            VariantCriterionSet = variantcriterion;
        }
        // Implementation: GENERIC_TUD_CLS_043_031

        /// <summary>
        /// Get Variant criterion set
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Configuration
        ///         <desc>The module configuration</desc>
        ///         <range>null/found config object</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF found moduleName (or "{moduleName}d*$") in configurations THEN
        ///     RETURN found configuration
        /// Return null
        /// </algorithm>
        public string GetVariantCriterionSet()
        {
            return VariantCriterionSet;
        }
        // Implementation: GENERIC_TUD_CLS_043_032

        /// <summary>
        /// Perform save variant criterion module configuration
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Configuration
        ///         <desc>The module configuration</desc>
        ///         <range>null/found config object</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET VariantCriterionModuleConfig = variantcriterion
        /// </algorithm>
        public void SaveVariantCriterionModuleConfig(string variantcriterion)
        {
            VariantCriterionModuleConfig = variantcriterion;
        }
        // Implementation: GENERIC_TUD_CLS_043_033

        /// <summary>
        /// Get variant criterion module configuration
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Configuration
        ///         <desc>The module configuration</desc>
        ///         <range>null/found config object</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN VariantCriterionModuleConfig
        /// </algorithm>
        public string GetVariantCriterionModuleConfig()
        {
            return VariantCriterionModuleConfig;
        }
        // Implementation: GENERIC_TUD_CLS_043_034

        /// <summary>
        /// Perform save evaluated variant set
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Configuration
        ///         <desc>The module configuration</desc>
        ///         <range>null/found config object</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Add variantname and variantvalue the store of EvaluatedVariantSet
        /// </algorithm>
        public void SaveEvaluatedVariantSet(string variantname, string variantvalue)
        {
            EvaluatedVariantSet.Add(variantname, variantvalue);
        }
        // Implementation: GENERIC_TUD_CLS_043_035

        /// <summary>
        /// Get evaluated variant set
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Configuration
        ///         <desc>The module configuration</desc>
        ///         <range>null/found config object</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN EvaluatedVariantSet
        /// </algorithm>
        public Dictionary<string,string> GetEvaluatedVariantSet()
        {
            return EvaluatedVariantSet;
        }
        // Implementation: GENERIC_TUD_CLS_043_036

        /// <summary>
        /// Add a container of a module
        /// 2-levels dictionary dataContext
        ///     Instance short name 1 --------- Container Short Name 1 --------- Container Object 1
        ///                           +-------- Container Short Name 2 --------- Container Object 2
        ///     Instance short name 2 --------- Container Short Name 3 --------- Container Object 3
        ///                           +-------- Container Short Name 4 --------- Container Object 4
        ///
        /// Add to dataContext: moduleName + container's ShortName + container
        /// </summary>
        /// <param name="moduleName">Module name</param>
        /// <param name="key">Container shortName <range>empty/valid string</range></param>
        /// <param name="container">Container object<range>empty/valid Container</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF moduleName, key and container isn't null or empty THEN
        ///     IF dataContext contains key THEN
        ///         IF value of dataContext with key whose isn't contains short name of container THEN
        ///             LET store container into dataContext
        ///     ELSE
        ///         LET store container into dataContext
        ///     CALL addInstanceIfNeeded WITH moduleName, key
        /// </algorithm>
        public void SaveContainer(string moduleName, string key, Container container)
        {
            // Store container in data context with structure as
            // 2-levels dictionary dataContext
            //     Instance short name 1 --------- Container Short Name 1 --------- Container Object 1
            //                           +-------- Container Short Name 2 --------- Container Object 2
            //     Instance short name 2 --------- Container Short Name 3 --------- Container Object 3
            //                           +-------- Container Short Name 4 --------- Container Object 4
            //
            //     Add to dataContext: moduleName + container's ShortName + container
            //
            if (!String.IsNullOrEmpty(moduleName) && !String.IsNullOrEmpty(key) && (null != container))
            {
                if (dataContext.ContainsKey(key))
                {
                    if (!dataContext[key].ContainsKey(container.ShortName))
                    {
                        dataContext[key].Add(container.ShortName, container);
                    }
                    else
                    {
                        // Not required
                    }
                }
                else
                {
                    dataContext.Add(key, new Dictionary<string, Container>
                    {
                        { container.ShortName, container }
                    });
                }

                addInstanceIfNeeded(moduleName, key);

            } // End of if !String.IsNullOrEmpty(moduleName) && !String.IsNullOrEmpty(key) && (null != container)
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_043_021

        /// <summary>
        /// Get all containers of a module
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>IList<Container>
        ///         <desc>The list of container</desc>
        ///         <range>empty/valid list Container</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF moduleName is NOT null or empty THEN
        ///     LET containerList = get all containers that are right under moduleName (or "{moduleName}d*$")
        ///         to add to a containers collection "result"
        ///     FOREACH container IN containerList
        ///         LET get all of its children containers to add to "result"
        ///     Return "result"
        /// Else
        ///     FOREACH module name IN dataContext
        ///         LET containerList = Get all containers that are right under moduleName (or "{moduleName}d*$")
        ///             to add to a containers collection "result"
        ///         FOREACH container IN containerList
        ///             LET get all of its children containers to add to "result"
        /// RETURN "result"
        /// </algorithm>
        public IList<Container> GetCurrentInstanceContainers(string moduleName = "")
        {
            List<Container> result = new List<Container>();

            if (isCurrentInstanceAvailable())
            {
                // Get all containers with current instance.
                if (!String.IsNullOrEmpty(moduleName))
                {
                    string key = getCurrentInstanceKey(moduleName);
                    if (!String.IsNullOrEmpty(key))
                    {
                        // Structure:
                        // ModuleName --- Key ----- --------Container
                        // Ex:
                        // ModuleName --- ShortName0 ----- container1
                        // ModuleName --- ShortName0 ----- container2
                        // ModuleName --- ShortName1 ----- container1
                        // ModuleName --- ShortName1 ----- container2
                        // Fls -----------Fls0--------------- FlsGeneral
                        // Fls -----------Fls0--------------- FlsConfig0
                        List<Container> containerList = dataContext[key].Values.ToList();
                        foreach (Container container in containerList)
                        {
                            result.AddRange(container.GetDescendant());
                        }
                    }// End of if (!String.IsNullOrEmpty(key))
                    else
                    {
                        // Not required
                    }
                } // End of if (!String.IsNullOrEmpty(moduleName))
                else
                {
                    // get all containers under each module.
                    foreach (string module in moduleInstances.Keys)
                    {
                        string key = getCurrentInstanceKey(module);
                        List<Container> containerList = dataContext[key].Values.ToList();
                        foreach (Container container in containerList)
                        {
                            result.AddRange(container.GetDescendant());
                        }
                    }
                }
            } // End of if (isCurrentInstanceAvailable())
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_043_015

        /// <summary>
        /// Get all containers of a module
        /// Get all instance based on module name
        /// Get all container in each instance
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Dictionary<string, IList<Container>>
        ///         <desc>The collection of containers</desc>
        ///         <range>empty/valid Dictionary</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = Dictionary empty
        /// IF moduleInstances contains moduleName AND value of moduleInstances with key moduleName isn't null THEN
        ///     FOREACH key IN value of moduleInstances with key moduleName is a list string
        ///         IF containerList isn't null THEN
        ///             LET containerList = value of dataContext with key
        ///             FOREACH container IN containerList
        ///                 LET add container and childs of container into eachInstance
        ///         LET result add data with Key is key, Value is eachInstance
        /// RETURN result
        /// </algorithm>
        public Dictionary<string, IList<Container>> GetAllInstanceContainers(string moduleName)
        {
            Dictionary<string, IList<Container>> result = new Dictionary<string, IList<Container>>();

            if (!String.IsNullOrEmpty(moduleName))
            {
                moduleName = moduleName.ToUpper();

                if (moduleInstances.ContainsKey(moduleName) && null != moduleInstances[moduleName])
                {
                    // Get all instances of module name
                    foreach (string key in moduleInstances[moduleName].Where(x => !String.IsNullOrEmpty(x)))
                    {
                        // get all container in instance
                        // Structure:
                        // ModuleName --- Key ----- --------Container
                        // Ex:
                        // ModuleName --- ShortName0 ----- container1
                        // ModuleName --- ShortName0 ----- container2
                        // ModuleName --- ShortName1 ----- container1
                        // ModuleName --- ShortName1 ----- container2
                        // Fls -----------Fls0--------------- FlsGeneral
                        // Fls -----------Fls0--------------- FlsConfig0
                        List<Container> eachInstance = new List<Container>();
                        List<Container> containerList = dataContext[key].Values.ToList();

                        foreach (Container container in containerList)
                        {
                            eachInstance.AddRange(container.GetDescendant());
                        }
                        result[key] = eachInstance;
                    }
                }// End of if (moduleInstances.ContainsKey(moduleName) && null != moduleInstances[moduleName])
                else
                {
                    // Not required
                }
            } // End of if (!String.IsNullOrEmpty(moduleName))
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_043_009

        /// <summary>
        /// Save configuration
        /// </summary>
        /// <param name="key">EcuConfiguration shortName<range>empty/valid string</range></param>
        /// <param name="config">The module configuration<range>null/valid Configuration</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// If moduleName is NOT null or empty and config is NOT null THEN
        ///     LET configurations = Save config with key moduleName
        /// </algorithm>
        public void SaveConfiguration(string key, Configuration config)
        {
            // Store configuation of module
            // Ref. Configuration.cs
            if (!String.IsNullOrEmpty(key) && (null != config))
            {
                if (!configurations.ContainsKey(key))
                {
                    configurations.Add(key, config);
                }
                else
                {
                    // Not required
                }
            }// End of if (!String.IsNullOrEmpty(moduleName) && !String.IsNullOrEmpty(key) && (null != config))
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_043_020

        /// <summary>
        /// Get configuration by module name
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Configuration
        ///         <desc>The module configuration</desc>
        ///         <range>null/found config object</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF found moduleName (or "{moduleName}d*$") in configurations THEN
        ///     RETURN found configuration
        /// Return null
        /// </algorithm>
        public Configuration GetCurrentInstanceConfiguration(string moduleName)
        {
            Configuration config = null;
            // Get configuration based on current instance of module.
            if (isCurrentInstanceAvailable() && !String.IsNullOrEmpty(moduleName))
            {
                string key = getCurrentInstanceKey(moduleName);
                if (!String.IsNullOrEmpty(key))
                {
                    config = configurations[key];
                }
                else
                {
                    // Not required
                }
            }// End of if (isCurrentInstanceAvailable() && !String.IsNullOrEmpty(moduleName))
            else
            {
                // Not required
            }

            return config;
        }
        // Implementation: GENERIC_TUD_CLS_043_014

        /// <summary>
        /// Get all configuration by module name
        /// With each instance, get all configuration based on module name
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>IList<Configuration>
        ///         <desc>The list of module configurations</desc>
        ///         <range>empty/valid list Configuration</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = list Configuration empty
        /// IF moduleInstances contains moduleName AND value of moduleInstances with key moduleName isn't null THEN
        ///     FOREACH each IN value of moduleInstances with key moduleName is a list string
        ///         LET result add value of configurations with Key is each
        /// RETURN result
        /// </algorithm>
        public IList<Configuration> GetAllInstanceConfigurations(string moduleName)
        {
            List<Configuration> result = new List<Configuration>();

            if (!String.IsNullOrEmpty(moduleName))
            {
                moduleName = moduleName.ToUpper();
                // Get all configuration of all instance in a module.
                if (moduleInstances.ContainsKey(moduleName) && null != moduleInstances[moduleName])
                {
                    foreach (string each in moduleInstances[moduleName].Where(x => configurations.ContainsKey(x) &&
                                                                                  null != configurations[x]))
                    {
                        result.Add(configurations[each]);
                    }
                } // End of if (moduleInstances.ContainsKey(moduleName) && null != moduleInstances[moduleName])
                else
                {
                    // Not required
                }
            } // End of if !String.IsNullOrEmpty(moduleName)
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_043_008

        /// <summary>
        /// Save bsw configuration
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <param name="config">The module configuration<range>null/valid Bsw Config</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF moduleName is NOT null or empty and config is NOT null THEN
        ///     LET bswConfigs = Add config with key is moduleName
        /// ELSE
        ///     LET bswConfigs = new dictionary of string and List of BswConfig with key is moduleName
        /// </algorithm>
        public void SaveBswConfiguration(string moduleName, BswConfig config)
        {
            if (!String.IsNullOrEmpty(moduleName) && (null != config))
            {
                // Each module name only has a bsw configuration
                if (bswConfigs.ContainsKey(moduleName))
                {
                    bswConfigs[moduleName].Add(config);
                }
                else
                {
                    bswConfigs[moduleName] = new List<BswConfig> { config };
                }
            } // End of if (!String.IsNullOrEmpty(moduleName) && (null != config))
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_043_018

        /// <summary>
        /// Get the first bsw configuration
        /// </summary>
        /// <param name="moduleName">Optional Module name<range>string/valid string</range></param>
        /// <returns>
        ///     <para>BswConfig
        ///         <desc>Basic software configuration info</desc>
        ///         <range>null/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF have any config with name is module name in bswConfigs THEN
        ///    RETURN config
        /// Else
        ///    RETURN first config
        /// </algorithm>
        public BswConfig GetBswConfiguration(string moduleName = "")
        {
            BswConfig config = null;
            // Get the first bsw configuration if module name does not input.
            if (!String.IsNullOrEmpty(moduleName))
            {
                BswConfig curBsw = GetCurrentInstanceBswConfig(moduleName);

                if (null != curBsw)
                {
                    config = curBsw;
                }
                else
                {
                    // Not required
                }
            }
            else
            {
                // default return first found bswConfig
                config = bswConfigs.Values.SelectMany(x => x).ToList().FirstOrDefault();
            }
            return config;
        }
        // Implementation: GENERIC_TUD_CLS_043_010

        /// <summary>
        /// Get all bsw configurations
        /// </summary>
        /// <returns>
        ///     <para>IList<BswConfig>
        ///         <desc>List of basic software configuration info</desc>
        ///         <range>null/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN all bsw configurations of bswConfigs
        /// </algorithm>
        public IList<BswConfig> GetBswConfigurations()
        {
            return bswConfigs.Values.SelectMany(x => x).ToList();
        }
        // Implementation: GENERIC_TUD_CLS_043_011

        /// <summary>
        /// Get all modules name from moduleInstances
        /// </summary>
        /// <returns>
        ///     <para>IList<string>
        ///         <desc>List of module name</desc>
        ///         <range>null/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN list key of moduleInstances
        /// </algorithm>
        public IList<string> GetModules()
        {
            return moduleInstances.Keys.ToList();
        }
        // Implementation: GENERIC_TUD_CLS_043_016

        /// <summary>
        /// Save CDF files
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <param name="shortName">Short name<range>empty/valid string</range></param>
        /// <param name="fileName">File name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF both moduleName, shortName and fileName are NOT null or empty THEN
        ///     LET cdfFiles = Add fileName with key is moduleName
        ///     LET cdfFiles = Add fileName with key is shortName in case multi-instance module
        /// </algorithm>
        public void SaveCdfFiles(string moduleName, string shortName, string fileName)
        {

            if (!String.IsNullOrEmpty(moduleName) &&
                !String.IsNullOrEmpty(fileName) &&
                !String.IsNullOrEmpty(shortName))
            {
                moduleName = moduleName.ToUpper();
                shortName = shortName.ToUpper();
                // File is stored with key module name that for servering module has an instance.
                if (!cdfFiles.ContainsKey(moduleName))
                {
                    cdfFiles.Add(moduleName, fileName);
                }
                else
                {
                    // Not required
                }
                // File is stored with key short name that for servering module has multi-instance platform.
                if (!cdfFiles.ContainsKey(shortName))
                {
                    cdfFiles.Add(shortName, fileName);
                }
                else
                {
                    // Do nothing
                }

            } // End of if !String.IsNullOrEmpty(moduleName) && !String.IsNullOrEmpty(fileName)
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_043_019

        /// <summary>
        /// Get CDF file
        /// </summary>
        /// <param name="shortName">Short name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>Cdf file</desc>
        ///         <range>empty/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF shortName is NOT null or empty THEN
        ///     IF found short name exists  in cdfFiles THEN
        ///         RETURN found file name
        /// RETURN empty
        /// </algorithm>
        public string GetCdfFile(string shortName)
        {
            string fileName = String.Empty;

            if (!String.IsNullOrEmpty(shortName))
            {
                shortName = shortName.ToUpper();
                // Store file path corresponding to module shortname
                if (cdfFiles.ContainsKey(shortName))
                {
                    fileName = cdfFiles[shortName];
                }
                else
                {
                    // Not required
                }
            }// End of if (!String.IsNullOrEmpty(shortName))
            else
            {
                // Not required
            }

            return fileName;
        }
        // Implementation: GENERIC_TUD_CLS_043_012

        /// <summary>
        /// Get container by UUID
        /// </summary>
        /// <param name="moduleName">Short name<range>empty/valid string</range></param>
        /// <param name="uuid">Uuid<range>string/valid string</range></param>
        /// <returns>
        ///     <para>Container
        ///         <desc>The container</desc>
        ///         <range>null/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF any of containers under moduleName has Uuid that equal to uuid THEN
        ///     RETURN first found container
        /// RETURN null
        /// </algorithm>
        public Container GetContainerByUUID(string moduleName, string uuid)
        {
            Container result = null;
            if ((false == String.IsNullOrEmpty(moduleName)) && (false == String.IsNullOrEmpty(uuid)))
            {
                // Get all containers of all instance in module.
                // find container has uuid coresponding to uuid input.
                // UUID of container of all instances is unique.
                Dictionary<string, IList<Container>> instanceContainers = GetAllInstanceContainers(moduleName);

                foreach (Container container in instanceContainers.Values.Where(x => null != x)
                    .SelectMany(cons => cons)
                    .Where(x => x.Uuid.Equals(uuid, StringComparison.OrdinalIgnoreCase)))
                {
                    result = container;
                    break;
                }// End of foreach (Container container in eachInstance)
            } // End of if ((false == String.IsNullOrEmpty(moduleName)) && (false == String.IsNullOrEmpty(uuid))).
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_043_013

        /// <summary>
        /// Update current instance index
        /// </summary>
        /// <param name="instanceIndex">Instance Index <range>integer</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET currentInstanceIndex = instanceIndex
        /// </algorithm>
        public void PrepareInstance(int instanceIndex)
        {
            currentInstanceIndex = instanceIndex;
        }
        // Implementation: GENERIC_TUD_CLS_043_017

        /// <summary>
        /// Get container by short name
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <param name="shortName">Short name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Container
        ///         <desc>The container</desc>
        ///         <range>null/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET containerList = return value of CALL GetCurrentInstanceContainers WITH moduleName
        /// RETURN first container in containerList WHERE it has short name is shortName
        /// </algorithm>
        private Container getContainerByShortName(string moduleName, string shortName)
        {
            IList<Container> containerList = GetCurrentInstanceContainers(moduleName);
            Container result = containerList
                .Where(x => x.ShortName.Equals(shortName, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_043_024

        /// <summary>
        /// Add instance if needed
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <param name="instanceShortname">Instance short name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF moduleInstances contains moduleName THEN
        ///     IF shortNames contains instanceShortname
        ///         LET add instanceShortname into shortNames
        /// ELSE
        ///     LET value of moduleInstances with Key is moduleName = instanceShortname
        /// </algorithm>
        private void addInstanceIfNeeded(string moduleName, string instanceShortname)
        {
            moduleName = moduleName.ToUpper();
            // Keep information all instances of module
            if (moduleInstances.ContainsKey(moduleName))
            {
                List<string> shortNames = moduleInstances[moduleName];
                if (!shortNames.Contains(instanceShortname))
                {
                    shortNames.Add(instanceShortname);
                }
                else
                {
                    // Not required
                }
            } // End of  if (moduleInstances.ContainsKey(moduleName))
            else
            {
                moduleInstances[moduleName] = new List<string> { instanceShortname };
            }
        }
        // Implementation: GENERIC_TUD_CLS_043_023

        /// <summary>
        /// Checking instance is current instance
        /// </summary>
        /// <returns>
        ///     <para>bool
        ///         <desc>The status of checking</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF currentInstanceIndex >=0 THEN
        ///     RETURN 1
        /// ELSE
        ///     RETURN 0
        /// </algorithm>
        private bool isCurrentInstanceAvailable()
        {
            return (currentInstanceIndex >= 0);
        }
        // Implementation: GENERIC_TUD_CLS_043_026

        /// <summary>
        /// Get current instance key
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>Instance key</desc>
        ///         <range>null/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF moduleInstances contains moduleName
        ///     IF keys isn't null THEN
        ///         IF size of keys is greater than currentInstanceIndex
        ///             LET result = value of keys with Key is currentInstanceIndex
        ///         ELSE
        ///             LET result = first elemant of keys
        /// RETURN result
        /// </algorithm>
        private string getCurrentInstanceKey(string moduleName)
        {
            string result = null;
            if (isCurrentInstanceAvailable() && !String.IsNullOrEmpty(moduleName))
            {
                moduleName = moduleName.ToUpper();
                // Get all instance of module
                if (moduleInstances.ContainsKey(moduleName))
                {
                    List<string> keys = moduleInstances[moduleName];
                    if (null != keys)
                    {
                        // If current instance index less more number of instance
                        // return current instance
                        // Else return the first instance.
                        if (keys.Count > currentInstanceIndex)
                        {
                            result = keys[currentInstanceIndex];
                        }
                        else
                        {
                            result = keys.FirstOrDefault();
                        }
                    }// End of if (null != keys)
                    else
                    {
                        // Not required
                    }
                } // End of  if (moduleInstances.ContainsKey(moduleName))
                else
                {
                    // Not required
                }
            } // End of if (isCurrentInstanceAvailable() && !String.IsNullOrEmpty(moduleName))
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_043_025

        /// <summary>
        /// Get current instance bswmdt configuration 
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>BswConfig
        ///         <desc>Instance bswConfig</desc>
        ///         <range>null/valid BswConfig</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = null
        /// IF found configuration contained moduleName
        ///     IF config isn't null AND bswConfigs is NOT null THEN
        ///         IF bswConfigs contained moduleName
        ///             LET result = bswConfig where bswConfig RootPath equal ModuleDescriptionRef config
        ///         ELSE
        ///             Do nothing
        /// RETURN result
        /// </algorithm>
        public BswConfig GetCurrentInstanceBswConfig(string moduleName)
        {
            BswConfig bswConf = null;
            // Get configuration based on current instance of module.
            if (isCurrentInstanceAvailable() && !String.IsNullOrEmpty(moduleName))
            {
                Configuration config = GetCurrentInstanceConfiguration(moduleName);

                if (null != config && null != bswConfigs && bswConfigs.ContainsKey(moduleName))
                {
                    bswConf = bswConfigs[moduleName].Where(x =>
                        null != x && x.ImplementRootPath.Equals(config.ModuleDescriptionRef)).FirstOrDefault();
                }
                else
                {
                    // Not required
                }
            }// End of if (isCurrentInstanceAvailable() && !String.IsNullOrEmpty(moduleName))
            else
            {
                // Not required
            }

            return bswConf;
        }
        // Implementation: GENERIC_TUD_CLS_043_027
    }
}

