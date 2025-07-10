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
    public void ParseContainerVariantItemValueTest_195_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement var2 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement varval2 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            varval2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement varval3 = new XElement("VALUE", "0");
            var2.Add(varval2);
            var2.Add(varval3);

            string criterion = "MATCHING-CRITERION-REF";
            string val = "VALUE";

            /* Act */
            string actualResult = (string)typeof(ParserXML).GetMethod("ParseContainerVariantItemValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] {typeof(XElement), typeof(string), typeof(string) }, null).Invoke(_target, new object[] { var2, criterion, val });
            /* Assert */
            Assert.AreEqual(actualResult, "0");
        }
    }

    [TestMethod]
    public void ParseContainerVariantItemValueTest_195_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement var2 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement varval2 = new XElement("MATCHING-CRITERION-REFF", "/VariantDefinition/Criterion/Criterion_1");
            varval2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement varval3 = new XElement("VALUE", "0");
            var2.Add(varval2);
            var2.Add(varval3);

            string criterion = "MATCHING-CRITERION-REF";
            string val = "VALUE";

            /* Act */
            string actualResult = (string)typeof(ParserXML).GetMethod("ParseContainerVariantItemValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement), typeof(string), typeof(string) }, null).Invoke(_target, new object[] { var2, criterion, val });
            /* Assert */
            Assert.AreEqual(actualResult, string.Empty);
        }
    }

    [TestMethod]
    public void ParseContainerVariantItemValueTest_195_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement var2 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement varval2 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            varval2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement varval3 = new XElement("VALUEE", "0");
            var2.Add(varval2);
            var2.Add(varval3);

            string criterion = "MATCHING-CRITERION-REF";
            string val = "VALUE";

            /* Act */
            string actualResult = (string)typeof(ParserXML).GetMethod("ParseContainerVariantItemValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement), typeof(string), typeof(string) }, null).Invoke(_target, new object[] { var2, criterion, val });
            /* Assert */
            Assert.AreEqual(actualResult, string.Empty);
        }
    }

    [TestMethod]
    public void ParseContainerVariantItemValueTest_195_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement var2 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement varval2 = new XElement("MATCHING-CRITERION-REF", "/VariantDefinition/Criterion/Criterion_1");
            varval2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement varval3 = new XElement("VALUE", "");
            var2.Add(varval2);
            var2.Add(varval3);

            string criterion = "MATCHING-CRITERION-REF";
            string val = "VALUE";

            /* Act */
            string actualResult = (string)typeof(ParserXML).GetMethod("ParseContainerVariantItemValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement), typeof(string), typeof(string) }, null).Invoke(_target, new object[] { var2, criterion, val });
            /* Assert */
            Assert.AreEqual(actualResult, string.Empty);
        }
    }

    [TestMethod]
    public void ParseContainerVariantItemValueTest_195_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement var2 = new XElement("POST-BUILD-VARIANT-CONDITION");
            XElement varval2 = new XElement("MATCHING-CRITERION-REF", "");
            varval2.Add(new XAttribute("DEST", "POST-BUILD-VARIANT-CRITERION"));
            XElement varval3 = new XElement("VALUE", "0");
            var2.Add(varval2);
            var2.Add(varval3);

            string criterion = "MATCHING-CRITERION-REF";
            string val = "VALUE";

            /* Act */
            string actualResult = (string)typeof(ParserXML).GetMethod("ParseContainerVariantItemValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement), typeof(string), typeof(string) }, null).Invoke(_target, new object[] { var2, criterion, val });
            /* Assert */
            Assert.AreEqual(actualResult, string.Empty);
        }
    }
}