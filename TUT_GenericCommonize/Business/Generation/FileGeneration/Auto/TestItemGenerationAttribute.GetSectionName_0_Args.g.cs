using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using static Renesas.Generator.MCALConfGen.Business.Generation.ItemGenerationAttribute;

public partial class TestItemGenerationAttribute
{
    [TestMethod]
    public void GetSectionNameTest_169_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            SectionName sectionname91 = SectionName.REVISION_HISTORY;
            typeof(ItemGenerationAttribute).GetProperty("Section", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, sectionname91);
            /* Act */
            String actualResult = (String)typeof(ItemGenerationAttribute).GetMethod("GetSectionName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((String)"Revision Control History", (String)actualResult);
        }
    }
}