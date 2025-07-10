/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = RepositoryLinQ.cs                                                                                   */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021, 2024 Renesas Electronics Corporation. All rights reserved.                                 */
/*====================================================================================================================*/
/* Purpose: This file contains RepositoryLinQ class that implements IRepository interfaces and use basic operations   */
/*          of CdfDataDictionary to provide more convenience operations to upper layers.                              */
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
/*              : class RepositoryLinQ                                                                                */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            18/02/2019 :    Modify method getContainersByDefName() to fix default of return value                   */
/*                                                                                                                    */
/*            21/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/*            01/03/2019 :    Added method GetVersionInformation #89553 #note24                                       */
/*            04/03/2019 :    Modify method GetVersionInformation #89553                                              */
/* 1.0.2:     10/12/2020 :    Fix Gentool Unit test issue #252822                                                     */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     04/05/2021 :    Update GetContainerByShortNamePath to get container correctly.                          */
/*            02/07/2021 :    Add new method UpdateBasicConfig                                                        */
/* 1.2.2:     01/09/2021 :    Update inside comment about support deviation autosar for GetVersionInformation         */
/* 1.2.3:     02/03/2024 :    Update GetContainerByDefName, GetContainersByDefName, GetAllInstancesContainersByDefName*/
/*                            GetContainerByShortNamePath, GetParameterValue, GetParameterValues, GetReferenceValue,  */
/*                            GetReferenceValues, GetChilds, GetContainer, getContainersByDefName                     */
/*                            Add CheckVariantParameterSupported, CheckVariantContainerSupported,                     */
/*                            GetAllVariantConfiguration, GetShortNameVariantConfig                                   */
/* 1.2.4:     26/03/2024 :    Update GetParameterValues, GetReferenceValues, CheckVariantContainerSupported           */
/* 1.2.5:     19/09/2024 :    Update initVersionInformation some macros to support PreCompile for Mem, Fee            */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Collections.Generic;
using System.Linq;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

namespace Renesas.Generator.MCALConfGen.Data.CDFData
{
    /// <summary>
    /// This "RepositoryLinQ" class that implements "IRepository" interfaces and use basic operations
    /// of "CdfDataDictionary" to provide more convenience operations to upper layers.
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    public class RepositoryLinQ : IRepository
    {
        /// <summary>
        /// "RepositoryLinQ" instance used by "ObjectFactory" to get a new "RepositoryLinQ" object
        /// </summary>
        public static readonly RepositoryLinQ Instance = new RepositoryLinQ();
        // Implementation: GENERIC_TUD_CLS_048_001

        /// <summary>
        /// To save and retrive infomration of CDF files.
        /// </summary>
        private ICdfData cdfData = null;
        // Implementation: GENERIC_TUD_CLS_048_002

        /// <summary>
        /// To record log information for debugging.
        /// </summary>
        private ILogger logger = null;
        // Implementation: GENERIC_TUD_CLS_048_003

        /// <summary>
        /// To parses and stores information of translation and device header files.
        /// </summary>
        private IRegisterProcessing register = null;
        // Implementation: GENERIC_TUD_CLS_048_004

        /// <summary>
        /// Repository LinQ constructor
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
        protected RepositoryLinQ() : this
        (
            ObjectFactory.GetInstance<ICdfData>(),
            ObjectFactory.GetInstance<ILogger>(),
            ObjectFactory.GetInstance<IRegisterProcessing>()
        )
        {
        }
        // Implementation: GENERIC_TUD_CLS_048_033

        /// <summary>
        /// Repository LinQ constructor
        /// </summary>
        /// <param name="cdfData">Cdf data <range>null/valid "ICdfData"</range></param>
        /// <param name="logger">Logger <range>null/valid "ILogger"</range></param>
        /// <param name="register">Register <range>null/valid "IRegisterProcessing"</range></param>
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
        protected RepositoryLinQ(ICdfData cdfData, ILogger logger, IRegisterProcessing register)
        {
            this.cdfData = cdfData;
            this.logger = logger;
            this.register = register;
        }
        // Implementation: GENERIC_TUD_CLS_048_034

        /// <summary>
        /// Get CDF file name
        /// </summary>
        /// <param name="shortName">Short name <range>null/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The cdf file name</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get CDF file name of shortName from cdfData
        /// </algorithm>
        public string GetCdfFileName(string shortName)
        {
            return cdfData.GetCdfFile(shortName);
        }
        // Implementation: GENERIC_TUD_CLS_048_011

        /// <summary>
        /// Get a container by def name
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <param name="defName">Def name <range>empty/valid string</range></param>
        /// <param name="sortOption">Sort option <range>0/valid integer</range></param>
        /// <returns>
        ///     <para>Container
        ///         <desc>The container</desc>
        ///         <range>null/valid Container</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// CALL GetContainersByDefName(moduleName, defName, sortOption, variantID).FirstOrDefault() to get list of containers
        /// </algorithm>
        public Container GetContainerByDefName(string moduleName, string defName, 
                                                                            int sortOption = 0, string variantID = "")
        {
            return GetContainersByDefName(moduleName, defName, sortOption, variantID).FirstOrDefault();
        }
        // Implementation: GENERIC_TUD_CLS_048_016

        /// <summary>
        /// Get all containers by def name
        /// </summary>
        /// <param name="moduleName">Module name <range>null/valid string</range></param>
        /// <param name="defName">Container Definition name <range>null/valid string</range></param>
        /// <param name="sortOption">Sort option <range>0/valid integer</range></param>
        /// <returns>
        ///     <para>IList<Container>
        ///         <desc>The list of containers</desc>
        ///         <range>empty/valid list Container</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET containerList = (List<Container>)cdfData.GetCurrentInstanceContainers WITH moduleName
        /// RETURN getContainersByDefName(containerList, defName, sortOption, variantID)
        /// </algorithm>
        public IList<Container> GetContainersByDefName(string moduleName, string defName, 
                                                                            int sortOption = 0, string variantID = "")
        {
            List<Container> containerList = (List<Container>)cdfData.GetCurrentInstanceContainers(moduleName);

            return getContainersByDefName(containerList, defName, sortOption, variantID);
        }
        // Implementation: GENERIC_TUD_CLS_048_019

        /// <summary>
        /// Get all containers based on definition name
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <param name="defName">Container Definition name <range>empty/valid string</range></param>
        /// <param name="sortOption">Sort option <range>0/valid integer</range></param>
        /// <returns>
        ///     <para>Dictionary<string, IList<Container>>
        ///         <desc>The list of containers</desc>
        ///         <range>empty/valid list Container</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get all containers of instances
        /// FOREACH instance in containers
        ///     LET get all containers based on definition name
        /// </algorithm>
        public Dictionary<string, IList<Container>> GetAllInstancesContainersByDefName(
            string moduleName,
            string defName,
            int sortOption = 0,
            string variantID = "")
        {
            Dictionary<string, IList<Container>> consOfInstances = cdfData.GetAllInstanceContainers(moduleName);
            List<string> shortNames = consOfInstances.Keys.ToList();
            // Get containers for each instance
            foreach (string each in shortNames)
            {
                consOfInstances[each] = getContainersByDefName(consOfInstances[each], defName, sortOption, variantID);
            }

            return consOfInstances;
        }
        // Implementation: GENERIC_TUD_CLS_048_010

        /// <summary>
        /// Get a container by short name path
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <param name="path">Container ShortName Path <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Container
        ///         <desc>The container</desc>
        ///         <range>null/valid Container</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get all containers in all instance of cdfData by moduleName
        /// Add all containers into containerList
		/// IF variantID is empty
		///   LET ret = container in containerList that has the Path same with argument path.
		/// ELSE
		///	  LET ret = container in containerList that has the Path same with argument path AND the given condition
        /// RETURN container in containerList that has the Path same with argument path.
        /// </algorithm>
        public Container GetContainerByShortNamePath(string moduleName, string path, string variantID = "")
        {
            Container ret = null;
            Dictionary<string, IList<Container>> containerDic = cdfData.GetAllInstanceContainers(moduleName);
            List<Container> containerList = containerDic.SelectMany(x => x.Value).ToList();
            // Get container based on path
            if (string.Empty == variantID)
            {
                ret = containerList.Where(c => c.Path.Equals(path)).FirstOrDefault();
            }
            else
            {
                // Case 1:
                // Container 0:
                // Path: "/ActiveEcuC/Msn/<Msn>GlobalConfig/<Container>"
                // VariantID: "1"

                // Case 2:
                // Container 0:
                // Path: "/ActiveEcuC/Msn/<Msn>GlobalConfig/<Container>"
                // VariantID: null
                ret = containerList.Where(c => ((c.Path.Equals(path)) 
                    && ((null == c.VariantID) || (variantID == c.VariantID)))).FirstOrDefault();
            }
            
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_048_017

        /// <summary>
        /// Get all containers by module name
        /// </summary>
        /// <param name="moduleName">Optional Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>IList<Container>
        ///         <desc>The list of containers</desc>
        ///         <range>empty/valid list Container</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN all containers in cdfData by moduleName
        /// </algorithm>
        public IList<Container> GetContainers(string moduleName = "")
        {
            return cdfData.GetCurrentInstanceContainers(moduleName);
        }
        // Implementation: GENERIC_TUD_CLS_048_018

        /// <summary>
        /// Get macro address value
        /// </summary>
        /// <param name="macroValue">Macro value <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The macro address values</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN the value by CALL GetMacroAddressValue from register to get address value
        /// </algorithm>
        public string GetMacroAddressValue(string macroValue)
        {
            return register.GetMacroAddressValue(macroValue);
        }
        // Implementation: GENERIC_TUD_CLS_048_020

        /// <summary>
        /// Get macro address type
        /// </summary>
        /// <param name="macroValue">Macro value <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The macro address type</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// CALL GetAddressType from register to get address type
        /// </algorithm>
        public string GetAddressType(string macroValue)
        {
            return register.GetAddressType(macroValue);
        }
        // Implementation: GENERIC_TUD_CLS_048_008

        /// <summary>
        /// Get address by macro definition
        /// </summary>
        /// <param name="renesasMacroName">Renesas macro name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The macro address value</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get macro value from macro definition by CALL method GetMacroLabelValue
        /// IF macro value is NOT null or empty THEN
        ///     LET get macro address from macro value by calling method GetMacroAddressValue
        ///     RETURN macro address
        /// ELSE
        ///     RETURN empty
        /// </algorithm>
        public string GetAddressByMacroDefinition(string renesasMacroName)
        {
            string address = String.Empty;
            string macroValue = GetMacroLabelValue(renesasMacroName);
            // Get macro name and get address based macro name
            // Ex:
            // E2x_translation.h => RENESAS_PMC11                                   PORT0PMC11
            // dr7f702z04a_0.h   => PORT0PMC11                                      0xff6102d4UL
            if (false == String.IsNullOrEmpty(macroValue))
            {
                address = GetMacroAddressValue(macroValue);
            }
            else
            {
                // Not required
            }

            return address;
        }
        // Implementation: GENERIC_TUD_CLS_048_007

        /// <summary>
        /// Get address type by macro definition
        /// </summary>
        /// <param name="renesasMacroName">Renesas macro name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The macro address type</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get macro value from macro definition by calling method GetMacroLabelValue
        /// If macro value is NOT null or empty
        ///     Get macro address type from macro value by calling method GetAddressType
        ///     Return macro address type
        /// Else
        ///     Return empty
        /// </algorithm>
        public string GetAddressTypeByMacroDefinition(string renesasMacroName)
        {
            string addressType = String.Empty;
            string macroValue = GetMacroLabelValue(renesasMacroName);
            string macroType = GetAddressType(macroValue);
            Dictionary<string, string> mapping = new Dictionary<string, string>()
            {
                {"u32_T", "uint32" },
                {"u16_T", "uint16" },
                {"u08_T", "uint8" },
                {"u8_T", "uint8" }
            };

            if (!String.IsNullOrEmpty(macroType) && mapping.Keys.Contains(macroType))
            {
                addressType = mapping[macroType];
            }
            else
            {
                // Not required
            }

            return addressType;
        }
        // Implementation: GENERIC_TUD_CLS_048_009

        /// <summary>
        /// Get macro label value
        /// </summary>
        /// <param name="renesasMacroName">Renesas macro name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The macro label value</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN the value by CALL GetMacroLabelValue from register to get label value
        /// </algorithm>
        public string GetMacroLabelValue(string renesasMacroName)
        {
            return register.GetMacroLabelValue(renesasMacroName);
        }
        // Implementation: GENERIC_TUD_CLS_048_021

        /// <summary>
        /// Get parameter value by def name
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <param name="defName">Parameter Definition name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>ItemValue
        ///         <desc>The parameter value</desc>
        ///         <range>null/valid item</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get all containers in cdfData by moduleName
        /// IF found any parameter of container has defName THEN
        ///     RETURN first found parameter
        /// ELSE
        ///     RETURN null
        /// </algorithm>
        public ItemValue GetParameterValue(string moduleName, string defName, string variantID = "")
        {
            ItemValue item = null;
            // Get parameter value in container.
            // Refer: Container.cs
            item = GetParameterValues(moduleName, defName, variantID).FirstOrDefault();
            return item;
        }
        // Implementation: GENERIC_TUD_CLS_048_022

        /// <summary>
        /// Get parameter values by def name
        /// </summary>
        /// <param name="moduleName">Module name <range>null/valid string</range></param>
        /// <param name="defName">Parameter Definition name <range>null/valid string</range></param>
        /// <returns>
        ///     <para>IList<ItemValue>
        ///         <desc>The list of parameter values</desc>
        ///         <range>null/valid list items</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get all containers in cdfData by moduleName
		/// IF variantID is empty
		///   LET get parameter value by defName and add to a collection "itemList"
		///	ELSE
        ///   LET get parameter value by defName where variantID is null or VariantIDs contains variantID
		///   and add to a collection "itemList"
		///   LET tempItemList = new list of ItemValue object
		///   FOREACH container in list container
		///	    IF number of ListVariantIDs greater than 0
		///	        Add found variant into List of variant of parameter
		///	    ELSE
		///	      Add item to tempItemList
		///	LET itemList = the tempItemList
        /// RETURN collection "itemList"
        /// </algorithm>
        public IList<ItemValue> GetParameterValues(string moduleName, string defName, string variantID = "")
        {
            IList<ItemValue> itemList = null;

            IList<Container> containerList = cdfData.GetCurrentInstanceContainers(moduleName);
            // Get parameter values in container.
            // Refer: Container.cs

            if (string.Empty == variantID)
            {
                itemList = containerList
                    .Select(x => x.GetParameterValue(defName))
                    .Where(x => null != x)
                    .ToList();
            }
            else
            {
                // Get item where variantID is null or VariantIDs contains variantID
                itemList = containerList
                    .Select(x => x.GetParameterValue(defName))
                    .Where(x => null != x)
                    .Where(x => ((0 == x.getVariantIDs().Count) || (x.getListVariantIDs().Contains(variantID))))
                    .ToList();

                IList<ItemValue> tempItemList = new List<ItemValue>();

                foreach(ItemValue item in itemList)
                {
                    if (0 < item.getListVariantIDs().Count)
                    {
                        // Add found variant into List of variant of parameter.
                        tempItemList.Add(new ItemValue(item.DefinitionRef(), 
                                item.getVariantItem(variantID).InternalValue()));
                    }
                    else
                    {
                        tempItemList.Add(item);
                    }
                }

                itemList = tempItemList;
            }

            return itemList;
        }
        // Implementation: GENERIC_TUD_CLS_048_023

        /// <summary>
        /// Get reference value
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <param name="defName">Reference Definition name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>ItemValue
        ///         <desc>The reference value</desc>
        ///         <range>null/valid item</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get all containers in cdfData by moduleName
		/// IF variantID is empty
        ///   IF found any reference of container has defName THEN
        ///     RETURN first found reference
        ///   ELSE
        ///     RETURN null
		/// ELSE
        ///   IF found any reference of container has defName, moduleName and variantID THEN
        ///     RETURN first found reference
        ///   ELSE
        ///     RETURN null
		/// RETURN item
        /// </algorithm>
        public ItemValue GetReferenceValue(string moduleName, string defName, string variantID = "")
        {
            ItemValue item = null;
            IList<Container> containerList = cdfData.GetCurrentInstanceContainers(moduleName);
            // Get refernce value in container.
            // Refer: Container.cs

            if (string.Empty == variantID)
            {
                item = containerList.Select(c => c.GetReferenceValue(defName))
                            .Where(r => null != r).FirstOrDefault();
            }
            else
            {
                item = GetReferenceValues(defName, moduleName, variantID).FirstOrDefault();
            }

            return item;
        }
        // Implementation: GENERIC_TUD_CLS_048_024

        /// <summary>
        /// To get reference values
        /// </summary>
        /// <param name="defName">Reference param Name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>List<ItemValue>
        ///         <desc>The list of reference values</desc>
        ///         <range>null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET itemList = new List of Itemvalue object
		/// IF moduleName is empty or variantID is empty
		///	  LET itemList = null
		/// ELSE
		///	  LET containerList = get all containers in cdfData by moduleName
		///   LET tempItemList = new list of ItemValue object
		///   FOREACH container in list container
		///	    IF number of ListVariantIDs greater than 0
		///	        Add found variant into List of variant of parameter
		///	    ELSE
		///	      Add item to tempList
		///	  IF number of tempList greater than 0
		///	    LET itemList = tempList
		///	  ELSE
		///	    LET itemList = null
        /// RETURN collection "itemList"
        /// </algorithm>
        public List<ItemValue> GetReferenceValues(string defName, string moduleName = "", string variantID = "")
        {
            List<ItemValue> itemList = new List<ItemValue>();

            if ((string.Empty == moduleName) || (string.Empty == variantID))
            {
                itemList = null;
            }
            else
            {
                IList<Container> containerList = cdfData.GetCurrentInstanceContainers(moduleName);

                itemList = containerList
                    .Select(x => x.GetReferenceValue(defName))
                    .Where(x => null != x)
                    .Where(c => ((0 == c.getVariantIDs().Count) || (c.getListVariantIDs().Contains(variantID))))
                    .ToList();

                // Covert type to return to old type ItemValue of this method
                // Convert from "VariantItemValue" to "Itemvalue"
                List<ItemValue> tempList = new List<ItemValue>();

                foreach (ItemValue item in itemList)
                {
                    if (0 < item.getListVariantIDs().Count)
                    {
                        tempList.Add(new ItemValue(item.DefinitionRef(), item.getVariantItem(variantID).InternalValue()));
                    }
                    else
                    {
                        tempList.Add(item);
                    }
                }

                if (0 < tempList.Count)
                {
                    itemList = tempList;
                }
                else
                {
                    itemList = null;
                }
            }

            return itemList;
        }
        // Implementation: GENERIC_TUD_CLS_048_025

        /// <summary>
        /// Get all children container of a container which is identified by module name and short name
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <param name="shortName">Short name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>IList<Container>
        ///         <desc>The list of containers</desc>
        ///         <range>empty/valid list containers</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get root container which is identified by module name, short name and variantID
        /// IF container != null THEN
		///   WHILE number of containerStack greater than 0
        ///     FOREACH recursively find children of the container
        ///	      IF VariantID of sub container is null
		///	        Add sub container to Stack
		///	      ELSE
		///	        Push sub container to container stack
		///	        IF variantID is equal to VariantID of sub container
		///	          Add sub container to Stack	
		///	        ELSE
        ///	          Do nothing
        /// ELSE
        ///   Do nothing
        /// RETURN ret
        /// </algorithm>
        public IList<Container> GetChilds(string moduleName, string shortName, string variantID = "")
        {
            List<Container> ret = new List<Container>();
            Container container = GetContainer(moduleName, shortName, variantID);
            Stack<Container> containerStack = new Stack<Container>();
            // Get all childs of container.
            if (null != container)
            {
                // Put first container into stack.
                containerStack.Push(container);

                while (Constant.INT_ZERO < containerStack.Count)
                {
                    // Get each container from stack
                    container = containerStack.Pop();
                    // Loop all childs of current container.
                    foreach (Container subContainer in container.Childs)
                    {
                        // Add sub container to Stack
                        if (subContainer.VariantID == null)
                        {
                            containerStack.Push(subContainer);
                            ret.Add(subContainer);
                        }
                        else
                        {
                            containerStack.Push(subContainer);

                            if (variantID == subContainer.VariantID)
                            {
                                ret.Add(subContainer);
                            }
                            else
                            {
                                // Do nothing
                            }
                        }
                    }
                }
            } // End of if (null != container).
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_048_012

        /// <summary>
        /// Get container by module name and short name
        /// </summary>
        /// <param name="moduleName">Module name<range>empty/valid string</range></param>
        /// <param name="shortName">Short name<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Container
        ///         <desc>The container</desc>
        ///         <range>Null/valid Container</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get a list of containers in cdfData by moduleName
		/// IF variantID is empty
        ///   FIND container in list of container
        ///   Have container's ShortName = shortName THEN
        ///   RETURN container
		/// ELSE
        ///   FIND container in list of container
        ///   Have container's ShortName = shortName AND variantID is null OR variantID is equal to VariantID
        ///   RETURN container
        /// RETURN null IF NOT found a container
        /// </algorithm>
        public Container GetContainer(string moduleName, string shortName, string variantID = "")
        {
            IList<Container> containerList = cdfData.GetCurrentInstanceContainers(moduleName);
            Container ret = null;
            // Get container based short name
            // Ref: Container.cs

            if (string.Empty == variantID)
            {
                ret = containerList.Where(c => c.ShortName.Equals(shortName)).FirstOrDefault();
            }
            else
            {
                ret = containerList.Where(c => ((c.ShortName.Equals(shortName)) && 
                    ((null == c.VariantID) || (variantID == c.VariantID)))).FirstOrDefault();
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_048_015

        /// <summary>
        /// Get version detail information by name
        /// </summary>
        /// <param name="name">Target Name <range>empty/valid string</range></param>
        /// <param name="moduleName=">Module Name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The version information</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get basic software config in cdfData by moduleName
        /// IF found a field in basic software config based that match with name THEN
        ///     RETURN value of found field
        /// ELSE
        ///     RETURN null
        /// </algorithm>
        public string GetVersionInformation(string name, string moduleName = "")
        {
            BswConfig bswConfig = cdfData.GetBswConfiguration(moduleName);
            string ret = String.Empty;
            // Get version detail information by name
            if (null != bswConfig)
            {
                switch (name)
                {
                    case Constant.AR_RELEASE_VERSION:
                        ret = bswConfig.ArReleaseVersion;
                        break;
                    case Constant.SW_VERSION:
                        ret = bswConfig.SwVersion;
                        break;
                    case Constant.VENDOR_ID:
                        ret = bswConfig.VendorId;
                        break;
                    case Constant.MODULE_ID:
                        ret = bswConfig.ModuleId;
                        break;
                    case Constant.VENDOR_API_INFIX:
                        ret = bswConfig.VendorApiInfix;
                        break;
                } // End of switch (name).
            } // End of if (null != bswConfig).
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_048_028

        /// <summary>
        /// Check if path existed
        /// </summary>
        /// <param name="path">Path <range>empty/valid string</range></param>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
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
        /// LET get all containers in cdfData by moduleName
        /// FOREACH container in list of container
        ///     IF found a container that container.Path = path THEN
        ///         RETURN true
        ///     ELSE
        ///         RETURN false
        /// </algorithm>
        public bool IsExistedPath(string path, string moduleName = "")
        {
            bool result = false;
            // Get containers based on current instance and check path exist of path container.
            IList<Container> containerList = cdfData.GetCurrentInstanceContainers(moduleName);
            result = containerList.Any(x => x.Path.Equals(path));
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_048_030

        /// <summary>
        /// Get start of db toc
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>The start of database</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get swMajorVersion in basic software configuration "SW-VERSION"
        ///    Use 0 for swMajorVersion if it's NOT a integer
        /// LET get swMinorVersion in basic software configuration "SW-VERSION"
        ///    Use 0 for swMinorVersion if it's NOT a integer
        /// LET get moduleId in basic software configuration "MODULE-ID"
        ///    Use 0 for moduleId if it's NOT a integer
        /// LET get vendorId in basic software configuration "VENDOR-ID"
        ///    Use 0 for vendorId if it's NOT a integer
        ///
        /// LET calculate start of db toc =
        ///     shift_left(vendorId, 22) or
        ///     shift_left(moduleId, 14) or
        ///     shift_left(swMajorVersion, 8) or
        ///     shift_left(swMinorVersion, 3)
        /// </algorithm>
        public string GetStartOfDbToc()
        {
            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            string strSwVersion = GetVersionInformation(Constant.SW_VERSION, basicConfiguration.ModuleName);
            string strModuleId = GetVersionInformation(Constant.MODULE_ID, basicConfiguration.ModuleName);
            string strVendorId = GetVersionInformation(Constant.VENDOR_ID, basicConfiguration.ModuleName);
            int moduleId = 0;
            int vendorId = 0;
            string startOfDbToc = String.Empty;
            // Get parameter ArSwVersion, ModuleId, VendorId from CDF input and
            // calculate according to formular.
            if ((false == String.IsNullOrEmpty(strSwVersion)) &&
                (true == int.TryParse(strModuleId, out moduleId)) &&
                (true == int.TryParse(strVendorId, out vendorId)))
            {
                int swMajorVersion = 0;
                int swMinorVersion = 0;
                // Formular:
                // The magic number shall consist of 32 bit. Those 32 bits are divided into portions of 10bit,
                // 8bit, 6bit, 5bit and 3bit.
                // The bits 31 down to 22 of the magic number shall define the vendor ID
                // The bits 21 down to 14 of the magic number shall define the module ID
                // The bits 13 down to 8 of the magic number shall define the major MCAL version
                // The bits 7 down to 3 of the magic number shall define the minor MCAL version
                // The bits 2 down to 0 of the magic number shall be reserved for future use.
                if ((true == int.TryParse(strSwVersion.Split('.')[Constant.INT_ZERO], out swMajorVersion)) &&
                    (true == int.TryParse(strSwVersion.Split('.')[Constant.INT_ONE], out swMinorVersion)))
                {
                    int result = vendorId << Constant.VendorIdPosition |
                        moduleId << Constant.ModuleIdPosition |
                        swMajorVersion << Constant.SwMajorVersionPosition |
                        swMinorVersion << Constant.SwMinorVersionPosition;

                    startOfDbToc = result.ToString("X8");
                }
                else
                {
                    // Not required
                }
            }
            else
            {
                // Not required
            }

            return startOfDbToc;
        }
        // Implementation: GENERIC_TUD_CLS_048_026

        /// <summary>
        /// Check if module name existed
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
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
        /// LET CALL GetContainers method to get all containers by moduleName
        /// IF number of containers is larger than 0 THEN
        ///     RETURN true
        /// ELSE
        ///     RETURN false
        /// </algorithm>
        public bool IsExistModuleName(string moduleName)
        {
            return (Constant.INT_ZERO < GetContainers(moduleName).Count);
        }
        // Implementation: GENERIC_TUD_CLS_048_029

        /// <summary>
        /// Get configuration by module name
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Configuration
        ///         <desc>The module configuration</desc>
        ///         <range>null/valid configuration</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get configuration in cdfData for moduleName
        /// </algorithm>
        public Configuration GetConfiguration(string moduleName)
        {
            return cdfData.GetCurrentInstanceConfiguration(moduleName);
        }
        // Implementation: GENERIC_TUD_CLS_048_013

        /// <summary>
        /// Get configurations
        /// </summary>
        /// <param name="moduleName">Module name <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>IList<Configuration>
        ///         <desc>The list of module configurations</desc>
        ///         <range>empty/valid list configuration</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get all instances based on module name
        /// Get configuration for each instance.
        /// </algorithm>
        public IList<Configuration> GetConfigurations(string moduleName)
        {
            return cdfData.GetAllInstanceConfigurations(moduleName);
        }
        // Implementation: GENERIC_TUD_CLS_048_014

        /// <summary>
        /// Check if register existed
        /// </summary>
        /// <param name="renesasMacroDefinition">Renesas macro definition <range>empty/valid string</range></param>
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
        /// LET CALL IsRegisterExist from register to check IF register of macro definition existed
        /// </algorithm>
        public bool IsRegisterExist(string renesasMacroDefinition)
        {
            return register.IsRegisterExist(renesasMacroDefinition);
        }
        // Implementation: GENERIC_TUD_CLS_048_031

        /// <summary>
        /// Update current instance
        /// </summary>
        /// <param name="instanceIndex">Instance Index<range>integer</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET update current instance based index instance.
        /// </algorithm>
        public void PrepareInstance(int instanceIndex)
        {
            cdfData.PrepareInstance(instanceIndex);
        }
        // Implementation: GENERIC_TUD_CLS_048_032

        /// <summary>
        /// Get containers based DefName
        /// </summary>
        /// <param name="containers">List of container<range>empty/valid IList<Container></range></param>
        /// <param name="defName">definition ref<range>empty/valid string</range></param>
        /// <param name="sortOption">Sort type<range>integer</range></param>
        /// <returns>
        ///     <para>IList<Container>
        ///         <desc>The list of containers</desc>
        ///         <range>N/A</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get all containers from input
		/// IF variantID is empty
        ///   LET filter containers based on DefName
		/// ELSE
		///	  LET checkVariantConfigured equal to 0 or 1 if VariantID in list of result have elements that is not null
		///   IF checkVariantConfigured equal to 1
		///	    LET filter containers based on DefName and the given condition
		///	  ELSE
		///	    LET filter containers based on DefName
        /// LET sort containers that is filtered as sortOption value
        ///     0 : DefName compare then ShortName compare if same DefName
        ///     1 : ShortName compare
        ///     others : not sort
        /// </algorithm>
        private IList<Container> getContainersByDefName(IList<Container> containers, string defName, int sortOption, 
                                                                                                string variantID = "")
        {
            List<Container> result = new List<Container>();

            // Get containers based on def name and sort according to numeric last index shortname
            // or alphabet shortname
            if (false == String.IsNullOrEmpty(defName))
            {
                result = containers.ToList();

                if (string.Empty == variantID)
                {
                    result = result
                        .Where(x => defName.Equals(StringUtils.GetElementLastInArray(x.DefinitionRef)))
                        .ToList();
                }
                else
                {
                    bool checkVariantConfigured = result.Any(x => null != x.VariantID);

                    if (checkVariantConfigured)
                    {
                        result = result
                            .Where(x => defName.Equals(StringUtils.GetElementLastInArray(x.DefinitionRef)))
                            .Where(x => ((variantID.Equals(x.VariantID)) || (null == x.VariantID)))
                            .ToList();
                    }
                    else
                    {
                        result = result
                            .Where(x => defName.Equals(StringUtils.GetElementLastInArray(x.DefinitionRef)))
                            .ToList();
                    }
                }
            }
            else
            {
                // Not required
            }
            // Process sort according to sort type input.
            if (Constant.INT_ZERO == sortOption)
            {
                result.Sort(Container.Compare);
            }
            else if (Constant.INT_ONE == sortOption)
            {
                result = result.OrderBy(x => x.ShortName).ToList();
            }
            else
            {
                // Not required
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_048_035

        /// <summary>
        /// Compute values of defined parameters that is bool data type.
        /// </summary>
        /// <param name="onOffParamsGroup">The collection of on/off parameters<range>null/valid Dictionary<string, string></range></param>
        /// <returns>
        ///     <para>"BaseIntermediateItem"
        ///         <desc>The intermediate data</desc>
        ///         <range>null/valie baseIntermediateItem </range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get value of parameter in module
        /// IF value is true THEN
        ///     LET convert to STD_ON
        /// ELSE is STD_OFF
        /// </algorithm>
        public BaseIntermediateItem ComputeOnOffParams(Dictionary<string, string> onOffParamsGroup)
        {
            BaseIntermediateItem result = new BaseIntermediateItem(Constant.ON_OFF_PARAMS, String.Empty);
            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            // Check all on/off defined parameter
            foreach (string paramName in onOffParamsGroup.Keys)
            {
                ItemValue paramVal = GetParameterValue(basicConfiguration.ModuleName, paramName);
                // Check if parameter was configured
                if ((null != paramVal) && paramVal.Value<bool>())
                {
                    result.AddChild(new BaseIntermediateItem(onOffParamsGroup[paramName], Constant.STD_ON));
                }
                else
                {
                    result.AddChild(new BaseIntermediateItem(onOffParamsGroup[paramName], Constant.STD_OFF));
                }
            }// End of foreach (string paramName in onOffParamsGroup.Keys)

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_048_006


        /// <summary>
        /// Process values of dem event paramaters.
        /// </summary>
        /// <param name="demEventParamsGroup">A collection contains parameter names<range>null/valid Dictionary<string, string></range></param>
        /// <returns>
        ///     <para>"BaseIntermediateItem"
        ///         <desc>The intermediate data</desc>
        ///         <range>null/valid baseIntermediateItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF parameter is configured THEN
        ///     LET concatenate "DemConf_DemEventParameter_" and last value of paramater
        /// </algorithm>
        public BaseIntermediateItem ComputeDemEventParams(Dictionary<string, string> demEventParamsGroup)
        {
            BaseIntermediateItem result = new BaseIntermediateItem(Constant.DEM_EVENT_PARAMS, String.Empty);
            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            // Check all dem event reference parameters
            foreach (string paramName in demEventParamsGroup.Keys)
            {
                ItemValue paramVal = GetReferenceValue(basicConfiguration.ModuleName, paramName);
                // Check if parameter was configured
                if ((null != paramVal) && (!String.IsNullOrEmpty(paramVal.Value<string>())))
                {
                    // Get Dem reference path from configuration
                    string demPath = string.Concat(Constant.DEM_CONF_DEM_EVENT_PARAMETER,
                                                        StringUtils.GetElementLastInArray(paramVal.Value<string>()));
                    // Add dem path to corresponding parameter
                    result.AddChild(new BaseIntermediateItem(demEventParamsGroup[paramName], demPath));
                }
                else
                {
                    // Not required
                }
            }// End of foreach (string paramName in demEventParamsGroup.Keys)

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_048_005

        /// <summary>
        /// To compute value of all param Version Information
        /// </summary>
        /// <returns>
        ///     <para>"BaseIntermediateItem"
        ///         <desc>The intermediate data</desc>
        ///         <range>null/valid baseIntermediateItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// CALL GetVersionInformation method WITH repository for get
        /// "AR-RELEASE-VERSION", "SW-VERSION", "VENDOR-ID", "MODULE-ID"
        ///     Slipt information to {x,y,z}.
        ///     IF Ar version & Sw version have 3 element {x,y,z} THEN
        ///         LET add Cfg Version Information to child of return value
        ///         LET add Cbk Version Information to child of return value
        ///         LET add Pbcfg Version Information to child of return value
        ///         LET add LinkTime Version Information to child of return value
        /// </algorithm>
        public BaseIntermediateItem GetVersionInformation()
        {
            BaseIntermediateItem ret = new BaseIntermediateItem(Constant.VERSION_INFORMATION_DATA, string.Empty);
            BaseIntermediateItem versionInformationConf = new BaseIntermediateItem(Constant.VERSION_INFORMATION_CFG,
                                                                                                    string.Empty);
            BaseIntermediateItem versionInformationCbk = new BaseIntermediateItem(Constant.VERSION_INFORMATION_CBK,
                                                                                                    string.Empty);
            BaseIntermediateItem versionInformationPbcfg = new BaseIntermediateItem(Constant.VERSION_INFORMATION_PBCFG,
                                                                                                        string.Empty);
            BaseIntermediateItem versionInformationLinkTime = new BaseIntermediateItem(Constant.VERSION_INFORMATION_LT,
                                                                                                        string.Empty);
            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            string moduleName = basicConfiguration.ModuleName.ToUpper();

            string autosarReqInfo = GetVersionInformation(Constant.AR_RELEASE_VERSION, basicConfiguration.ModuleName);
            string softWareInfo = GetVersionInformation(Constant.SW_VERSION, basicConfiguration.ModuleName);
            string vendorId = GetVersionInformation(Constant.VENDOR_ID, basicConfiguration.ModuleName);
            string moduleId = GetVersionInformation(Constant.MODULE_ID, basicConfiguration.ModuleName);

            // split format. Ex: 4.2.2
            Dictionary<string, string> versionInformation = initVersionInformation(
                autosarReqInfo.Split('.').Select(x => x.Trim()).ToArray(),
                softWareInfo.Split('.').Select(x => x.Trim()).ToArray(),
                vendorId,
                moduleId);
            BaseIntermediateItem intermediateItem = null;
            foreach (string param in versionInformation.Keys)
            {
                BswConfig bswConfig = cdfData.GetBswConfiguration(basicConfiguration.ModuleName);
                // Process as SWS_BSW_00102 - <Ma>. Ex. ICU_59_RENESAS_Parameters
                // Keep code flow due to support deviation autosar
                string option = string.IsNullOrEmpty(bswConfig.VendorApiInfix) ? string.Empty :
                                                              $"_{vendorId}_{bswConfig.VendorApiInfix.ToUpper()}";
                intermediateItem = new BaseIntermediateItem($"{moduleName}{option}_{param}",
                                                                                    versionInformation[param]);

                // Store parameters of call back
                if (param.StartsWith(Constant.CALL_BACK))
                {
                    versionInformationCbk.AddChild(intermediateItem);
                }
                // Store parameters of post build
                else if (param.StartsWith(Constant.POST_BUILD))
                {
                    versionInformationPbcfg.AddChild(intermediateItem);
                }
                // Store parameters link time
                else if (param.StartsWith(Constant.LINK_TIME))
                {
                    versionInformationLinkTime.AddChild(intermediateItem);
                }
                // Store parameters of cfg
                else
                {
                    versionInformationConf.AddChild(intermediateItem);
                }
            }// End of foreach (string param in versionInformation.Keys)
            ret.AddChild(versionInformationConf);
            ret.AddChild(versionInformationCbk);
            ret.AddChild(versionInformationPbcfg);
            ret.AddChild(versionInformationLinkTime);

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_048_027

        /// <summary>
        /// Init values autosar version requirement and software version
        /// </summary>
        /// <param name="autosarReqInfo">Autosar version info<range>null/valid string[]</range></param>
        /// <param name="softWareInfo">software version info<range>null/valid string[]</range></param>
        /// <param name="vendorId">The vendor Id<range>empty/valid string</range></param>
        /// <param name="moduleId">The module Id<range>empty/valid string</range></param>
        /// <returns>
        ///     <para>Dictionary<string, string>
        ///         <desc>The collection of version info</desc>
        ///         <range>valid Dictionary<string, string></range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Parsing vendor ID, software info, module ID, autosar version
        /// into Published information of Generation Files such as: PreCfg, LCfg, PbCfg, Callback
        /// </algorithm>
        private Dictionary<string, string> initVersionInformation(string[] autosarReqInfo, string[] softWareInfo,
            string vendorId, string moduleId)
        {
            Dictionary<string, string> ret = new Dictionary<string, string>() {

                { Constant.CFG_AR_RELEASE_MAJOR_VERSION, $"{autosarReqInfo[0]}U" },
                { Constant.CFG_AR_RELEASE_MINOR_VERSION, $"{autosarReqInfo[1]}U" },
                { Constant.CFG_AR_RELEASE_REVISION_VERSION, $"{autosarReqInfo[2]}U" },
                { Constant.CFG_SW_MAJOR_VERSION, $"{softWareInfo[0]}U" },
                { Constant.CFG_SW_MINOR_VERSION, $"{softWareInfo[1]}U" },
                { Constant.AR_RELEASE_MAJOR_VERSION_VALUE, $"{autosarReqInfo[0]}U" },
                { Constant.AR_RELEASE_MINOR_VERSION_VALUE, $"{autosarReqInfo[1]}U" },
                { Constant.AR_RELEASE_REVISION_VERSION_VALUE, $"{autosarReqInfo[2]}U" },
                { Constant.SW_MAJOR_VERSION_VALUE, $"{softWareInfo[0]}U" },
                { Constant.SW_MINOR_VERSION_VALUE, $"{softWareInfo[1]}U" },
                { Constant.SW_PATCH_VERSION_VALUE, $"{softWareInfo[2]}U" },
                { Constant.VENDOR_ID_VALUE, $"{vendorId}U" },
                { Constant.MODULE_ID_VALUE, $"{moduleId}U" },
                { Constant.CBK_AR_RELEASE_MAJOR_VERSION, $"{autosarReqInfo[0]}U" },
                { Constant.CBK_AR_RELEASE_MINOR_VERSION, $"{autosarReqInfo[1]}U" },
                { Constant.CBK_AR_RELEASE_REVISION_VERSION, $"{autosarReqInfo[2]}U" },
                { Constant.CBK_SW_MAJOR_VERSION, $"{softWareInfo[0]}U" },
                { Constant.CBK_SW_MINOR_VERSION, $"{softWareInfo[1]}U" },
                { Constant.PBCFG_C_AR_RELEASE_MAJOR_VERSION, $"{autosarReqInfo[0]}U" },
                { Constant.PBCFG_C_AR_RELEASE_MINOR_VERSION, $"{autosarReqInfo[1]}U" },
                { Constant.PBCFG_C_AR_RELEASE_REVISION_VERSION, $"{autosarReqInfo[2]}U" },
                { Constant.PBCFG_C_SW_MAJOR_VERSION, $"{softWareInfo[0]}U" },
                { Constant.PBCFG_C_SW_MINOR_VERSION, $"{softWareInfo[1]}U" },
                { Constant.LCFG_C_AR_RELEASE_MAJOR_VERSION, $"{autosarReqInfo[0]}U" },
                { Constant.LCFG_C_AR_RELEASE_MINOR_VERSION, $"{autosarReqInfo[1]}U" },
                { Constant.LCFG_C_AR_RELEASE_REVISION_VERSION, $"{autosarReqInfo[2]}U" },
                { Constant.LCFG_C_SW_MAJOR_VERSION, $"{softWareInfo[0]}U" },
                { Constant.LCFG_C_SW_MINOR_VERSION, $"{softWareInfo[1]}U" },
                { Constant.CFG_C_AR_RELEASE_MAJOR_VERSION, $"{autosarReqInfo[0]}U" },
                { Constant.CFG_C_AR_RELEASE_MINOR_VERSION, $"{autosarReqInfo[1]}U" },
                { Constant.CFG_C_AR_RELEASE_REVISION_VERSION, $"{autosarReqInfo[2]}U" },
                { Constant.CFG_C_SW_MAJOR_VERSION, $"{softWareInfo[0]}U" },
                { Constant.CFG_C_SW_MINOR_VERSION, $"{softWareInfo[1]}U" }
            };
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_048_036

        /// <summary>
        /// Update basic configuration
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
        /// Update VendorId and VendorApiInfix with linked BSWMDT node.
        /// </algorithm>
        public void UpdateBasicConfig()
        {
            IBasicConfiguration basicConfig = ObjectFactory.GetInstance<IBasicConfiguration>();
            Configuration currentConfig = cdfData.GetCurrentInstanceConfiguration(basicConfig.ModuleName);

            BswConfig linkedBswConfig = cdfData.GetBswConfigurations().Where(x => currentConfig.ModuleDescriptionRef ==
                                                                                  x.ImplementRootPath).FirstOrDefault();

            basicConfig.VendorId = int.Parse(linkedBswConfig.VendorId);
            basicConfig.VendorApiInfix = linkedBswConfig.VendorApiInfix;
        }
        // Implementation: GENERIC_TUD_CLS_048_037

        /// <summary>
        /// Check supported variant parameters 
        /// </summary>
        /// <returns>
        ///     <para>
        ///         <desc></desc>
        ///         <range></range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = false
      	/// LET get all containers in cdfData by moduleName and parameterName
		///	IF number of item greater than 0
		///   LET result = 1 if number of list VariantIDs that have elements other than 0
		///	ELSE
        ///	  Do nothing
		///	RETURN result
        /// </algorithm>
        public bool CheckVariantParameterSupported(string moduleName, string parameterName)
        {
            bool result = false;

            IList<ItemValue> item = GetParameterValues(moduleName, parameterName);

            if (0 < item.Count)
            {
                result = item.Any(x => 0 != x.getVariantIDs().Count);
            }
            else
            {
                // Not required
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_048_038

        /// <summary>
        /// Check supported variant containers
        /// </summary>
        /// <returns>
        ///     <para>
        ///         <desc></desc>
        ///         <range></range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = false
		///	LET container = get container by moduleName and containerName
		/// LET result = return result if any element in List ItemValue of variant is not null
		/// RETURN result
        /// </algorithm>
        public bool CheckVariantContainerSupported(string moduleName, string containerName)
        {
            bool result = false;

            // Get container by moduleName and containerName
            Container container = GetContainerByDefName(moduleName, containerName);

            // Return result if any element in List ItemValue of variant is not null
            result = ((container.ParameterValues.Any(item => item.getVariantIDs() != null))
                | (container.ReferenceValues.Any(item => item.getVariantIDs() != null)));

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_048_039

        /// <summary>
        /// Get all variant configurations
        /// </summary>
        /// <returns>
        ///     <para>
        ///         <desc></desc>
        ///         <range></range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = new List of string
		///	LET get all containers in cdfData by moduleName
		/// LET result = List contains all elements from ListConfiguredVariantID in containerList with the given condition
		///	IF number of result equal to 0
		///	  LET result = new list of string with string is empty
		///	ELSE
        ///	  Do nothing
		///	RETURN result
        /// </algorithm>
        public List<string> GetAllVariantConfiguration(string moduleName)
        {
            List<string> result = new List<string>();

            IList<Container> containerList = cdfData.GetCurrentInstanceContainers(moduleName);

            result = containerList.SelectMany(x => x.ListConfiguredVariantID)
                .Where(x => null != x).Distinct().OrderBy(x => x).ToList();

            if (0 == result.Count)
            {
                result = new List<string> { string.Empty };
            }
            else
            {
                // Do nothing
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_048_040

        /// <summary>
        /// Get short name variant configuration
        /// </summary>
        /// <returns>
        ///     <para>
        ///         <desc></desc>
        ///         <range></range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = new object
		/// LET get all containers in cdfData by moduleName
		/// LET variantIDs = List of configured from parameter 
		/// LET varianIDcontainer = List of configured from parameter
		/// Add list of configured variant from container to VariantIDs
		/// LET varianSet = get all evaluated variant in cdfData
		/// IF number of variantIDs greater than 0
		///	  FOREACH container in list container
		///	    Add item to result
		/// ELSE
		///	  Make the default variant as Empty String
		/// RETURN result
        /// </algorithm>
        public Dictionary<string, string> GetShortNameVariantConfig(string moduleName)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            IList<Container> containerList = cdfData.GetCurrentInstanceContainers(moduleName);

            /* List of configured from parameter */
            List<string> varianIDs = containerList.SelectMany(x => x.ListConfiguredVariantID)
                .Where(x => null != x).Distinct().OrderBy(x => x).ToList();

            /* List of configured from parameter  */
            List<string> varianIDcontainer = containerList.Select(x => x.VariantID)
                .Where(x => null != x).Distinct().OrderBy(x => x).ToList();

            /* Add list of configured variant from container to VariantIDs */
            varianIDs.AddRange(varianIDcontainer);
            varianIDs = varianIDs.Distinct().ToList();

            Dictionary<string, string> variantSet = cdfData.GetEvaluatedVariantSet();
            
            if (0 < varianIDs.Count)
            {
                foreach(string item in varianIDs)
                {
                    result.Add(item, variantSet[item]);
                }
            }
            else
            {
                // Make the default variant as Empty String
                result.Add(string.Empty, string.Empty);
            }
            
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_048_041
    }
}
