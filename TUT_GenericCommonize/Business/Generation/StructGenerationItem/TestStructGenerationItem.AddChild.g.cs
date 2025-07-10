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
    public void AddChildTest_83_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseGenerationItem basegenerationitem91 = new BaseGenerationItem(null, null, null, null, null, null, 0, false, false);
            BaseGenerationItem child = basegenerationitem91;
            /* Act */
            typeof(StructGenerationItem).GetMethod("AddChild", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(BaseGenerationItem)}, null).Invoke(_target, new object[]{child});
            /* Assert */
            Object children12 = typeof(StructGenerationItem).GetField("children", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object children12_count_13 = typeof(List<BaseGenerationItem>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(children12);
            Assert.AreEqual((Int32)1, (Int32)children12_count_13);
        }
    }
}