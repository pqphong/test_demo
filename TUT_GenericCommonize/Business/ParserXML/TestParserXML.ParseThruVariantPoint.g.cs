using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using System.Xml.Linq;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestParserXML
{
    [TestMethod]
    public void ParseThruVariantPointTest_197_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement variant = new XElement("VARIATION-POINT");
            XElement var1 = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement var2 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement varval2 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            varval2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement varval3 = new XElement("VALUE", "0");
            var2.Add(varval2);
            var2.Add(varval3);
            var1.Add(var2);
            variant.Add(var1);

            /* Act */
            string actualResult = (string)typeof(ParserXML).GetMethod("ParseThruVariantPoint", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] {typeof(XElement) }, null).Invoke(_target, new object[] { variant });
            /* Assert */
            Assert.AreEqual(actualResult, "0");
        }
    }

    [TestMethod]
    public void ParseThruVariantPointTest_197_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement variant = new XElement("VARIATION-POINT");
            XElement var1 = new XElement("POST-BUILD-VARIANT-CONDITIONS");
            XElement var2 = new XElement("POST-BUILD-VARIANT-CONDITIONNN");
            XElement varval2 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            varval2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement varval3 = new XElement("VALUE", "0");
            var2.Add(varval2);
            var2.Add(varval3);
            var1.Add(var2);
            variant.Add(var1);

            /* Act */
            string actualResult = (string)typeof(ParserXML).GetMethod("ParseThruVariantPoint", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement) }, null).Invoke(_target, new object[] { variant });
            /* Assert */
            Assert.AreEqual(actualResult, string.Empty);
        }
    }
}