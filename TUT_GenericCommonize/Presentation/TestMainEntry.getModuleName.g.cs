using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Presentation.MainEntry;
using Renesas.Generator.MCALConfGen.Business.CommandLine;

public partial class TestMainEntry
{
    [TestMethod]
    public void getModuleNameTest_6_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.GetAndValidateModuleName = (CommandLine instance) =>
            {
                String string91 = "adc";
                return string91;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(MainEntry).GetMethod("getModuleName", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{ });
            /* Assert */
            Assert.AreEqual((String)"adc", (String)actualResult);
        }
    }
}