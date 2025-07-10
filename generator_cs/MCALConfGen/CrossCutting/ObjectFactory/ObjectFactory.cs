/*====================================================================================================================*/
/* Project      = RH850/X2x AR4 MCAL Development                                                                      */
/* Module       = ObjectFactory.cs                                                                                    */
/* Version      = 2.3.0                                                                                               */
/* Date         = 31/01/2025                                                                                          */
/*====================================================================================================================*/
/*                                  COPYRIGHT                                                                         */
/*====================================================================================================================*/
/* Copyright(c) 2019-2022 Renesas Electronics Corporation. All rights reserved.                                       */
/*====================================================================================================================*/
/* Purpose: This file contains ObjectFactory class which is used to bind an interface to concrete classes.            */
/*          Binding to which concrete classes depend on ObjectFactoryAttribute's fields of the classes.               */
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
/*              : class ObjectFactory                                                                                 */
/*              : class CacheObject                                                                                   */
/*                                                                                                                    */
/*====================================================================================================================*/
/*====================================================================================================================*/
/* Version History:                                                                                                   */
/* Version    Last modified   Description                                                                             */
/*====================================================================================================================*/
/* 1.0.0:     29/01/2019 :    Initial Version                                                                         */
/* 1.0.1:     29/01/2019 :    Fix all bug from E2x FCC2 branch #87842                                                 */
/*            21/02/2019 :    Handle ILC findings to improve GenTool #88604                                           */
/*            12/03/2019 :    Fix bug that is cloned from C1X - #91630 as follow:                                     */
/*                            Modify method getCacheObjectsOfInterface(),                                             */
/*                            parseOtherConditions() to remove unnecessary code.                                      */
/* 1.0.2:     07/02/2020 :    Fix gentool unit test issue #242611, #252486                                            */
/*                            Remove supported GTM feature as #242611                                                 */
/*            24/02/2020 :    Fix coverity issue                                                                      */
/* 1.1.0:     22/06/2020 :    No change code, only increase version.                                                  */
/* 1.2.0:     26/08/2020 :    Release                                                                                 */
/* 1.2.1:     05/05/2021 :    Change SupportedDevices to SupportedVariants, update RegisterAssemblyTypes method       */
/* 1.3.2:     23/02/2022 :    Update RegisterAssemblyTypes to use LoadFrom method                                     */
/* 2.2.0:     31/12/2024 :    Update SW Version for Ver22.02.00/Ver22.02.00.D Final Release                           */
/* 2.2.1:     31/12/2024 :    Update SW Version for Ver22.00.01 U2Ax Release                                          */
/* 2.3.0:     31/01/2025 :    Update SW Version for Ver22.00.06 U2Cx Release                                          */
/*====================================================================================================================*/
// Implementation: GENERIC_TUD_FST_001

using Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory
{
    /// <summary>
    /// This class which is used to bind an interface to concrete classes.
    /// Binding to which concrete classes depend on "ObjectFactoryAttribute's" fields of the classes.
    /// </summary>
    public class ObjectFactory
    {
        /// <summary>
        /// Gentool executable type
        /// </summary>
        private static HashSet<Type> gentoolExecutableTypes = null;
        // Implementation: GENERIC_TUD_CLS_035_006

        /// <summary>
        /// Types that are loaded from DLLs
        /// </summary>
        private static Dictionary<Type, List<Type>> registeredTypes = null;
        // Implementation: GENERIC_TUD_CLS_035_007

        /// <summary>
        /// A cache of initialized instances for interfaces
        /// </summary>
        private static Dictionary<Type, List<CacheObject>> cache = new Dictionary<Type, List<CacheObject>>();
        // Implementation: GENERIC_TUD_CLS_035_008

        /// <summary>
        /// Property of a string to store module name
        /// </summary>
        public static string ModuleName { get; set; } = "";
        // Implementation: GENERIC_TUD_CLS_035_001

        /// <summary>
        /// Property of list SupportedDevices
        /// </summary>
        public static Dictionary<string, List<string>> SupportedVariants { get; set; }
                                                                            = new Dictionary<string, List<string>>();
        // Implementation: GENERIC_TUD_CLS_035_002

        /// <summary>
        /// Property of a string to store module dll file name
        /// </summary>
        public static string ModuleDllName { get; set; } = "";
        // Implementation: GENERIC_TUD_CLS_035_003

        /// <summary>
        /// Property of a string to store module dll file product version
        /// </summary>
        public static string ModuleDllVersion { get; set; } = "";
        // Implementation: GENERIC_TUD_CLS_035_004

        /// <summary>
        /// Property of a list of selected dlls.
        /// </summary>
        public static List<string> SelectedDllPaths { get; set; } = new List<string>();
        // Implementation: GENERIC_TUD_CLS_035_005

        /// <summary>
        /// Object factory constructor
        /// </summary>
        /// <returns>
        ///     <para>Type
        ///         <desc>The type</desc>
        ///         <range>null/!=null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     registeredTypes, gentoolExecutableTypes
        ///
        /// GLOBAL VARIABLE OUT:
        ///     N/A
        ///
        /// PRECONDITION:
        ///     N/A
        ///
        /// ABNORMAL SCENARIO:
        ///     N/A
        /// LET registeredTypes = initialize new Dictionary WITH key is Type and value are list of Type
        /// LET gentoolExecutableTypes = initialize new HashSet of Type
        /// FOREACH assembly in all assembly MCALConfGen
        ///     LET types = list of the types defined in this assembly which has defined ObjectFactoryAttribute
        ///     FOREACH type in types
        ///         LET interfaceTypes = load all interface
        ///         FOREACH interfaceType in interfaceTypes
        ///             IF registeredTypes is not contain interfaceType
        ///                 LET value of interfaceType in dictionary registeredTypes = new list of type
        ///             LET registeredTypes[interfaceType].Add(type)
        ///         LET gentoolExecutableTypes.Add(type)
        ///
        /// End
        /// </algorithm>
        static ObjectFactory()
        {
            registeredTypes = new Dictionary<Type, List<Type>>();
            gentoolExecutableTypes = new HashSet<Type>();
            // Load all assembly MCALConfGen
            foreach (Assembly myAssembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type[] types = myAssembly.GetTypes()
                            .Where(t => Attribute.IsDefined(t, typeof(ObjectFactoryAttribute)))
                            .ToArray();
                // Load all interface, class in assembly and store in cache. It is re-used to find class implementation
                // and invoke method in class If need.
                foreach (Type type in types)
                {
                    Type[] interfaceTypes = type.GetInterfaces();

                    foreach (Type interfaceType in interfaceTypes)
                    {
                        if (false == registeredTypes.Keys.Contains(interfaceType))
                        {
                            registeredTypes[interfaceType] = new List<Type>();
                        }
                        else
                        {
                            // Not required
                        }

                        registeredTypes[interfaceType].Add(type);
                    } // End of foreach (var inf in interfaces).
                    gentoolExecutableTypes.Add(type);
                } // End of foreach (Type type in types).
            } // End of foreach (Assembly myAssembly in AppDomain.CurrentDomain.GetAssemblies()).
        }
        // Implementation: GENERIC_TUD_CLS_035_013

        /// <summary>
        /// Register all types from files specified by assemblyFilePaths
        /// </summary>
        /// <param name="assemblyFilePaths">Assembly file paths <range>null/list string</range></param>
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
        ///     registeredTypes
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
        /// FOREACH filePath in assemblyFilePaths
        ///     LET specificDLL = CALL LoadFrom WITH filePath and exit code = 2
        ///     IF specificDLL is not null
        ///         LET types = list of the types defined in this assembly which has defined ObjectFactoryAttribute
        ///         FOREACH type in types
        ///             LET interfaceTypes = load all interface
        ///             FOREACH interfaceType in interfaceTypes
        ///                 IF registeredTypes is not contain key interfaceType
        ///                      LET Store all interface
        /// FOREACH type in list key of registeredTypes
        ///     FOREACH type in types
        ///         LET attribute = type.GetCustomAttribute<ObjectFactoryAttribute>
        ///         IF attribute is not null and att.Device is not null and att.Device is not Equals '*'
        ///                                                                                 and att.Variant is not null
        ///             LET Store all devices name to dictionary SupportedVariant with key is att.Variant
        /// </algorithm>
        public static void RegisterAssemblyTypes(string[] assemblyFilePaths)
        {
            // Load all assembly based files input.
            foreach (string filePath in assemblyFilePaths)
            {
                Assembly specificDLL = ReflectionWrapper.LoadFrom(filePath, Constant.EXIT_DUE_INPUT_FILES_ERROR);
                if (specificDLL != null)
                {
                    // Load all interface, class in assembly and store in cache.
                    // It is re-used to find class implementation and invoke method in class If need.
                    Type[] types = specificDLL.GetTypes()
                            .Where(t => Attribute.IsDefined(t, typeof(ObjectFactoryAttribute)))
                            .ToArray();
                    foreach (Type type in types)
                    {
                        Type[] interfaceTypes = type.GetInterfaces();

                        foreach (Type interfaceType in interfaceTypes)
                        {
                            // Store all interface and implementations of interface
                            if (false == registeredTypes.Keys.Contains(interfaceType))
                            {
                                registeredTypes[interfaceType] = new List<Type>();
                            }
                            else
                            {
                                // Not required
                            }

                            registeredTypes[interfaceType].Add(type);
                        } // End of foreach (Type interfaceType in interfaceTypes).
                    } // End of foreach (Type type in types).
                }
                else
                {
                    // Not required
                }
            } // End of foreach (string filePath in assemblyFilePaths).

            // Scan and add for supported devices
            foreach (var types in registeredTypes.Values)
            {
                foreach (var type in types)
                {
                    var att = type.GetCustomAttribute<ObjectFactoryAttribute>();
                    if (null != att &&
                        !string.IsNullOrEmpty(att.Device) &&
                        Constant.DEVICE_NAME_ALL != att.Device &&
                        !string.IsNullOrEmpty(att.Variant))
                    {
                        // Store all devices on class that is used to compare with device in CDFs.
                        List<string> devices = att.Device.Split(',').Select(x => x.Trim())
                            .Where(x => !string.IsNullOrEmpty(x)).Distinct().ToList();

                        if (SupportedVariants.ContainsKey(att.Variant))
                        {
                            SupportedVariants[att.Variant].AddRange(
                                devices.Where(x => !SupportedVariants[att.Variant].Contains(x)));
                        }
                        else
                        {
                            SupportedVariants.Add(att.Variant, devices);
                        }
                    }
                    else
                    {
                        // Not required
                    }
                } // End of foreach (var types in registeredTypes.Values)
            }

        }
        // Implementation: GENERIC_TUD_CLS_035_012

        /// <summary>
        /// Get an instance object with interface is T
        /// </summary>
        /// <returns>
        ///     <para>T
        ///         <desc>Instance object with interface T</desc>
        ///         <range>Type of T object</range>
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
        /// LET CALL getCacheObjectsOfInterface to get all instance objects with interface is T
        /// IF found THEN
        ///     RETURN first object
        /// ELSE
        ///     Exit Gentool
        /// </algorithm>
        public static T GetInstance<T>() where T : class
        {
            // get all type of interface and return the first instance of type.
            T result = null;
            Type interfaceType = typeof(T);
            // All class apply singleton pattern, so they cannot create direct instance.
            // ObjectFactory created instance each class and stored in cache
            List<CacheObject> cacheObjects = getCacheObjectsOfInterface(interfaceType);
            // Get instance that was stored in cache.
            if ((null != cacheObjects) && (Constant.INT_ZERO < cacheObjects.Count))
            {
                result = (T)cacheObjects.First().Instance;
            }
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_035_010

        /// <summary>
        /// Get all instance objects with interface is T
        /// </summary>
        /// <returns>
        ///     <para>T[]
        ///         <desc>ALL Instance object with interface T</desc>
        ///         <range>Type of T objects</range>
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
        /// LET CALL getCacheObjectsOfInterface to get all instance objects with interface is T
        /// IF found THEN
        ///     RETURN first object
        /// ELSE
        ///     Exit Gentool
        /// </algorithm>
        public static T[] GetInstances<T>() where T : class
        {
            // get all type of interface and return the all instance of type.
            T[] result = null;
            Type interfaceType = typeof(T);
            // All class apply singleton pattern, so they cannot create direct instance.
            // ObjectFactory created instance each class and stored in cache
            List<CacheObject> cacheObjects = getCacheObjectsOfInterface(interfaceType);
            // Get array of instance that was stored in cache.
            if ((null != cacheObjects) && (Constant.INT_ZERO < cacheObjects.Count))
            {
                result = cacheObjects.Select(e => (T)e.Instance).ToArray();
            }
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_035_011


        /// <summary>
        /// Remove all instance in cache because it need to clear static data each completed instance
        /// in case multi-instance
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
        ///     cache
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
        /// IF cache is contain key type
        ///     LET remove type
        /// </algorithm>
        public static void ClearCache(Type type)
        {
            // Remove all instance in cache because it need to clear static data each completed instance
            // in case multi-instance
            if (cache.ContainsKey(type))
            {
                cache.Remove(type);
            }
            else
            {
                // No action required
            }
        }
        // Implementation: GENERIC_TUD_CLS_035_009


        /// <summary>
        /// Create object instance from a concrete type
        /// </summary>
        /// <param name="concreteType">Concrete type <range>Type of passed argument</range></param>
        /// <returns>
        ///     <para>Object
        ///         <desc>The object from a concrete type</desc>
        ///         <range>null/!null</range>
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
        /// LET ctor = CALL GetConstructor WITH Type.EmptyTy"Instance", BindingFlags.Public | BindingFlags.Static)pes
        /// LET getInstance = CALL GetField WITH "Instance", BindingFlags.Public | BindingFlags.Static
        /// IF ctor is not null
        ///     LET result = ctor.Invoke(null)
        /// ELSE IF getInstance is not null
        ///     result = getInstance.GetValue(null)
        /// RETURN result
        /// </algorithm>
        private static Object createInstance(Type concreteType)
        {
            Object result = null;
            ConstructorInfo ctor = concreteType.GetConstructor(Type.EmptyTypes);
            FieldInfo getInstance = concreteType.GetField("Instance", BindingFlags.Public | BindingFlags.Static);
            // If type has constructor no params, invoke constructor
            // else get instance variable of type.
            if (null != ctor)
            {
                result = ctor.Invoke(null);
            }
            else if (null != getInstance)
            {
                result = getInstance.GetValue(null);
            }
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_035_015

        /// <summary>
        /// Check type to meet Autosar and Device conditions
        /// </summary>
        /// <param name="concreteType">Concrete type <range>Type of passed argument</range></param>
        /// <returns>
        ///     <para>bool
        ///         <desc>The status when check Autosar and Device conditions</desc>
        ///         <range>true/false</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     gentoolExecutableTypes
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
        /// IF (AutoSarVersion == "*" or AutoSarVersion == basicConfig.AutoSARVersion) and
        ///    (Device == "*" or basicConfig.DeviceNames contain Device) THEN
        ///     RETURN true
        /// ELSE
        ///     RETURN false
        /// </algorithm>
        private static bool checkConditionType(Type concreteType)
        {
            ObjectFactoryAttribute attribute =
                (ObjectFactoryAttribute)concreteType.GetCustomAttribute(typeof(ObjectFactoryAttribute));
            bool result = true;
            // Don't support to use selectors (AutoSarVersion, Device and OtherConditions)
            // for types of GenTool executable
            if ((false == gentoolExecutableTypes.Contains(concreteType)) && (null != attribute))
            {
                IBasicConfiguration basicConfig = GetInstance<IBasicConfiguration>();
                if ((null != basicConfig) &&
                    ((Constant.AR_VERSION_ALL == attribute.AutoSarVersion) ||
                     ((false == String.IsNullOrEmpty(attribute.AutoSarVersion)) &&
                      (attribute.AutoSarVersion == basicConfig.AutoSARVersion))) &&
                    ((Constant.DEVICE_NAME_ALL == attribute.Device) ||
                     ((false == String.IsNullOrEmpty(attribute.Device) &&
                      (basicConfig.DeviceNames.Any(e => attribute.Device.Contains(e)))))))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }

                // Only consider module of gentool
                result &= (attribute.ModuleNames == "*" ||
                        attribute.ModuleNames.ToLower().Contains(ObjectFactory.ModuleName.ToLower()));

            } // End of if ((false == gentoolExecutableTypes.Contains(concreteType)) && (null != attribute)).
            else
            {
                // Not required
            }

            return result;
        }
        // Implementation: GENERIC_TUD_CLS_035_014

        /// <summary>
        /// Get cache object instance of specified interface
        /// </summary>
        /// <param name="interfaceType">Interface <range>Type of passed argument</range></param>
        /// <returns>
        ///     <para>List<CacheObject>
        ///         <desc>Cache object instance of specified interface</desc>
        ///         <range>null/!null</range>
        ///     </para>
        /// </returns>
        /// <generated_value>
        ///     None
        /// </generated_value>
        /// <algorithm>
        /// GLOBAL VARIABLE IN:
        ///     cache, registeredTypes
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
        /// LET cacheObjects = NULL
        /// IF key of cache contain interfaceType and cache[interfaceType].Count > 0
        ///     LET cacheObjects = cache[interfaceType]
        /// ELSE IF key of cache not contain interfaceType and key of registeredTypes contain interfaceType
        ///     LET concreteTypes = registeredTypes[interfaceType]
        ///     LET cacheObjects = initialize new List<CacheObject>
        ///     FOREACH type in concreteTypes (which has the interface in registeredTypes)
        ///         LET create a new instance and add to cache
        /// RETURN object instances from cache
        /// </algorithm>
        private static List<CacheObject> getCacheObjectsOfInterface(Type interfaceType)
        {
            List<CacheObject> cacheObjects = null;
            if (cache.ContainsKey(interfaceType) && (Constant.INT_ZERO < cache[interfaceType].Count))
            {
                cacheObjects = cache[interfaceType];
            }
            // Store instance into cache to lazy load
            else if (registeredTypes.ContainsKey(interfaceType))
            {
                List<Type> concreteTypes = registeredTypes[interfaceType];
                cacheObjects = new List<CacheObject>();
                foreach (Type type in concreteTypes.Where(x => checkConditionType(x)))
                {
                    cacheObjects.Add(new CacheObject(type, createInstance(type)));
                }
                // Sort classes of type according to version.
                cacheObjects.Sort(delegate (CacheObject type1, CacheObject type2)
                {
                    ObjectFactoryAttribute attribute1 =
                        (ObjectFactoryAttribute)type1.TypeOf.GetCustomAttribute(typeof(ObjectFactoryAttribute));
                    ObjectFactoryAttribute attribute2 =
                        (ObjectFactoryAttribute)type2.TypeOf.GetCustomAttribute(typeof(ObjectFactoryAttribute));
                    // Get class has newest version
                    return String.Compare(attribute2.Version, attribute1.Version);
                });
                cache[interfaceType] = cacheObjects;
            } // End of if ((false == cache.ContainsKey(interfaceType)) && registeredTypes.ContainsKey(interfaceType)).
            else
            {
                // Not required
            }
            return cacheObjects;
        }
        // Implementation: GENERIC_TUD_CLS_035_016

        /// <summary>
        /// Save instance of type to re-used (lazy loading)
        /// </summary>
        internal class CacheObject
        {
            /// <summary>
            /// Property of Instance object
            /// </summary>
            public Object Instance { get; set; } = null;
            // Implementation: GENERIC_TUD_CLS_036_001

            /// <summary>
            /// Property of TypeOf
            /// </summary>
            public Type TypeOf { get; set; } = null;
            // Implementation: GENERIC_TUD_CLS_036_002

            /// <summary>
            /// Cache object constructor
            /// </summary>
            /// <param name="typeOf">Type <range>None</range></param>
            /// <param name="intance">Object instance <range>None</range></param>
            /// <returns>
            ///     <para>
            ///     None
            ///     </para>
            /// </returns>
            /// <generated_value>
            ///     None
            /// </generated_value>
            /// <algorithm>
            /// This is constructor
            /// </algorithm>
            public CacheObject(Type typeOf, object instance = null)
            {
                Instance = instance;
                TypeOf = typeOf;
            }
            // Implementation: GENERIC_TUD_CLS_036_003
        }
    }
}
