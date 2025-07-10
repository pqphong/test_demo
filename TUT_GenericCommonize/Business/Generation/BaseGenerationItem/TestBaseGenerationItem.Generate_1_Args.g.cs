using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.Settings;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestBaseGenerationItem
{
    [TestMethod]
    public void GenerateTest_88_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings genSettings = null;
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}