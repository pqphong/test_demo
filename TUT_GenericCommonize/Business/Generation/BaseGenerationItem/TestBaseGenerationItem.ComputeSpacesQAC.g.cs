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
    public void ComputeSpacesQACTest_190_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Line                                                                                                              Content";
            String value = string91;
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("ComputeSpacesQAC", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((String)" ", (String)actualResult);
        }
    }

    [TestMethod]
    public void ComputeSpacesQACTest_190_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "Line Content";
            String value = string93;
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("ComputeSpacesQAC", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((String)"                                                                                                            ", (String)actualResult);
        }
    }    
}