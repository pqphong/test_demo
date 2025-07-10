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
    public void ConvertToContainerTest_9_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement con1 = new XElement("ECUC-CONTAINER-VALUE");
            con1.Add(new XAttribute("UUID", "7614f670-7ac9-45ee-a4db-614e1dec1f13"));
            XElement shortName1 = new XElement("SHORT-NAME", "LinGeneral");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral");
            XElement param1 = new XElement("PARAMETER-VALUES");
            XElement p1 = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defref1 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules");
            defref1.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            p1.Add(defref1);
            p1.Add(new XElement("VALUE", "true"));
            param1.Add(p1);
            con1.Add(shortName1);
            con1.Add(defRef);

            


            /* Act */
            Container actualResult = (Container)typeof(ParserXML).GetMethod("ConvertToContainer", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(XElement)}, null).Invoke(_target, new object[]{con1});
            /* Assert */
            Assert.AreEqual(actualResult.ShortName, "LinGeneral");
            Assert.AreEqual(actualResult.DefinitionRef, "/Renesas/EcucDefs_Lin/Lin/LinGeneral");
            Assert.AreEqual(actualResult.ParameterValues.Count,0);
            Assert.AreEqual(actualResult.ReferenceValues.Count,0);

        }
    }

    [TestMethod]
    public void ConvertToContainerTest_9_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement con1 = new XElement("ECUC-CONTAINER-VALUE");
            XElement shortName1 = new XElement("SHORT-NAME", "LinGeneral");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral");
            XElement param1 = new XElement("PARAMETER-VALUES");
            XElement p1 = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            XElement defref1 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules");
            defref1.Add(new XAttribute("DEST", "ECUC-BOOLEAN-PARAM-DEF"));
            p1.Add(defref1);
            p1.Add(new XElement("VALUE", "true"));
            param1.Add(p1);
            con1.Add(shortName1);
            con1.Add(defRef);
            con1.Add(param1);

            XElement ref1 = new XElement("REFERENCE-VALUES");
            XElement r1 = new XElement("ECUC-REFERENCE-VALUE");
            XElement refdef2 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinDemEventParameterRefs/LIN_E_TIMEOUT");
            refdef2.Add(new XAttribute("DEST", "ECUC-SYMBOLIC-NAME-REFERENCE-DEF"));

            r1.Add(refdef2);
            r1.Add(new XElement("VALUE-REF", "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter"));
            ref1.Add(r1);

            con1.Add(ref1);

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
            con1.Add(variant);


            /* Act */
            Container actualResult = (Container)typeof(ParserXML).GetMethod("ConvertToContainer", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XElement) }, null).Invoke(_target, new object[] { con1 });
            /* Assert */
            Assert.AreEqual(actualResult.ShortName, "LinGeneral");
            Assert.AreEqual(actualResult.DefinitionRef, "/Renesas/EcucDefs_Lin/Lin/LinGeneral");
            Assert.AreEqual(actualResult.ParameterValues.Count, 1);
            Assert.AreEqual(actualResult.ReferenceValues.Count, 1);
            Assert.AreEqual(actualResult.VariantID, "0");
        }
    }
}