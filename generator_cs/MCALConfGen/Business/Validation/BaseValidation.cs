/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = BaseValidation.cs                                                                                   */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020, 2024 Renesas Electronics Corporation. All rights reserved.                                */
/*====================================================================================================================*/
/* Purpose: This file contains BaseValidation a base class for other classes used to validate CDF and                 */
/*          intermediate data.                                                                                        */
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
/*              : class BaseValidation                                                                                */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            20/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/*            12/03/2019 :    Fix bug that is cloned from C1X - #91630 as follow:                                     */
/*                            Modify method CheckRequiredModules() to remove unnecessary code                         */
/*                            and check empty arguments of method                                                     */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     07/03/2024 :    Update CheckForMandatoryParameters, addErrorMessage, isMissingContainer                 */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Reflection;
using Renesas.Generator.MCALConfGen.CrossCutting.Logger;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using System.Linq;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;
using Renesas.Generator.MCALConfGen.Properties;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using static Renesas.Generator.MCALConfGen.Business.Validation.ValidationResult;
using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using System.Text.RegularExpressions;

namespace Renesas.Generator.MCALConfGen.Business.Validation
{
    /// <summary>
    /// This "BaseValidation" class is a base class that is implemented by other classes used
    /// to validate CDF and intermediate data of specific module.
    /// </summary>
    public class BaseValidation : IValidation
    {
        /// <summary>
        /// To record log information for debugging.
        /// </summary>
        protected ILogger Logger = null;
        // Implementation: GENERIC_TUD_CLS_026_001

        /// <summary>
        /// To record Error, Warning, Info information and exit Gentool.
        /// </summary>
        protected IUserInterface UserInterface = null;
        // Implementation: GENERIC_TUD_CLS_026_002

        /// <summary>
        /// To provide more convenience operations to upper layers.
        /// </summary>
        protected IRepository Repository = null;
        // Implementation: GENERIC_TUD_CLS_026_003

        /// <summary>
        /// To store the basic information of gentool module.
        /// </summary>
        protected IBasicConfiguration BasicConfiguration = null;
        // Implementation: GENERIC_TUD_CLS_026_004

        /// <summary>
        /// To save and retrive data intermediation.
        /// </summary>
        protected IIntermediateData IntermediateData = null;
        // Implementation: GENERIC_TUD_CLS_026_005

        /// <summary>
        /// Force both pre and post validation
        /// </summary>
        protected bool ForceBothPreAndPostValidation = false;
        // Implementation: GENERIC_TUD_CLS_026_006

        /// <summary>
        /// Force all continue if failed
        /// </summary>
        protected bool ForceAllContinueIfFailed = false;
        // Implementation: GENERIC_TUD_CLS_026_007

        /// <summary>
        /// To initialize a new "BaseValidation" data instance.
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
        protected BaseValidation() : this
        (
            ObjectFactory.GetInstance<ILogger>(),
            ObjectFactory.GetInstance<IUserInterface>(),
            ObjectFactory.GetInstance<IRepository>(),
            ObjectFactory.GetInstance<IBasicConfiguration>(),
            ObjectFactory.GetInstance<IIntermediateData>()
        )
        {
        }
        // Implementation: GENERIC_TUD_CLS_026_010

        /// <summary>
        /// This is constructor of "Basevalidation".
        /// </summary>
        /// <param name="logger">Logger <range>null/valid ILogger</range></param>
        /// <param name="userInterface">User interface <range>null/valid IUserInterface</range></param>
        /// <param name="repo">Repo <range>null/valid IRepository</range></param>
        /// <param name="basicConfiguration">Basic configuration <range>null/valid IBasicConfiguration</range></param>
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
        protected BaseValidation
        (
            ILogger logger,
            IUserInterface userInterface,
            IRepository repository,
            IBasicConfiguration basicConfiguration,
            IIntermediateData intermediateData
        )
        {
            this.Logger = logger;
            this.UserInterface = userInterface;
            this.Repository = repository;
            this.BasicConfiguration = basicConfiguration;
            this.IntermediateData = intermediateData;
        }
        // Implementation: GENERIC_TUD_CLS_026_011

        /// <summary>
        /// This is constructor of basevalidation.
        /// </summary>
        /// <param name="logger">Logger inferace<range>null/valid ILogger</range></param>
        /// <param name="userInterface">User interface <range>null/valid IUserInterface</range></param>
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
        protected BaseValidation(ILogger logger, IUserInterface userInterface)
        {
            this.Logger = logger;
            this.UserInterface = userInterface;
        }
        // Implementation: GENERIC_TUD_CLS_026_012

        /// <summary>
        /// Validate post intermediate
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
        /// LET CALL Info of Logger WITH format is "Run all post validations starting at {0:d/M/yyyy HH:mm:ss}"
        ///                               and marameter is current date.
        /// LET CALL run WITH runPre is false.
        /// LET CALL Info of Logger WITH format is "Run all post validations ending at {0:d/M/yyyy HH:mm:ss}"
        ///                               and marameter is current date.
        /// </algorithm>
        public void ValidatePostIntermediate()
        {
            Logger.Info("Run all post validations starting at {0:d/M/yyyy HH:mm:ss}", DateTime.Now);
            run(false);
            Logger.Info("Run all post validations ending at {0:d/M/yyyy HH:mm:ss}", DateTime.Now);
        }
        // Implementation: GENERIC_TUD_CLS_026_008

        /// <summary>
        /// To check module E_INT_INCONSISTENT
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
        /// CMN_TAD_ERR_041
        /// </ref>
        /// <algorithm>
        /// LET moduleName = BasicConfiguration.ModuleName
        /// LET moduleNameFirstCap = moduleName WITH only first character in upper case
        /// LET intConsistencyCheck = string.Format("MsnInterruptConsistencyCheck", moduleNameFirstCap)
        /// LET eIntInconsistent = string.Format("MSN_E_INT_INCONSISTENT", moduleName.ToUpper())
        /// LET intCheckItem = CALL Repository.GetParameterValue(moduleName, intConsistencyCheck)
        /// IF intCheckItem is null AND value of intCheckItem is true THEN
        ///     LET eIntItem = CALL Repository.GetReferenceValue(moduleName, eIntInconsistent)
        ///     IF eIntItem is null OR Value of eIntItem is null THEN
        ///         Raise ERR000041
        /// </algorithm>
        [ValidationRule(PreIntermediationValidation = true)]
        protected virtual ValidationResult CheckE_INT_INCONSISTENT()
        {
            ValidationResult result = new ValidationResult
            {
                ModuleId = 0,
            };
            string moduleName = BasicConfiguration.ModuleName;
            string moduleNameFirstCap =
                System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(moduleName.ToLower());
            string intConsistencyCheck = string.Format("{0}InterruptConsistencyCheck", moduleNameFirstCap);
            string eIntInconsistent = string.Format("{0}_E_INT_INCONSISTENT", moduleName.ToUpper());
            ItemValue eIntItem = null;
            ItemValue intCheckItem = Repository.GetParameterValue(moduleName, intConsistencyCheck);
            // If <Msn>InterruptConsistencyCheck is configurated
            if (intCheckItem != null && intCheckItem.Value<bool>())
            {
                // Raise error if MsnInterruptConsistencyCheck parameter is configurated and
                // reference MSN_E_INT_INCONSISTENT is not provided value.
                eIntItem = Repository.GetReferenceValue(moduleName, eIntInconsistent);
                if (eIntItem == null || string.IsNullOrEmpty(eIntItem.Value<string>()))
                {
                    result.Type = MessageType.ERROR;
                    result.Code = 41;
                    result.AddMessage(string.Format(Resources.ERR000041, moduleName.ToUpper(), moduleName));
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
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_026_013

        /// <summary>
        /// Validate pre intermediate
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
        /// LET CALL Info of Logger WITH format is "Run all prevalidations starting at {0:d/M/yyyy HH:mm:ss}"
        ///                               and marameter is current date.
        /// LET CALL run WITH runPre is true.
        /// LET CALL Info of Logger WITH format is "Run all prevalidations starting at {0:d/M/yyyy HH:mm:ss}"
        ///                               and marameter is current date.
        /// </algorithm>
        public void ValidatePreIntermediate()
        {
            Logger.Info("Run all prevalidations starting at {0:d/M/yyyy HH:mm:ss}", DateTime.Now);
            run(true);
            Logger.Info("Run all prevalidations starting at {0:d/M/yyyy HH:mm:ss}", DateTime.Now);
        }
        // Implementation: GENERIC_TUD_CLS_026_009

        /// <summary>
        /// Run validation
        /// </summary>
        /// <param name="runPre">Pre-validation <range>true/false</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET methods = collection of all validation methods that are decorated by ValidationRuleAttribute
        /// FOREACH method IN methods
        ///     LET attribute = ValidationRuleAttribute of method
        ///     IF PreIntermediationValidation of attribute is runPre AND EnableMethod of attribute is true THEN
        ///         LET result = return value of method
        ///         IF result is not null AND result is not Error THEN
        ///             FOREACH message IN result.Message
        ///                 Print message and corresponding error code
        /// </algorithm>
        private void run(bool runPre)
        {
            IEnumerable<MethodInfo> methods = GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(method => null != method.GetCustomAttribute<ValidationRuleAttribute>())
                .OrderBy(method => method.GetCustomAttribute<ValidationRuleAttribute>().Order);
            // Using reflection to scan all methods, geting method has ValidationRuleAttribute to invoke in order
            // (Pre - Validation before Intermediate process, Post - Validation after Intermediate process)
            foreach (MethodInfo method in methods)
            {
                ValidationRuleAttribute attribute =
                    (ValidationRuleAttribute)method.GetCustomAttribute(typeof(ValidationRuleAttribute));

                if ((attribute.PreIntermediationValidation == runPre) &&
                    (attribute.EnableMethod == true))
                {
                    ValidationResult result = (ValidationResult)method.Invoke(this, null);
                    // Get result of validation process and report to corresponding message.
                    if (result != null && result.IsError())
                    {
                        foreach (string message in result.Message)
                        {
                            if (ValidationResult.MessageType.ERROR == result.Type)
                            {
                                UserInterface.Error(result.ModuleId, result.Code, message);
                            }
                            else if (ValidationResult.MessageType.WARN == result.Type)
                            {
                                UserInterface.Warn(result.ModuleId, result.Code, message);
                            }
                            else
                            {
                                UserInterface.Info(result.ModuleId, result.Code, message);
                            }
                        } // End of foreach (string message in result.Message).

                        // Report to console with message that has information as what cause error.
                        if (ValidationResult.MessageType.ERROR == result.Type)
                        {
                            exitWithType(result.Type);
                        }
                        else
                        {
                            // Not required
                        }
                    } // End of if (result.IsError()).
                    else
                    {
                        // Not required
                    }
                } // End of if ((null != attribute) && (attribute.PreIntermediationValidation == runPre)).
                else
                {
                    // Not required
                }
            } //End of foreach (MethodInfo method in methods).
        }
        // Implementation: GENERIC_TUD_CLS_026_028

        /// <summary>
        /// Check mandatory parameters
        /// </summary>
        /// <param name="moduleName">Module name <range>null/valid string</range></param>
        /// <param name="mandatoryParams">Mandatory parameters<range>null/valid Hashtable</range></param>
        /// <param name="containerDefName">Container Definition Names<range>null/valid IList<string></range></param>
        /// <returns>
        ///     <para>List<string>
        ///         <desc>The error messages</desc>
        ///         <range>Empty/Valid messages</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
    		/// LET variants = Get all variant configurations by moduleName
        /// LET errorMessages = new List<string>()
	    	/// FOREACH container in list container
        /// 	IF mandatoryParams is not null THEN
        ///     	FOREACH defName IN Keys of mandatoryParams
        ///         	IF mandatoryParams[defName] is List<string> THEN
        ///             	LET containerList = CALL Repository.GetContainersByDefName(moduleName, defName, variantID: variant.Key)
        ///                 	FOREACH container IN containerList
        ///                     	FOREACH param IN paramList
        ///                         	LET paramValue = container.GetParameterValue(param, variant.Key)
        ///                         	LET refValue = container.GetReferenceValue(param, variant.Key)
        ///                         	IF paramValue is null OR refValue is null THEN
        ///                             	LET message = addErrorMessage(moduleName, param, defName, container.Path, variant.Value)
        ///                             	ADD message to errorMessages
        /// RETURN errorMessages
        /// </algorithm>
        protected List<string> CheckForMandatoryParameters(string moduleName,
                                                           Hashtable mandatoryParams,
                                                           IList<string> containerDefName)
        {
            Dictionary<string, string> variants =
                                                Repository.GetShortNameVariantConfig(moduleName);

            List<string> errorMessages = new List<string>();

            foreach (KeyValuePair<string, string> variant in variants)
            {
                if (null != mandatoryParams)
                {
                    foreach (string defName in mandatoryParams.Keys)
                    {
                        if (mandatoryParams[defName] is List<string>)
                        {
                            List<string> paramList = (List<string>)mandatoryParams[defName];
                            IList<Container> containerList = Repository.GetContainersByDefName(moduleName, defName, variantID: variant.Key);
                            // Scan all containers contain parameter that is required.
                            // For container is configued in cdf files
                            if (containerList.Any())
                            {
                                foreach (Container container in containerList)
                                {
                                    // Check exists value of required parameters in CDFs.
                                    foreach (string param in paramList)
                                    {
                                        ItemValue paramValue = container.GetParameterValue(param, variant.Key);
                                        ItemValue refValue = container.GetReferenceValue(param, variant.Key);
                                        // Report error if have any parameter is not configurated.
                                        if ((null != paramValue) || (null != refValue))
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            string message = addErrorMessage(moduleName, param, defName, container.Path, variant.Value);
                                            errorMessages.Add(message);
                                        }
                                    } // End of foreach (string param in paramList).
                                } // End of foreach (Container container in containerList).
                            }//End of  if (containerList.Any())
                             // If container is not configured in Cdf but container is mandatory
                            else
                            {
                                // If container is not configured in cdf, raise error message
                                if (isMissingContainer(moduleName, defName, containerDefName, variant.Key))
                                {
                                    // Add error message for all parameters.
                                    foreach (string param in paramList)
                                    {
                                        string message = addErrorMessage(moduleName, param, defName, string.Empty, variant.Value);
                                        errorMessages.Add(message);
                                    }
                                }
                                else
                                {
                                    // Not required
                                }
                            }
                        } // End of if (mandatoryParams[defName] is List<string>).
                        else
                        {
                            // Not required
                        }
                    } // End of foreach (string defName in mandatoryParams.Keys).
                }
                else
                {
                    // Not required
                }
            }
            return errorMessages;
        }
        // Implementation: GENERIC_TUD_CLS_026_014

        /// <summary>
        /// Process error message for checking mandatory parameters
        /// </summary>
        /// <param name="moduleName">Module name<range>null/valid string</range></param>
        /// <param name="param">Parameter<range>null/valid string</range></param>
        /// <param name="defName">Definition name<range>null/valid string</range></param>
        /// <param name="path">Path of conainer<range>null/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The error message</desc>
        ///         <range>valid string.</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET stringBuilder = initialize a StringBuilder.
        /// LET fileName = return value by CALL GetFullPath of IOWrapper WITH
        ///                              path is the return value by CALL GetCdfFileName WITH moduleName is moduleName.
	    	/// LET variantName = a string "variantID" if variantID is not null or empty, or a empty string 
        /// LET CALL AppendFormat of stringBuilder WITH
        ///                                 format is "The parameter '{0}' in the container " and arg0 is param, arg1 is variantName
        /// LET CALL AppendFormat of stringBuilder WITH
        ///                                 format is "'{0}' should be configured.\n" and arg0 is param.
        /// LET CALL AppendFormat of stringBuilder WITH
        ///                                 format is "File Name: {0}\n" and arg0 is param.
        /// LET CALL AppendFormat of stringBuilder WITH
        ///                                 format is "Path: {0}" and arg0 is param.
        /// RETURN stringBuilder
        /// </algorithm>
        private string addErrorMessage(string moduleName, string param, string defName, string path, string variantID = "")
        {
            StringBuilder stringBuilder = new StringBuilder();
            string fileName = IOWrapper.GetFullPath(Repository.GetCdfFileName(moduleName));

            string variantName = (!string.IsNullOrEmpty(variantID)) ? $"[{variantID}]" : string.Empty;

            stringBuilder.AppendFormat("{1} The parameter '{0}' in the container ", param, variantName);
            stringBuilder.AppendFormat("'{0}' should be configured.\n", defName);
            stringBuilder.AppendFormat("File Name: {0}\n", fileName);
            stringBuilder.AppendFormat("Path: {0}", path);
            return stringBuilder.ToString();
        }
        // Implementation: GENERIC_TUD_CLS_026_022


        /// <summary>
        /// Check the availability of container
        /// </summary>
        /// <param name="moduleName">Module name<range>null/valid string</range></param>
        /// <param name="defName">Definition name<range>null/valid string</range></param>
        /// <param name="containerDefName">Container Definition Names<range>null/valid IList<string></range></param>
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
        /// FOREACH defName in mandatoryParams
        ///     LET get list of mandatory parameters in mandatoryParams for this def name
        ///     LET get list of containers by this def name
        ///     FOREACH container in containerDefName
        ///         IF not all the mandatory parameters have value in each container THEN
        ///             LET add an error for each missing parameter to collection "result"
        /// RETURN collection "result"
        /// </algorithm>
        private bool isMissingContainer(string moduleName, string defName, IList<string> containerDefName, string variantID = "")
        {
            List<string> errorMessages = new List<string>();
            bool ret = false;
            // If defName in required containers, check whether container does exist ot not.
            if (null != containerDefName &&
                containerDefName.Any(x => x.Equals(defName, StringComparison.OrdinalIgnoreCase)))
            {
                foreach (string container in containerDefName)
                {
                    IList<Container> containerList = Repository.GetContainersByDefName(moduleName, defName, variantID:variantID);
                    if (!containerList.Any())
                    {
                        ret = true;
                        break;
                    }
                    else
                    {
                        // Not required
                    }
                } // End of  foreach (string defName in mandatoryDefName).
            }// if (null != containerDefName &&
             // containerDefName.Any(x => x.Equals(defName, StringComparison.OrdinalIgnoreCase)))
            else
            {
                // Not required
            }
            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_026_027


        /// <summary>
        /// Check same field of substructs
        /// </summary>
        /// <param name="structName">Struct name<range>null/valid string</range></param>
        /// <returns>
        ///     <para>List<string>
        ///         <desc>The error message</desc>
        ///         <range>empty/valid messages</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Default dataPath = "/" + structName
        /// CALL CheckSameFieldsOfSubstructs WITH default dataPath and structName
        /// RETURN error list from result of CheckSameFieldsOfSubstructs
        /// </algorithm>
        protected List<string> CheckSameFieldsOfSubstructs(string structName)
        {
            return CheckSameFieldsOfSubstructs(String.Concat("/", structName), structName);
        }
        // Implementation: GENERIC_TUD_CLS_026_017

        /// <summary>
        /// Check same fields of substructs
        /// </summary>
        /// <param name="dataPath">Data path<range>null/valid string</range></param>
        /// <param name="structName">Struct name<range>null/valid string</range></param>
        /// <returns>
        ///     <para>List<string>
        ///         <desc>The error message</desc>
        ///         <range>empty/valid messages</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET get a BaseIntermediateItem structData from dataPath
        /// IF structData is NOT null and structData.Childs is NOT null THEN
        ///     - CALL method findFieldsOfAnyLastNodeStruct to get fields of an sample struct
        ///     - CALL method checkSameFieldsOfSubstructs to check all substructs in structData has the same number of
        ///       fields with the sample struct
        ///     - RETURN error found by checkSameFieldsOfSubstructs
        /// Else
        ///     RETURN empty error list
        /// </algorithm>
        protected List<string> CheckSameFieldsOfSubstructs(string dataPath, string structName)
        {
            List<string> errorMessages = new List<string>();
            BaseIntermediateItem structData = IntermediateData.GetItemByPath(dataPath);
            // Report error if have any sub struct has not the same number of fields.
            if ((null != structData) && (null != structData.Childs))
            {
                List<string> fields = findFieldsOfAnyLastNodeStruct(structData);

                string errorMessage = checkSameFieldsOfSubstructs(structName, structData, fields);
                // There are many structs in array, report error if those generated structs have to the same fields.
                if (false == String.IsNullOrEmpty(errorMessage))
                {
                    errorMessages.Add(errorMessage);
                }
                else
                {
                    // Not required
                }
            } // End of if ((null != structData) && (null != structData.Childs)).
            else
            {
                // Not required
            }

            return errorMessages;
        }
        // Implementation: GENERIC_TUD_CLS_026_018

        /// <summary>
        /// Check required fields of substructs
        /// </summary>
        /// <param name="structName">Struct name<range>null/valid string</range></param>
        /// <param name="requiredFields">Required fields<range>null/valid List<string></range></param>
        /// <returns>
        ///     <para>List<string>
        ///         <desc>The error message</desc>
        ///         <range>empty/valid messages</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Default dataPath = "/" + structName
        /// CALL CheckRequiredFieldsOfSubstructs WITH default dataPath, structName and requiredFields
        /// RETURN error list from result of CheckRequiredFieldsOfSubstructs
        /// </algorithm>
        protected List<string> CheckRequiredFieldsOfSubstructs(string structName, List<string> requiredFields)
        {
            return CheckRequiredFieldsOfSubstructs(String.Concat("/", structName), structName, requiredFields);
        }
        // Implementation: GENERIC_TUD_CLS_026_015

        /// <summary>
        /// Check required fields of substructs
        /// </summary>
        /// <param name="dataPath">Data path<range>null/valid string</range></param>
        /// <param name="structName">Struct name<range>null/valid string</range></param>
        /// <param name="requiredFields">Required fields<range>null/valid List<string></range></param>
        /// <returns>
        ///     <para>List<string>
        ///         <desc>The error message</desc>
        ///         <range>empty/valid messages</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get BaseIntermediateItem structData from dataPath
        /// CALL checkRequiredFieldsOfSubstructs WITH structName, structData and requiredFields
        /// RETURN error list from result of checkRequiredFieldsOfSubstructs
        /// </algorithm>
        protected List<string> CheckRequiredFieldsOfSubstructs(string dataPath,
            string structName, List<string> requiredFields)
        {
            BaseIntermediateItem structData = IntermediateData.GetItemByPath(dataPath);
            return checkRequiredFieldsOfSubstructs(structName, structData, requiredFields).ToList();
        }
        // Implementation: GENERIC_TUD_CLS_026_016

        /// <summary>
        /// Check same fields of substructs
        /// </summary>
        /// <param name="rootStructName">Root struct name<range>null/valid string</range></param>
        /// <param name="structData">Struct name<range>null/valid string</range></param>
        /// <param name="fields">Fields<range>null/valid List<string></range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The error message</desc>
        ///         <range>empty/valid message</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Recurively scan substructs in structData
        ///     IF a substruct is last node (all items are fields, NOT inner substruct) THEN
        ///         IF substruct NOT have the same number of field with sample fields list THEN
        ///             LET add a error to collection "result"
        /// RETURN error collection "result"
        /// </algorithm>
        private string checkSameFieldsOfSubstructs(string rootStructName,
            BaseIntermediateItem structData, List<string> fields)
        {
            string errorMessage = String.Empty;

            if ((null != structData) && (null != structData.Childs))
            {
                // Only check required fields for a last node struct that is last node of hierarchy
                if (structData.Childs.All(e => (null == e) ||
                                                (null == e.Childs) ||
                                                (Constant.INT_ZERO == e.Childs.Count)))
                {
                    foreach (string field in fields)
                    {
                        if (false == structData.Childs.Exists(e => (null != e) && (e.Name == field)))
                        {
                            errorMessage = String.Format(Resources.ERR_SPECIFIC_01, rootStructName);
                            break;
                        }
                        else
                        {
                            // Not required
                        }
                    }
                } // End of if (structData.Childs.All(e => (null == e) || (null == e.Childs) || (0 == e.Childs.Count)))
                else
                {
                    // Scan data child struct and check fields in child struct.
                    foreach (BaseIntermediateItem childStruct in structData.Childs)
                    {
                        errorMessage = checkSameFieldsOfSubstructs(rootStructName, childStruct, fields);

                        if (false == String.IsNullOrEmpty(errorMessage))
                        {
                            break;
                        }
                        else
                        {
                            // Not required
                        }
                    } // End of foreach (BaseIntermediateItem childStruct in structData.Childs).
                }
            } // End of if ((null != structData) && (null != structData.Childs)).
            else
            {
                // Not required
            }

            return errorMessage;
        }
        // Implementation: GENERIC_TUD_CLS_026_024

        /// <summary>
        /// Find sample fields of any last node struct
        /// </summary>
        /// <param name="structData">Struct name<range>null/valid BaseIntermediateItem</range></param>
        /// <returns>
        ///     <para>List<string>
        ///         <desc>The found fields</desc>
        ///         <range>empty/valid fields</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Recurively scan substructs in structData
        ///     IF a substruct is last node (all items are fields, NOT inner substruct) THEN
        ///         RETURN the substruct fields list
        /// </algorithm>
        private List<string> findFieldsOfAnyLastNodeStruct(BaseIntermediateItem structData)
        {
            List<string> fields = new List<string>();

            if ((null != structData) && (null != structData.Childs))
            {
                // Return fields if this is a last node struct that is last node of hierarchy
                if (structData.Childs.All(e => (null == e) ||
                                               (null == e.Childs) ||
                                               (Constant.INT_ZERO == e.Childs.Count)))
                {
                    fields = structData.Childs.Where(e => null != e).Select(e => e.Name).ToList();
                }
                else
                {
                    // Return all fields of child structs of last node struct.
                    foreach (BaseIntermediateItem childStruct in structData.Childs)
                    {
                        fields = findFieldsOfAnyLastNodeStruct(childStruct);

                        if (Constant.INT_ZERO < fields.Count)
                        {
                            break;
                        }
                        else
                        {
                            // Not required
                        }
                    } // End of foreach (BaseIntermediateItem childStruct in structData.Childs).
                } // End of if (structData.Childs.All(e => (null == e) || (null == e.Childs) || (0 == e.Childs.Count)))
            } // End of if ((null != structData) && (null != structData.Childs)).
            else
            {
                // Not required
            }

            return fields;
        }
        // Implementation: GENERIC_TUD_CLS_026_026

        /// <summary>
        /// Find sample fields of any last node struct
        /// </summary>
        /// <param name="rootStructName">Parent Struct Name<range>null/valid string</range></param>
        /// <param name="structData">Parent Struct Data<range>null/valid BaseIntermediateItem</range></param>
        /// <param name="requiredFields">Required Fields<range>null/valid strings</range></param>
        /// <returns>
        ///     <para>HashSet<string>
        ///         <desc>The error message</desc>
        ///         <range>empty/valid messages</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Recurively scan substructs in structData
        ///     IF a substruct is last node (all items are fields, NOT inner substruct) THEN
        ///         IF substruct NOT have values for all requiredFields THEN
        ///             LET add an error to collection "result"
        /// RETURN error collection "result"
        /// </algorithm>
        private HashSet<string> checkRequiredFieldsOfSubstructs(string rootStructName,
            BaseIntermediateItem structData, List<string> requiredFields)
        {
            HashSet<string> errorMessages = new HashSet<string>();

            if ((null != structData) && (null != structData.Childs))
            {
                // Only check required fields for a last node struct that is last node of hierarchy
                if (structData.Childs.All(e => (null == e) ||
                                                (null == e.Childs) ||
                                                (Constant.INT_ZERO == e.Childs.Count)))
                {
                    foreach (string field in requiredFields)
                    {
                        if (false == structData.Childs.Exists(e => (null != e) && (e.Name == field)))
                        {
                            errorMessages.Add(String.Format(Resources.ERR_SPECIFIC_02, field, rootStructName));
                        }
                        else
                        {
                            // Not required
                        }
                    }
                } // End of if (structData.Childs.All(e => (null == e) || (null == e.Childs) || (0 == e.Childs.Count)))
                else
                {
                    // Check all required fields of child structs of data node struct.
                    foreach (BaseIntermediateItem childStruct in structData.Childs)
                    {
                        errorMessages.UnionWith
                        (
                            checkRequiredFieldsOfSubstructs(rootStructName, childStruct, requiredFields)
                        );
                    }
                }
            } // End of if ((null != structData) && (null != structData.Childs)).
            else
            {
                // Not required
            }
            return errorMessages;
        }
        // Implementation: GENERIC_TUD_CLS_026_023

        /// <summary>
        /// Exit with type
        /// </summary>
        /// <param name="type">Error message type<range>null/valid string</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET exitCode =
        ///     EXIT_DUE_INPUT_FILES_ERROR if type = ERROR
        ///     EXIT_SUCCESSFUL_WITH_WARNINGS if type = WARN
        ///     EXIT_SUCCESSFUL otherwise
        ///
        /// CALL userInterface.Exit WITH exitCode
        /// </algorithm>
        private void exitWithType(ValidationResult.MessageType type)
        {
            int exitCode = Constant.EXIT_SUCCESSFUL;
            // Alway report status of exit the generation tool.
            switch (type)
            {
                case ValidationResult.MessageType.ERROR:
                    exitCode = Constant.EXIT_DUE_INPUT_FILES_ERROR;
                    break;
                case ValidationResult.MessageType.WARN:
                    exitCode = Constant.EXIT_SUCCESSFUL_WITH_WARNINGS;
                    break;
                case ValidationResult.MessageType.SUCCESS:
                    break;
                default:
                    break;
            } // End of switch (type).

            UserInterface.Exit(exitCode);
        }
        // Implementation: GENERIC_TUD_CLS_026_025

        /// <summary>
        /// To check number of fields in entity structure name
        /// </summary>
        /// <returns>
        ///     <para>"ValidationResult"
        ///         <desc>The checking result</desc>
        ///         <range>null/valid ValidationResult</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = initialize a ValidationResult WITH Code is two and ModuleId is specific module id.
        /// LET errorMessages = initialize a list of string.
        /// LET requiredStructData = return value by CALL GetAllStructureData.
        /// IF the value of requiredStructData is not Null THEN
        ///     FOREACH structName in each key of requiredStructData
        ///         LET add the value by CALL CheckSameFieldsOfSubstructs WITH
        ///                                 structuName to errorMessages.
        ///     IF the number of element of errorMessages is larger than zero THEN
        ///         LET Message of result is errorMessages.
        ///         LET Type of result is ERROR.
        /// </algorithm>
        [ValidationRule(PostIntermediationValidation = true, EnableMethod = false)]
        protected virtual ValidationResult Check_ERR_SPECIFIC_01()
        {
            ValidationResult result = new ValidationResult
            {
                ModuleId = BasicConfiguration.ModuleId,
                Code = 1
            };

            List<string> errorMessages = new List<string>();
            // Get all generated structure information of specific module
            var requiredStructData = GetAllStructureData();

            if (null != requiredStructData)
            {
                foreach (string structName in requiredStructData.Keys.Where(x => !String.IsNullOrEmpty(x)))
                {
                    errorMessages.AddRange(CheckSameFieldsOfSubstructs(structName));
                }
                // Report error if have any number of field each structure is difference.
                if (errorMessages.Count > 0)
                {
                    result.Message = errorMessages;
                    result.Type = MessageType.ERROR;
                }
                else
                {
                    // Do nothing
                }
            } // End of if (null != requiredStructData)
            else
            {
                // Do nothing
            }
            return result;
        }
        // Implementation: GENERIC_TUD_CLS_026_019

        /// <summary>
        /// To check empty field name in entity structure name
        /// </summary>
        /// <returns>
        ///     <para>"ValidationResult"
        ///         <desc>The checking result</desc>
        ///         <range>null/valid ValidationResult</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET result = initialize a ValidationResult WITH Code is two and ModuleId is specific module id.
        /// LET errorMessages = initialize a list of string.
        /// LET requiredStructData = return value by CALL GetAllStructureData.
        /// IF the value of requiredStructData is not Null THEN
        ///     FOREACH structName in each key of requiredStructData
        ///         LET add the value by CALL CheckRequiredFieldsOfSubstructs WITH
        ///                                 structuName and requiredStructData[structName] to errorMessages.
        ///     IF the number of element of errorMessages is larger than zero THEN
        ///         LET Message of result is errorMessages.
        ///         LET Type of result is ERROR.
        /// RETURN result.
        /// </algorithm>
        [ValidationRule(PostIntermediationValidation = true, EnableMethod = false)]
        protected virtual ValidationResult Check_ERR_SPECIFIC_02()
        {
            ValidationResult result = new ValidationResult
            {
                ModuleId = BasicConfiguration.ModuleId,
                Code = 2
            };

            List<string> errorMessages = new List<string>();
            // Get all generated structure information of specific module
            var requiredStructData = GetAllStructureData();

            if (null != requiredStructData)
            {
                foreach (string structName in requiredStructData.Keys.Where(x => (!String.IsNullOrEmpty(x)) &&
                                                                            (null != requiredStructData[x])))
                {
                    errorMessages.AddRange(CheckRequiredFieldsOfSubstructs(structName,
                                                                           requiredStructData[structName]));
                }
                // Report error if have any required field each structure is missing.
                if (errorMessages.Count > 0)
                {
                    result.Message = errorMessages;
                    result.Type = MessageType.ERROR;
                }
                else
                {
                    // Do nothing
                }
            }
            else
            {
                // Do nothing
            }
            return result;

        }
        // Implementation: GENERIC_TUD_CLS_026_020

        /// <summary>
        /// Get all structure data name, an abstract method to be override by
        /// specific module to provide structure data in post build source
        /// </summary>
        /// <returns>
        ///     <para>Dictionary<string, List<string>>
        ///         <desc>The Structure Data dictionary</desc>
        ///         <range>null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Return null
        /// </algorithm>
        protected virtual Dictionary<string, List<string>> GetAllStructureData()
        {
            return null;
        }
        // Implementation: GENERIC_TUD_CLS_026_021
    }
}
