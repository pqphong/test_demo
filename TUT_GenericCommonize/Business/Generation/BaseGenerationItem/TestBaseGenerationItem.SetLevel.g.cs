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
    public void SetLevelTest_91_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 1;
            Int32 level = int3291;
            /* Act */
            typeof(BaseGenerationItem).GetMethod("SetLevel", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Int32)}, null).Invoke(_target, new object[]{level});
            /* Assert */
            Object level12 = typeof(BaseGenerationItem).GetProperty("Level", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Assert.AreEqual((Int32)1, (Int32)level12);
        }
    }
}