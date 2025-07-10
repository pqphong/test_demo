using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestStructGenerationItem
{
    [TestMethod]
    public void getQacMessageTest_77_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "2qac";
            String param = string91;
            Dictionary<String, Dictionary<String, String>> dictionary102 = new Dictionary<String, Dictionary<String, String>>();
            Dictionary<String, String> dictionary102_1qac = new Dictionary<string, string>()
            {{"00", "0"}};
            Dictionary<String, String> dictionary102_2qac = new Dictionary<string, string>()
            {{"01", "1"}};
            Dictionary<String, String> dictionary102_3qac = new Dictionary<string, string>()
            {{"02", "2"}};
            Dictionary<String, String> dictionary102_4qac = new Dictionary<string, string>()
            {{"03", "3"}};
            Dictionary<String, String> dictionary102_5qac = new Dictionary<string, string>()
            {{"04", "4"}};
            Dictionary<String, String> dictionary102_6qac = new Dictionary<string, string>()
            {{"05", "5"}};
            dictionary102["1qac"] = dictionary102_1qac;
            dictionary102["2qac"] = dictionary102_2qac;
            dictionary102["3qac"] = dictionary102_3qac;
            dictionary102["4qac"] = dictionary102_4qac;
            dictionary102["5qac"] = dictionary102_5qac;
            dictionary102["6qac"] = dictionary102_6qac;
            Dictionary<String, Dictionary<String, String>> qacMapping = dictionary102;
            /* Act */
            Dictionary<String, String> actualResult = (Dictionary<String, String>)typeof(StructGenerationItem).GetMethod("getQacMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(Dictionary<String, Dictionary<String, String>>)}, null).Invoke(_target, new object[]{param, qacMapping});
            /* Assert */
            Object actualResult_01_15 = ((Dictionary<String, String>)actualResult)["01"];
            Assert.AreEqual((String)"1", (String)actualResult_01_15);
        }
    }

    [TestMethod]
    public void getQacMessageTest_77_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "qac";
            String param = string93;
            Dictionary<String, Dictionary<String, String>> dictionary104 = new Dictionary<String, Dictionary<String, String>>();
            Dictionary<String, String> dictionary104_1qac = new Dictionary<string, string>()
            {{"00", "0"}};
            Dictionary<String, String> dictionary104_2qac = new Dictionary<string, string>()
            {{"01", "1"}};
            Dictionary<String, String> dictionary104_3qac = new Dictionary<string, string>()
            {{"02", "2"}};
            Dictionary<String, String> dictionary104_4qac = new Dictionary<string, string>()
            {{"03", "3"}};
            Dictionary<String, String> dictionary104_5qac = new Dictionary<string, string>()
            {{"04", "4"}};
            Dictionary<String, String> dictionary104_6qac = new Dictionary<string, string>()
            {{"05", "5"}};
            dictionary104["1qac"] = dictionary104_1qac;
            dictionary104["2qac"] = dictionary104_2qac;
            dictionary104["3qac"] = dictionary104_3qac;
            dictionary104["4qac"] = dictionary104_4qac;
            dictionary104["5qac"] = dictionary104_5qac;
            dictionary104["6qac"] = dictionary104_6qac;
            Dictionary<String, Dictionary<String, String>> qacMapping = dictionary104;
            /* Act */
            Dictionary<String, String> actualResult = (Dictionary<String, String>)typeof(StructGenerationItem).GetMethod("getQacMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(Dictionary<String, Dictionary<String, String>>)}, null).Invoke(_target, new object[]{param, qacMapping});
            /* Assert */
            Assert.AreEqual((Dictionary<String, String>)null, (Dictionary<String, String>)actualResult);
        }
    }
}