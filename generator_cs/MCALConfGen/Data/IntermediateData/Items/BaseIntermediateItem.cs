/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = BaseIntermediateItem.cs                                                                             */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019, 2020 Renesas Electronics Corporation. All rights reserved.                                      */
/*====================================================================================================================*/
/* Purpose: This file contains BaseIntermediateItem class to store an intermediate data.                              */
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
/*              : class BaseIntermediateItem                                                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*                                                                                                                    */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renesas.Generator.MCALConfGen.Data.IntermediateData.Items
{
    /// <summary>
    /// This "BaseIntermediateItem" class to store an intermediate data.
    /// </summary>
    public class BaseIntermediateItem
    {
        /// <summary>
        /// Property of Name
        /// </summary>
        public string Name { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_051_001

        /// <summary>
        /// Property of Value
        /// </summary>
        public string Value { get; set; } = String.Empty;
        // Implementation: GENERIC_TUD_CLS_051_002

        /// <summary>
        /// Property of Childs
        /// </summary>
        public List<BaseIntermediateItem> Childs { get; set; } = new List<BaseIntermediateItem>();
        // Implementation: GENERIC_TUD_CLS_051_003

        /// <summary>
        /// Base intermediate item constructor
        /// </summary>
        /// <param name="name">Name <range>empty/valid string</range></param>
        /// <param name="value">Value <range>empty/valid string</range></param>
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
        public BaseIntermediateItem(string name, string value)
        {
            Name = name;
            Value = value;
        }
        // Implementation: GENERIC_TUD_CLS_051_005

        /// <summary>
        /// Base intermediate item constructor
        /// </summary>
        /// <param name="name">Name <range>empty/valid string</range></param>
        /// <param name="value">Value <range>empty/valid string</range></param>
        /// <param name="childs">Childs <range>null/valid List<baseIntermediateItem></range></param>
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
        public BaseIntermediateItem(string name, string value, List<BaseIntermediateItem> childs)
        {
            Name = name;
            Value = value;
            Childs = childs;
        }
        // Implementation: GENERIC_TUD_CLS_051_006

        /// <summary>
        /// Add child
        /// </summary>
        /// <param name="childs">Childs <range>null/valid List<baseIntermediateItem></range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Add child to a children list
        /// </algorithm>
        public void AddChild(BaseIntermediateItem child)
        {
            Childs.Add(child);
        }
        // Implementation: GENERIC_TUD_CLS_051_004

        /// <summary>
        /// To string method
        /// </summary>
        /// <returns>
        ///     <para>string
        ///         <desc>The output string</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Return a string with following information
        /// - Current node: Name, Value and Childs.Count
        /// - All child nodes: Name, Value and inner Childs.Count
        /// </algorithm>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine
            (
                String.Format("[Name = {0}, Value = {1}, Childs.Count = {2}]", Name, Value, Childs.Count)
            );

            foreach (var child in Childs)
            {
                stringBuilder.AppendLine("  " + child.ToString());
            }

            return stringBuilder.ToString();
        }
        // Implementation: GENERIC_TUD_CLS_051_010

        /// <summary>
        /// Get string data by path
        /// </summary>
        /// <param name="path">Path <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>string
        ///         <desc>The output string</desc>
        ///         <range>empty/valid string</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Get BaseIntermediateItem by path by calling method GetItemByPath
        /// If BaseIntermediateItem is NOT null
        ///     Return BaseIntermediateItem.Value
        /// Else
        ///     Return empty
        /// </algorithm>
        public string GetStringDataByPath(string path)
        {
            BaseIntermediateItem item = GetItemByPath(path);

            return (null == item) ? String.Empty : item.Value;
        }
        // Implementation: GENERIC_TUD_CLS_051_008

        /// <summary>
        /// Get item by path
        /// </summary>
        /// <param name="path">Path <range>empty/valid string</range></param>
        /// <returns>
        ///     <para>baseIntermediateItem
        ///         <desc>intermediate data</desc>
        ///         <range>null/valid baseIntermediateItem</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Path has format of multiple segments "/Segment/Segment/Segment"
        /// Tracing path by comparing BaseIntermediateItem.Name with each path segment
        /// If found a BaseIntermediateItem
        ///     Return the item
        /// Else
        ///     Return null
        /// /// </algorithm>
        public BaseIntermediateItem GetItemByPath(string path)
        {
            BaseIntermediateItem ret = this;
            // Find child of one node based on path. Ex. root/parent/child1/child2
            foreach (string node in path.Split('/').Where(x => false == String.IsNullOrEmpty(x)))
            {
                ret = ret.Childs.Find(x => x.Name == node);

                if (null == ret)
                {
                    break;
                }
                else
                {
                    // Not required
                }
            } // End of foreach (string node in path.Split('/').Where(x => false == String.IsNullOrEmpty(x))).

            return ret;
        }
        // Implementation: GENERIC_TUD_CLS_051_007

        /// <summary>
        /// Store a valid baseIntermediateItem
        /// </summary>
        /// <param name="path">Path <range>empty/valid string</range></param>
        /// <param name="target">Target <range>null/valid baseIntermediateItem</range></param>
        /// <returns>
        ///     <para>
        ///     None
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// Path has format of multiple segments "/Segment/Segment/Segment"
        /// From current BaseIntermediateItem (this), tracing the path to find a farthest BaseIntermediateItem.
        /// Farthest BaseIntermediateItem can be
        /// - A last segment or
        /// - An intermediate segment where there are NO corresponding BaseIntermediateItems for remaining segments
        ///
        /// Add target BaseIntermediateItem into the farthest BaseIntermediateItem.
        /// </algorithm>
        public void Store(string path, BaseIntermediateItem target)
        {
            // Value will be store as tree structure. Node of tree is determined by path as root/parent/child
            if (null != target)
            {
                BaseIntermediateItem ret = this;
                // Loop via each node in path and find childs of node.
                // Stop when node has not child, target will be added as child of node.
                foreach (string node in path.Split('/').Where(x => false == String.IsNullOrEmpty(x)))
                {

                    BaseIntermediateItem item = ret.Childs.Find(x => x.Name == node);

                    if (null != item)
                    {
                        ret = item;
                    }
                    else
                    {
                        // last node in path, store data here
                        break;
                    }
                } // End of foreach (string node in path.Split('/').Where(x => false == String.IsNullOrEmpty(x))).

                ret.AddChild(target);
            } // End of if (null != value).
            else
            {
                // Not required
            }
        }
        // Implementation: GENERIC_TUD_CLS_051_009
    }
}
