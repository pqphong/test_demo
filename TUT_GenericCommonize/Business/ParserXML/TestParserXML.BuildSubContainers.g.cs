using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using System.Xml.Linq;

public partial class TestParserXML
{
    [TestMethod]
    public void BuildSubContainersTest_23_1()
    {
        using (ShimsContext.Create())
        {
            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement root1 = new XElement("ECUC-CONTAINER-VALUE");
            root1.Add(new XAttribute("UUID", "91fbb526-baea-48c4-8e23-27af55c8a9ba"));
            XElement shortName = new XElement("SHORT-NAME", "LinGeneral");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral");
            XElement parameterValues = new XElement("PARAMETER-VALUES");
            root1.Add(shortName);
            root1.Add(defRef);
            root1.Add(parameterValues);
            XElement item1 = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            item1.Add(new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGeneral/LinVersionCheckExternalModules"));
            item1.Add(new XElement("VALUE", "true"));
            XElement sub_containers = new XElement("SUB-CONTAINERS");
            XElement root2 = new XElement("ECUC-CONTAINER-VALUE");
            root2.Add(new XAttribute("UUID", "582bd618-c5f5-42b3-8dd7-5efbcfa8295e"));
            root2.Add(new XElement("SHORT-NAME", "LinChannel_002"));
            root2.Add(new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin/LinGlobalConfig/LinChannel"));
            root1.Add(sub_containers);
            root1.Add(root2);
            module.Add(root1);
            module.Add(root2);
            /* Arrange */
            Container container91 = new Container();
            Container container = container91;
   
            Stack<XElement> stack113 = new Stack<XElement>();
            Stack<XElement> stack = stack113;
            /* Act */
            typeof(ParserXML).GetMethod("BuildSubContainers", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Stack<XElement>).MakeByRefType(), typeof(Container), typeof(XElement)}, null).Invoke(_target, new object[]{stack, container, module});
            /* Assert */
            Assert.AreEqual(2, stack.Count);
        }
    }
}