using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestRuntimeConfiguration
{
    [TestMethod]
    public void overrideFilesTest_131_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list91 = new List<String>();
            List<String> filePaths = list91;
            typeof(RuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, "");
            /* Act */
            typeof(RuntimeConfiguration).GetMethod("overrideFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(List<String>)}, null).Invoke(_target, new object[]{filePaths});
            /* Assert */
            Object translationfilepath14 = typeof(RuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(_target);
            Assert.AreEqual((String)"", (String)translationfilepath14);
        }
    }

    [TestMethod]
    public void overrideFilesTest_131_2()
    {
        using (ShimsContext.Create())
        {
            typeof(RuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, "");
            /* Arrange */
            List<String> list92 = null;
            List<String> filePaths = list92;
            /* Act */
            typeof(RuntimeConfiguration).GetMethod("overrideFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(List<String>)}, null).Invoke(_target, new object[]{filePaths});
            /* Assert */
            Object translationfilepath15 = typeof(RuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(_target);
            Assert.AreEqual((String)"", (String)translationfilepath15);
        }
    }

    [TestMethod]
    public void overrideFilesTest_131_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list93 = new List<String>();
            String list93_0 = "can.arxml";
            String list93_1 = "can.trxml";
            list93.Add(list93_0);
            list93.Add(list93_1);
            List<String> filePaths = list93;
            /* Act */
            typeof(RuntimeConfiguration).GetMethod("overrideFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(List<String>)}, null).Invoke(_target, new object[]{filePaths});
            /* Assert */
            Object translationfilepath16 = typeof(RuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(_target);
            Assert.AreEqual((String)"can.trxml", (String)translationfilepath16);
        }
    }
}