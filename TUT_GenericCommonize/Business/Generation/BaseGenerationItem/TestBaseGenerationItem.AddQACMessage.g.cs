using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestBaseGenerationItem
{
    [TestMethod]
    public void AddQACMessage_192_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "#define ICU_E_INT_INCONSISTENT                                                 \r\n                                                                             DemConf_DemEventParameter_DemEventParameter";
            String wrappedText = string91;
            String string102 = "ICU_E_INT_INCONSISTENT";
            String type = string102;
            String string113 = "DemConf_DemEventParameter_DemEventParameter";
            String name = string113;
            Dictionary<String, String> dictionary124 = null;
            Dictionary<String, String> qacData = dictionary124;
            String string135 = " \\"; 
            String delimiter = string135;  
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("AddQACMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(Dictionary<String, String>), typeof(String)}, null).Invoke(_target, new object[]{wrappedText, type, name, qacData, delimiter});
            /* Assert */
            Assert.AreEqual((String)"#define ICU_E_INT_INCONSISTENT                                                  \\\r\n                                                                             DemConf_DemEventParameter_DemEventParameter", (String)actualResult);
        }
    }

    [TestMethod]
    public void AddQACMessage_192_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = "";
            String wrappedText = string96;
            String string107 = "ICU_E_INT_INCONSISTENT";
            String type = string107;
            String string118 = "DemConf_DemEventParameter_DemEventParameter";
            String name = string118;
            Dictionary<String, String> dictionary129 = new Dictionary<string, string>()
                                                    {{"0303", "JV-01"}, {"3432", "JV-01"}};
            Dictionary<String, String> qacData = dictionary129;
            String string1310 = " \\"; 
            String delimiter = string1310;  
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("AddQACMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(Dictionary<String, String>), typeof(String)}, null).Invoke(_target, new object[]{wrappedText, type, name, qacData, delimiter});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void AddQACMessage_192_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = "#define ICU_E_INT_INCONSISTENT                                                 \r\n                                                                             DemConf_DemEventParameter_DemEventParameter";
            String wrappedText = string911;
            String string1012 = "ICU_E_INT_INCONSISTENT";
            String type = string1012;
            String string1113 = "DemConf_DemEventParameter_DemEventParameter";
            String name = string1113;
            Dictionary<String, String> dictionary1214 = new Dictionary<string, string>()
            {{"0303", "JV-01"}, {"3432", "JV-01"}};
            Dictionary<String, String> qacData = dictionary1214;
            String string1315 = " \\"; 
            String delimiter = string1315; 
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("AddQACMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(Dictionary<String, String>), typeof(String)}, null).Invoke(_target, new object[]{wrappedText, type, name, qacData, delimiter});
            /* Assert */
            Assert.AreEqual((String)"#define ICU_E_INT_INCONSISTENT                                                                                          /* PRQA S 0303 # JV-01 */ \\\r\n                                                                             DemConf_DemEventParameter_DemEventParameter /* PRQA S 3432 # JV-01 */", (String)actualResult);
        }
    }

    [TestMethod]
    public void AddQACMessage_192_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string916 = "#define ICU_E_INT_INCONSISTENT                                                 \r\n                                                                             DemConf_DemEventParameter_DemEventParameter";
            String wrappedText = string916;
            String string1017 = "ICU_E_INT_INCONSISTENT";
            String type = string1017;
            String string1118 = "DemConf_DemEventParameter_DemEventParameter";
            String name = string1118;
            Dictionary<String, String> dictionary1219 = new Dictionary<string, string>()
            {{"0303", "JV-01"}, {"0315", "JV-01"}};
            Dictionary<String, String> qacData = dictionary1219;
            String string1320 = " \\"; 
            String delimiter = string1320;  
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("AddQACMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(Dictionary<String, String>), typeof(String)}, null).Invoke(_target, new object[]{wrappedText, type, name, qacData, delimiter});
            /* Assert */
            Assert.AreEqual((String)"#define ICU_E_INT_INCONSISTENT                                                                                          /* PRQA S 0303, 0315 # JV-01, JV-01 */ \\\r\n                                                                             DemConf_DemEventParameter_DemEventParameter", (String)actualResult);
        }
    }

    [TestMethod]
    public void AddQACMessage_192_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string921 = "#define ICU_E_INT_INCONSISTENT                                                 \r\n                                                                             DemConf_DemEventParameter_DemEventParameter";
            String wrappedText = string921;
            String string1022 = "ICU_E_INT_INCONSISTENT";
            String type = string1022;
            String string1123 = "DemConf_DemEventParameter_DemEventParameter";
            String name = string1123;
            Dictionary<String, String> dictionary1224 = new Dictionary<string, string>()
            {{"1504", "JV-01"}, {"3432", "JV-01"}};
            Dictionary<String, String> qacData = dictionary1224;
            String string1325 = " \\"; 
            String delimiter = string1325;  
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("AddQACMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String), typeof(Dictionary<String, String>), typeof(String)}, null).Invoke(_target, new object[]{wrappedText, type, name, qacData, delimiter});
            /* Assert */
            Assert.AreEqual((String)"#define ICU_E_INT_INCONSISTENT                                                  \\\r\n                                                                             DemConf_DemEventParameter_DemEventParameter /* PRQA S 1504, 3432 # JV-01, JV-01 */", (String)actualResult);
        }
    }

    [TestMethod]
    public void AddQACMessage_192_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string921 = "#define ICU_E_INT_INCONSISTENT                                                 \r\n                                                                             DemConf_DemEventParameter_DemEventParameter";
            String wrappedText = string921;
            String string1022 = string.Empty;
            String type = string1022;
            String string1123 = string.Empty;
            String name = string1123;
            Dictionary<String, String> dictionary1224 = new Dictionary<string, string>()
            {{"1504", "JV-01"}, {"3432", "JV-01"}};
            Dictionary<String, String> qacData = dictionary1224;
            String string1325 = " \\";
            String delimiter = string1325;
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("AddQACMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(String), typeof(String), typeof(Dictionary<String, String>), typeof(String) }, null).Invoke(_target, new object[] { wrappedText, type, name, qacData, delimiter });
            /* Assert */
            Assert.AreEqual((String)"#define ICU_E_INT_INCONSISTENT                                                  \\\r\n                                                                             DemConf_DemEventParameter_DemEventParameter /* PRQA S 1504, 3432 # JV-01, JV-01 */", (String)actualResult);
        }
    }
}