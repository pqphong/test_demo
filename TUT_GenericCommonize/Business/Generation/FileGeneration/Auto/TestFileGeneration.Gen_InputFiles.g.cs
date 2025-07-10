using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestFileGeneration
{
    [TestMethod]
    public void Gen_InputFilesTest_140_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<String> list91 = new List<String>();
            String list91_0 = "can.arxml";
            String list91_1 = "can_bswmdt.arxml";
            list91.Add(list91_0);
            list91.Add(list91_1);
            Object runtimeconfiguration14 = typeof(FileGeneration).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("CDFFilePaths", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration14, list91);
            String string102 = "can.trxml";
            Object runtimeconfiguration15 = typeof(FileGeneration).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IRuntimeConfiguration).GetProperty("TranslationFilePath", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(runtimeconfiguration15, string102);
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (String path, Nullable<Int32> exitCode) =>
            {
                String string113 = "D:\\can.arxml";
                return string113;
            }

            ;
            /* Act */
            BaseGenerationItem actualResult = (BaseGenerationItem)typeof(FileGeneration).GetMethod("Gen_InputFiles", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            string value = (string)typeof(BaseGenerationItem).GetProperty("Value", BindingFlags.NonPublic | BindingFlags.Instance
                ).GetValue(actualResult);
            Assert.IsTrue(value.Contains(@"INPUT FILE:    D:\can.arxml"));
        }
    }
}