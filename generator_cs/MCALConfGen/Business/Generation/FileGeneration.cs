/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = FileGeneration.cs                                                                                   */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2022 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains FileGeneration a base class for other classes used to generate .h and .c files.        */
/*          It also implements GenerateFile method of interface IFileGeneration.                                      */
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
/*              : class FileGeneration                                                                                */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            19/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    Update method FileGeneration                                                            */
/*            10/07/2021 :    Update method Gen_GentoolVersion                                                        */
/*            16/07/2021 :    Update pseudo code for method FileGeneration                                            */
/* 1.3.2      23/02/2022 :    Update Gen_InputFiles for format of date time                                           */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Properties;
using static Renesas.Generator.MCALConfGen.Business.Generation.ItemGenerationAttribute;
using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using System.Globalization;

namespace Renesas.Generator.MCALConfGen.Business.Generation
{
    /// <summary>
    /// "FileGeneration" is a abstract class for other classes used to generate .h and .c files.
    /// It also implements GenerateFile method of interface "IFileGeneration".
    /// </summary>
    public abstract class FileGeneration : IFileGeneration
    {
        /// <summary>
        /// Property of file name
        /// </summary>
        protected string FileName { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_005_001

        /// <summary>
        /// Property of Output directory
        /// </summary>
        protected string OutputDirectory { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_005_002

        /// <summary>
        /// Property of Description
        /// </summary>
        protected string Description { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_005_003

        /// <summary>
        /// To record log information for debugging.
        /// </summary>
        protected ILogger Logger = null;
        // Implementation: GENERIC_TUD_CLS_005_004

        /// <summary>
        /// To store basic information of Gentool.
        /// </summary>
        protected IBasicConfiguration BasicConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_005_005

        /// <summary>
        /// To define information processed by command line.
        /// </summary>
        protected IRuntimeConfiguration RuntimeConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_005_006

        /// <summary>
        /// To save and retrive data intermediation.
        /// </summary>
        protected IIntermediateData IntermediateData = null;
        // Implementation: GENERIC_TUD_CLS_005_007

        /// <summary>
        /// To record Error, Warning,Info information and exit Gentool.
        /// </summary>
        protected IUserInterface UserInterface = ObjectFactory.GetInstance<IUserInterface>();
        // Implementation: GENERIC_TUD_CLS_005_008

        /// <summary>
        /// To store "Generation" setting instances.
        /// </summary>
        protected GenerationSettings GenSettings = new GenerationSettings();
        // Implementation: GENERIC_TUD_CLS_005_009

        /// <summary>
        /// File generation constructor
        /// </summary>
        /// <param name="fileName">File name <range>null/valid string</range></param>
        /// <param name="outputDirectory">Output directory <range>null/valid string</range></param>
        /// <param name="logger">Logger <range>null/valid ILogger</range></param>
        /// <param name="basicConfiguration">Basic configuration <range>null/valid IBasicConfiguration</range></param>
        /// <param name="runtimeConfiguration">Runtime configuration <range>null/valid "IRuntimeConfiguration"</range></param>
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
        /// LET GenSettings.InstanceSetting = new InstanceSetting with basicConfiguration
        /// LET FileName = fileName
        /// LET this.Logger = logger
        /// LET this.BasicConfiguration = basicConfiguration
        /// LET this.RuntimeConfiguration = runtimeConfiguration
        /// LET this.IntermediateData = intermediateData
        /// </algorithm>
        protected FileGeneration
        (
            string fileName,
            string outputDirectory,
            ILogger logger,
            IBasicConfiguration basicConfiguration,
            IRuntimeConfiguration runtimeConfiguration,
            IIntermediateData intermediateData
        )
        {
            GenSettings.InstanceSetting = new InstanceSetting(basicConfiguration);

            FileName = basicConfiguration.AppendInstanceToFileName(fileName);
            OutputDirectory = outputDirectory;
            this.Logger = logger;
            this.BasicConfiguration = basicConfiguration;
            this.RuntimeConfiguration = runtimeConfiguration;
            this.IntermediateData = intermediateData;
        }
        // Implementation: GENERIC_TUD_CLS_005_014

        /// <summary>
        /// Get attribute section
        /// </summary>
        /// <param name="method">method metadata<range>null/valid MethodInfo</range></param>
        /// <returns>
        ///     <para>SectionName
        ///         <desc>The section name</desc>
        ///         <range>Enum of SectionName</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET attribute = CALL method.GetCustomAttribute(typeof(ItemGenerationAttribute), false) to get method's attribute
        /// IF attribute is not null THEN
        ///     LET ret = attribute.Section
        /// ELSE
        ///     Do nothing
        /// RETURN ret
        /// </algorithm>
        public SectionName GetAttrSection(MethodInfo method)
        {
            ItemGenerationAttribute attribute =
                            (ItemGenerationAttribute)method.GetCustomAttribute(typeof(ItemGenerationAttribute), false);
            ItemGenerationAttribute.SectionName ret = ItemGenerationAttribute.SectionName.END_OF_FILE;
            // Get section attribute of method to output macro to proper sections.
            if (null != attribute)
            {
                ret = attribute.Section;
            }
            else
            {
                // Not required
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_005_011

        /// <summary>
        /// Get attribute sectionOrder
        /// </summary>
        /// <param name="method">method metadata<range>null/valid MethodInfo</range></param>
        /// <returns>
        ///     <para>float
        ///         <desc>The section attribute order value</desc>
        ///         <range>valid float</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET attribute = CALL method.GetCustomAttribute(typeof(ItemGenerationAttribute), false) to get method's attribute
        /// IF attribute is not null THEN
        ///     LET ret = attribute.SectionOrder
        /// ELSE
        ///     Do nothing
        /// RETURN ret
        /// </algorithm>
        public float GetAttrSectionOrder(MethodInfo method)
        {
            ItemGenerationAttribute attribute =
                           (ItemGenerationAttribute)method.GetCustomAttribute(typeof(ItemGenerationAttribute), false);
            float ret = 0;
            // Get order section attribute of method to output macro to proper order in a section.
            if (null != attribute)
            {
                ret = attribute.SectionOrder;
            }
            else
            {
                // Not required
            }

            return ret;

        }
        // Implementation: GENERIC_TUD_CLS_005_012

        /// <summary>
        /// Generate an output file. It can be .h or .c file.
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
        /// LET stringBuilder = new StringBuilder()
        /// LET sections = Collection of all non-public methods which have ItemGeneration attribute and sort them by Section
        /// FOREACH section IN sections
        ///     methods = Collection of all methods sorted by its order
        ///     FOREACH method IN methods
        ///         LET newLineAttribute = method.GetCustomAttribute<NewLineAttribute>()
        ///         IF newLineAttribute is not null THEN
        ///             CALL new BreakLineGenerationItem(newLineAttribute.NumberOfNewLines) then ADD to items
        ///         ELSE
        ///             Do nothing
        ///         IF type of method.ReturnType is BaseGenerationItem[] THEN
        ///             LET addedItems = (BaseGenerationItem[])method.Invoke(this, new object[] { })
        ///             IF addedItems is not null THEN
        ///                 CALL AddRange(addedItems) to add to items
        ///             ELSE
        ///                 Do nothing
        ///         ELSE
        ///             Do nothing
        /// </algorithm>
        public virtual void GenerateFile()
        {
            StringBuilder stringBuilder = new StringBuilder();
            // Scan all non-public methods which have ItemGeneration attribute and sort them by Section
            // Object is generate macro in a Section
            IEnumerable<IGrouping<ItemGenerationAttribute.SectionName, MethodInfo>> sections =
                    GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                    .Where(method => null != method.GetCustomAttribute<ItemGenerationAttribute>())
                    .GroupBy(method =>
                    {
                        // This is not return of funtion. don't violate coding rule.
                        return GetAttrSection(method);
                    })
                    .OrderBy(method => method.Key);

            // For each section groups, scan all methods which are sorted by same Order
            // Object is generate macros in an proper order in a section
            foreach (IGrouping<ItemGenerationAttribute.SectionName, MethodInfo> section in sections)
            {
                IEnumerable<MethodInfo> methods = section
                    .OrderBy(method =>
                    {
                        // This is not return of funtion. don't violate coding rule.
                        return GetAttrSectionOrder(method);
                    });
                List<BaseGenerationItem> items = new List<BaseGenerationItem>();

                // For each methods with same Order
                foreach (MethodInfo method in methods)
                {
                    NewLineAttribute newLineAttribute = method.GetCustomAttribute<NewLineAttribute>();

                    // If method has NewLine attribute, generate new lines based on value of NumberOfNewLines
                    if (null != newLineAttribute)
                    {
                        items.Add(new BreakLineGenerationItem(newLineAttribute.NumberOfNewLines));
                    }
                    else
                    {
                        // Not required
                    }

                    // Calculate each method to write result to output files
                    // Incase: return type of this method is list of BaseGenerationItem
                    if (typeof(BaseGenerationItem[]) == method.ReturnType)
                    {
                        BaseGenerationItem[] addedItems = (BaseGenerationItem[])method.Invoke(this, new object[] { });

                        if (null != addedItems)
                        {
                            items.AddRange(addedItems);
                        }
                        else
                        {
                            // Not required
                        }
                    } // End of if (typeof(BaseGenerationItem[]) == method.ReturnType).
                    // Incase: return type of this method is a BaseGenerationItem
                    else if (typeof(BaseGenerationItem) == method.ReturnType)
                    {
                        BaseGenerationItem addedItems = (BaseGenerationItem)method.Invoke(this, new object[] { });

                        if (null != addedItems)
                        {
                            items.Add(addedItems);
                        }
                        else
                        {
                            // Not required
                        }
                    } // End of if (typeof(BaseGenerationItem) == method.ReturnType).
                    else
                    {
                        // Not required
                    }
                } // End of foreach (MethodInfo method in methods).

                stringBuilder.Append((new Section(
                        ItemGenerationAttribute.GetSectionName(section.Key),
                        BaseGenerationItem.Generate(items.ToArray(), GenSettings))).Generate());
            } // End of foreach (IGrouping<ItemGenerationAttribute.SectionName, MethodInfo> section in sections).

            WriteToFile(stringBuilder.ToString());

            Logger.Debug("Write to file {0}{1}", OutputDirectory, FileName);
        }
        // Implementation: GENERIC_TUD_CLS_005_010

        /// <summary>
        /// Write to file
        /// </summary>
        /// <param name="buffer">The buffer string to be written<range>null/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_019,
        /// CMN_TAD_USG_009
        /// </ref>
        /// <algorithm>
        /// IF RuntimeConfiguration.DryRun is true THEN
        ///     IF OutputDirectory is not null AND OutputDirectory does not exist THEN
        ///         CALL IOWrapper.CreateDirectory WITH OutputDirectory to create new folder
        ///     ELSE
        ///         Do nothing
        ///     TRY
        ///         LET path = string.Concat(OutputDirectory, FileName)
        ///         CALL IOWrapper.StreamWrite WITH buffer to write to path
        ///     CATCH
        ///         Raise ERR000019
        /// ELSE
        ///     Do nothing
        /// </algorithm>
        public virtual void WriteToFile(string buffer)
        {
            // Ref: GENERIC_TUM_U2X_GT_ERR_019
            string path = string.Empty;
            if (false == RuntimeConfiguration.DryRun)
            {
                // Create output directory if not exists
                if ((false == String.IsNullOrEmpty(OutputDirectory)) &&
                    (false == IOWrapper.DirectoryExists(OutputDirectory)))
                {
                    IOWrapper.CreateDirectory(OutputDirectory);
                }
                else
                {
                    // Not required
                }

                // Report error if exception is catched in case output files can not write.
                try
                {
                    if (false == OutputDirectory.EndsWith(Path.DirectorySeparatorChar.ToString()))
                    {
                        OutputDirectory = OutputDirectory + Path.DirectorySeparatorChar;
                    }
                    else
                    {
                        // Not required
                    }
                    path = string.Concat(OutputDirectory, FileName);
                    using (StreamWriter streamWriter = UserInterface.OpenFile(path))
                    {
                        IOWrapper.StreamWrite(streamWriter, buffer, path);
                    }
                } // End of try.
                catch (Exception)
                {
                    // Can not open file
                    UserInterface.Error(0, 19, Resources.ERR000019, path);
                    UserInterface.Exit();
                }
            } // End of if (false == runtimeConfiguration.DryRun).
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_005_013

        /// <summary>
        /// Generate copyright
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of copyright info</desc>
        ///         <range>Null/BaseGenerationItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate copyright from template
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.COPY_RIGHT)]
        protected virtual BaseGenerationItem[] GenCOPYRIGHTSection()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "FileName", FileName},
                { "MicroFamilyName", BasicConfiguration.MicroFamilyName},
                { "Description", Description},
                { "DeviceName", BasicConfiguration.DeviceNames.FirstOrDefault()},
            };
            // Generate content copy right that has a template.
            string copyRight = StringUtils.GetStringFromTemplate(Resources.CopyrightTemplate, dictionary);

            return new BaseGenerationItem[] { new StringGenerationItem(copyRight) };
        }
        // Implementation: GENERIC_TUD_CLS_005_015

        /// <summary>
        /// Generate revision history
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of revision history</desc>
        ///         <range>Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN null
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.REVISION_HISTORY)]
        protected virtual BaseGenerationItem[] GenRevisionHistorySection()
        {
            return null;
        }
        // Implementation: GENERIC_TUD_CLS_005_018

        /// <summary>
        /// Generate include section
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of include section</desc>
        ///         <range>Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN null
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.INCLUDE)]
        protected virtual BaseGenerationItem[] GenIncludeSection()
        {
            return null;
        }
        // Implementation: GENERIC_TUD_CLS_005_017

        /// <summary>
        /// Generate version information
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of version information</desc>
        ///         <range>Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN null
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.VERSION_INFO)]
        protected virtual BaseGenerationItem[] GenVersionInformationSection()
        {
            return null;
        }
        // Implementation: GENERIC_TUD_CLS_005_019

        /// <summary>
        /// Generate end of file section
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem[]
        ///         <desc>BaseGenerationItem of end of file section</desc>
        ///         <range>Null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// RETURN null
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.END_OF_FILE)]
        protected virtual BaseGenerationItem[] GenEND_OF_FILE()
        {
            return null;
        }
        // Implementation: GENERIC_TUD_CLS_005_016

        /// <summary>
        /// Generate tool version
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem
        ///         <desc>BaseGenerationItem of tool version</desc>
        ///         <range>Null/BaseGenerationItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate tool version from template
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.GENTOOL_VERSION)]
        protected virtual BaseGenerationItem Gen_GentoolVersion()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                {
                    "Version", String.Concat(ObjectFactory.ModuleDllName, " version: ", ObjectFactory.ModuleDllVersion,
                    Constant.ListSeparator, BasicConfiguration.ExecutionName, " version: ", 
                                                                                    BasicConfiguration.ExecutionVersion)
                }
            };
            string toolVersion = StringUtils.GetStringFromTemplate(Resources.GentoolVersionTemplate, dictionary);

            return new StringGenerationItem(toolVersion);
        }
        // Implementation: GENERIC_TUD_CLS_005_020

        /// <summary>
        /// Generate input files paths
        /// </summary>
        /// <returns>
        ///     <para>BaseGenerationItem
        ///         <desc>BaseGenerationItem of input files' paths</desc>
        ///         <range>Null/BaseGenerationItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Generate file paths which are inputs to generation tool by using a template
        /// </algorithm>
        [ItemGeneration(Section = ItemGenerationAttribute.SectionName.INPUT_FILES)]
        protected virtual BaseGenerationItem Gen_InputFiles()
        {
            List<string> files = new List<string>();
            Dictionary<string, string> dictionary = null;
            // Generate all input files include time, file path in .c, .h
            files.AddRange(RuntimeConfiguration.CDFFilePaths);
            files.Add(RuntimeConfiguration.TranslationFilePath);
            dictionary = new Dictionary<string, string>
            {
                { "Files", String.Join(Environment.NewLine + " *                ",
                                       files.Select(x => IOWrapper.GetFullPath(x)).ToArray())},
                { "Time", DateTime.Now.ToString("dd MMM yyyy - HH:mm:ss", CultureInfo.InvariantCulture)},
            };

            return new StringGenerationItem
            (
                StringUtils.GetStringFromTemplate(Resources.InputFilesTemplate, dictionary)
            );
        }
        // Implementation: GENERIC_TUD_CLS_005_021
    }
}
