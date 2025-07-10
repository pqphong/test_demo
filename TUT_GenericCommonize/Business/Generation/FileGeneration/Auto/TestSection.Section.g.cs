using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;

public partial class TestSection
{
    [TestMethod]
    public void SectionTest_168_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Section sec = new Section("HISTORY", "REVISION");
            string title = (string) typeof(Section).GetField("title", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(sec);
            string body = (string) typeof(Section).GetField("body", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(sec);
            Assert.AreEqual("HISTORY",title);
            Assert.AreEqual("REVISION",body);

        }
    }

    [TestMethod]
    public void SectionTest_168_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Section sec = new Section("", "");
            string title = (string)typeof(Section).GetField("title", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(sec);
            string body = (string)typeof(Section).GetField("body", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(sec);
            Assert.AreEqual("", title);
            Assert.AreEqual("", body);
        }
    }
}