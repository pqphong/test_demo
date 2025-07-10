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
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;

public partial class TestParserXML
{
    [TestMethod]
    public void BuildAndSaveContainerTreeTest_10_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement root = new XElement("CONTAINERS");
            XElement root1 = new XElement("ECUC-CONTAINER-VALUE");
            root1.Add(new XAttribute("UUID", "11111111111111111111"));
            XElement shortName = new XElement("SHORT-NAME", "FlsGeneral");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Fls/Fls/LinGeneral");
            XElement parameterValues = new XElement("PARAMETER-VALUES");
            root1.Add(shortName);
            root1.Add(defRef);
            root1.Add(parameterValues);
            XElement item1 = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            item1.Add(new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Fls/Fls/LinGeneral/FlsVersionCheckExternalModules"));
            item1.Add(new XElement("VALUE", "true"));
            XElement sub_containers = new XElement("SUB-CONTAINERS");
            XElement root2 = new XElement("ECUC-CONTAINER-VALUE");
            root2.Add(new XAttribute("UUID", "222222222222222222222222222222"));
            root2.Add(new XElement("SHORT-NAME", "FlsChannel_002"));
            root2.Add(new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Fls/Fls/FlsGlobalConfig/FlsChannel"));
            sub_containers.Add(root2);

            root1.Add(sub_containers);
            root1.Add(root2);
            root.Add(root1);
            root.Add(root2);
            module.Add(root);
            Configuration configuration113 = new Configuration();
            String configuration113_ShortName = "Fls0";
            String configuration113_DefinitionRef = "Renesas\\Fls\\Fls0";
            configuration113.ShortName = configuration113_ShortName;
            configuration113.DefinitionRef = configuration113_DefinitionRef;
            Configuration config = configuration113;
            ICdfData cdfData = ObjectFactory.GetInstance<ICdfData>();
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, cdfData);
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetContainerByUUIDStringString = (instance, a, b) =>
            {

                return null;

            };

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildSubContainersStackOfXElementRefContainerXElement = (ParserXML instance, ref Stack<XElement> stack, Container container, XElement sub_container) => {

                 // do nothing
            };


            /* Act */
            typeof(ParserXML).GetMethod("BuildAndSaveContainerTree", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument), typeof(XElement), typeof(Configuration) }, null).Invoke(_target, new object[] { new XDocument(), module, config });
            /* Assert */
        }
    }

    [TestMethod]
    public void BuildAndSaveContainerTreeTest_10_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement root = new XElement("CONTAINERS");
            XElement root1 = new XElement("ECUC-CONTAINER-VALUE");
            root1.Add(new XAttribute("UUID", "11111111111111111111"));
            XElement shortName = new XElement("SHORT-NAME", "FlsGeneral");
            XElement defRef = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Fls/Fls/LinGeneral");
            XElement parameterValues = new XElement("PARAMETER-VALUES");
            root1.Add(shortName);
            root1.Add(defRef);
            root1.Add(parameterValues);
            XElement item1 = new XElement("ECUC-NUMERICAL-PARAM-VALUE");
            item1.Add(new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Fls/Fls/LinGeneral/FlsVersionCheckExternalModules"));
            item1.Add(new XElement("VALUE", "true"));
            XElement sub_containers = new XElement("SUB-CONTAINERS");
            XElement root2 = new XElement("ECUC-CONTAINER-VALUE");
            root2.Add(new XAttribute("UUID", "222222222222222222222222222222"));
            root2.Add(new XElement("SHORT-NAME", "FlsChannel_002"));
            root2.Add(new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Fls/Fls/FlsGlobalConfig/FlsChannel"));
            sub_containers.Add(root2);

            root1.Add(sub_containers);
            root1.Add(root2);
            root.Add(root1);
            root.Add(root2);
            module.Add(root);
            Configuration configuration113 = new Configuration();
            String configuration113_ShortName = "Fls0";
            String configuration113_DefinitionRef = "Renesas\\Fls\\Fls1";
            configuration113.ShortName = configuration113_ShortName;
            configuration113.DefinitionRef = configuration113_DefinitionRef;
            Configuration config = configuration113;
            ICdfData cdfData =  ObjectFactory.GetInstance<ICdfData>();
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(_target, cdfData);
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetContainerByUUIDStringString = (instance, a, b) =>
            {
                
                return new Container(){
                    ShortName="Lin0",
                    DefinitionRef="Renesas/Autosar/Lin/LinChannel"
                };

            };

            Renesas.Generator.MCALConfGen.Business.Parser.Fakes.ShimParserXML.AllInstances.BuildSubContainersStackOfXElementRefContainerXElement = (ParserXML instance, ref Stack<XElement> stack, Container container, XElement sub_container) => {

                // do nothing
            };


            /* Act */
            typeof(ParserXML).GetMethod("BuildAndSaveContainerTree", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument), typeof(XElement), typeof(Configuration) }, null).Invoke(_target, new object[] { new XDocument(), module, config });
            /* Assert */
        }
    }

}