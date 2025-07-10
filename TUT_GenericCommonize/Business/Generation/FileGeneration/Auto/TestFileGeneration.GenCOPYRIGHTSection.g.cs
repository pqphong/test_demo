using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestFileGeneration
{
    [TestMethod]
    public void GenCOPYRIGHTSectionTest_143_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            /* Act */
            BaseGenerationItem[] actualResult = (BaseGenerationItem[])typeof(FileGeneration).GetMethod("GenCOPYRIGHTSection", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_length_11 = typeof(BaseGenerationItem[]).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_length_11);
            Object actualResult_0_12 = ((BaseGenerationItem[])actualResult)[0];
            Object actualResult_0_12_value_23 = typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_12);
            Assert.IsTrue(actualResult_0_12_value_23.ToString().Contains("COPYRIGHT"));
        }
    }
}