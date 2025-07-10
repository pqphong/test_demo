/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = StructGenerationItem.cs                                                                             */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2022 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains StructGenerationItem that defines a struct will be output to .c files.                 */
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
/*              : class StructGenerationItem                                                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            19/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/*            28/02/2019 :    GenTool Improvement Idea #89553                                                         */
/*            25/03/2019 :    Supporting multi-line QAC message                                                       */
/*                             Updated methods: Generate                                                              */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     28/04/2021 :    Update genFieldInStructure to improve QAC message with null pointer generation          */
/*            02/07/2021 :    Change default value of hasNameInstanceSetting                                          */
/*            10/07/2021 :    Update method Generate, GenStructure, StructGenerationItem, getQacMessage,              */
/*                            genMemorySection, genFieldInStructur. Update data type of qacMapping                    */
/*            16/07/2021 :    Update pseudo code for methods StructGenerationItem, Generate, GenStructure,            */
/*                            getQacMessage, genMemorySection, genSingleStruct, genFieldInStructure                   */
/* 1.2.2:     09/08/2021 :    Change default falue of hasInstanceSetting to false, update GenStructure method         */
/*            25/08/2021 :    Add new argument of genMemorySection method, update class and struct type processing    */
/*                            Add new property structClass, memClass                                                  */
/*            31/08/2021 :    Update Generate method                                                                  */
/* 1.3.2      23/02/2022 :    Add new property preCompileMapping, update GenStructure for pre compile generation      */
/*                            Add new method isMemmapInsidePreCompile                                                 */
/* 1.3.3      10/05/2022 :    Add new argument for GenStructure method                                                */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Renesas.Generator.MCALConfGen.Properties;
using static Renesas.Generator.MCALConfGen.Data.BasicConfiguration.BasicConfiguration;

namespace Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems
{
    /// <summary>
    /// "StructGenerationItem" class that defines a struct will be output to .c files.
    /// </summary>
    public class StructGenerationItem : BaseGenerationItem
    {
        /// <summary>
        /// Inner structs or fields
        /// </summary>
        private List<BaseGenerationItem> children = new List<BaseGenerationItem>();
        // Implementation: GENERIC_TUD_CLS_014_006

        /// <summary>
        /// Struct generation item constructor
        /// </summary>
        /// <param name="preComment">Pre comment <range>null/valid string</range></param>
        /// <param name="postComment">Post comment <range>null/valid string</range></param>
        /// <param name="qacMessage">Qac message Dictionary<range>null/valid Dictionary</range></param>
        /// <param name="name">Name of define statement or struct <range>null/valid string</range></param>
        /// <param name="type">Type of a struct <range>null/valid string</range></param>
        /// <param name="value">Value of define statement <range>null/valid string</range></param>
        /// <param name="level">Level of inner struct <range>0/valid integer</range></param>
        /// <param name="hasInstanceSetting">Instance setting<range>true/false</range></param>
        /// <param name="expansion">Level of parent struct type<range>AppendType</range></param>
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
        public StructGenerationItem
        (
            string preComment,
            string postComment,
            Dictionary<string, string> qacMessage = null,
            string name = "",
            string type = "",
            int level = 0,
            bool hasInstanceSetting = false,
            AppendType expansion = AppendType.ORIGINAL)
            : base(preComment, postComment, qacMessage, name, type, String.Empty, level,
                                                                                   hasInstanceSetting, false, expansion)
        {
        }
        // Implementation: GENERIC_TUD_CLS_014_009

        /// <summary>
        /// Calculated intermediate item from specific module
        /// </summary>
        public BaseIntermediateItem data { get; set; }
        // Implementation: GENERIC_TUD_CLS_014_001

        /// <summary>
        /// The QAC mapping
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> qacMapping { get; set; }
        // Implementation: GENERIC_TUD_CLS_014_002

        /// <summary>
        /// The memory section mapping
        /// </summary>
        public Dictionary<string, List<string>> memorySectionMapping { get; set; }
        // Implementation: GENERIC_TUD_CLS_014_003

        /// <summary>
        /// The basic configuration
        /// </summary>
        public IBasicConfiguration basicConfig { get; set; }
        // Implementation: GENERIC_TUD_CLS_014_004

        /// <summary>
        /// The include memmap
        /// </summary>
        public string includeMemMap { get; set; }
        // Implementation: GENERIC_TUD_CLS_014_005

        /// <summary>
        /// The struct Class
        /// </summary>
        public string structClass { get; set; } = "CONFIG_DATA";
        // Implementation: GENERIC_TUD_CLS_014_015

        /// <summary>
        /// The mem Class
        /// </summary>
        public string memClass { get; set; } = string.Empty;
        // Implementation: GENERIC_TUD_CLS_014_016

        /// <summary>
        /// The pre compile mapping
        /// </summary>
        public Dictionary<string, string> preCompileMapping { get; set; } = new Dictionary<string, string>();
        // Implementation: GENERIC_TUD_CLS_014_017

        /// <summary>
        /// The memory section
        /// </summary>
        public enum MemorySection
        {
            START_SECTION,
            STOP_SECTION
        }
        // Implementation: CMN_TUD_DTT_003

        /// <summary>
        /// Add an inner struct or a field
        /// </summary>
        /// <param name="child">Child item <range>null/valid BaseGenerationItem</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// ADD child into children
        /// </algorithm>
        public void AddChild(BaseGenerationItem child)
        {
            children.Add(child);
        }
        // Implementation: GENERIC_TUD_CLS_014_007

        /// <summary>
        /// Generate output string of a struct
        /// </summary>
        /// <param name="genSettings">generation setting
        ///     <range>null/valid GenerationSettings</range>
        /// </param>
        /// <returns>
        ///     <para>string
        ///         <desc>The output string</desc>
        ///         <range>valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET stringBuilder = new StringBuilder()
        /// LET indentStr = (new StringBuilder()).Insert(Constant.INT_ZERO, "  ", Level).ToString()
        /// CALL AppendLine(stringBuilder, string.Empty, new string[] { PreComment }) to add pre comment
        /// IF Name is not null AND Type is not null THEN
        ///     LET instSetting = (genSettings != null) ? genSettings.InstanceSetting : null
        ///     LET nameOfInstance = Name
        ///     IF HasNameInstanceSetting is true AND instSetting is not null AND instSetting.IsMultiInstance is true
        ///     THEN
        ///         LET nameOfInstance = CALL AppendSuffixToMacro for instSetting with macro is nameOfInstance
        ///     ELSE
        ///         Do nothing
        ///         
        ///     LET structDefine = WrapText(indentStr + String.Format("{0} {1} =", Type, nameOfInstance)) 
        ///     CALL stringBuilder.AppendLine(AddQACMessage(structDefine, Type, nameOfInstance, QACMessage))
        /// ELSE
        ///     Do nothing
        /// FOREACH childItem IN noNullChilds WHERE childItem is not null
        ///     IF childItem does not equal to lastItem THEN
        ///         CALL childItem.SetLastItem(true)
        ///     ELSE
        ///         Do nothing
        ///     CALL childItem.SetLevel(Level + CHILD_LEVEL)
        ///     CALL stringBuilder.AppendLine WITH childItem.Generate(genSettings)
        /// CALL AppendLine(stringBuilder, indentStr, new string[] { PostComment }) to append post comment
        ///
        /// RETURN stringBuilder.ToString().TrimEnd()
        /// </algorithm>
        internal override string Generate(GenerationSettings genSettings)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string indentStr = (new StringBuilder()).Insert(Constant.INT_ZERO, "  ", Level).ToString();
            IEnumerable<BaseGenerationItem> noNullChilds = children.Where(e => null != e);
            BaseGenerationItem lastItem = noNullChilds.LastOrDefault();

            // Add precomment and start QAC string of a struct
            AppendLine(stringBuilder, indentStr, new string[] { PreComment });

            // Concatenate string of a struct type format
            if ((false == String.IsNullOrEmpty(Name)) && (false == String.IsNullOrEmpty(Type)))
            {
                InstanceSetting instSetting = (genSettings != null) ? genSettings.InstanceSetting : null;
                string nameOfInstance = Name;

                // If apply multi-instance, add suffix to name of struct.
                // Ex. CONST(Wdg_59_ConfigType, WDG_59_CONFIG_CONST) Wdg_59_GstConfiguration_0 (0 is suffix)
                if (HasNameInstanceSetting && instSetting != null && instSetting.IsMultiInstance)
                {
                    nameOfInstance = instSetting.AppendSuffixToMacro(nameOfInstance, Expansion);
                }// End of if (HasNameInstanceSetting && instSetting != null && instSetting.IsMultiInstance)
                else
                {
                    // Not required
                }
                string structDefine = indentStr + WrapText(String.Format("{0} {1} =", Type, nameOfInstance));                
                stringBuilder.AppendLine(AddQACMessage(structDefine, Type, nameOfInstance, QACMessage));
            }// End of if ((false == String.IsNullOrEmpty(Name)) && (false == String.IsNullOrEmpty(Type)))
            else
            {
                // Not required
            }

            stringBuilder.AppendLine(indentStr + "{");

            // Concatenate string of all inner struct element, which is separated by comma, excepted last item
            foreach (BaseGenerationItem childItem in noNullChilds.Where(x => null != x))
            {
                if (childItem == lastItem)
                {
                    childItem.SetLastItem(true);
                }
                else
                {
                    // Not required
                }
                childItem.SetLevel(Level + CHILD_LEVEL);
                stringBuilder.AppendLine(childItem.Generate(genSettings));

            } // End of foreach (BaseGenerationItem childItem in noNullChilds.Where(x => null != x)).

            stringBuilder.AppendLine(indentStr + "}" + (IsLast ? String.Empty : (Level == PARENT_LEVEL ? ";" : ",")));

            // Add end QAC and postcomment string of a struct
            AppendLine(stringBuilder, indentStr, new string[] { PostComment });

            return stringBuilder.ToString().TrimEnd();
        }
        // Implementation: GENERIC_TUD_CLS_014_010

        /// <summary>
        /// Generate the content of struct
        /// </summary>
        /// <param name="structName">struct name<range>null/valid string</range></param>
        /// <param name="qualifier">qualifier<range>null/valid string</range></param>
        /// <param name="structComment">struct comment<range>null/valid string</range></param>
        /// <param name="structItemNum">optional struct item number<range>null/valid string</range></param>
        /// <param name="isArray">optional array detection<range>true/false</range></param>
        /// <returns>
        ///     <para>List<BaseGenerationItem>
        ///         <desc>The output string</desc>
        ///         <range>empty/valid list "BaseGenerationItem"</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET ret = new List<BaseGenerationItem>()
        /// LET name = isArray ? $"{structName}[{structItemNum}]" : structName
        /// LET qacMessage = CALL getQacMessage(structName, qacMapping) to get corresponding QAC message
        /// LET module = basicConfig.ModuleName.Split('_')[0]
        /// IF CALL isMemmapInsidePreCompile(structName) is true
        ///     Create struct pre compile then ADD to ret
        ///     ADD memory start section based on struct name
        /// ELSE
        ///     ADD memory start section based on struct name
        ///     IF struct has precompile
        ///         Create struct pre compile then ADD to ret
        /// IF structComment is not null THEN
        ///     Create struct comment then ADD to ret
        /// ELSE
        ///     Do nothing
        /// IF data is not null AND data.Childs.Count is greater than 0 THEN
        ///     LET dataType = $"{qualifier}({structType}, {className})"
        ///     LET structGeneration = new StructGenerationItem(String.Empty, string.Empty, qacMessage, name, dataType)
        ///     FOREACH child IN data.Childs
        ///         IF child.Childs.Count is greater than 0 THEN
        ///             CALL genSingleStruct(child, count, qacMapping) then ADD to structGeneration
        ///         ELSE
        ///             CALL genFieldInStructure(child, qacMapping) then ADD to structGeneration
        ///     ADD structGeneration to ret
        /// ELSE
        ///     Do nothing
        /// CALL BreakLineGenerationItem() then ADD to ret
        /// IF CALL isMemmapInsidePreCompile(structName) is true
        ///     ADD memory stop section based on struct name to ret
        ///     Create struct end pre compile then ADD to ret
        /// ELSE
        ///     IF struct has precompile
        ///         Create struct end pre compile then ADD to ret
        ///     ADD memory stop section based on struct name to ret
        ///
        /// RETURN ret
        /// </algorithm>
        public List<BaseGenerationItem> GenStructure(string structName, string qualifier, string structComment, 
                                                                        string structItemNum = "", bool isArray = true)
        {
            List<BaseGenerationItem> ret = new List<BaseGenerationItem>();
            string name = isArray ? $"{structName}[{structItemNum}]" : structName;
            Dictionary<string, string> qacMessage = getQacMessage(structName, qacMapping);
            string module = basicConfig.ModuleName.Split('_')[0];

            // Define memory class
            // Add memory start section based on struct name
            if (isMemmapInsidePreCompile(structName))
            {
                string memSecName = memorySectionMapping.Keys.Where(x =>
                                                        memorySectionMapping[x].Contains(structName)).FirstOrDefault();
                ret.Add(new StringGenerationItem(preCompileMapping[structName]));
                ret.AddRange(genMemorySection(structName, MemorySection.START_SECTION,
                includeMemMap,
                new Dictionary<string, List<string>>() { { memSecName, new List<string>() { structName } } },
                HasNameInstanceSetting));
            }
            else
            {
                ret.AddRange(genMemorySection(structName, MemorySection.START_SECTION,
                includeMemMap,
                memorySectionMapping,
                HasNameInstanceSetting));
                if (preCompileMapping.ContainsKey(structName) && !string.IsNullOrEmpty(preCompileMapping[structName]))
                {
                    ret.Add(new StringGenerationItem(preCompileMapping[structName]));
                }
                else
                {
                    //Do nothing
                }
            }

            if (!string.IsNullOrEmpty(structComment))
            {
                ret.Add(new CommentGenerationItem(structComment));
            }
            else
            {
                // Not required
            }

            if (null != data && 0 < data.Childs.Count)
            {
                string className = !HasNameInstanceSetting ? $"{module.ToUpper()}_{structClass}" :
                          basicConfig.AppendInstanceToMacro($"{module.ToUpper()}_{structClass}", AppendType.FULL_UPPER);

                string structType = !HasNameInstanceSetting ? data.Value :
                                                     basicConfig.AppendInstanceToMacro(data.Value, AppendType.ORIGINAL);
                string dataType = string.Empty;
                if (!string.IsNullOrEmpty(memClass))
                {
                    string memName = !HasNameInstanceSetting ? $"{module.ToUpper()}_{memClass}" :
                             basicConfig.AppendInstanceToMacro($"{module.ToUpper()}_{memClass}", AppendType.FULL_UPPER);
                    dataType = $"{qualifier}({structType}, {memName}, {className})";
                }
                else
                {
                    dataType = $"{qualifier}({structType}, {className})";
                }  
                
                StructGenerationItem structGeneration = new StructGenerationItem(String.Empty,
                    string.Empty,
                    qacMessage,
                    name,
                    dataType,
                    hasInstanceSetting: HasNameInstanceSetting,
                    expansion: Expansion);
                int count = 0;
                foreach (var child in data.Childs)
                {
                    if (0 < child.Childs.Count)
                    {
                        structGeneration.AddChild(genSingleStruct(child, count, qacMapping));
                        count++;
                    }
                    else
                    {
                        structGeneration.AddChild(genFieldInStructure(child, qacMapping));
                    }
                }
                ret.Add(structGeneration);
            }
            else
            {
                //Do nothing
            }//End of if ((null != data) && (0 < data.Childs.Count))
            ret.Add(new BreakLineGenerationItem());

            if (isMemmapInsidePreCompile(structName))
            {
                string memSecName = memorySectionMapping.Keys.Where(x =>
                                                        memorySectionMapping[x].Contains(structName)).FirstOrDefault();
                // Add memory stop section based on struct name
                ret.AddRange(genMemorySection(structName, MemorySection.STOP_SECTION,
                    includeMemMap, 
                    new Dictionary<string, List<string>>() { { memSecName, new List<string>() { structName } } }, 
                    HasNameInstanceSetting));
                ret.Add(new StringGenerationItem("#endif"));
            }
            else
            {
                if (preCompileMapping.ContainsKey(structName) && !string.IsNullOrEmpty(preCompileMapping[structName]))
                {
                    ret.Add(new StringGenerationItem("#endif"));
                }
                else
                {
                    //Do nothing
                }
                
                // Add memory stop section based on struct name
                ret.AddRange(genMemorySection(structName, MemorySection.STOP_SECTION,
                    includeMemMap, memorySectionMapping, HasNameInstanceSetting));
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_014_008

        /// <summary>
        /// Update QAC message
        /// </summary>
        /// <param name="param">Parameter to get QAC message<range>null/valid string</range></param>
        /// <param name="qacMapping">QAC mapping<range>Null/!=Null</range></param>
        /// <returns>
        ///     <para> Dictionary<string,string>
        ///         <desc>QAC message of parameter</desc>
        ///         <range>Valid Dictionary</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET ret = null
        /// IF qacMapping constains param 
        ///         LET ret = value of qacMapping at index , with value of index is param
        /// ELSE
        ///         Do nothing
        /// RETURN ret
        /// </algorithm>
        private Dictionary<string, string> getQacMessage(string param, 
                                                              Dictionary<string, Dictionary<string, string>> qacMapping)
        {
            Dictionary<string, string> ret = null;
            if (qacMapping.ContainsKey(param))
            {
                ret = qacMapping[param];
            }
            else
            {
                //Do nothing
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_014_014

        /// <summary>
        /// Generate data for memory section based on struct name
        /// </summary>
        /// <param name="structName">struct name<range>null/valid string</range></param>
        /// <param name="memorySection">Parameter to get QAC message<range>null/valid string</range></param>
        /// <param name="includeMem">The include memmap<range>null/valid string</range></param>
        /// <param name="MemorySectionMapping">Memory section mapping<range>null/valid dictionary</range></param>
        /// <param name="hasInstanceSetting">instance setting config<range>true/false</range></param>
        /// <returns>
        ///     <para>List<BaseGenerationItem>
        ///         <desc>"Generation" item for include memmap</desc>
        ///         <range>Null/!=Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET startSection = String.Empty
        /// LET stopSection = String.Empty
        /// LET moduleName = basicConfig.ModuleName.ToUpper()
        /// LET qacMessage = null
        /// LET ret = new List<BaseGenerationItem>()
        /// FOREACH memSection IN Keys of MemorySectionMapping
        ///     LET startSection = $"{moduleName}_START_SEC_{memSection}"
        ///     LET stopSection = $"{moduleName}_STOP_SEC_{memSection}"
        ///     LET structNames = MemorySectionMapping[memSection]
        ///     IF memorySection is START_SECTION AND structName is first item of structNames THEN
        ///         LET qacMessage = CALL getQacMessage(memSection + Constant.StartSec, qacMapping)
        ///         CALL new DefineGenerationItem(string.Empty, string.Empty, String.Empty, String.Empty, startSection, string.Empty))
        ///         then ADD to ret
        ///         CALL new StringGenerationItem(includeMem, qacMessage) then ADD to ret
        ///         CALL new BreakLineGenerationItem() then ADD to ret
        ///     ELSE IF memorySection is END_SECTION AND structName is last item of structNames THEN
        ///         LET qacMessage = CALL getQacMessage(memSection + Constant.StopSec, qacMapping)
        ///         CALL new DefineGenerationItem(string.Empty, string.Empty, String.Empty, String.Empty, stopSection, string.Empty))
        ///         then ADD to ret
        ///         CALL new StringGenerationItem(includeMem, qacMessage) then ADD to ret
        ///         CALL new BreakLineGenerationItem() then ADD to ret
        ///     ELSE
        ///         Do nothing
        /// RETURN ret
        /// </algorithm>
        private List<BaseGenerationItem> genMemorySection(string structName,
            MemorySection memorySection, string includeMem,
            Dictionary<string, List<string>> MemorySectionMapping, bool hasInstanceSetting)
        {
            string startSection = String.Empty;
            string stopSection = String.Empty;
            string moduleName = basicConfig.ModuleName.ToUpper();
            Dictionary<string, string> qacMessage = null;
            List <BaseGenerationItem> ret = new List<BaseGenerationItem>();
            foreach (string memSection in MemorySectionMapping.Keys)
            {
                startSection = $"{moduleName}_START_SEC_{memSection}";
                stopSection = $"{moduleName}_STOP_SEC_{memSection}";
                List<string> structNames = MemorySectionMapping[memSection];

                if (memorySection.Equals(MemorySection.START_SECTION) &&
                    structNames[0].Equals(structName))
                {
                    //First item found, start section here
                    qacMessage = getQacMessage(memSection + Constant.StartSec, qacMapping);
                    ret.Add(new DefineGenerationItem(string.Empty, string.Empty, null,
                        startSection,
                        string.Empty,
                        hasNameInstanceSetting : hasInstanceSetting));
                    ret.Add(new StringGenerationItem(includeMem, qacMessage));
                    ret.Add(new BreakLineGenerationItem());
                }
                else if (memorySection.Equals(MemorySection.STOP_SECTION) &&
                    structNames[structNames.Count - 1].Equals(structName))
                {
                    //For last struct, insert stop section here
                    qacMessage = getQacMessage(memSection + Constant.StopSec, qacMapping);
                    ret.Add(new DefineGenerationItem(string.Empty, string.Empty, null,
                        stopSection,
                        string.Empty,
                        hasNameInstanceSetting : hasInstanceSetting));
                    ret.Add(new StringGenerationItem(includeMem, qacMessage));
                    ret.Add(new BreakLineGenerationItem());
                }
                else
                {
                    // Do nothing
                }
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_014_012

        /// <summary>
        /// Generate a struct that includes only single item
        /// </summary>
        /// <param name="child">"Intermediate" item used to generate struct info<range>null/valid "BaseIntermediateItem"</range></param>
        /// <param name="index">Index of struct item<range>0/valid integer</range></param>
        /// <param name="qacMapping">QAC message mapping<range>null/valid dictionary</range></param>
        /// <returns>
        ///     <para>StructGenerationItem
        ///         <desc>"Generation" item of struct</desc>
        ///         <range>Null/!=Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET childStruct = new StructGenerationItem(
        ///     $"Index: {index} - {child.Name}",
        ///     string.Empty, null, string.Empty, string.Empty)
        /// FOREACH subChild IN child.Childs
        ///     IF subChild.Childs.Count is greater than 0 THEN
        ///         CALL genSingleStruct(subChild, indexSubChild, qacMapping) then ADD to childStruct
        ///     ELSE
        ///         CALL genFieldInStructure(subChild, qacMapping) then ADD to childStruct
        ///         IF indexSubChild != (child.Childs.Count - 1) THEN
        ///             CALL new BreakLineGenerationItem() then ADD to childStruct
        ///         ELSE
        ///             Do nothing
        /// RETURN childStruct
        /// </algorithm>
        private StructGenerationItem genSingleStruct(BaseIntermediateItem child, int index,
                                                            Dictionary<string, Dictionary<string, string>> qacMapping)
        {
            StructGenerationItem childStruct = new StructGenerationItem(
                $"Index: {index} - {child.Name}",
                string.Empty, null, string.Empty, string.Empty);
            int indexSubChild = 0;
            foreach (var subChild in child.Childs)
            {
                if (subChild.Childs.Count > 0)
                {
                    childStruct.AddChild(genSingleStruct(subChild, indexSubChild, qacMapping));
                }
                else
                {
                    childStruct.AddChild(genFieldInStructure(subChild, qacMapping));
                    // Add newline if current struct is not the last one
                    if (indexSubChild != (child.Childs.Count - 1))
                    {
                        childStruct.AddChild(new BreakLineGenerationItem());
                    }
                    else
                    {
                        //Do nothing
                    }
                }
                indexSubChild++;
            }
            return childStruct;
        }
        // Implementation: GENERIC_TUD_CLS_014_013

        /// <summary>
        /// Generate field in a structure
        /// </summary>
        /// <param name="item">"Intermediate" item used to generate field info<range>null/valid BaseIntermediateItem</range></param>
        /// <param name="qacMapping">QAC message mapping<range>null/valid string</range></param>
        /// <returns>
        ///     <para>BaseGenerationItem
        ///         <desc>"Generation" item of field</desc>
        ///         <range>Null/!=Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate a field in a structure with comment if this field has value in intermediate data
        /// IF (item != null) THEN
        ///     IF item is not null pointer THEN
        ///         CALL getQacMessage WITH item.Name, qacMapping THEN add result into qacMessage
        ///     ELSE
        ///         Do nothing
        ///     LET string preComment = "<item.Name>"
        ///     LET BaseGenerationItem ret = StructMemberGenerationItem(preComment,
        ///                               string.Empty, qacMessage, value)
        /// ELSE
        ///     LET BaseGenerationItem ret = new BreakLineGenerationItem();
        /// RETURN ret
        /// </algorithm>
        private BaseGenerationItem genFieldInStructure(BaseIntermediateItem item, 
                                                            Dictionary<string, Dictionary<string, string>> qacMapping)
        {
            BaseGenerationItem ret = null;
            string value = item.Value;
            if (!string.IsNullOrEmpty(value))
            {
                Dictionary<string, string> qacMessage = null;
                string preComment = $"{item.Name}";

                if (!StringUtils.IsNullPointer(value))
                {
                    qacMessage = getQacMessage(item.Name, qacMapping);
                }
                else
                {
                    // do nothing
                }
                ret = new StructMemberGenerationItem(preComment, string.Empty, qacMessage, value);
            }
            else
            {
                ret = new BreakLineGenerationItem();
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_014_011

        /// <summary>
        /// Check memory section need to be in Precompile switch
        /// </summary>
        /// <returns>
        ///     <para>bool
        ///         <desc>value of condition</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Initialize ret value
        /// Get memory section name of structName
        /// IF all struct in memorySectionMapping[memSecName] have preCompile
        ///     LET ret = true
        /// RETURN ret
        /// </algorithm>
        private bool isMemmapInsidePreCompile (string structName)
        {
            bool ret = false;

            string memSecName = memorySectionMapping.Keys.Where(x => 
                                                        memorySectionMapping[x].Contains(structName)).FirstOrDefault();
            if (!string.IsNullOrEmpty(memSecName) && memorySectionMapping[memSecName].All(
                                x => (preCompileMapping.ContainsKey(x) && !string.IsNullOrEmpty(preCompileMapping[x]))))
            {
                ret = true;
            }
            else
            {
                //Do nothing
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_014_018
    }
}
