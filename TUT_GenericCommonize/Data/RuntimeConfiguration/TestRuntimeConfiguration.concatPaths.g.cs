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
    public void concatPathsTest_127_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String[] string91 = new String[2];
            String string91_0 = "lin/Output";
            String string91_1 = "include\\";
            string91[0] = string91_0;
            string91[1] = string91_1;
            String[] paths = string91;
            /* Act */
            String actualResult = (String)typeof(RuntimeConfiguration).GetMethod("concatPaths", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String[])}, null).Invoke(_target, new object[]{paths});
            /* Assert */
            Assert.AreEqual((String)"lin\\Output\\include\\", (String)actualResult);
        }
    }

    [TestMethod]
    public void concatPathsTest_127_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String[] string92 = new String[2];
            String string92_0 = "lin/Output/";
            String string92_1 = "\\include\\";
            string92[0] = string92_0;
            string92[1] = string92_1;
            String[] paths = string92;
            /* Act */
            String actualResult = (String)typeof(RuntimeConfiguration).GetMethod("concatPaths", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String[])}, null).Invoke(_target, new object[]{paths});
            /* Assert */
            Assert.AreEqual((String)@"lin\Output\include\", (String)actualResult);
        }
    }
}