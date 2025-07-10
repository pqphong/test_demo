/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = IRepository.cs                                                                                      */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2021, 2024 Renesas Electronics Corporation. All rights reserved.                                 */
/*====================================================================================================================*/
/* Purpose: This file contains IRepository interface that bases on basic operations of ICdfData to provide more       */
/*          convenience operations to upper layers.                                                                   */
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
/* Classes      : This file contains the following IRepository interface                                              */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            01/03/2019 :    Added method GetVersionInformation, ComputeOnOffParams,ComputeDemEventParams            */
/*                            #89553 #note24                                                                          */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.1.1:     02/07/2021 :    Add new method UpdateBasicConfig                                                        */
/* 1.1.2:     02/03/2024 :    Update argument GetContainerByDefName, GetContainersByDefName,                          */
/*                            GetContainerByShortNamePath, GetParameterValue, GetParameterValues, GetReferenceValue   */
/*                            GetReferenceValues, GetChilds, GetAllInstancesContainersByDefName                       */
/*                            Add CheckVariantParameterSupported, CheckVariantContainerSupported                      */
/*                            GetAllVariantConfiguration, GetShortNameVariantConfig                                   */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;
using System.Collections.Generic;

namespace Renesas.Generator.MCALConfGen.Data.CDFData
{
    /// <summary>
    /// This file contains IRepository interface that bases on basic operations of ICdfData to provide more
    /// convenience operations to upper layers.
    /// </summary>
    public interface IRepository
    {
        //
        // Methods applied for current instance
        //
        IList<Container> GetContainers(string moduleName = "");
        Container GetContainerByDefName(string moduleName, string defName, int sortType = 0, string variantID = "");
        IList<Container> GetContainersByDefName(string moduleName, string defName, 
                                                                            int sortOption = 0, string variantID = "");
        Container GetContainerByShortNamePath(string moduleName, string path, string variantID = "");
        ItemValue GetParameterValue(string moduleName, string defName, string variantID = "");
        IList<ItemValue> GetParameterValues(string moduleName, string defName, string variantID = "");
        ItemValue GetReferenceValue(string moduleName, string defName, string variantID = "");
        List<ItemValue> GetReferenceValues(string defName, string moduleName = "", string variantID = "");
        IList<Container> GetChilds(string moduleName, string shortName, string variantID = "");
        bool IsExistedPath(string path, string moduleName = "");
        Configuration GetConfiguration(string moduleName);
        IList<Configuration> GetConfigurations(string moduleName);
        BaseIntermediateItem ComputeDemEventParams(Dictionary<string, string> demEventParamsGroup);
        BaseIntermediateItem ComputeOnOffParams(Dictionary<string, string> onOffParamsGroup);
        //
        // Methods applied for all instances
        //
        Dictionary<string, IList<Container>> GetAllInstancesContainersByDefName(string moduleName, string defName,
                                                                            int sortOption = 0, string variantID = "");

        //
        // Instance-independent methods
        //
        string GetMacroLabelValue(string renesasMacroName);
        string GetMacroAddressValue(string renesasMacroName);
        string GetAddressByMacroDefinition(string renesasMacroName);
        string GetAddressTypeByMacroDefinition(string renesasMacroName);
        string GetVersionInformation(string name, string module = "");
        string GetCdfFileName(string shortName);
        string GetStartOfDbToc();
        bool IsExistModuleName(string moduleName);
        bool IsRegisterExist(string renesasMacroDefinition);
        void PrepareInstance(int instanceIndex);
        void UpdateBasicConfig();
        BaseIntermediateItem GetVersionInformation();

        //
        // Variant post build supported
        //
        bool CheckVariantParameterSupported(string moduleName, string parameterName);
        bool CheckVariantContainerSupported(string moduleName, string containerName);
        List<string> GetAllVariantConfiguration(string moduleName);
        Dictionary<string, string> GetShortNameVariantConfig(string moduleName);
    }
}
