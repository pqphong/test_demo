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
    public void SetLastItemTest_92_1()
    {
        using (ShimsContext.Create())
        {
            bool value = true;
            /* Arrange */
            /* Act */
            typeof(BaseGenerationItem).GetMethod("SetLastItem", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Boolean)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Object islast11 = typeof(BaseGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Assert.AreEqual((Boolean)true, (Boolean)islast11);
        }
    }

    [TestMethod]
    public void SetLastItemTest_92_2()
    {
        using (ShimsContext.Create())
        {
            bool value = false;
            /* Arrange */
            /* Act */
            typeof(BaseGenerationItem).GetMethod("SetLastItem", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(Boolean)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Object islast12 = typeof(BaseGenerationItem).GetField("IsLast", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Assert.AreEqual((Boolean)false, (Boolean)islast12);
        }
    }
}