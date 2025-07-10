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
    public void GenEND_OF_FILETest_148_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            /* Act */
            BaseGenerationItem[] actualResult = (BaseGenerationItem[])typeof(FileGeneration).GetMethod("GenEND_OF_FILE", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((BaseGenerationItem[])null, (BaseGenerationItem[])actualResult);
        }
    }
}