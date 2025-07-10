using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;

public partial class TestStringUtils
{
    [TestMethod]
    public void GetStringFromTemplateTest_38_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "$$val:10:L$$";
            String inputString = string91;
            Dictionary<String, String> dictionary102 = new Dictionary<String, String>();
            String dictionary102_1 = "output";
            dictionary102["val"] = dictionary102_1;
            Dictionary<String, String> dictionary = dictionary102;
            
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetStringFromTemplate", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{inputString, dictionary});
            /* Assert */
            Assert.AreEqual((String)"output    ", (String)actualResult);
        }
    }
}