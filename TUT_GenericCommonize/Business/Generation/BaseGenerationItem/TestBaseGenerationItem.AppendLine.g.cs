using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;
using System.Text;

public partial class TestBaseGenerationItem
{
    [TestMethod]
    public void AppendLineTest_89_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            StringBuilder stringbuilder91 = new StringBuilder();
            StringBuilder builder = stringbuilder91;
            String string102 = "";
            String indent = string102;
            String[] string113 = new String[2];
            String string113_0 = "comment 1";
            String string113_1 = "comment 2";
            string113[0] = string113_0;
            string113[1] = string113_1;
            String[] comments = string113;
            /* Act */
            typeof(BaseGenerationItem).GetMethod("AppendLine", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(StringBuilder), typeof(String), typeof(String[])}, null).Invoke(_target, new object[]{builder, indent, comments});
            /* Assert */
            Assert.IsTrue(builder.ToString().Contains("comment 1"));
            Assert.IsTrue(builder.ToString().Contains("comment 2"));
        }
    }
}