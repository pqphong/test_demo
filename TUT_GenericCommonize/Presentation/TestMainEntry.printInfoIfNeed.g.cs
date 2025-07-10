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
    public void printInfoIfNeedTest_7_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            Int32 flag = int3291;
            Renesas.Generator.MCALConfGen.Business.CommandLine.Fakes.ShimCommandLine.AllInstances.PrintToolInfo = (CommandLine instance) =>
            {
                flag = 1;
                ;
            }

            ;
            /* Act */
            typeof(MainEntry).GetMethod("printInfoIfNeed", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }
}