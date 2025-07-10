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
    public void addCommentFormatTest_86_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "this is comment";
            String comment = string91;
            /* Act */
            String[] actualResult = (String[])typeof(BaseGenerationItem).GetMethod("addCommentFormat", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{comment});
            /* Assert */
            Object actualResult_0_13 = ((String[])actualResult)[0];
            Assert.AreEqual((String)"/* this is comment */", (String)actualResult_0_13);
        }
    }

    [TestMethod]
    public void addCommentFormatTest_86_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "";
            String comment = string92;
            /* Act */
            String[] actualResult = (String[])typeof(BaseGenerationItem).GetMethod("addCommentFormat", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{comment});
            /* Assert */
            Object actualResult_0_14 = ((String[])actualResult)[0];
            Assert.AreEqual((String)"", (String)actualResult_0_14);
        }
    }
}