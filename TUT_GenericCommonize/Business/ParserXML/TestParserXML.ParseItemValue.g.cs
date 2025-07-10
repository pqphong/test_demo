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
    public void ParseItemValueTest_13_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules");
            DEFINITION_REF.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            element.Add(DEFINITION_REF);
            XElement VALUE = new XElement("VALUE", "true");
            element.Add(VALUE);

            String string102 = "DEFINITION-REF";
            String definitionKey = string102;
            String string113 = "VALUE";
            String valueKey = string113;
            /* Act */
            ItemValue actualResult = (ItemValue)typeof(ParserXML).GetMethod("ParseItemValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(XElement), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{element, definitionKey, valueKey});
            /* Assert */
            Assert.AreNotEqual((ItemValue)null, (ItemValue)actualResult);
        }
    }

    [TestMethod]
    public void ParseItemValueTest_13_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement DEFINITION_REF = new XElement("DEFINITION-REF", "");
            DEFINITION_REF.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            element.Add(DEFINITION_REF);
            XElement VALUE = new XElement("VALUE", "");
            element.Add(VALUE);

            String string102 = "DEFINITION-REF";
            String definitionKey = string102;
            String string113 = "VALUE";
            String valueKey = string113;
            /* Act */
            ItemValue actualResult = (ItemValue)typeof(ParserXML).GetMethod("ParseItemValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { element, definitionKey, valueKey });
            /* Assert */
            Assert.AreEqual((ItemValue)null, (ItemValue)actualResult);
        }
    }

    [TestMethod]
    public void ParseItemValueTest_13_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement element = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement VALUE = new XElement("VALUE", "");
            element.Add(VALUE);

            String string102 = "DEFINITION-REF";
            String definitionKey = string102;
            String string113 = "VALUE";
            String valueKey = string113;
            /* Act */
            ItemValue actualResult = (ItemValue)typeof(ParserXML).GetMethod("ParseItemValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { element, definitionKey, valueKey });
            /* Assert */
            Assert.AreEqual((ItemValue)null, (ItemValue)actualResult);
        }
    }
}