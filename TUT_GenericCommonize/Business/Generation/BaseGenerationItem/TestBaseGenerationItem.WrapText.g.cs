using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestBaseGenerationItem
{
    [TestMethod]
    public void WrapTextTest_84_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "The name of the error notification function which shall be called with the ApiID and ErrorId when there is aaaaaa write-verify error. ";
            String inputString = string91;
            String string102 = "/*";
            String prefix = string102;
            String string113 = "*/";
            String suffix = string113;
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("WrapText", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{inputString, prefix, suffix});
            /* Assert */
            Assert.IsTrue(actualResult.Contains("The name of the error notification function which shall be called with the ApiID and ErrorId when there is a"));
            Assert.IsTrue(actualResult.Contains("write-verify error."));
        }
    }

    [TestMethod]
    public void WrapTextTest_84_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "Enables/Disables LIN_INTERRUPT_CONSISTENCY_CHECK";
            String inputString = string94;
            String string105 = "/*";
            String prefix = string105;
            String string116 = "*/";
            String suffix = string116;
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("WrapText", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{inputString, prefix, suffix});
            /* Assert */
            Assert.IsTrue(actualResult.Contains("Enables/Disables"));
        }
    }

    [TestMethod]
    public void WrapTextTest_84_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "The name of the error notification function which shall be called with the ApiID and ErrorId when there is aaaaaaaaaaa write-verify error. ";
            String inputString = string97;
            String string108 = "";
            String prefix = string108;
            String string119 = "";
            String suffix = string119;
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("WrapText", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{inputString, prefix, suffix});
            /* Assert */
            Assert.IsTrue(actualResult.Contains("The name of the error notification function which shall be called with"));
        }
    }
    [TestMethod]
    public void WrapTextTest_84_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "Enables/Disables LIN_INTERRUPT_CONSISTENCY_CHECK_ENABLED_DISABLED_CHECK_ENABLED_DISABLED STD_ON/STD_OFF STD_OFF STD_OFF STD_OFF STD_OFF";
            String inputString = string94;
            String string105 = "/*";
            String prefix = string105;
            String string116 = "*/";
            String suffix = string116;
            /* Act */
            String actualResult = (String)typeof(BaseGenerationItem).GetMethod("WrapText", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { inputString, prefix, suffix });
            /* Assert */
            Assert.IsTrue(actualResult.Contains("Enables/Disables"));
        }
    }



}