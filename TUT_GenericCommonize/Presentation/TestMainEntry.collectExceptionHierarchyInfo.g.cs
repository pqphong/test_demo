using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Presentation.MainEntry;

public partial class TestMainEntry
{
    [TestMethod]
    public void collectExceptionHierarchyInfoTest_5_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Exception exception91 = null;
            Exception e = exception91;
            /* Act */
            String actualResult = (String)typeof(MainEntry).GetMethod("collectExceptionHierarchyInfo", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(Exception)}, null).Invoke(_target, new object[]{e});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void collectExceptionHierarchyInfoTest_5_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Exception exception92 = new NullReferenceException();
            Exception e = exception92;
            /* Act */
            String actualResult = (String)typeof(MainEntry).GetMethod("collectExceptionHierarchyInfo", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(Exception)}, null).Invoke(_target, new object[]{e});
            /* Assert */
            Assert.IsTrue(actualResult.ToString().Contains("--"));
            Assert.IsTrue(actualResult.ToString().Contains("Object reference not set to an instance of an object."));
        }
    }
}