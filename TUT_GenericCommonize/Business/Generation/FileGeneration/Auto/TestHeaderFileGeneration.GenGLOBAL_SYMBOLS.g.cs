using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestHeaderFileGeneration
{
    [TestMethod]
    public void GenGLOBAL_SYMBOLSTest_161_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            /* Act */
            BaseGenerationItem[] actualResult = (BaseGenerationItem[])typeof(HeaderFileGeneration).GetMethod("GenGLOBAL_SYMBOLS", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_0_11 = ((BaseGenerationItem[])actualResult)[0];
            Object actualResult_0_11_value_22 = typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(actualResult_0_11);
            Assert.AreEqual((String)"", (String)actualResult_0_11_value_22);
        }
    }
}