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
    public void GetSectionNameTest_170_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            SectionName sectionname91 = SectionName.REVISION_HISTORY;
            String actualResult = (String)typeof(ItemGenerationAttribute).GetMethod("GetSectionName", BindingFlags.Instance | BindingFlags.Public|BindingFlags.Static, null, new Type[]{typeof(SectionName) }, null).Invoke(_target, new object[]{ sectionname91 });
            /* Assert */
            Assert.AreEqual((String)"Revision Control History", (String)actualResult);
        }
    }
}