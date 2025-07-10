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
    public void GenerateTest_101_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings91 = null;
            GenerationSettings genSettings = generationsettings91;
            String string102 = "STD_ON";
            typeof(CommentGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string102);
            /* Act */
            String actualResult = (String)typeof(CommentGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(GenerationSettings)}, null).Invoke(_target, new object[]{genSettings});
            /* Assert */
            Assert.AreEqual((String)"/* STD_ON */", (String)actualResult);
        }
    }

    [TestMethod]
    public void GenerateTest_101_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            GenerationSettings generationsettings91 = null;
            GenerationSettings genSettings = generationsettings91;
            String string102 = "";
            typeof(CommentGenerationItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string102);
            /* Act */
            String actualResult = (String)typeof(CommentGenerationItem).GetMethod("Generate", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(GenerationSettings) }, null).Invoke(_target, new object[] { genSettings });
            /* Assert */
            Assert.AreEqual((String)"/* */", (String)actualResult);
        }
    }
}