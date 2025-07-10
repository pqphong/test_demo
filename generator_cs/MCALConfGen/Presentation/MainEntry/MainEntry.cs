/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = MainEntry.cs                                                                                        */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2024 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains MainEntry class that defines entry point of Gentool.                                   */
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
/*              : class MainEntry                                                                                     */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            22/02/2019 :    Handle ILC findings to improve GenTool - #88604                                         */
/*            01/03/2019 :    Added method load basic configuration specific module                                   */
/* 1.0.2:     10/04/2020 :    Fix Gentool Unit test issue #252666, #252593                                            */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     02/07/2021 :    Update main process.                                                                    */
/*            16/07/2021 :    Update pseudo code for Main                                                             */
/* 1.3.2:     23/02/2022 :    Update Main, rename printHelpIfNeed to printInfoIfNeed to print Tool Information        */
/* 1.4.0:     15/03/2023 :    Update registerAssemblyTypes to correct logic get dll does not contain tst in module    */
/*                            name.                                                                                   */
/* 1.5.0:     12/08/2024 :    Update registerAssemblyTypes to correct logic get dll does not contain acc in module    */
/*                            name. Update loadConfiguration to detect project name with "-"                          */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Business.Intermediate;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;

namespace Renesas.Generator.MCALConfGen.Presentation.MainEntry
{
    /// <summary>
    /// This "MainEntry" class that defines entry point of Gentool.
    /// </summary>
    public class MainEntry
    {

        /// <summary>
        /// Main entry
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
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET initialize ICommandLine, IParser, IValidation, IIntermediate, IGeneration, IUserInterface,
        ///                 IBasicConfiguration, IRepository
        /// LET handle unexpected exception
        /// LET handle command line
        /// LET handle outline algorithm parse and validate CDFs in Autosar
        /// LET InstanceIndex = 0
        /// Loop via instance and process each instance as normal instance.
        /// </algorithm>
        public static void Main()
        {
            ICommandLine cmd = null;
            IParser parser = null;
            IValidation validation = null;
            IIntermediate intermediate = null;
            IGeneration generation = null;
            IUserInterface userInterface = null;
            IBasicConfiguration basicConfig = null;
            IRepository repo = null;
            System.AppDomain.CurrentDomain.UnhandledException += unhandledExceptionHandler;
            // Firstly, always load appropriated assemblies.
            printInfoIfNeed();
            registerAssemblyTypes();

            // Start processing flow.
            cmd = ObjectFactory.GetInstance<ICommandLine>();
            cmd.ProcessCommandLine();

            parser = ObjectFactory.GetInstance<IParser>();
            parser.RunAll();

            cmd.DisplayCmdInformation();

            basicConfig = ObjectFactory.GetInstance<IBasicConfiguration>();
            repo = ObjectFactory.GetInstance<IRepository>();
            basicConfig.InstanceIndex = 0;
            
            // Loop via instance and process each instance as normal instance.
            for (int i = Constant.INT_ZERO; i < basicConfig.NumberOfInstances; i++)
            {
                /* Update Instance index */
                basicConfig.InstanceIndex = i;
                repo.PrepareInstance(basicConfig.InstanceIndex);
                repo.UpdateBasicConfig();

                /* Pre - Validation */
                validation = ObjectFactory.GetInstance<IValidation>();
                validation.ValidatePreIntermediate();

                /* Compute data */
                intermediate = ObjectFactory.GetInstance<IIntermediate>();
                intermediate.ComputeAll();

                /* Post - Validation */
                validation.ValidatePostIntermediate();

                /* Generation file */
                generation = ObjectFactory.GetInstance<IGeneration>();
                generation.GenerateOuput();

                /* Clear cache */
                ObjectFactory.ClearCache(typeof(IValidation));
                ObjectFactory.ClearCache(typeof(IIntermediate));
                ObjectFactory.ClearCache(typeof(IGeneration));
                ObjectFactory.ClearCache(typeof(IFileGeneration));
                ObjectFactory.ClearCache(typeof(IIntermediateData));
                ObjectFactory.ClearCache(typeof(ItemGenerationAttribute));
            }// End of for (int i = Constant.INT_ZERO; i < numberOfInstances; i++)

            /* User interface */
            userInterface = ObjectFactory.GetInstance<IUserInterface>();
            userInterface.Exit(Constant.EXIT_SUCCESSFUL);
        }
        // Implementation: GENERIC_TUD_CLS_053_001

        /// <summary>
        /// Handle unexpected exception
        /// </summary>
        /// <param name="sender">Sender<range>null/!null</range></param>
        /// <param name="e">Exceptions<range>null/!null exceptions</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_043
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET userInterface = CALL ObjectFactory.GetInstance WITH IUserInterface
        /// LET ex = e.ExceptionObject
        /// LET type = CALL ex.GetType()
        /// LET innerException = ex.InnerException
        /// LET innerExType = CALL innerException.GetType()
        /// IF type is TargetInvocationException AND
        /// innerExceptionType is one of these type TypeInitializationException,
        /// MissingMethodException, MissingFieldException
        ///     LET Handle error ERR000043
        /// ELSE
        ///     LET RAISE error
        /// Check type of exception, print message then exit
        /// </algorithm>
        private static void unhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            var userInterface = ObjectFactory.GetInstance<IUserInterface>();
            Exception ex = (Exception)e.ExceptionObject;
            Type type = ex.GetType();
            Exception innerException = ex.InnerException;
            Type innerExceptionType = innerException.GetType();
            // Dll specific module is uncompatible
            if (type == typeof(TargetInvocationException) &&
                ((innerExceptionType == typeof(TypeInitializationException) ||
                innerExceptionType == typeof(MissingMethodException) ||
                innerExceptionType == typeof(MissingFieldException)))
                )
            {
                string filename = string.Format("{0}.dll", innerException.Source);
                userInterface.Error(00, 43, Resources.ERR000043, filename);
                userInterface.Exit(Constant.EXIT_DUE_UNCOMPATIBLE_DLL);
            }
            else
            {
                // Raise error If have any exception in development environment.
                Console.WriteLine(collectExceptionHierarchyInfo(ex));
                userInterface.Exit(Constant.EXIT_DUE_CRASH);
                throw ex;
            }
        }
        // Implementation: GENERIC_TUD_CLS_053_007

        /// <summary>
        /// Collect information in exception object and print output
        /// </summary>
        /// <param name="e">Exception<range>null/!null exceptions</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET stringBuilder = initialize new StringBuilder
        /// IF e is not null THEN
        ///     LET appendLine (--, e.Message, e.StackTrace, collectExceptionHierarchyInfo(e.InnerException))
        ///         into stringBuilder
        /// RETURN stringBuilder
        /// </algorithm>
        private static string collectExceptionHierarchyInfo(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            if (null != e)
            {
                sb.AppendLine("--");
                sb.AppendLine(e.Message);
                sb.AppendLine(e.StackTrace);
                sb.AppendLine(collectExceptionHierarchyInfo(e.InnerException));
            }
            else
            {
                // Not required
            }
            return sb.ToString();
        }
        // Implementation: GENERIC_TUD_CLS_053_002

        /// <summary>
        /// Print info messages if need
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
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// IF user only input option -h THEN
        ///     LET print help content to user
        /// </algorithm>
        private static void printInfoIfNeed()
        {
            ICommandLine cmd = ObjectFactory.GetInstance<ICommandLine>();
            cmd.PrintToolInfo();
        }
        // Implementation: GENERIC_TUD_CLS_053_005

        /// <summary>
        /// Register assembly types
        /// </summary>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_045
        /// </ref>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// LET scannedLocation = read dlls path
        /// LET allDlls = Find all file have extension .dll
        /// LET moduleName = CALL getModuleName
        /// LET selectedDlls = get dll with moduleName
        /// IF module name does not contain tst
        ///     LET selectedDlls = selectedDlls with removed path contain tst in file name
        /// LET moduleDLL = get first element array selectedDlls
        /// LET SET ObjectFactory.ModuleName = moduleName
        /// LET assembly = CALL ReflectionWrapper.LoadFrom WITH moduleDLL
        /// IF dll does not contain module name or module name not extracted from Assembly Product Attribute
        ///     LET Handle error ERR000045
        /// </algorithm>
        private static void registerAssemblyTypes()
        {
            // Read dlls path
            string scannedLocation = AppDomain.CurrentDomain.BaseDirectory + Resources.DLLS_PATH;
            // Find all file have extension .dll
            string[] allDlls = IOWrapper.GetFiles(scannedLocation, "*.dll", SearchOption.AllDirectories,
                                                                                Constant.EXIT_DUE_INPUT_FILES_ERROR);

            // Get module name from command line input of user
            string moduleName = getModuleName();
            string[] selectedDlls = allDlls
                    .Where(e => Path.GetFileName(e).StartsWith(moduleName, StringComparison.OrdinalIgnoreCase))
                    .ToArray();

            // Remove dll paths contain "tst" in file name
            if (!moduleName.ToLower().Contains("tst"))
            {
                selectedDlls = selectedDlls.Where(e => !Path.GetFileName(e).ToLower().Contains("tst")).ToArray();
            }
            else
            {
                // Not required
            }
			
            // Remove dll paths contain "acc" in file name
            if (!moduleName.ToLower().Contains("acc"))
            {
                selectedDlls = selectedDlls.Where(e => !Path.GetFileName(e).ToLower().Contains("acc")).ToArray();
            }
            else
            {
                // Not required
            }
			
            Assembly assembly = null;
            ObjectFactory.ModuleName = moduleName;
            string moduleDLL = selectedDlls.Length != 0 ? selectedDlls.FirstOrDefault() : string.Empty;
            // If dll does not contain module name that is extracted from Assembly Product Attribute.
            // That's mean that dll is not corresponding with module MCAL.
            if (string.IsNullOrEmpty(moduleDLL) ||
                false == ReflectionWrapper.LoadFrom(moduleDLL, Constant.EXIT_DUE_INPUT_FILES_ERROR)
                            .GetCustomAttribute<AssemblyProductAttribute>()
                            .Product.StartsWith(moduleName, StringComparison.OrdinalIgnoreCase))
            {
                string filename = string.Format("{0}*.dll", moduleName);
                IUserInterface ui = ObjectFactory.GetInstance<IUserInterface>();
                ui.Error(0, 45, Resources.ERR000045, filename, moduleName);
                ui.Exit(Constant.EXIT_DUE_DLL_NOT_FOUND);
            }
            else
            {
                assembly = ReflectionWrapper.LoadFrom(moduleDLL, Constant.EXIT_DUE_INPUT_FILES_ERROR);
                // Load basic configuration of specific
                loadConfiguration(assembly);
            }
            ObjectFactory.SelectedDllPaths = selectedDlls.ToList();
            ObjectFactory.RegisterAssemblyTypes(selectedDlls);

        }
        // Implementation: GENERIC_TUD_CLS_053_006

        /// <summary>
        /// Load basic information from specific module such as module name, module id, project title, microfamily.
        /// </summary>
        /// <param name="assembly"> Specific module assembly <range>null/!null </range></param>
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
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        /// LET name = GET FullName in assembly
        /// LET resourceManager = initialize new ResourceManager
        /// LET configuration = ObjectFactory.GetInstance<IBasicConfiguration>
        /// LET configuration.ModuleName = rm.GetString(Constant.MODULE_NAME)
        /// LET configuration.ModuleId = int.Parse(rm.GetString(Constant.MODULE_TOOL_ID))
        /// LET configuration.MicroFamilyName = rm.GetString(Constant.MICROFAMILY_NAME)
        /// LET configuration.ExecutionName = $"{configuration.ModuleName}_{configuration.MicroFamilyName}.exe"
        /// LET configuration.OutputFolder = $"{configuration.ExeDirectory}{configuration.ModuleName}_Output"
        /// LET configuration.ModuleRequired = rm.GetString(Constant.MODULE_REQUIRED)
        /// LET configuration.ProjectTitle = rm.GetString(Constant.PROJECT_TITLE)
        /// </algorithm>
        private static void loadConfiguration(Assembly assembly)
        {
            string name = assembly.FullName.Split(',').Select(x => x.Trim()).FirstOrDefault().Replace("-", "");
            ResourceManager rm = new ResourceManager($"Renesas.Generator.{name}.Properties.Resources", assembly);
            IBasicConfiguration configuration = ObjectFactory.GetInstance<IBasicConfiguration>();
            configuration.ModuleName = rm.GetString(Constant.MODULE_NAME);
            configuration.ModuleId = int.Parse(rm.GetString(Constant.MODULE_TOOL_ID));
            configuration.MicroFamilyName = rm.GetString(Constant.MICROFAMILY_NAME);
            configuration.ExecutionName = $"{configuration.ModuleName}_{configuration.MicroFamilyName}.exe";
            configuration.OutputFolder = $"{configuration.ExeDirectory}{configuration.ModuleName}_Output";
            configuration.ModuleRequired = rm.GetString(Constant.MODULE_REQUIRED).Split(',').
                                                                Select(e => e.Trim()).ToList();
            configuration.ProjectTitle = rm.GetString(Constant.PROJECT_TITLE);
        }
        // Implementation: GENERIC_TUD_CLS_053_004


        /// <summary>
        /// Get module name
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>The name of module</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     N/A
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        ///
        /// LET Read module name from commandline input of user
        /// RETURN module name
        /// </algorithm>
        private static string getModuleName()
        {
            ICommandLine cmd = ObjectFactory.GetInstance<ICommandLine>();
            return cmd.GetAndValidateModuleName();
        }
        // Implementation: GENERIC_TUD_CLS_053_003
    }
}
