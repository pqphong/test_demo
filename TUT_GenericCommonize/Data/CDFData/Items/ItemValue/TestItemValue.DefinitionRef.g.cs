using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestItemValue
{
    [TestMethod]
    public void DefinitionRefTest_123_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9311 = "/definitionRef";
            typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string9311);
            /* Act */
            String actualResult = (String)typeof(ItemValue).GetMethod("DefinitionRef", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"/definitionRef", (String)actualResult);
        }
    }
}