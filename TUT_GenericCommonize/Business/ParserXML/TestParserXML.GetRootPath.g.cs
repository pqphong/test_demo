using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using System.Xml.Linq;

public partial class TestParserXML
{
    [TestMethod]
    public void GetRootPathTest_15_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackages = new XElement("AR-PACKAGES");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackages.Add(arPackage);
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));
            XElement elements = new XElement("ELEMENTS");

            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement shortName = new XElement("SHORT-NAME","Lin");
            XElement def = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            module.Add(shortName);
            module.Add(def);
            arPackage.Add(elements);
            arPackage.Add(module);

            root.Add(arPackages);
            document.Add(root);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetRootPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(XDocument), typeof(XElement)}, null).Invoke(_target, new object[]{ document,null });
            /* Assert */
            Assert.AreEqual((String)"/", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetRootPathTest_15_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));
            XElement elements = new XElement("ELEMENTS");

            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement shortName = new XElement("SHORT-NAME", "Lin");
            XElement def = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            module.Add(shortName);
            module.Add(def);
            arPackage.Add(elements);
            arPackage.Add(module);
            root.Add(arPackage);
            document.Add(root);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetRootPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument), typeof(XElement) }, null).Invoke(_target, new object[] { document, null });
            /* Assert */
            Assert.AreEqual((String)"/", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetRootPathTest_15_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackages = new XElement("AR-PACKAGES");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackage.Add(arPackages);

            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement shortName = new XElement("SHORT-NAME", "Lin");
            XElement def = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            module.Add(shortName);
            module.Add(def);
            arPackage.Add(module);
            root.Add(arPackage);
            document.Add(root);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetRootPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument) ,typeof(XElement)}, null).Invoke(_target, new object[] { document,null });
            /* Assert */
            Assert.AreEqual((String)"/", (String)actualResult);
        }
    }
    [TestMethod]
    public void GetRootPathTest_15_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));

            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement shortName = new XElement("SHORT-NAME", "Lin");
            XElement def = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            module.Add(shortName);
            module.Add(def);
            arPackage.Add(module);
            root.Add(arPackage);
            document.Add(root);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetRootPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument) , typeof(XElement)}, null).Invoke(_target, new object[] { document , null});
            /* Assert */
            Assert.AreEqual((String)"/", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetRootPathTest_15_5()
    {
        using (ShimsContext.Create())
        {

            XElement module2 = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement sn2 = new XElement("SHORT-NAME","Lin");
            XElement def2 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            module2.Add(sn2);
            module2.Add(def2);


            /* Arrange */
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackages = new XElement("AR-PACKAGES");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackages.Add(arPackage);
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));
            XElement elements = new XElement("ELEMENTS");

            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement shortName = new XElement("SHORT-NAME", "Lin");
            XElement def = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            elements.Add(module);
            module.Add(shortName);
            module.Add(def);
            arPackage.Add(elements);
            arPackage.Add(module);

            root.Add(arPackages);
            document.Add(root);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetRootPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument), typeof(XElement) }, null).Invoke(_target, new object[] { document, module2 });
            /* Assert */
            Assert.AreEqual((String)"/ActiveEcuC/", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetRootPathTest_15_6()
    {
        using (ShimsContext.Create())
        {
            XElement module2 = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement sn2 = new XElement("SHORT-NAME", "Spi");
            XElement def2 = new XElement("DEFINITION-REF", "/TS_T37D6M4I02R2_01_02/Spi");
            module2.Add(sn2);
            module2.Add(def2);

            /* Arrange */
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));
            XElement elements = new XElement("ELEMENTS");

            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement shortName = new XElement("SHORT-NAME", "Lin");
            XElement def = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            module.Add(shortName);
            module.Add(def);
            arPackage.Add(elements);
            arPackage.Add(module);
            root.Add(arPackage);
            document.Add(root);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetRootPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument),typeof(XElement) }, null).Invoke(_target, new object[] { document,module2 });
            /* Assert */
            Assert.AreEqual((String)"/", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetRootPathTest_15_7()
    {
        using (ShimsContext.Create())
        {
            XElement module2 = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement sn2 = new XElement("SHORT-NAME", "Lin");
            module2.Add(sn2);

            /* Arrange */
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackages = new XElement("AR-PACKAGES");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackage.Add(arPackages);
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));

            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement shortName = new XElement("SHORT-NAME", "Lin");
            module.Add(shortName);
            arPackage.Add(module);
            root.Add(arPackage);
            document.Add(root);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetRootPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument),typeof(XElement) }, null).Invoke(_target, new object[] { document,module2 });
            /* Assert */
            Assert.AreEqual((String)"/", (String)actualResult);
        }
    }
    [TestMethod]
    public void GetRootPathTest_15_8()
    {
        using (ShimsContext.Create())
        {
            XElement module2 = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement sn2 = new XElement("SHORT-NAME", "Lin");
            XElement def2 = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            module2.Add(sn2);
            module2.Add(def2);
            /* Arrange */
            XDocument document = new XDocument();
            XElement root = new XElement("AUTOSAR");
            XElement arPackage = new XElement("AR-PACKAGE");
            arPackage.Add(new XElement("SHORT-NAME", "ActiveEcuC"));

            XElement module = new XElement("ECUC-MODULE-CONFIGURATION-VALUES");
            XElement shortName = new XElement("SHORT-NAME", "Lin");
            XElement def = new XElement("DEFINITION-REF", "/Renesas/EcucDefs_Lin/Lin");
            module.Add(shortName);
            module.Add(def);
            arPackage.Add(module);
            root.Add(arPackage);
            document.Add(root);
            /* Act */
            String actualResult = (String)typeof(ParserXML).GetMethod("GetRootPath", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(XDocument),typeof(XElement) }, null).Invoke(_target, new object[] { document,module2 });
            /* Assert */
            Assert.AreEqual((String)"/", (String)actualResult);
        }
    }

}