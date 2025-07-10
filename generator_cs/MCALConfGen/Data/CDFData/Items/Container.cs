/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = Container.cs                                                                                        */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020, 2024 Renesas Electronics Corporation. All rights reserved.                                */
/*====================================================================================================================*/
/* Purpose: This file contains Container class that stores information of a CDF tag ECUC-CONTAINER-VALUE              */
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
/*              : class Container                                                                                     */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.1.1:     02/03/2024 :    Add VariantID, ListConfiguredVariantID                                                  */
/*                            Update GetParameterValue, GetParameterValues, GetReferenceValue, GetReferenceValues     */
/*                            GetChildsByDefName, GetChildByDefName                                                   */
/* 1.1.2:     26/03/2024 :    Update GetParameterValue, GetParameterValues, GetReferenceValue, GetReferenceValues     */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Collections.Generic;
using System.Linq;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;

namespace Renesas.Generator.MCALConfGen.Data.CDFData.Items
{
    /// <summary>
    /// This class that stores information of a CDF on the tag ECUC-CONTAINER-VALUE
    /// </summary>
    public class Container
    {
        /// <summary>
        /// This field store Uuid of a ECUC-CONTAINER-VALUE
        /// </summary>
        public string Uuid { get; set; }
        // Implementation: GENERIC_TUD_CLS_046_001

        /// <summary>
        /// This field store Short name of a ECUC-CONTAINER-VALUE
        /// </summary>
        public string ShortName { get; set; }
        // Implementation: GENERIC_TUD_CLS_046_002

        /// <summary>
        /// This field store Definition reference of a ECUC-CONTAINER-VALUE
        /// </summary>
        public string DefinitionRef { get; set; }
        // Implementation: GENERIC_TUD_CLS_046_003

        /// <summary>
        /// This field store Parameter values of a ECUC-CONTAINER-VALUE
        /// </summary>
        public IList<ItemValue> ParameterValues { get; set; } = new List<ItemValue>();
        // Implementation: GENERIC_TUD_CLS_046_004

        /// <summary>
        /// This field store Reference values of a ECUC-CONTAINER-VALUE
        /// </summary>
        public IList<ItemValue> ReferenceValues { get; set; } = new List<ItemValue>();
        // Implementation: GENERIC_TUD_CLS_046_005

        /// <summary>
        /// This field store Parent of a ECUC-CONTAINER-VALUE
        /// </summary>
        public Container Parent { get; set; }
        // Implementation: GENERIC_TUD_CLS_046_006

        /// <summary>
        /// This field store Path of a ECUC-CONTAINER-VALUE
        /// </summary>
        public string Path { get; set; }
        // Implementation: GENERIC_TUD_CLS_046_007

        /// <summary>
        /// This field store List of Childs of a ECUC-CONTAINER-VALUE
        /// </summary>
        public List<Container> Childs { get; set; } = new List<Container>();
        // Implementation: GENERIC_TUD_CLS_046_008

        /// <summary>
        /// This field store List of Childs of a ECUC-CONTAINER-VALUE
        /// </summary>
        public string VariantID { get; set; }
        // Implementation: GENERIC_TUD_CLS_046_019

        /// <summary>
        /// This field store List of Childs of a ECUC-CONTAINER-VALUE
        /// </summary>
        public List<string> ListConfiguredVariantID { get; set; } = new List<string>();
        // Implementation: GENERIC_TUD_CLS_046_020

        /// <summary>
        /// Check if this object and target are equal
        /// </summary>
        /// <param name="target">Target object <range>null/valid object</range></param>
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
        /// IF target is null or not instance of Container THEN
        ///     RETURN false
        /// ELSE IF Uuid and short name of this object are equal to target object
        ///     RETURN true
        /// ELSE
        ///     RETURN false
        /// </algorithm>
        public override bool Equals(object target)
        {
            bool ret = false;
            Container targetContainer = target as Container;

            // If parameter cannot be cast to Point return false.
            if (null == targetContainer)
            {
                ret = false;
            }
            // Compare two container by UUID and Short name attribute
            else
            {
                ret = Uuid.Equals(targetContainer.Uuid) && ShortName.Equals(targetContainer.ShortName);
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_046_010

        /// <summary>
        /// Get hash code of container
        /// </summary>
        /// <returns>
        ///     <para>int
        ///         <desc>hash code</desc>
        ///         <range>0/valid int</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF Uuid is NOT null or empty THEN
        ///     RETURN hash code of Uuid
        /// ELSE
        ///     RETURN hash code from base method Object.GetHashCode()
        /// </algorithm>
        public override int GetHashCode()
        {
            int hashCode = Constant.INT_ZERO;

            if (false == String.IsNullOrEmpty(Uuid))
            {
                hashCode = Uuid.GetHashCode();
            }
            else
            {
                hashCode = base.GetHashCode();
            }

            return hashCode;
        }
        // Implementation: GENERIC_TUD_CLS_046_014

        /// <summary>
        /// Get a parameter value from name
        /// </summary>
        /// <param name="paramName">Param name <range>null/valid string</range></param>
        /// <returns>
        ///     <para>ItemValue
        ///         <desc>Parameter value</desc>
        ///         <range>null/vaild value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
		/// LET item = null
		/// IF variantID is empty
        ///   LET item = Scan all ParameterValues of this container
        //    where definition name of a parameter item is equal to paramName THEN
        ///   RETURN first found parameter item
		/// ELSE
		///	  LET item = Scan all ParameterValues of this container
        ///   where definition name of a parameter item is equal to paramName THEN
		///	    Scan all ParameterValues of this container based on the given condition
        ///     RETURN first found parameter item
		///     IF variantID is not null
		///       IF number of variantID greater than 0 THEN
		///	          LET item = Conversion type of VariantItemValue to ItemValue
		///	      ELSE
        ///	        Do nothing
		///	    ELSE	
		///       Do nothing
        /// RETURN item
        /// </algorithm>
        public ItemValue GetParameterValue(string paramName, string variantID = "")
        {
            ItemValue item = null;

            if (string.Empty ==  variantID)
            {
                item = ParameterValues.Where(
                        x => StringUtils.GetElementLastInArray(x.DefinitionRef())
                        .Equals(paramName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            else
            {
                // New validation for variant post build configuration
                item = ParameterValues.Where(x => StringUtils.GetElementLastInArray(x.DefinitionRef())
                        .Equals(paramName, StringComparison.OrdinalIgnoreCase))
                        .Where(x => ((0 == x.getVariantIDs().Count) || (x.getListVariantIDs().Contains(variantID))))
                        .FirstOrDefault();
                // Check if variantID is not null or empty but parameter does not configured any variant post build
                if (null != item)
                {
                    if (0 < item.getListVariantIDs().Count)
                    {
                       // Convert type of VariantItemValue to ItemValue
                       item = new ItemValue(item.DefinitionRef(), item.getVariantItem(variantID).InternalValue());
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
            }

            return item;
        }
        // Implementation: GENERIC_TUD_CLS_046_015

        /// <summary>
        /// Get all parameters' values from name
        /// </summary>
        /// <param name="paramName">Param name<range>null/valid string</range></param>
        /// <returns>
        ///     <para>IList<ItemValue>
        ///         <desc>List of parameter values</desc>
        ///         <range>empty/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
		/// LET paramList = new List of ItemValue object
		/// IF variantID is empty
        ///   LET paramList = Scan all ParameterValues of this container
        ///   where definition name of a parameter item is equal to paramName THEN
        ///   RETURN a list of found parameter items
		/// ELSE
		///	  LET paramList = Scan all ParameterValues of this container
        ///   where definition name of a parameter item is equal to paramName THEN
		///	  Scan all ParameterValues of this container based on the given condition
        ///   RETURN a list of found parameter items
		///	  LET tempParamList = new List of ItemValue object
		///	  FOREACH container in list container
		///     IF number of variantID greater than 0 THEN
		///         Add new container with the defined value to tempParamList	
		///	    ELSE
		///	      Add this container to tempParamList
		///	  LET list container = tempParamList
        /// RETURN null if NOT found
        /// </algorithm>
        public IList<ItemValue> GetParameterValues(string paramName, string variantID = "")
        {
            IList<ItemValue> paramList = new List<ItemValue>();
            if (string.Empty == variantID)
            {
                paramList = ParameterValues.Where(
                        x => StringUtils.GetElementLastInArray(x.DefinitionRef())
                        .Equals(paramName, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else
            {
                paramList = ParameterValues.Where(x => StringUtils.GetElementLastInArray(x.DefinitionRef())
                    .Equals(paramName, StringComparison.OrdinalIgnoreCase))
                    .Where(x => ((0 == x.getVariantIDs().Count) || (x.getListVariantIDs().Contains(variantID))))
                    .ToList();

                IList<ItemValue> tempParamList = new List<ItemValue>();

                foreach (ItemValue param in paramList)
                {
                    if (0 < param.getListVariantIDs().Count)
                    {
                        tempParamList.Add(new ItemValue(param.DefinitionRef(), 
                                param.getVariantItem(variantID).InternalValue()));
                    }
                    else
                    {
                        tempParamList.Add(param);
                    }
                }

                paramList = tempParamList;
            }

            return paramList;
        }
        // Implementation: GENERIC_TUD_CLS_046_016

        /// <summary>
        /// Get a reference value from name
        /// </summary>
        /// <param name="paramName">Param name<range>null/valid string</range></param>
        /// <returns>
        ///     <para>ItemValue
        ///         <desc>Reference value</desc>
        ///         <range>empty/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
		///	LET item = null
		/// IF variantID is empty
        ///   LET item = Scan all ReferenceValues of this container
        ///   where definition name of a reference item is equal to paramName THEN
        ///   RETURN first found reference item
		///	ELSE
        ///   LET item = Scan all ReferenceValues of this container
        ///   where definition name of a reference item is equal to paramName THEN
		///	    Scan all ReferenceValues of this container based on the given condition
        ///     RETURN first found reference item	
		///   IF variantID is not null
		///     IF number of variantID greater than 0 THEN
		///	        LET item = Conversion type of VariantItemValue to ItemValue
		///	    ELSE 
        ///	      Do nothing
		///	  ELSE
        ///	    Do nothing
        /// RETURN null if NOT found
        /// </algorithm>
        public ItemValue GetReferenceValue(string paramName, string variantID = "")
        {
            ItemValue item = null;

            if (string.Empty == variantID)
            {
                item = ReferenceValues.Where(
                        x => StringUtils.GetElementLastInArray(x.DefinitionRef())
                        .Equals(paramName, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            else
            {
                item = ReferenceValues.Where(x => StringUtils.GetElementLastInArray(x.DefinitionRef())
                    .Equals(paramName, StringComparison.OrdinalIgnoreCase))
                    .Where(x => ((0 == x.getVariantIDs().Count) || x.getListVariantIDs().Contains(variantID)))
                    .FirstOrDefault();

                if (null != item)
                {
                    if (0 < item.getListVariantIDs().Count)
                    {
                        item = new ItemValue(item.DefinitionRef(), item.getVariantItem(variantID).InternalValue());
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
            }

            return item;
        }
        // Implementation: GENERIC_TUD_CLS_046_017

        /// <summary>
        /// Get all references' values from name
        /// </summary>
        /// <param name="paramName">Param name<range>null/valid string</range></param>
        /// <returns>
        ///     <para>IList<ItemValue>
        ///         <desc>List of reference values</desc>
        ///         <range>empty/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
		/// LET paramList = new List of ItemValue object
		/// IF variantID is empty      
		///   LET paramList = Scan all ReferenceValues of this container        
		///   where definition name of a parameter item is equal to paramName THEN
        ///   RETURN a list of found parameter items
		/// ELSE
		///	  LET paramList = Scan all ReferenceValues of this container
        ///   where definition name of a parameter item is equal to paramName THEN
		///	  Scan all ReferenceValues of this container based on the given condition
        ///   RETURN a list of found parameter items
		///	  LET tempParamList = new List of ItemValue object
		///	  FOREACH container in list container
		///	    IF number of variantID greater than 0 THEN
		///	        Add new container with the defined value to tempParamList	
		///	    ELSE
		///	      Add this container to tempParamList
		///		LET list container = tempParamList
        /// RETURN null if NOT found
        /// </algorithm>
        public IList<ItemValue> GetReferenceValues(string paramName, string variantID = "")
        {
            IList<ItemValue> paramList = new List<ItemValue>();

            if (string.Empty == variantID)
            {
                paramList = ReferenceValues.Where(
                    x => StringUtils.GetElementLastInArray(x.DefinitionRef())
                    .Equals(paramName, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else
            {
                paramList = ReferenceValues.Where(x => StringUtils.GetElementLastInArray(x.DefinitionRef())
                    .Equals(paramName, StringComparison.OrdinalIgnoreCase))
                    .Where(x => ((0 == x.getVariantIDs().Count) || (x.getListVariantIDs().Contains(variantID))))
                    .ToList();

                IList<ItemValue> tempParamList = new List<ItemValue>();

                foreach (ItemValue param in paramList)
                {
                    if (0 < param.getListVariantIDs().Count)
                    {
                        tempParamList.Add(new ItemValue(param.DefinitionRef(),
                                param.getVariantItem(variantID).InternalValue()));
                    }
                    else
                    {
                        tempParamList.Add(param);
                    }
                }

                paramList = tempParamList;
            }

            return paramList;
        }
        // Implementation: GENERIC_TUD_CLS_046_018

        /// <summary>
        /// Get all descendant containers (including this container)
        /// </summary>
        /// <returns>
        ///     <para>IList<Container>
        ///         <desc>List of containers</desc>
        ///         <range>empty/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET list = Add this container
        /// IF scan all descendant containers of this container THEN
        ///     LET list = Add descendant container
        /// RETURN list
        /// </algorithm>
        public IList<Container> GetDescendant()
        {
            List<Container> ret = new List<Container>();
            Stack<Container> containerStack = new Stack<Container>();

            containerStack.Push(this);
            // Get all childs of container.
            while (Constant.INT_ZERO < containerStack.Count)
            {
                Container con = containerStack.Pop();

                ret.Add(con);

                foreach (Container subContainer in con.Childs)
                {
                    containerStack.Push(subContainer);
                }
            } // End of while (0 < containerStack.Count).

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_046_013

        /// <summary>
        /// Compare 2 containers by their def names and short names
        /// </summary>
        /// <param name="container1">Container 1 <range>null/valid Container</range></param>
        /// <param name="container2">Container 2 <range>null/valid Container</range></param>
        /// <returns>
        ///     <para>int
        ///         <desc>Status of checking</desc>
        ///         <range>0/1</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// IF both are null THEN
        ///     RETURN 0
        /// ELSE IF container1 is null && container2 NOT null THEN
        ///     RETURN -1
        /// ELSE IF container1 NOT null && container2 is null THEN
        ///     Return 1
        /// ELSE IF container1.DefinitionRef and container2.DefinitionRef NOT equal THEN
        ///     RETURN string comparision result of container1.ShortName and container2.ShortName
        /// ELSE
        ///     RETURN string comparision result of container1.DefinitionRef and container2.DefinitionRef
        /// </algorithm>
        public static int Compare(Container con1, Container con2)
        {
            // Compare two container by DefinitionRef and short name
            int ret = con1.DefinitionRef.CompareTo(con2.DefinitionRef);
            if (Constant.INT_ZERO == ret)
            {
                ret = StringUtils.CompareShortName(con1.ShortName, con2.ShortName);
            }
            else
            {
                // Different DefinitionRef
                ret = Constant.INT_ZERO;
            }

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_046_009

        /// <summary>
        /// Get direct children by def name
        /// </summary>
        /// <param name="defName">Def name <range>null/valid string</range></param>
        /// <param name="sortOption">Sort option <range>0/valid integer</range></param>
        /// <returns>
        ///     <para>IList<Container>
        ///         <desc>List of containers</desc>
        ///         <range>empty/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
		/// LET result = new List of Container object
		/// IF variantID is empty THEN
		///	  LET result = Scan all direct children of this container
		///   collect a list of children where their DefinitionRef end with "/" + defName
		/// ELSE
		///   LET result = Scan all direct children of this container
		///             collect a list of children where their DefinitionRef end with "/" + defName
		///	  Scan a list of children above based on the given condition and
		///				convert it to List
		/// IF sortOption equal to 1
        ///   LET Short list
		/// ELSE
        ///   Do nothing
        /// Return list
        /// </algorithm>
        public IList<Container> GetChildsByDefName(string defName, int sortOption = 0, string variantID = "")
        {
            List<Container> result = new List<Container>();

            if (string.Empty == variantID)
            {
                result = Childs.FindAll(x => x.DefinitionRef.EndsWith("/" + defName));
            }
            else
            {
                result = Childs.FindAll(x => x.DefinitionRef.EndsWith("/" + defName))
                         .Where(x => ((null == x.VariantID) || (variantID == x.VariantID)))
                         .ToList();
            }

            if (Constant.INT_ONE == sortOption)
            {
                result.Sort(Container.Compare);
            }
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_046_011

        /// <summary>
        /// Get a child by def name
        /// </summary>
        /// <param name="defName">Def name <range>null/valid string</range></param>
        /// <param name="sortOption">Sort option <range>0/valid integer</range></param>
        /// <returns>
        ///     <para>IList<Container>
        ///         <desc>List of containers</desc>
        ///         <range>empty/valid value</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// LET ret = Get a list of child by def name by calling method GetChildsByDefName
        /// IF not found THEN
        ///     RETURN null
        /// ELSE
        ///     RETURN first child
        /// </algorithm>
        public Container GetChildByDefName(string defName, int sortOption = 0, string variantID = "")
        {
            return GetChildsByDefName(defName, sortOption, variantID).FirstOrDefault();
        }
        // Implementation: GENERIC_TUD_CLS_046_012

    }
}
