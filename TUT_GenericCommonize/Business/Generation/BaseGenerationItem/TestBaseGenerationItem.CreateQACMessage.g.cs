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
    public void CreateQACMessageTest_191_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary91 = new Dictionary<String, String>();
            String dictionary91_0791 = "JV-01";
            dictionary91["0791"] = dictionary91_0791;
            Dictionary<String, String> qacData = dictionary91;
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("CreateQACMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{qacData});
            /* Assert */
            Assert.AreEqual((String)"/* PRQA S 0791 # JV-01 */", (String)actualResult);
        }
    }

    [TestMethod]
    public void CreateQACMessageTest_191_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, String> dictionary92 = null;
            Dictionary<String, String> qacData = dictionary92;
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("CreateQACMessage", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{qacData});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}