using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestSourceFileGeneration
{
    [TestMethod]
    public void GenREVISION_HISTORYTest_153_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            /* Act */
            BaseGenerationItem[] actualResult = (BaseGenerationItem[])typeof(SourceFileGeneration).GetMethod("GenREVISION_HISTORY", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_length_11 = typeof(BaseGenerationItem[]).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            string result =  (string)typeof(BaseGenerationItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult[0]);
            Assert.AreEqual((Int32)1, (Int32)actualResult_length_11);
            Assert.AreEqual("", result);
        }
    }
}