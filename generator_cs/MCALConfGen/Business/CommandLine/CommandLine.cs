/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = CommandLine.cs                                                                                      */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2022 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains CommandLine class to handle input from command lines.                                  */
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
/*              : class CommandLine                                                                                   */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            19/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/* 1.0.2:     07/02/2020 :    Fix Gentool Unit test issue #249940, #249320                                            */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     04/05/2021 :    Update method parseXmlConfig to support parse STUBS tag from cfgxml file                */
/* 1.3.2:     23/02/2022 :    Change name of PrintToolHelp to PrintToolInfo and update algorithm                      */
/*                            Add new method displayToolVersion                                                       */
/*            20/07/2024 :    In method displayToolVersion, add information for U2Bx-E                                */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Properties;
using System.Text;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Renesas.Generator.MCALConfGen.Business.CommandLine
{
    /// <summary>
    /// Command Line class to handle input of user by receiving options command line
    /// </summary>
    [ObjectFactory(AutoSarVersion = Constant.AR_VERSION_ALL, Device = Constant.DEVICE_NAME_ALL,
                                                                                    Version = Constant.VERSION_1_0_0)]
    class CommandLine : ICommandLine
    {
        /// <summary>
        /// Command Line instance used by ObjectFactory to get a new Command Line object
        /// </summary>
        public static readonly CommandLine Instance = new CommandLine();
        // Implementation: GENERIC_TUD_CLS_001_001

        /// <summary>
        /// To define information processed by command line.
        /// </summary>
        private IRuntimeConfiguration runtimeConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_001_002

        /// <summary>
        /// To store the basic information of gentool module.
        /// </summary>
        private IBasicConfiguration basicConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_001_003

        /// <summary>
        /// To record Error, Warning, Info information and exit Gentool.
        /// </summary>
        private IUserInterface userInterface = null;
        // Implementation: GENERIC_TUD_CLS_001_004

        /// <summary>
        /// To record log information for debugging.
        /// </summary>
        private ILogger logger = null;
        // Implementation: GENERIC_TUD_CLS_001_005

        /// <summary>
        /// Command line constructor
        /// </summary>
        /// <returns>
        ///     <para>
        ///      None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Init component
        /// </algorithm>
        protected CommandLine() : this
        (
            ObjectFactory.GetInstance<ILogger>(),
            ObjectFactory.GetInstance<IRuntimeConfiguration>(),
            ObjectFactory.GetInstance<IBasicConfiguration>(),
            ObjectFactory.GetInstance<IUserInterface>()
        )
        {

        }
        // Implementation: GENERIC_TUD_CLS_001_010

        /// <summary>
        /// Command line constructor
        /// </summary>
        /// <param name="logger">Logger <range>None</range></param>
        /// <param name="runtimeConfiguration">Runtime configuration <range>None</range></param>
        /// <param name="basicConfiguration">Basic configuration <range>None</range></param>
        /// <param name="userInterface">User interface <range>None</range></param>
        /// <returns>
        ///     <para>
        ///      None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        ///     Init component with agruments
        /// </algorithm>
        protected CommandLine
        (
            ILogger logger,
            IRuntimeConfiguration runtimeConfiguration,
            IBasicConfiguration basicConfiguration,
            IUserInterface userInterface
        )
        {
            this.logger = logger;
            this.runtimeConfiguration = runtimeConfiguration;
            this.basicConfiguration = basicConfiguration;
            this.userInterface = userInterface;
        }
        // Implementation: GENERIC_TUD_CLS_001_011

        /// <summary>
        /// Print Gentool help information
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
        /// CMN_TAD_USG_002
        /// </ref>
        /// <algorithm>
        /// LET args = CALL Environment.GetCommandLineArgs().Skip(1).ToArray() to get all input arguments
        /// LET enaHelpFlag = runtimeConfiguration.PrintHelp
        /// LET enaVersionFlag = runtimeConfiguration.PrintToolVersion
        /// IF enaHelpFlag is not TRUE THEN
        ///     FOREACH option IN list of argument
        ///         IF option equals to "-h"/"-help" THEN
        ///             LET enaHelpFlag = TRUE
        ///         ELSE
        ///             Not required
        /// ELSE
        ///     Not required
        /// IF enaVersionFlag is not TRUE THEN
        ///     FOREACH option IN list of argument
        ///         IF option equals to "-h"/"-help" THEN
        ///             LET enaVersionFlag = TRUE
        ///         ELSE
        ///             Not required
        /// ELSE
        ///     Not required
        /// LET printInfo = enaHelpFlag || enaVersionFlag
        /// IF enaHelpFlag is TRUE THEN
        ///     LET info = CALL StringUtils.GetStringFromTemplate(
        ///         Resources.HelpToolTemplate,
        ///         new Dictionary<string, string>) to get message info
        ///     CALL ConsoleWrapper.WriteLine(info) to print message
        /// ELSE
        ///     Not required
        /// IF enaVersionFlag is TRUE THEN
        ///     LET info = CALL StringUtils.GetStringFromTemplate(
        ///         Resources.HelpToolTemplate,
        ///         new Dictionary<string, string>) to get message info
        ///     CALL ConsoleWrapper.WriteLine(info) to print message
        /// ELSE
        ///     Not required  
        /// IF printInfo is true
        ///     Exit with successful
        /// ELSE
        ///     Not required
        /// </algorithm>
        public void PrintToolInfo()
        {
            string[] args = Environment.GetCommandLineArgs().Skip(1).ToArray();
            bool enaHelpFlag = runtimeConfiguration.PrintHelp;

            bool enaVersionFlag = runtimeConfiguration.PrintToolVersion;

            // Print help information if -h/-help is used in command line option
            if (!enaHelpFlag)
            {
                if (Constant.INT_ZERO == args.Length)
                {
                    enaHelpFlag = true;
                }
                else
                {
                    foreach (string option in args.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        if ((option.Equals("-h", StringComparison.OrdinalIgnoreCase)) ||
                            (option.Equals("-help", StringComparison.OrdinalIgnoreCase)))
                        {
                            enaHelpFlag = true;
                        }
                        else
                        {
                            // No action required
                        }
                    } // End of Foreach (string option in args.Where(x => !string.IsNullOrEmpty(x)))
                }
            }
            else
            {
                // Not required
            }

            if (!enaVersionFlag)
            {
                if (Constant.INT_ZERO == args.Length)
                {
                    enaVersionFlag = true;
                }
                else
                {
                    foreach (string option in args.Where(x => !string.IsNullOrEmpty(x)))
                    {
                        if ((option.Equals("-v", StringComparison.OrdinalIgnoreCase)) ||
                            (option.Equals("-version", StringComparison.OrdinalIgnoreCase)))
                        {
                            enaVersionFlag = true;
                        }
                        else
                        {
                            // No action required
                        }
                    } // End of Foreach (string option in args.Where(x => !string.IsNullOrEmpty(x)))
                }
            }
            else
            {
                // Not required
            }

            bool printInfo = enaHelpFlag || enaVersionFlag;
            if (enaHelpFlag)
            {
                string info = StringUtils.GetStringFromTemplate(
                    Resources.HelpToolTemplate,
                    new Dictionary<string, string> { });
                ConsoleWrapper.WriteLine(info);
            }
            else
            {
                // Not required
            }

            if (enaVersionFlag)
            {
                displayToolVersion();
            }
            else
            {
                // Not required
            }

            if (printInfo)
            {
                userInterface.InfoErrorCode(Constant.EXIT_SUCCESSFUL);
                userInterface.Exit(Constant.EXIT_SUCCESSFUL);
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_008

        /// <summary>
        /// Get and validate module name from command line options
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>the module name</desc>
        ///         <range>null/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_031
        /// </ref>
        /// <algorithm>
        /// LET module = NULL
        /// LET args = CALL Environment.GetCommandLineArgs().Skip(1).ToArray() to get all input arguments
        /// IF args is not NULL THEN
        ///     IF found module name from -m and -module option and it's in a list of supported module names THEN
        ///         break
        ///     ELSE
        ///         module = NULL
        /// ELSE
        ///     Not required
        /// IF module is NULL THEN
        ///     Print ERR000031 message
        /// ELSE
        ///     Not required
        /// </algorithm>
        public string GetAndValidateModuleName()
        {
            string module = null;
            string[] args = Environment.GetCommandLineArgs().Skip(1).ToArray();

            /* From command line option, the argument value next to argument -m/-module is module name value
                 * For loop to get all module name value.
                 */
            for (int i = Constant.INT_ZERO; args.Length > i; i++)
            {
                string[] moduleNameOptions = new string[] { "-m", "-module" };
                string input = args[i].ToLower();

                // Store the first supported module name value found.
                if (moduleNameOptions.Contains(input) && ((i + Constant.INT_ONE) < args.Length))
                {
                    IEnumerable<string> supportedModules = Resources.MCAL_MODULES
                        .Split(',')
                        .Select(e => e.Trim());

                    module = args[i + Constant.INT_ONE];
                    // Get a module that only is supported by MCAL modules. Ex. Can, Fls, Mcu,....
                    module = supportedModules.FirstOrDefault(
                        e => e.Equals(module, StringComparison.OrdinalIgnoreCase));
                    break;
                } // End of if (moduleNameOptions.Contains(input) && ((i + 1) < args.Length))
                else
                {
                    // Not required
                }
            } // End of for (int i = 0; args.Length > i; i++)

            // Report ERR000031 if module name value is not supported.
            if (null == module)
            {
                userInterface.ErrorModuleNotFound();
            }
            else
            {
                // Not required
            }

            return module;
        }
        // Implementation: GENERIC_TUD_CLS_001_007

        /// <summary>
        /// To coordinate other methods to process command line options
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
        /// CALL parseAndValidateOptions to parse and validate options
        /// Print tool information
        /// CALL showInvalidInputPath to validate input path
        /// CALL showInvalidOutputPath to validate output path
        /// </algorithm>
        public void ProcessCommandLine()
        {
            parseAndValidateOptions();
            PrintToolInfo();
            showInvalidOutputPath();
            showInvalidInputPath();
        }
        // Implementation: GENERIC_TUD_CLS_001_009

        /// <summary>
        /// Display command line information
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
        /// CMN_TAD_INF_001, CMN_TAD_INF_002
        /// </ref>
        /// <algorithm>
        /// LET args = CALL Environment.GetCommandLineArgs().Skip(1).ToArray() to get all input arguments
        /// LET basicConfiguration.ExecutionName = CALL Path.GetFileName(System.Reflection.Assembly.GetExecutingAssembly().Location)
        /// to get execution name
        /// LET moduleDll version regarding to SelectedDllPaths at runtime.
        /// CALL userInterface.Info WITH moduleDll and ExecutionName to print INF000001
        /// CALL userInterface.Info WITH basicConfiguration.ExecutionName, String.Join(" ", args) to print INF000002
        /// </algorithm>
        public void DisplayCmdInformation()
        {
            string[] args = Environment.GetCommandLineArgs().Skip(1).ToArray();
            // Update basicConfiguration.ExecutionName as http://172.29.143.164:8080/issues/15546
            string executionLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            basicConfiguration.ExecutionName =
                                           Path.GetFileName(executionLocation);
            basicConfiguration.ExecutionVersion =
                                           FileVersionInfo.GetVersionInfo(executionLocation).ProductVersion;


            string selectedDll = ObjectFactory.SelectedDllPaths.Where(x =>
            x.Contains(basicConfiguration.ModuleName + basicConfiguration.DeviceVariant)).FirstOrDefault().ToString();

            FileVersionInfo dllVersionInfo = FileVersionInfo.GetVersionInfo(selectedDll);
            ObjectFactory.ModuleDllName = dllVersionInfo.OriginalFilename;
            ObjectFactory.ModuleDllVersion = dllVersionInfo.ProductVersion;


            userInterface.Info(0, 1, Resources.INF000001,
                basicConfiguration.ExecutionName, basicConfiguration.ExecutionVersion,
                ObjectFactory.ModuleDllName, ObjectFactory.ModuleDllVersion);
            userInterface.Info(0, 2, Resources.INF000002, basicConfiguration.ExecutionName, String.Join(" ", args));
        }
        // Implementation: GENERIC_TUD_CLS_001_006

        /// <summary>
        /// Parse and validate options
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
        /// CMN_TAD_USG_004
        /// </ref>
        /// <algorithm>
        /// LET configOptions = CALL string[] [ "-c", "-configfile" ]
        /// LET xmlConfigPath = NULL
        /// LET userInputs = CALL parseUserInputs() to parse all information from command line options
        /// CALL validateUserInputs(userInputs) to validate the command line options to handle errors and warning
        /// FOREACH option IN configOptions
        ///     IF configuration file is NOT specified by -c/-configfile THEN
        ///         LET xmlConfigPath = userInputs.OptionsWithValues[option]
        ///     ELSE
        ///         Not required
        /// IF xmlConfigPath is NULL THEN
        ///     LET xmlConfigPath = default configuration file MSN_MICRO_FAMILY_NAME.cfgxml at the same MCALConfGen.exe location
        /// ELSE
        ///     Not required
        ///
        /// LET xmlConfigInputs = CALL parseXmlConfig(xmlConfigPath) to parse all information
        /// CALL validateXmlConfig(xmlConfigPath, xmlConfigInputs) to validate options from .cfgxml files to handle errors and warning
        ///
        /// IF output folder is NOT specified by -o/-output THEN
        ///         Use default output folder MODULE_NAME_Output
        /// ELSE
        ///     Not required
        /// CALL validateBothUserAndXmlInputs(userInputs, xmlConfigInputs) to validate both user/xml input
        /// </algorithm>
        private void parseAndValidateOptions()
        {
            CommandLineInput xmlConfigInputs = null;

            string[] configOptions = new string[] { "-c", "-configfile" };
            bool useDefaultConfigPath = false;
            string xmlConfigPath = null;

            string[] outputOptions = new string[] { "-o", "-output" };
            bool useDefaultOutputPath = false;
            string outputPath = null;
            runtimeConfiguration.PrintHelp = false;

            // Parse and validate user inputs
            CommandLineInput userInputs = parseUserInputs();

            validateUserInputs(userInputs);

            // Store the first -c/-configfile value specified by user via command line option
            foreach (string option in configOptions)
            {
                if (userInputs.OptionsWithValues.ContainsKey(option) &&
                    (false == String.IsNullOrEmpty(userInputs.OptionsWithValues[option])))
                {
                    xmlConfigPath = userInputs.OptionsWithValues[option];
                    break;
                }
                else
                {
                    // Not required
                }
            } // End of foreach (string opt in configOpts).

            // Use default XML config file if NOT specified by user
            if (String.IsNullOrEmpty(xmlConfigPath))
            {
                xmlConfigPath = String.Format("{0}{1}_{2}.cfgxml",
                    basicConfiguration.ExeDirectory,
                    basicConfiguration.ModuleName,
                    basicConfiguration.MicroFamilyName);
                useDefaultConfigPath = true;
            }
            else
            {
                // Not required
            }

            // Parse and validate xml config file
            xmlConfigInputs = parseXmlConfig(xmlConfigPath);
            validateXmlConfig(xmlConfigPath, xmlConfigInputs);

            // Store the first -o/-output value specified by user via command line option
            foreach (string option in outputOptions.Where(o => xmlConfigInputs.OptionsWithValues.ContainsKey(o) &&
                                                 !String.IsNullOrEmpty(xmlConfigInputs.OptionsWithValues[o])))
            {
                outputPath = xmlConfigInputs.OptionsWithValues[option];
                break;

            } // End of foreach (string option in outputOptions).

            // Set default output path
            if (String.IsNullOrEmpty(outputPath))
            {
                outputPath = basicConfiguration.OutputFolder;
                useDefaultOutputPath = true;
            }
            else
            {
                // Not required
            }

            // Validation need both user/xml input
            validateBothUserAndXmlInputs(userInputs, xmlConfigInputs);

            // Store default xml config file
            if (useDefaultConfigPath)
            {
                userInputs.OptionsWithValues[configOptions.First()] = xmlConfigPath;
            }
            else
            {
                // Not required
            }

            // Store default output path
            if (useDefaultOutputPath)
            {
                xmlConfigInputs.OptionsWithValues[outputOptions.First()] = outputPath;
            }
            else
            {
                // Not required
            }

            runtimeConfiguration.OverrideCurrentConfigsBy(xmlConfigInputs.OptionsWithValues, xmlConfigInputs.Files);
            runtimeConfiguration.OverrideCurrentConfigsBy(userInputs.OptionsWithValues, userInputs.Files);
            runtimeConfiguration.SetDefaultOptionsValue(basicConfiguration);
            // Enable print help flag if -h/-help is used by user via command line option
            if (xmlConfigInputs.OptionsWithValues["-h"].ToLower() == Constant.TRUE)
            {
                runtimeConfiguration.PrintHelp = true;
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_019

        /// <summary>
        /// Parse all information from command line options entried by users
        /// </summary>
        /// <returns>
        ///     <para>"CommandLineInput" class
        ///         <desc>The options entried by user</desc>
        ///         <range>null/valid input</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET args = CALL Environment.GetCommandLineArgs().Skip(1).ToArray() to get all input arguments
        ///     FOREACH argument IN args
        ///         IF argument start with "-" THEN
        ///             ADD argument and its value in to option list of CommandLineInput instance
        ///         ELSE
        ///             ADD argument into files list of CommandLineInput instance
        /// </algorithm>
        private CommandLineInput parseUserInputs()
        {
            string[] args = Environment.GetCommandLineArgs().Skip(1).ToArray();

            CommandLineInput result = null;
            string[] moduleOptions = new string[] { "-m", "-module" };
            string[] configOptions = new string[] { "-c", "-configfile" };
            string[] outputOptions = new string[] { "-o", "-output" };
            string[] filterOptions = new string[] { "-fr", "-filter" };
            string[] dryrunOptions = new string[] { "-d", "-dryrun" };
            string[] logOptions = new string[] { "-l", "-log" };
            Dictionary<string, string[]> sameCmdOptions = new Dictionary<string, string[]>();
            sameCmdOptions.Add("module", moduleOptions);
            sameCmdOptions.Add("config", configOptions);
            sameCmdOptions.Add("output", outputOptions);
            sameCmdOptions.Add("filter", filterOptions);
            sameCmdOptions.Add("dryrun", dryrunOptions);
            sameCmdOptions.Add("log", logOptions);
            List<string> duplicatedCmnOptions = new List<string>();

            // Single options such as -l, -h, -dryrun
            string[] singleOptions = runtimeConfiguration.GetSingleCmdOptions();

            result = new CommandLineInput();

            // For each argurment of command line options is configured by user.
            for (int i = Constant.INT_ZERO; args.Length > i; i++)
            {
                string input = args[i];

                // If Option is a new one.
                if ((false == result.OptionsWithValues.Keys.Contains(input, StringComparer.OrdinalIgnoreCase)) &&
                    (false == result.Files.Contains(input)))
                {
                    // Handler of option which starts with "-"
                    if (input.StartsWith("-"))
                    {
                        string option = input.ToLower();

                        string value = null;
                        // single options such as -h, -l, -dryrun
                        if (singleOptions.Contains(option))
                        {
                            value = Boolean.TrueString;
                        }
                        else
                        {
                            if ((i + Constant.INT_ONE) < args.Length)
                            {
                                value = args[i + Constant.INT_ONE];
                                if (false == value.StartsWith("-"))
                                {
                                    // Skip to next args
                                    i++;
                                }
                                else
                                {
                                    value = null;
                                }
                            } // End of if ((i + 1) < args.Length).
                            else
                            {
                                // Not required
                            }
                        } // End of if (singleOptions.Contains(option)).

                        // If two options are the same meaning, tool only store one option.
                        // Ex. -dryrun and -d, -log and -l, tool only store -d, -l. if it occur, tool replace by
                        // the short option that is input from user. Ex: -d instead of -dryrun.
                        string sameOption = sameCmdOptions.Values.Where(x => x[1].Equals(option)).Select(x => x[0])
                                                                                                .FirstOrDefault();
                        option = sameOption == null ? option : sameOption;
                        if (result.OptionsWithValues.ContainsKey(option))
                        {
                            option = input.ToLower();
                        }
                        else
                        {
                            // Not required
                        }
                        result.OptionsWithValues[option] = value;
                        result.OptionsAppearances.Add(option, Constant.INT_ONE);

                    } // End of if (input.StartsWith("-")).
                    else // input is a file
                    {
                        bool isFilePath = (false == String.IsNullOrEmpty(IOWrapper.GetFileName(input)));

                        // Store file name if user sets correct file name value.
                        if (isFilePath)
                        {
                            result.Files.Add(input);
                            result.OptionsAppearances.Add(input, Constant.INT_ONE);
                        }
                        else
                        {
                            // Not required
                        }
                    }
                } // End of if ((false == result.OptionsWithValues.Keys.Contains(input,
                  //                                                        StringComparer.OrdinalIgnoreCase)) &&
                  //                                                       (false == result.Files.Contains(input)))

                // If Option is an OptionsWithValue which have been specified before, ignore it.
                else if (true == result.OptionsWithValues.Keys.Contains(input, StringComparer.OrdinalIgnoreCase))
                {
                    string option = input.ToLower();

                    // Handler of duplicate options
                    if ((i + Constant.INT_ONE) < args.Length)
                    {
                        string value = args[i + Constant.INT_ONE];
                        if (false == value.StartsWith("-"))
                        {
                            // Skip value for next loop
                            i++;
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

                    // Keep the name of duplicated option
                    result.OptionsAppearances[option] += Constant.INT_ONE;
                }
                // If files are duplicated in commandline.
                else
                {
                    result.OptionsAppearances[input] += Constant.INT_ONE;
                }
            } // End of for (int i = 0; args.Length > i; i++).

            foreach (string option in sameCmdOptions.Keys)
            {
                duplicatedCmnOptions = sameCmdOptions[option]
                                                .Where((x) => result.OptionsWithValues.ContainsKey(x)).ToList();
                // If options is duplication, remove it
                if (duplicatedCmnOptions.Count > Constant.INT_ONE)
                {
                    result.OptionsWithValues.Remove(duplicatedCmnOptions.Last());
                    result.OptionsAppearances.Remove(duplicatedCmnOptions.Last());
                    result.OptionsAppearances[duplicatedCmnOptions.First()] += Constant.INT_ONE;
                }
                else
                {
                    // Do nothing
                }
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_001_020

        /// <summary>
        /// Filter value vendor name
        /// </summary>
        /// <param name="userInputs">User inputs
        ///     <range>null/valid "CommandLineInput"</range>
        /// </param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_032
        /// </ref>
        /// <algorithm>
        /// LET isMissing = CALL checkMissingValueForOption(filterOptions, userInputs) to check missing value of filter option
        /// IF isMissing is TRUE THEN
        ///     CALL userInterface.Error WITH Resources.ERR000032 to print ERR000032
        /// ELSE
        ///     Not required
        /// </algorithm>
        private void filterValueVendorName(CommandLineInput userInputs)
        {
            // Ref: GENERIC_TUM_U2X_GT_ERR_032
            string[] filterOptions = new string[] { "-fr", "-filter" };
            bool isMissing = checkMissingValueForOption(filterOptions, userInputs);
            // If -fr/-filter value is empty, report error
            if (isMissing)
            {
                userInterface.Error(0, 32, Resources.ERR000032);
                userInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_017

        /// <summary>
        /// Checking missing value for options command line.
        /// </summary>
        /// <param name="options">A list of options that need checking<range>null/valid array of string</range></param>
        /// <param name="userInputs">User inputs <range>null/valid "CommandLineInput"</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The result of checking</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET ret = FALSE
        /// LET optionsWithValues = userInputs.OptionsWithValues
        /// FOREACH option IN options
        ///     IF keys of optionsWithValues contain option THEN
        ///         LET ret = TRUE
        ///     ELSE
        ///         Not required
        ///
        /// RETURN ret
        /// </algorithm>
        private bool checkMissingValueForOption(string[] options, CommandLineInput userInputs)
        {
            bool ret = false;
            Dictionary<string, string> optionsWithValues = userInputs.OptionsWithValues;
            foreach (string option in options)
            {
                // Return true value of option command line is empty.
                if (optionsWithValues.ContainsKey(option) &&
                    (String.IsNullOrEmpty(optionsWithValues[option])))
                {
                    ret = true;
                    break;
                }
                else
                {
                    // Not required
                }
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_001_015

        /// <summary>
        /// Check name gentool configuration
        /// </summary>
        /// <param name="userInputs">User inputs <range>null/valid "CommandLineInput"</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_002
        /// </ref>
        /// <algorithm>
        /// LET isMissing = CALL checkMissingValueForOption(configOptions, userInputs) to check missing value of option
        /// IF isMissing is TRUE THEN
        ///     CALL userInterface.Error WITH Resources.ERR000002 to print ERR000002
        /// ELSE
        ///     Not required
        /// </algorithm>
        private void checkConfigOptionFileName(CommandLineInput userInputs)
        {
            string[] configOptions = new string[] { "-c", "-configfile" };
            bool isMissing = checkMissingValueForOption(configOptions, userInputs);
            // If -c/-configfile value is empty, report error
            if (isMissing)
            {
                userInterface.Error(0, 2, Resources.ERR000002, "-C/-CONFIGFILE");
                userInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_012

        /// <summary>
        /// Check invalid options
        /// </summary>
        /// <param name="userInputs">User inputs <range>null/valid "CommandLineInput"</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_008, CMN_TAD_WRN_002
        /// </ref>
        /// <algorithm>
        /// LET optionsWithValues = userInputs.OptionsWithValues
        /// LET validOptions = CALL runtimeConfiguration.GetAllCmdOptions() to get all commandline options
        ///
        /// FOREACH option IN Keys of optionsWithValues
        ///     IF validOptions contain option THEN
        ///         CALL userInterface.Error WITH Resources.ERR000008 to print ERR000008
        ///     ELSE
        ///         Not required
        /// IF option is repeated THEN
        ///     CALL userInterface.Warn WITH Resources.WRN000002 to print WRN000002
        /// ELSE
        ///     Not required
        /// </algorithm>
        private void checkInvalidOption(CommandLineInput userInputs)
        {
            Dictionary<string, string> optionsWithValues = userInputs.OptionsWithValues;
            List<string> duplicatedOptions = new List<string>();

            string[] validOptions = runtimeConfiguration.GetAllCmdOptions();
            // Report error in the case option command line is invalid
            foreach (string option in optionsWithValues.Keys)
            {
                if (false == validOptions.Contains(option))
                {
                    userInterface.Error(0, 8, Resources.ERR000008, option);
                    userInterface.Exit();
                }
                else
                {
                    // Not required
                }
            }

            // Report warning in the case there is duplication in commandline
            if (userInputs.OptionsAppearances.Keys.Count > Constant.INT_ZERO)
            {
                duplicatedOptions = userInputs.OptionsAppearances
                                    .Where((key, val) => key.Value > Constant.INT_ONE)
                                    .Select(x => x.Key).ToList();
                if (duplicatedOptions.Count > Constant.INT_ZERO)
                {
                    userInterface.Warn(0, 2, Resources.WRN000002, string.Join(", ", duplicatedOptions.ToArray()));
                }
                else
                {
                    // Do nothing
                }
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_014

        /// <summary>
        /// Check output directory
        /// </summary>
        /// <param name="userInputs">User inputs <range>null/valid "CommandLineInput"</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_005, CMN_TAD_ERR_010,
        /// CMN_TAD_USG_005, CMN_TAD_USG_006, CMN_TAD_USG_007
        /// </ref>
        /// <algorithm>
        /// LET optionsWithValues = userInputs.OptionsWithValues
        /// LET outputOptions = new string[]  ["-o", "-output", "-oinc", "-osrc" ]
        /// FOREACH each IN outputOptions WHERE keys of optionsWithValues contain each
        ///     LET optionValue = optionsWithValues[each]
        ///     IF optionValue is not NULL THEN
        ///         CALL userInterface.Error WITH Resources.ERR000005 to print ERR000005
        ///     ELSE IF optionValue is invalid THEN
        ///         CALL userInterface.Error WITH Resources.ERR000010 to print ERR000010
        ///     ELSE
        ///         Do nothing
        /// </algorithm>
        private void checkOutputDirectory(CommandLineInput userInputs)
        {
            Dictionary<string, string> optionsWithValues = userInputs.OptionsWithValues;
            string[] outputOptions = new string[] { "-o", "-output", "-oinc", "-osrc" };
            foreach (string each in outputOptions.Where(x => optionsWithValues.ContainsKey(x)))
            {
                string optionValue = optionsWithValues[each];
                // Report error in the case output directory is not given.
                if (String.IsNullOrEmpty(optionValue))
                {
                    userInterface.Error(0, 5, Resources.ERR000005, each);
                    userInterface.Exit();
                }
                // Report error in the case output directory exists invalid character
                else if (StringUtils.IsInvalidName(optionValue))
                {
                    userInterface.Error(0, 10, Resources.ERR000010, optionValue);
                    userInterface.Exit();
                }
                else
                {
                    // Not required
                }
            } // End of foreach (string each in outputOptions).

        }
        // Implementation: GENERIC_TUD_CLS_001_016

        /// <summary>
        /// Validate command line options
        /// </summary>
        /// <param name="userInputs">User inputs <range>null/valid "CommandLineInput"</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF userInputs is not NULL THEN
        ///     CALL checkInvalidOption WITH userInputs
        ///     CALL checkConfigOptionFileName WITH userInputs
        ///     CALL checkOutputDirectory WITH userInputs
        ///     CALL filterValueVendorName WITH userInputs
        ///     CALL validateAcceptedFiles WITH userInputs.Files
        /// ELSE
        ///     Do nothing
        /// </algorithm>
        private void validateUserInputs(CommandLineInput userInputs)
        {
            if (null != userInputs)
            {
                // Validate values from user input
                checkInvalidOption(userInputs);

                checkConfigOptionFileName(userInputs);

                checkOutputDirectory(userInputs);

                filterValueVendorName(userInputs);

                validateAcceptedFiles(userInputs.Files);
            } // End of if (null != userInputs).
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_026

        /// <summary>
        /// Parse all information from .cfgxml file
        /// </summary>
        /// <param name="path">Path to .cfgxml file <range>null/valid string</range></param>
        /// <returns>
        ///     <para>"CommandLineInput"
        ///         <desc>The options entried by user</desc>
        ///         <range>null/valid input</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_CFG_004
        /// </ref>
        /// <algorithm>
        /// LET result = null
        /// IF path does not exist THEN
        ///     LET document = CALL IOWrapper.LoadXML(path) to load data
        ///     LET result = new CommandLineInput()
        ///     FOREACH pair IN mapping
        ///         LET optionValue = CALL getOptionValueFromXmlConfig(document, pair.Key)
        ///         SWITCH pair.Key
        ///             CASE Constant.OUTPUT:
        ///                 IF optionValue equals to Constant.STR_ON THEN
        ///                     LET outputPath = CALL getOptionValueFromXmlConfig(document, Constant.OUTPUT_PATH)
        ///                     LET result.OptionsWithValues[pair.Value] = outputPath
        ///                 ELSE
        ///                     Do nothing
        ///             CASE Constant.INPUT_FILE:
        ///                 IF optionValue is not NULL THEN
        ///                     CALL result.Files.AddRange(optionValue.Split(',').Select(e => e.Trim()))
        ///                 ELSE
        ///                     Do nothing
        ///             CASE Constant.FILTER:
        ///                 LET vendor = CALL getOptionValueFromXmlConfig(document, Constant.FILTER_NAME)
        ///                 IF vendor is not NULL THEN
        ///                     CALL result.OptionsWithValues[pair.Value] = vendor
        ///                 ELSE
        ///                     Do nothing
        ///             CASE Constant.STUBS:
        ///                 IF optionValue is not NULL THEN
        ///                     CALL runtimeConfiguration.StubsFilter.AddRange(optionValue.Split(',').Select(
        ///                                                                                             e => e.Trim()))
        ///                 ELSE
        ///                     Do nothing
        ///             DEFAULT:
        ///                 IF optionValue equals to Constant.STR_ON THEN
        ///                     CALL result.OptionsWithValues[pair.Value] = Boolean.TrueString
        ///                 ELSE IF optionValue equals to Constant.STR_OFF THEN
        ///                     CALL result.OptionsWithValues[pair.Value] = Boolean.FalseString
        ///                 ELSE
        ///                     Do nothing
        /// ELSE
        ///     CALL userInterface.ErrorFileNotFound WITH path
        /// RETURN result
        /// </algorithm>
        private CommandLineInput parseXmlConfig(string path)
        {
            // Ref: GENERIC_TUM_U2X_GT_ERR_001, GENERIC_TUM_U2X_GT_ERR_003
            CommandLineInput result = null;
            if (IOWrapper.FileExists(path))
            {
                XDocument document = IOWrapper.LoadXML(path);
                Dictionary<string, string> mapping = new Dictionary<string, string>
                    {
                        {"HELP", "-h"},     {"LOG", "-l"},      {"DRYRUN", "-d"},
                        {"OUTPUT", "-o"},   {"FILTER", "-fr"},  {"INPUT-FILE", null}, {"STUBS", null}
                    };


                result = new CommandLineInput();

                /* .cfgxml file and command line options exist pair value, which has same meaning.
                 * Loop to store all pair value
                 */
                foreach (KeyValuePair<string, string> pair in mapping)
                {
                    string optionValue = getOptionValueFromXmlConfig(document, pair.Key);
                    // Parse options from XML Config based on Tags as convention
                    switch (pair.Key)
                    {
                        // Parse output from xml config
                        case Constant.OUTPUT:
                            if (optionValue.Equals(Constant.STR_ON, StringComparison.OrdinalIgnoreCase))
                            {
                                string outputPath = getOptionValueFromXmlConfig(document, Constant.OUTPUT_PATH);
                                result.OptionsWithValues[pair.Value] = outputPath;
                            }
                            else
                            {
                                // Don't need to implement ELSE which is different from single options
                                // Because the needed result is OUTPUT-PATH, not ON/OFF of stage of OUTPUT itself
                            }
                            break;
                        // Parse input files such as cdf, bsw, translation file from xml config
                        case Constant.INPUT_FILE:
                            if (false == String.IsNullOrEmpty(optionValue))
                            {
                                result.Files.AddRange(optionValue.Split(',').Select(e => e.Trim()));
                            }
                            else
                            {
                                // Not required
                            }
                            break;
                        // Parse filter vendor corresponding to option -fr
                        case Constant.FILTER:
                            string vendor = getOptionValueFromXmlConfig(document, Constant.FILTER_NAME);
                            if (!string.IsNullOrEmpty(vendor))
                            {
                                result.OptionsWithValues[pair.Value] = vendor;
                            }
                            else
                            {
                                // Not required
                            }
                            break;
                        case Constant.STUBS:
                            if (false == String.IsNullOrEmpty(optionValue))
                            {
                                runtimeConfiguration.StubsFilter.AddRange(optionValue.Split(',').Select(e => e.Trim()));
                            }
                            else
                            {
                                // Not required
                            }
                            break;
                        default:
                            if (optionValue.Equals(Constant.STR_ON, StringComparison.OrdinalIgnoreCase))
                            {
                                result.OptionsWithValues[pair.Value] = Boolean.TrueString;
                            }
                            else if (optionValue.Equals(Constant.STR_OFF, StringComparison.OrdinalIgnoreCase))
                            {
                                result.OptionsWithValues[pair.Value] = Boolean.FalseString;
                            }
                            else
                            {
                                // Not required
                            }
                            break;
                    } // End of switch (pair.Key).
                } // End of foreach (KeyValuePair<string, string> pair in mapping).
            } // End of if (File.Exists(path)).
            else
            {
                userInterface.ErrorFileNotFound(path);
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_001_021

        /// <summary>
        /// Validate options from .cfgxml files
        /// </summary>
        /// <param name="xmlConfigFile">.cfgxml files file path <range>null/valid string</range></param>
        /// <param name="xmlConfig">Xml config <range>null/valid "CommandLineInput"</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_006
        /// </ref>
        /// <algorithm>
        /// IF xmlConfig is not null THEN
        ///     LET optionsWithValues = xmlConfig.OptionsWithValues
        ///     IF keys of optionsWithValues contain '-o' AND value of optionsWithValues["-o"] is not null THEN
        ///         CALL userInterface.Error WITH Resources.ERR000006 to print ERR000006
        ///     ELSE
        ///         Do nothing
        ///     CALL validateAcceptedFiles(xmlConfig.Files) to check file extension as .trxml, .arxml
        /// ELSE
        ///     Do nothing
        /// </algorithm>
        private void validateXmlConfig(string xmlConfigFile, CommandLineInput xmlConfig)
        {
            //TODO: Implement wrong option tags (only support specific tags)
            //TODO: Implement wrong value of tag
            if (null != xmlConfig)
            {
                Dictionary<string, string> optionsWithValues = xmlConfig.OptionsWithValues;
                // Report error If value of option -o is not provided by configuration XML.
                if (optionsWithValues.ContainsKey("-o") && String.IsNullOrEmpty(optionsWithValues["-o"]))
                {
                    userInterface.Error(0, 6, Resources.ERR000006, xmlConfigFile);
                    userInterface.Exit();
                }
                else
                {
                    // Not required
                }
                // Check file extension as .trxml, .arxml
                validateAcceptedFiles(xmlConfig.Files);
            } // End of if (null != xmlConfig).
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_027

        /// <summary>
        /// Check explicit options
        /// </summary>
        /// <param name="userInput">User input <range>null/valid "CommandLineInput"</range></param>
        /// <param name="xmlConfig">Xml config <range>null/valid "CommandLineInput"</range></param>
        /// <returns>
        ///     <para>"StringBuilder"
        ///         <desc>Invalid options from userInput and xmlConfig</desc>
        ///         <range>Empty/List invalid options</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET singleCmdOptions = new string[] { "-h", "-l", "-d" }
        /// LET notExplicitOptions = new StringBuilder()
        /// IF userInput is not null AND xmlConfig is not null THEN
        ///     FOREACH option IN singleCmdOptions WHERE its value matches with option
        ///         IF notExplicitOptions.Length > 0 THEN
        ///             CALL notExplicitOptions.Append(", ")
        ///         ELSE
        ///             Do nothing
        ///         CALL notExplicitOptions.Append(option)
        /// ELSE
        ///     Do nothing
        /// RETURN notExplicitOptions
        /// </algorithm>
        private StringBuilder checkExplicitOptions(CommandLineInput userInput, CommandLineInput xmlConfig)
        {
            string[] singleCmdOptions = new string[] { "-h", "-l", "-d" };
            StringBuilder notExplicitOptions = new StringBuilder();
            if (null != userInput && null != xmlConfig)
            {
                // Store all options, which are not explicit in command line options and *.cfgxml file
                foreach (string option in singleCmdOptions.Where(x => !userInput.OptionsWithValues.ContainsKey(x) &&
                                                                    !xmlConfig.OptionsWithValues.ContainsKey(x)))
                {
                    if (Constant.INT_ZERO < notExplicitOptions.Length)
                    {
                        notExplicitOptions.Append(", ");
                    }
                    else
                    {
                        // Not required
                    }
                    notExplicitOptions.Append(option);
                } // End of foreach (string option in singleCmdOptions).
            }
            else
            {
                // Do nothing
            }
            return notExplicitOptions;
        }
        // Implementation: GENERIC_TUD_CLS_001_013

        /// <summary>
        /// Validate both command line options and .cfgxml file options
        /// </summary>
        /// <param name="userInput">User input <range>null/valid "CommandLineInput"</range></param>
        /// <param name="xmlConfig">Xml config <range>null/valid "CommandLineInput"</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_ERR_007, CMN_TAD_ERR_034, CMN_TAD_INF_003,
        /// CMN_TAD_USG_003, CMN_TAD_USG_008
        /// </ref>
        /// <algorithm>
        /// LET singleCmdOptions = new string[] [ "-h", "-l", "-d" ]
        /// LET notExplicitOptions = new StringBuilder()
        /// LET noUserInputs = userInput is null OR value of option '-m' is not provided from user input
        /// LET noXmlInputs = xmlConfig is null OR value of option '-m' is not provided from xml input
        /// IF noUserInputs && noXmlInputs is true THEN
        ///     CALL userInterface.Error WITH Resources.ERR000007 to raise ERR000007
        ///     CALL userInterface.Info WITH Resources.INF000003 to raise INF000003
        /// ELSE
        ///     Do nothing
        ///
        /// LET notExplicitOptions = CALL checkExplicitOptions(userInput, xmlConfig)
        /// IF notExplicitOptions.Length > 0 THEN
        ///     CALL userInterface.Error WITH Resources.ERR000034 to raise ERR000034
        /// ELSE
        ///     Do nothing
        /// </algorithm>
        private void validateBothUserAndXmlInputs(CommandLineInput userInput, CommandLineInput xmlConfig)
        {
            StringBuilder notExplicitOptions = new StringBuilder();
            string[] singleCmdOptions = new string[] { "-h", "-l", "-d" };

            // Check any input is not provided by Commandline.
            bool noUserInputs = (null == userInput) ||
                                ((Constant.INT_ZERO == userInput.OptionsWithValues.Where(e => "-m" != e.Key &&
                                                                               "-module" != e.Key).Count()) &&
                                             (Constant.INT_ZERO == userInput.Files.Count));
            // Check any input is not configured by XML configuration.
            bool noXmlInputs = (null == xmlConfig) ||
                                ((Constant.INT_ZERO == xmlConfig.OptionsWithValues.Where(e => "-m" != e.Key &&
                                                                                       "-module" != e.Key).Count()) &&
                                             (Constant.INT_ZERO == xmlConfig.Files.Count));
            // Report error, info if have not any options that is provided by command line or XML configuration.
            if (noUserInputs && noXmlInputs)
            {
                userInterface.Error(0, 7, Resources.ERR000007);
                userInterface.Info(0, 3, Resources.INF000003);
                userInterface.Exit();
            }
            else
            {
                // Not required
            }

            notExplicitOptions = checkExplicitOptions(userInput, xmlConfig);
            // Report error if have any options that is not configured by commandline and XML configuration.
            if (notExplicitOptions.Length > Constant.INT_ZERO)
            {
                userInterface.Error(0, 34, Resources.ERR000034, notExplicitOptions.ToString());
                userInterface.Exit();
            }
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_025

        /// <summary>
        /// Validate input files with extension .trxml, .arxml
        /// </summary>
        /// <param name="filePaths">File paths <range>null/valid list of string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// CMN_TAD_WRN_001
        /// </ref>
        /// <algorithm>
        /// IF filePaths is not null THEN
        ///     LET allowExtensions = new string[] [ Constant.TRANSLATION_FILE_EXTENSION, Constant.CDF_EXTENSION ]
        ///     FOREACH file IN filePaths
        ///         IF extension of file does not end with any string in allowExtensions THEN
        ///             CALL userInterface.Warn WITH Resources.WRN000001 to raise WRN000001
        ///         ELSE
        ///             Do nothing
        /// ELSE
        ///     Do nothing
        /// </algorithm>
        private void validateAcceptedFiles(List<string> filePaths)
        {
            if (null != filePaths)
            {
                string[] allowExtensions = new string[] { Constant.TRANSLATION_FILE_EXTENSION, Constant.CDF_EXTENSION };
                // Validate input files with allowed extension .trxml or .arxml
                foreach (string file in filePaths)
                {
                    // Report warning if have any file that is not end with .trxml or .arxml
                    if (allowExtensions.All(e => (false == file.EndsWith(e))))
                    {
                        userInterface.Warn(0, 1, Resources.WRN000001, file);
                    }
                    else
                    {
                        // Not required
                    }
                } // End foreach (string file in filePaths)
            } // End of if (null != filePaths).
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_024

        /// <summary>
        /// Validate input paths
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
        /// CMN_TAD_ERR_011
        /// </ref>
        /// <algorithm>
        /// LET listPath = new List<string>()
        /// IF runtimeConfiguration.CDFFilePaths.Count is 0 THEN
        ///     CALL userInterface.Error WITH Resources.ERR000011 to raise ERR000011
        /// ELSE
        ///     Do nothing
        /// LET listPath.AddRange WITH runtimeConfiguration.CDFFilePaths
        /// LET listPath.AddRange WITH new string[]
        ///     [runtimeConfiguration.ConfigFilePath, runtimeConfiguration.TranslationFilePath]
        /// FOREACH path IN listPath WHERE path does not exist or null
        ///     CALL userInterface.ErrorFileNotFound WIH path
        /// </algorithm>
        private void showInvalidInputPath()
        {
            List<string> listPath = new List<string>();

            // Report error if have not any CDF file that is provided, error 11
            if (Constant.INT_ZERO == runtimeConfiguration.CDFFilePaths.Count)
            {
                userInterface.Error(0, 11, Resources.ERR000011);
                userInterface.Exit();
            }
            else
            {
                // Not required
            }

            listPath.AddRange(runtimeConfiguration.CDFFilePaths);
            listPath.AddRange(new string[]
            {
                runtimeConfiguration.ConfigFilePath,
                runtimeConfiguration.TranslationFilePath
            });

            // Report error if any file paths that is not found.
            foreach (string path in listPath.Where(p => (false == IOWrapper.FileExists(p)) &&
                                                        (false == String.IsNullOrEmpty(p))))
            {
                userInterface.ErrorFileNotFound(path);
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_022

        /// <summary>
        /// Validate output paths
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
        /// CMN_TAD_ERR_009
        /// </ref>
        /// <algorithm>
        /// IF runtimeConfiguration.FolderOutpu is not null THEN
        ///     IF runtimeConfiguration.FolderOutput does not exist THEN
        ///         CALL userInterface.Error WITH Resources.ERR000009 to raise ERR000009
        ///     ELSE
        ///         Do nothing
        /// ELSE
        ///     Do nothing
        /// LET paths = new string[]
        ///     runtimeConfiguration.FolderOutput,
        ///     runtimeConfiguration.IncOutputDirectory,
        ///     runtimeConfiguration.SrcOutputDirectory
        /// FOREACH directory IN paths
        ///     CALL IOWrapper.CreateDirectory WITH directory to create new directory
        /// </algorithm>
        private void showInvalidOutputPath()
        {
            if (false == String.IsNullOrEmpty(runtimeConfiguration.FolderOutput))
            {
                // Report error if path of Folder Output is not exists
                if (IOWrapper.FileExists(runtimeConfiguration.FolderOutput))
                {
                    userInterface.Error(0, 9, Resources.ERR000009, runtimeConfiguration.FolderOutput);
                    userInterface.Exit();
                }
                else
                {
                    // Not required
                }

                // Report error If cannot create folder on paths.
                string[] paths = new string[]
                {
                    runtimeConfiguration.FolderOutput,
                    runtimeConfiguration.IncOutputDirectory,
                    runtimeConfiguration.SrcOutputDirectory
                };

                // Loop to create output folder, output of source and output of header
                foreach (string directory in paths)
                {
                    IOWrapper.CreateDirectory(directory);
                }
            } // End of if (false == String.IsNullOrEmpty(runtimeConfiguration.FolderOutput))
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_001_023

        /// <summary>
        /// Get an option value from .cfgxml file
        /// </summary>
        /// <param name="document">Parsed .cfgxml file <range>null/valid XDocument</range></param>
        /// <param name="option">Option <range>null/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>Value of option extracted from xml config</desc>
        ///         <range>null/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = String.Empty
        /// LET element = collection of pair of value/option
        /// IF element is not null AND element.Value is not null THEN
        ///     LET result = element.Value.ToString()
        /// ELSE
        ///     Do nothing
        ///
        /// RETURN result
        /// </algorithm>
        private string getOptionValueFromXmlConfig(XDocument document, string option)
        {
            string result = String.Empty;
            XElement element = document.Descendants()
                .Where(x => x.Name.LocalName.Equals(option, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            // Scan .cfgxml file to get value of the option
            if ((null != element) && (null != element.Value))
            {
                result = element.Value.ToString();
            }
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_001_018

        /// <summary>
        /// Print Gentool Version
        /// </summary>
        /// <returns>
        ///     None
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <ref>
        /// </ref>
        /// <algorithm>
        /// LET string infoExe
        /// LET executionPath = System.Reflection.Assembly.GetExecutingAssembly().Location
        /// LET executionFileDirectory = Path.GetDirectoryName(executionPath)
        /// LET executionFileNane = Path.GetFileName(executionPath)
        /// LET scannedLocation = executionFileDirectory + "/" + Resources.DLLS_PATH
        /// CALL ConsoleWrapper.WriteLine() to print VERSION INFORMATION
        /// LET infoExe = Generator information
        /// CALL ConsoleWrapper.WriteLine() to print Generator information
        /// LET allDlls = list of all path of dll in scannedLocation
        /// FOREACH dll in allDlls
        ///     IF dll is of E2x|U2Ax|U2Bx
        ///         Store dll to varriantSortedDlls with key is E2x|U2Ax|U2Bx
        ///     ELSE
        ///         Store dll to varriantSortedDlls with key is "Other Dlls"
        /// CALL ConsoleWrapper.WriteLine() to print "Dlls:"
        /// FOREACH variant in varriantSortedDlls.Keys
        ///     Print all dll version information with each variant
        /// </algorithm>
        private void displayToolVersion()
        {
            string infoExe = string.Empty;
            string executionPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string executionFileDirectory = Path.GetDirectoryName(executionPath);
            string executionFileNane = Path.GetFileName(executionPath);
            string scannedLocation = executionFileDirectory + "/" + Resources.DLLS_PATH;

            //Print Generator version information
            ConsoleWrapper.WriteLine("VERSION INFORMATION:");
            infoExe = String.Concat("Generator: ", executionFileNane, ", Version: ",
                                FileVersionInfo.GetVersionInfo(executionPath).ProductVersion);
            ConsoleWrapper.WriteLine(infoExe);

            string[] allDlls = IOWrapper.GetFiles(scannedLocation, "*.dll", SearchOption.AllDirectories,
                                                                                Constant.EXIT_DUE_CRASH);
            Dictionary<string, List<string>> varriantSortedDlls = new Dictionary<string, List<string>>();
            List<string> otherDlls = new List<string>();

            foreach (string dll in allDlls)
            {
                Regex variantRegex = new Regex(@"(E2x|U2Ax|U2Bx|U2Bx-E).dll");
                Match matchVariant = variantRegex.Match(Path.GetFileName(dll));
                if (matchVariant.Success)
                {
                    if (varriantSortedDlls.ContainsKey(matchVariant.Groups[1].Value))
                    {
                        varriantSortedDlls[matchVariant.Groups[1].Value].Add(dll);
                    }
                    else
                    {
                        varriantSortedDlls.Add(matchVariant.Groups[1].Value, new List<string>() { dll });
                    }
                }
                else
                {
                    otherDlls.Add(dll);
                }
            }

            if (otherDlls.Count > Constant.INT_ZERO)
            {
                varriantSortedDlls.Add("Other Dlls", otherDlls);
            }
            else
            {

            }

            ConsoleWrapper.WriteLine("Dlls:");

            foreach (string variant in varriantSortedDlls.Keys)
            {
                List<string> listDll = varriantSortedDlls[variant];

                ConsoleWrapper.WriteLine(String.Concat("  ", variant, ":"));
                foreach (string dll in listDll)
                {
                    string versionInfo = String.Format("    {0}, Version: {1}", Path.GetFileName(dll),
                                                                    FileVersionInfo.GetVersionInfo(dll).ProductVersion);
                    ConsoleWrapper.WriteLine(versionInfo);
                }
            }
            ConsoleWrapper.WriteLine("");
        }
        // Implementation: GENERIC_TUD_CLS_001_028
    }
}


