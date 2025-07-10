using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using Renesas.Generator.MCALConfGen.Business.Generation.Settings;

public partial class TestCommentGenerationItem
{
    [TestMethod]
    public void CommentGenerationItemTest_100_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            string text = "";

            CommentGenerationItem commentGenerationItem = new CommentGenerationItem(text);


            string value = (string) typeof(CommentGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(commentGenerationItem);
            Assert.AreEqual((String)"", (String)value);
        }
    }

    [TestMethod]
    public void CommentGenerationItemTest_100_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            string text = "/* this is comment */";

            CommentGenerationItem commentGenerationItem = new CommentGenerationItem(text);


            string value = (string)typeof(CommentGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(commentGenerationItem);
            Assert.AreEqual((String)" this is comment ", (String)value);
        }
    }
}