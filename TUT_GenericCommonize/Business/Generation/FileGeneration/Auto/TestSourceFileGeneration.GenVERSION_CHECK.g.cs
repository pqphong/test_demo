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
    public void GenVERSION_CHECKTest_154_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            /* Act */
            BaseGenerationItem[] actualResult = (BaseGenerationItem[])typeof(SourceFileGeneration).GetMethod("GenVERSION_CHECK", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((BaseGenerationItem[])null, (BaseGenerationItem[])actualResult);
        }
    }
}